using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using prismmod.NPCs.WaterTown;

namespace prismmod.NPCs.WaterTown
{
    //@todo add head file for these NPCS
    [AutoloadHead]
    internal class FishBlue : FishPerson
    {
        public override void SetChatButtons(ref string button, ref string button2)
        {
			button = "Bruh";

		}
        public override string GetChat()
        {
            return "This is the only chat message so far, stop trying for a new one.";
            //request chat messages from braden
        }
        public override void OnChatButtonClicked(bool firstbutton, ref bool shop)
        {
            shop=true;
        }

        //@todo Setup Shop method
        //unique to each fish person?



    }
}