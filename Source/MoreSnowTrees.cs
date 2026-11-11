using UnityEngine;
using Verse;

namespace MoreSnowTrees;

public class MoreSnowTrees : Mod
{
    public MoreSnowTrees(ModContentPack content) : base(content) {
        GetSettings<YouActivated>();
    }

    public override void DoSettingsWindowContents(Rect inRect) {
        Listing_Standard list = new Listing_Standard();
        list.Begin(inRect.LeftHalf());
        
        list.CheckboxLabeled(
            "MST_OverwriteVanillaTextures".Translate(),
            ref YouActivated.MyTrapCard,
            "MST_OverwriteVanillaTextures_Tooltip".Translate());
        
        list.End();
    }
    
    public override string SettingsCategory()
    {
        return "MST_Title".Translate();
    }
    
}