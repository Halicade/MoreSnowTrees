using Verse;

namespace MoreSnowTrees;

public class Settings : ModSettings
{
    public static bool YouActivedMyTrapCard;

    public override void ExposeData() {
        base.ExposeData();
        Scribe_Values.Look(ref YouActivedMyTrapCard, "IActivatePotOfGreed");
    }
}