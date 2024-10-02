using DiscordRPC_Plugin.Loggin;
using DiscordRPC;
using DiscordRPC.Logging;
using Intersect.Client.Framework.Entities;
using Intersect.GameObjects;
using LogLevel = DiscordRPC.Logging.LogLevel;

namespace DiscordRPC_Plugin;

public class DiscordRichPresenceManager
{
    private readonly DiscordRpcClient _client;
    private string _currentMap;
    private int _currentPartySize;
    private DateTime _lastUpdate;
    private Timestamps _timestamps;

    public DiscordRichPresenceManager(string clientId)
    {
        _client = new DiscordRpcClient(clientId);

        _client.Logger = new ConsoleLogger() { Level = LogLevel.Warning };

        _client.OnReady += (sender, e) =>
        {
            Logger.Write(Loggin.LogLevel.Info, String.Format("Received Ready from user {0}", e.User.Username));
            _timestamps = Timestamps.Now;
        };

        _client.Initialize();
    }
    
    public void UpdatePresence(IPlayer player)
    {
        var map = player.MapInstance?.Name;
        var partySize = player.PartyMembers?.Count ?? 0;
        var details = $"Map: {map}, Player: {player.Name}, Level: {player.Level}";
        var state = $"Class: {ClassBase.GetName(player.Class)}";

        if (_currentMap != map || _currentPartySize != partySize || (DateTime.Now - _lastUpdate).TotalSeconds > 5)
        {
            _currentMap = map;
            _currentPartySize = partySize;
            _lastUpdate = DateTime.Now;
            
            _client.SetPresence(new RichPresence()
            {
                Details = details,
                State = state,
                Timestamps = _timestamps,
                Party = partySize > 0 ? new Party
                {
                    ID = "party_id",
                    Size = partySize,
                    Max = 4, // TODO: Get max party size from server
                    Privacy = Party.PrivacySetting.Private
                } : null,
                Buttons = new Button[]
                {
                    new Button() { Label = "Button 1", Url = "https://www.intersectengine.com" },
                    new Button() { Label = "Button 2", Url = "https://www.intersectengine.com" }
                }
            });
        }
    }
    
    public void Dispose()
    {
        _client.Dispose();
    }
}