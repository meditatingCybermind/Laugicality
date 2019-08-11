﻿using Terraria;

namespace Laugicality.Structures
{
    public class LavaCave1
    {
        
        private static readonly int[,] _structureArray = new int[,]
        {
            {0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,1,0,0,0,0,0,0,0,0,0,0,0},
            {0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,1,0,0,0,0,0,0,0,0,0,0,0},
            {0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,1,1,1,0,0,0,0,0,0,0,0,0,0},
            {0,0,0,0,0,0,0,0,0,0,1,1,0,0,0,0,0,1,1,1,1,1,1,0,0,0,0,0,0,0,0,0},
            {0,0,0,0,0,0,0,0,0,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,0,0,0,0,0,0,0,0},
            {0,0,0,0,0,0,0,0,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,0,0,0,0,0,0},
            {0,0,0,0,0,0,0,0,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,0,0,0,0,0},
            {0,0,0,0,0,0,0,1,1,1,1,1,1,1,9,9,9,9,9,9,1,1,1,1,1,1,1,0,0,0,0,0},
            {0,0,0,0,0,0,1,1,1,1,1,9,9,9,9,9,9,9,9,9,9,9,9,1,1,1,1,1,0,0,0,0},
            {0,0,0,0,0,0,1,1,1,1,9,9,9,9,9,9,9,9,9,9,9,9,9,9,1,1,1,1,1,0,0,0},
            {0,0,0,0,0,1,1,1,1,9,9,9,9,9,9,9,9,9,9,9,9,9,9,9,1,1,1,1,1,1,0,0},
            {0,0,0,0,1,1,1,1,1,9,9,9,9,9,9,9,9,9,9,9,9,9,9,9,9,1,1,1,1,1,0,0},
            {0,0,0,0,1,1,1,1,1,9,9,9,9,9,9,9,9,9,9,9,9,9,9,9,9,1,1,1,1,1,0,0},
            {0,0,0,1,1,1,1,1,1,2,2,2,2,2,2,2,1,3,9,9,9,9,9,9,9,9,9,1,1,1,1,0},
            {0,0,0,1,1,1,1,1,1,1,2,2,2,2,2,1,1,3,9,9,9,9,9,9,9,9,9,1,1,1,1,0},
            {0,0,0,1,1,1,1,1,1,1,1,1,2,1,1,1,9,3,9,9,9,9,9,9,9,9,9,9,1,1,1,0},
            {0,0,1,1,1,1,9,1,1,1,1,1,1,1,1,1,9,3,9,9,9,9,9,9,9,9,9,9,1,1,1,0},
            {0,0,1,1,1,9,9,9,9,1,1,1,1,9,9,9,9,3,9,9,9,9,9,9,9,9,9,9,1,1,1,1},
            {0,0,1,1,1,9,9,9,9,9,9,9,9,9,9,9,9,3,9,9,9,9,9,9,9,9,9,9,1,1,1,1},
            {0,0,1,1,9,9,9,9,9,9,9,9,9,9,9,9,9,3,9,9,9,9,9,9,9,9,9,9,1,1,1,1},
            {0,0,1,1,9,9,9,9,9,9,9,9,9,9,9,9,9,3,9,9,9,9,9,9,9,9,9,9,1,1,1,1},
            {0,1,1,1,9,9,9,9,9,9,9,9,9,9,9,9,9,3,9,9,9,9,9,9,9,9,9,9,1,1,1,0},
            {0,1,1,1,9,9,9,9,9,9,9,9,9,9,9,9,9,3,9,9,9,9,9,9,9,9,9,9,1,1,1,0},
            {0,1,1,1,9,9,9,9,9,9,9,9,9,9,9,9,9,3,9,9,9,9,9,9,9,9,9,1,1,1,1,0},
            {0,1,1,1,1,9,9,9,9,9,9,9,9,9,9,9,9,3,9,9,9,9,9,9,9,9,9,1,1,1,0,0},
            {0,1,1,1,1,1,1,9,9,9,9,9,9,9,9,9,9,3,9,9,9,9,9,9,9,9,9,1,1,1,0,0},
            {1,1,1,1,1,1,1,1,9,9,9,9,9,9,9,9,9,3,9,9,9,9,9,9,9,9,1,1,1,0,0,0},
            {1,1,1,1,1,1,1,1,2,2,2,2,2,2,2,2,2,2,2,2,2,2,2,2,1,1,1,1,1,0,0,0},
            {1,1,1,1,1,1,1,1,1,2,2,2,2,2,2,2,2,2,2,2,2,2,2,1,1,1,1,1,1,0,0,0},
            {1,1,1,1,1,1,1,1,1,1,1,2,2,2,2,2,2,2,2,2,2,2,1,1,1,1,1,1,0,0,0,0},
            {0,1,1,1,1,1,1,1,1,1,1,1,1,2,2,2,2,2,2,2,1,2,1,1,1,1,1,0,0,0,0,0},
            {0,0,0,0,1,1,1,1,1,1,1,1,1,1,2,2,2,2,2,1,1,1,1,1,1,1,0,0,0,0,0,0},
            {0,0,0,0,0,0,0,1,1,1,1,1,1,1,1,1,2,2,1,1,1,1,1,1,0,0,0,0,0,0,0,0},
            {0,0,0,0,0,0,0,0,0,0,1,1,1,1,1,1,1,1,1,1,1,1,0,0,0,0,0,0,0,0,0,0},
            {0,0,0,0,0,0,0,0,0,0,0,0,0,1,1,1,1,1,1,0,0,0,0,0,0,0,0,0,0,0,0,0},

        };

