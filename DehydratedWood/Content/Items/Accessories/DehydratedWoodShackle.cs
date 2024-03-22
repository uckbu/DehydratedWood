using Terraria;
using Terraria.ModLoader;
using Terraria.GameContent.Creative;
using Terraria.ID;

namespace DehydratedWood.Content.Items.Accessories
{
    internal class DehydratedWoodShackle : ModItem
    {
        public override void SetStaticDefaults()
        {
            CreativeItemSacrificesCatalog.Instance.SacrificeCountNeededByItemId[Type] = 1;
        }

        public override void SetDefaults()
        {
            Item.width = 24;
            Item.height = 28;
            Item.rare = ItemRarityID.Blue;
            Item.accessory = true;
            Item.defense = 5;
        }

        public override void AddRecipes()
        {
            CreateRecipe()
                .AddIngredient(ModContent.ItemType<DehydratedWoodItem>(), 10)
                .AddTile(TileID.Anvils)
                .Register();
        }
    }
}
