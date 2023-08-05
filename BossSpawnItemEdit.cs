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
                var ig = ContentSamples.CreativeHelper.GetItemGroup(item, out _);

                if (ig == (ContentSamples.CreativeHelper.ItemGroup.BossItem) || ig == (ContentSamples.CreativeHelper.ItemGroup.EventItem))
                {
                    return false;
                }
                return true;
            }
            return false;
        }
    }
}
