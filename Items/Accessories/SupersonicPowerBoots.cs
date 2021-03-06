using Terraria;
using Terraria.ModLoader;

namespace prismmod.Items.Accessories
{
    public class SupersonicPowerBoots : ModItem
    {
        public override bool Autoload(ref string name)
        {
            return !ModContent.GetInstance<ServerConfig>().DisableDevItems;
        }

        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Supersonic Power Boots");
            Tooltip.SetDefault("Delete these now, you cheater");
        }

        public override void SetDefaults()
        {
            item.accessory = true;
            item.defense = 0;
            item.rare = -12;
        }

        public override void UpdateAccessory(Player player, bool hideVisual)
        {
            player.moveSpeed += 110f;
            player.maxRunSpeed += 110f;
        }
    }
}