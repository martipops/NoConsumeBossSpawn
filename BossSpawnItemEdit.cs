using Terraria.ID;
using Terraria;
using Terraria.ModLoader;
using Terraria.Social.WeGame;

namespace NoConsumeBossSpawn
{
    public class BossSpawnItemEdit : GlobalItem
    {
        public override bool ConsumeItem(Item item, Player player)
        {
            if (base.ConsumeItem(item, player))
            {
                // bitwise to test itemgroup in a local context
                if ((ContentSamples.CreativeHelper.GetItemGroup(item, out _)
                & (ContentSamples.CreativeHelper.ItemGroup.BossItem
                | ContentSamples.CreativeHelper.ItemGroup.EventItem)) != 0)
                {
                    return false;
                }
                return true;
            }
            return false;
        }
    }
}
