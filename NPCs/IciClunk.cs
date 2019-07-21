﻿using Terraria.ID;
using Terraria.ModLoader;
using Terraria;
using Microsoft.Xna.Framework;

namespace prismmod.NPCs
{
    class IciClunk : ModNPC
    {

        Player player;
        private float speed;


        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Iciclunk");
            Main.npcFrameCount[npc.type] = Main.npcFrameCount[8];//will change
        }

        public override void SetDefaults()
        {
            npc.width =18;
            npc.height = 34;
            //npc.aiStyle = 41;
            npc.lifeMax = 75;
            npc.HitSound = SoundID.NPCHit1;
            npc.DeathSound = SoundID.NPCDeath1;
            npc.value = 0.75f;
            npc.knockBackResist= 0.5f;

        }

        

        public override void NPCLoot()
        {
            Item.NewItem(npc.getRect(), mod.ItemType("IciclunkHorn"), Main.rand.Next(3, 6));
        }

        public void Target()
        {
            player = Main.player[npc.target];
        }

        public override void AI()
        {
            
        }

        public override void FindFrame(int frameHeight)
        {

            npc.frame.Y = 0;
        }

    }


}
