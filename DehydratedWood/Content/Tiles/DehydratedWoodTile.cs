using Terraria;
using Terraria.ModLoader;
using Terraria.ID;
using Microsoft.Xna.Framework;
using Terraria.Audio;

namespace DehydratedWood.Content.Tiles
{
    internal class DehydratedWoodTile: ModTile

    {
        public override void SetStaticDefaults()
        {

            TileID.Sets.Ore[Type] = true;
            Main.tileSolid[Type] = true;
            Main.tileMergeDirt[Type] = true;
            Main.tileBlockLight[Type] = true;
            Main.tileShine[Type] = 900;
            Main.tileShine2[Type] = true;
            Main.tileSpelunker[Type] = false;
            Main.tileOreFinderPriority[Type] = 350;

            AddMapEntry(new Color(160, 80, 0), CreateMapEntryName());
            DustType = DustID.Tungsten;
            ItemDrop = ModContent.ItemType<Items.DehydratedWoodItem>();

            MineResist = 1.5f;
            MinPick = 30;


        }
    }
}
