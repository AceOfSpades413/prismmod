using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace prismmod
{
    public class PrismHelper
    {
        public static int mcs = 1;
        public static int ctwl = 2;

        public static int[,] testHouse = {

            {mcs, mcs, mcs},
            {mcs, ctwl, mcs},
            {mcs, mcs, mcs}
        };

        public static void UnlockWaterTown()
        {
            if (Main.netMode != 2)
            {
                Main.NewText("The gateway to a restricted land has opened... the fish people want your money...", 0, 0, 255);
            }

            for (int x = 0; x < Main.maxTilesX; x++)
            {
                int y = ModContent.GetInstance<PrismWorld>().gatesY;
                Tile tile = Framing.GetTileSafely(x, y);
                if (tile.type == (ushort)ModContent.TileType<Tiles.Blox.UnbreakableGate>())
                {
                    tile.ClearTile();
                }
            }

            ModContent.GetInstance<PrismWorld>().accessedWaterTown = true;
        }
        public static void drawBaseFishHouse(int xStart, int yStart, int height, int width, int block)
        {
            for (int x = xStart; x <= (xStart + width); x++)
            {
                for (int y = yStart; y >= (yStart-height); y--)
                {
                    if (x == xStart || x == xStart + width || y == yStart || y == yStart - height)
                    {
                        WorldGen.PlaceTile(x, y, block);
                    }
                }
                /*int yRoof=0;
                int h = (x + (width / 2));
                int k = (5);
                int cx = xStart;
                int cy = yStart + height;
                int a = (cy-k)/(x-h^2);
                yRoof = a*(x - h) ^ 2 + k;
                WorldGen.PlaceTile(x, yRoof, block);*/

            }


        }

        public static void drawGroundFromWall(int xStart, int yStart, int height, int width, int block, char direction)
        {
            if (direction == 'l')
            {
                for (int y = yStart; y <= (yStart + height); y++)
                {
                    if ((y - yStart) / (yStart + height) <= 0.25)
                    {
                        width -= 1;
                    }
                    if ((y - yStart) / (yStart + height) <= 0.5)
                    {
                        width -= 1;
                    }
                    if ((y - yStart) / (height) <= 0.75)//at each interval, decrease width by an increasing amount
                    {
                        width -= 1;
                    }
                    for (int x = xStart; x <= (xStart + width); x++)
                    {
                        Tile tile = Framing.GetTileSafely(x, y);
                        tile.ClearTile();
                        WorldGen.PlaceTile(x,y,block);
                    }
                }
            }
        }


        //Building Section

        //other values
        public static string[] fishNames = { "Coral","Jerry","Mark","Bubbles","Octavius, Destroyer of Worlds",
        "Reefback", "Gerald", "Markus", "Vincent", "Tom", "Bofa", "Gex", "Salmonelly",
         "Jeb", "Joel", "[REDACTED]", "Guppy","Sharko","Natalie","Lance","Louie","Alph","Skinner",
         "Travis", "Joe", "Carl", "Smokey", "Toad", "Magnus", "Devin", "Blart"};

    }

}