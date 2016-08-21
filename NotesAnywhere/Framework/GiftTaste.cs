using StardewValley;

namespace Pathoschild.NotesAnywhere.Framework
{
    /// <summary>Indicates how much an NPC likes a particular gift.</summary>
    public enum GiftTaste
    {
        Hate = NPC.gift_taste_hate,
        Dislike = NPC.gift_taste_dislike,
        Neutral = NPC.gift_taste_neutral,
        Like = NPC.gift_taste_like,
        Love = NPC.gift_taste_love
    }
}