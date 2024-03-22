using Terraria;
using Terraria.ModLoader;
using Terraria.GameContent.Creative;
using Terraria.ID;

namespace DehydratedWood.Content.Items.Armor
{
    [AutoloadEquip(EquipType.Head)]
    internal class DehydratedWoodHelmet : ModItem
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
            Item.defense = 3;
        }

        public override bool IsArmorSet(Item head, Item body, Item legs)
        {
            return body.type == ModContent.ItemType<DehydratedWoodChestplate>() && legs.type == ModContent.ItemType<DehydratedWoodLeggings>();
        }

        public override void AddRecipes()
        {
            CreateRecipe()
                .AddRecipeGroup(RecipeGroupID.Wood, 2)
                .AddIngredient(ModContent.ItemType<DehydratedWoodItem>(), 4)
                .AddTile(TileID.Anvils)
                .Register();
        }
    }
}