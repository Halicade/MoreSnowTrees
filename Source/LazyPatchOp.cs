using System.Xml;
using Verse;

namespace MoreSnowTrees;

public class LazyPatchOp : PatchOperationConditional
{
    
    protected override bool ApplyWorker(XmlDocument xml) {
        if (YouActivated.MyTrapCard) {
            return base.ApplyWorker(xml);
        }

        return true;
    }
}