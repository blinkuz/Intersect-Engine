using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Intersect.Config
{
    /// <summary>
    /// Contains configurable options pertaining quests and the layout of the quest log
    /// </summary>
    public class QuestOptions
    {
        /// <summary>
        /// Quest categories in which to separate quests into on the quest log
        /// </summary>
        public List<string> Categories { get; set; } = new List<string>()
        {
            "Main Quests",
            "Side Quests",
            "Completed Quests",
        };
        
        public string GuidActualDay
        {
            get;
            set;
        } = "7e0fb019-8a03-4245-8481-3fb4af76dc60";

        [OnDeserializing]
        internal void OnDeserializingMethod(StreamingContext context)
        {
            Categories.Clear();
        }
    }
}
