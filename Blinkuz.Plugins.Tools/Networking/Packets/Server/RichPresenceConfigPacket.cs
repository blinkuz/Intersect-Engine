
using Intersect;
using Intersect.Network;
using MessagePack;

namespace Blinkuz.Plugins.Tools.Networking.Packets.Server;

[MessagePackObject]
public partial class RichPresenceConfigPacket : IntersectPacket
{
    // Parameterless Constructor for MessagePack
    RichPresenceConfigPacket() { }

    public RichPresenceConfigPacket(string discordClientId, string detailsTemplate, string stateTemplate, string button1Label, string button1Url, string button2Label, string button2Url, string largeImageKey, string largeImageText, string smallImageKey, string smallImageText)
    {
        DiscordClientId = discordClientId;
        DetailsTemplate = detailsTemplate;
        StateTemplate = stateTemplate;
        Button1Label = button1Label;
        Button1Url = button1Url;
        Button2Label = button2Label;
        Button2Url = button2Url;
        LargeImageKey = largeImageKey;
        LargeImageText = largeImageText;
        SmallImageKey = smallImageKey;
        SmallImageText = smallImageText;
    }

    [Key(0)]
    public string DiscordClientId { get; set; }

    [Key(1)]
    public string DetailsTemplate { get; set; }

    [Key(2)]
    public string StateTemplate { get; set; }

    [Key(3)]
    public string Button1Label { get; set; }

    [Key(4)]
    public string Button1Url { get; set; }

    [Key(5)]
    public string Button2Label { get; set; }

    [Key(6)]
    public string Button2Url { get; set; }

    [Key(7)]
    public string LargeImageKey { get; set; }

    [Key(8)]
    public string LargeImageText { get; set; }

    [Key(9)]
    public string SmallImageKey { get; set; }

    [Key(10)]
    public string SmallImageText { get; set; }

    [Key(11)]
    public int MaxPartySize { get; set; } = Options.Instance.Party.MaximumMembers;
    
}