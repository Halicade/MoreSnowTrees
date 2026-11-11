using Verse;

namespace MoreSnowTrees;

public class YouActivated : ModSettings
{
    public static bool MyTrapCard;

    public override void ExposeData() {
        base.ExposeData();
        Scribe_Values.Look(ref MyTrapCard, "IActivatePotOfGreed");
    }
}