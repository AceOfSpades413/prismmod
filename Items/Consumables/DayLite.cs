using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace prismmod.Items.Consumables
{
    public class DayLite : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Day-Lite");
            Tooltip.SetDefault("Changes the time to Day.");
        }

        public override void SetDefaults()
        {
            item.width = 40;
            item.height = 20;
            item.noMelee = true;
            item.consumable = true;
            item.useTime = 30;
            item.useStyle = ItemUseStyleID.HoldingUp;
            item.UseSound = SoundID.Item29;
            item.maxStack = 999;
            item.useAnimation = 30;
        }

        public override bool CanUseItem(Player player)
        {
            if (Main.dayTime == false)
            {
                Main.time = 10000;
                Main.dayTime = true;
                return true;
            }
            else
            {
                return false;
            }
        }

        public override bool UseItem(Player player)
        {
            return true;
        }

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddTile(TileID.WorkBenches);
            recipe.AddIngredient(ItemID.HellstoneBar, 5);
            recipe.AddIngredient(ItemID.FallenStar, 3);
            recipe.SetResult(this, 3);
            recipe.AddRecipe();
        }
    }
}