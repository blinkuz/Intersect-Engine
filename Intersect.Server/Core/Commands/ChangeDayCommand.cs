using System;

using Intersect.Server.Core.CommandParsing;
using Intersect.Server.Database;
using Intersect.Server.Database.GameData;
using Intersect.Server.Entities;
using Intersect.Server.Localization;
using Intersect.Server.Networking;

namespace Intersect.Server.Core.Commands
{
    internal sealed class ChangeDayCommand : ServerCommand
    {
        public ChangeDayCommand() : base(Strings.Commands.ChangeDay)
        {
        }

        protected override void HandleValue(ServerContext context, ParserResult result)
        {
            var variable = GameContext.Queries.ServerVariableById(new Guid(Options.Instance.Quest.GuidActualDay));

            if (variable == null)
            {
                Console.WriteLine($@"No global variable with id '{Options.Instance.Quest.GuidActualDay}'.");
            }

            variable.Value.Value += 1;

            Player.StartCommonEventsWithTriggerForAll(
                Enums.CommonEventTrigger.ServerVariableChange, "", Options.Instance.Quest.GuidActualDay
            );

            DbInterface.UpdatedServerVariables.AddOrUpdate(variable.Id, variable, (key, oldValue) => variable);
            PacketSender.SendGlobalMsg(Strings.Commandoutput.changeday.ToString(variable.Value.ToString()));
            PacketSender.SendGameAnnouncement(
                Strings.Commandoutput.changeday.ToString(variable.Value.ToString()),
                Options.Chat.AnnouncementDisplayDuration
            );
            Console.WriteLine(Strings.Commandoutput.changeday.ToString(variable.Value.ToString()));
        }
    }
}
