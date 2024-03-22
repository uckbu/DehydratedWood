using Terraria;
using Terraria.ModLoader;
using Terraria.GameContent.Creative;
using Terraria.ID;

namespace DehydratedWood.Content.Items.Armor
{
     [AutoloadEquip(EquipType.Legs)]
    internal class DehydratedWoodLeggings : ModItem
    {
        public override void SetStaticDefaults()
        {
            CreativeItemSacrificesCatalog.Instance.SacrificeCountNeededByItemId[Type] = 1;
        }

        public override void SetDefaults()
        {
            Item.width = 18;
            Item.height = 18;
            Item.rare = ItemRarityID.Blue;
            Item.defense = 5;
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
  