        public static void StructureGen(int xPosO, int yPosO, bool mirrored)
        {
            /**
             * 0 = Do Nothing
             * 1 = Obsidium Rock
             * 2 = Lava
             * 3 = Lavafall
             * 9 = Kill tile
             * */

            for (int i = 0; i < _structureArray.GetLength(1); i++)
            {
                for (int j = 0; j < _structureArray.GetLength(0); j++)
                {
                    if(mirrored)
                    {
                        if (TileCheckSafe((int)(xPosO + _structureArray.GetLength(1) - i), (int)(yPosO + j)))
                        {
                            if (_structureArray[j, i] == 1)
                            {
                                WorldGen.KillTile(xPosO + _structureArray.GetLength(1) - i, yPosO + j);
                                WorldGen.PlaceTile(xPosO + _structureArray.GetLength(1) - i, yPosO + j, Laugicality.instance.TileType("ObsidiumRock"), true, true);
                            }
                            if (_structureArray[j, i] == 2)
                            {
                                WorldGen.KillTile(xPosO + i, yPosO + j);
                                Main.tile[xPosO + _structureArray.GetLength(1) - i, yPosO + j].lava(true);
                                Main.tile[xPosO + _structureArray.GetLength(1) - i, yPosO + j].liquid = 255;
                            }
                            if (_structureArray[j, i] == 3)
                            {
                                WorldGen.KillTile(xPosO + _structureArray.GetLength(1) - i, yPosO + j);
                                WorldGen.KillWall(xPosO + _structureArray.GetLength(1) - i, yPosO + j);
                                WorldGen.PlaceWall(xPosO + _structureArray.GetLength(1) - i, yPosO + j, 137, true); //Lavafall Wall
                            }
                            if (_structureArray[j, i] == 9)
                            {
                                WorldGen.KillTile(xPosO + _structureArray.GetLength(1) - i, yPosO + j);
                            }
                        }
                    }
                    else
                    {
                        if (TileCheckSafe((int)(xPosO + i), (int)(yPosO + j)))
                        {
                            if (_structureArray[j, i] == 1)
                            {
                                WorldGen.KillTile(xPosO + i, yPosO + j);
                                WorldGen.PlaceTile(xPosO + i, yPosO + j, Laugicality.instance.TileType("ObsidiumRock"), true, true);
                            }
                            if (_structureArray[j, i] == 2)
                            {
                                WorldGen.KillTile(xPosO + i, yPosO + j);
                                Main.tile[xPosO + i, yPosO + j].lava(true);
                                Main.tile[xPosO + i, yPosO + j].liquid = 255;
                            }
                            if (_structureArray[j, i] == 3)
                            {
                                WorldGen.KillTile(xPosO + i, yPosO + j);
                                WorldGen.KillWall(xPosO + i, yPosO + j);
                                WorldGen.PlaceWall(xPosO + i, yPosO + j, 137, true); //Lavafall Wall
                            }
                            if (_structureArray[j, i] == 9)
                            {
                                WorldGen.KillTile(xPosO + i, yPosO + j);
                            }
                        }
                    }
                }
            }
        }
        
        //Making sure tiles arent out of bounds
        private static bool TileCheckSafe(int i, int j)
        {
            if (i > 0 && i < Main.maxTilesX && j > 0 && j < Main.maxTilesY)
                return true;
            return false;
        }
    }
}