using Blinkuz.Plugins.Tools.Logging;
using DiscordRPC;
using DiscordRPC.Logging;
using Intersect.Client.Framework.Entities;
using Intersect.GameObjects;
using LogLevel = DiscordRPC.Logging.LogLevel;

namespace DiscordRPC_Plugin;

public class DiscordRichPresenceManager
{
    private static DiscordRichPresenceManager _instance;
    private DiscordRpcClient _client;
    private string _currentMap;
    private int _currentPartySize;
    private DateTime _lastUpdate;
    private Timestamps _timestamps;
    private string _detailsTemplate;
    private string _stateTemplate;
    private string _button1Label;
    private string _button1Url;
    private string _button2Label;
    private string _button2Url;
    private int _maxPartySize;
    private string _largeImageKey;
    private string _largeImageText;
    private string _smallImageKey;
    private string _smallImageText;

    private DiscordRichPresenceManager() { }

    public static DiscordRichPresenceManager Instance => _instance ??= new DiscordRichPresenceManager();

    public void Initialize(string clientId, string detailsTemplate, string stateTemplate, string button1Label, string button1Url, string button2Label, string button2Url, int maxPartySize, string largeImageKey, string largeImageText, string smallImageKey, string smallImageText)
    {
        _client = new DiscordRpcClient(clientId);
        _detailsTemplate = detailsTemplate;
        _stateTemplate = stateTemplate;
        _button1Label = button1Label;
        _button1Url = button1Url;
        _button2Label = button2Label;
        _button2Url = button2Url;
        _maxPartySize = maxPartySize;
        _largeImageKey = largeImageKey;
        _largeImageText = largeImageText;
        _smallImageKey = smallImageKey;
        _smallImageText = smallImageText;

        _client.Logger = new ConsoleLogger() { Level = LogLevel.Warning };

        _client.OnReady += (sender, e) =>
        {
            Logger.Write(Blinkuz.Plugins.Tools.Logging.LogLevel.Info, String.Format("Received Ready from user {0}", e.User.Username));
            _timestamps = Timestamps.Now;
        };

        _client.Initialize();
    }

    public void UpdatePresence(IPlayer player)
    {
        if (_client == null) return;

        var map = player.MapInstance?.Name;
        var partySize = player.PartyMembers?.Count ?? 0;
        var details = _detailsTemplate.Replace("{Name}", player.Name)
                                      .Replace("{Level}", player.Level.ToString())
                                      .Replace("{Class}", ClassBase.GetName(player.Class))
                                      .Replace("{Map}", map);
        var state = _stateTemplate.Replace("{Name}", player.Name)
                                  .Replace("{Level}", player.Level.ToString())
                                  .Replace("{Class}", ClassBase.GetName(player.Class))
                                  .Replace("{Map}", map);

        if (_currentMap != map || _currentPartySize != partySize || (DateTime.Now - _lastUpdate).TotalSeconds > 5)
        {
            _currentMap = map;
            _currentPartySize = partySize;
            _lastUpdate = DateTime.Now;
            
            var buttons = new List<Button>();
            if (!string.IsNullOrEmpty(_button1Label) && !string.IsNullOrEmpty(_button1Url))
            {
                buttons.Add(new Button() { Label = _button1Label, Url = _button1Url });
            }
            if (!string.IsNullOrEmpty(_button2Label) && !string.IsNullOrEmpty(_button2Url))
            {
                buttons.Add(new Button() { Label = _button2Label, Url = _button2Url });
            }

            _client.SetPresence(new RichPresence()
            {
                Details = details,
                State = state,
                Timestamps = _timestamps,
                Assets = new Assets
                {
                    LargeImageKey = _largeImageKey,
                    LargeImageText = _largeImageText,
                    SmallImageKey = _smallImageKey,
                    SmallImageText = _smallImageText
                },
                Party = partySize > 0 ? new Party
                {
                    ID = "party_id",
                    Size = partySize,
                    Max = _maxPartySize,
                    Privacy = Party.PrivacySetting.Private
                } : null,
                Buttons = buttons.ToArray()
            });
        }
    }

    public void Dispose()
    {
        _client?.Dispose();
    }
}