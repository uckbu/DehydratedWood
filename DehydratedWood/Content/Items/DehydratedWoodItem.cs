using Terraria;
using Terraria.ModLoader;
using Terraria.ID;
using Terraria.ModLoader.Default;
using Terraria.GameContent.Creative;

namespace DehydratedWood.Content.Items
{
    internal class DehydratedWoodItem : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Dehydrated Wood");
            CreativeItemSacrificesCatalog.Instance.SacrificeCountNeededByItemId[Type] = 100;
        }
        public override void SetDefaults()
        {
            Item.width = 24;
            Item.height = 22;
            Item.value = Item.buyPrice(copper: 50);
            Item.maxStack = 999;
            Item.consumable = true;
            Item.useStyle = ItemUseStyleID.Swing;
            Item.useAnimation = 15;
            Item.useTime = 10;
            Item.useTurn = true;
            Item.autoReuse = true;

            Item.createTile = ModContent.TileType<Tiles.DehydratedWoodTile>();
        }

            public override void AddRecipes()
        {
            CreateRecipe()
                .AddRecipeGroup(RecipeGroupID.Wood, 2)
                .AddTile(TileID.Furnaces)
                .Register();
        }

        
    }
}
