using Terraria;
using Terraria.ModLoader;
using Terraria.GameContent.Creative;
using Terraria.ID;
using Steamworks;


namespace DehydratedWood.Content.Items.Tools
{
    internal class DehydratedWoodAxe : ModItem
    {
        public override void SetStaticDefaults()
        {
            CreativeItemSacrificesCatalog.Instance.SacrificeCountNeededByItemId[Type] = 1;

        }

        public override void SetDefaults()
        {
            Item.width = 32;
            Item.height = 32;
            Item.useTime = 13;
            Item.useAnimation = 15;
            Item.autoReuse = true;
            Item.useStyle = ItemUseStyleID.Swing;
            Item.useTurn = true;

            Item.DamageType = DamageClass.Melee;
            Item.damage = 7;
            Item.knockBack = 3f;

            Item.value = Item.buyPrice(silver: 4);
            Item.rare = ItemRarityID.Blue;
            Item.axe = 60;

        }

        public override void AddRecipes()
        {
            CreateRecipe()
                .AddRecipeGroup(RecipeGroupID.Wood, 4)
                .AddIngredient(ModContent.ItemType<DehydratedWoodItem>(), 8)
                .AddTile(TileID.Anvils)
                .Register();
        }
    }
}
