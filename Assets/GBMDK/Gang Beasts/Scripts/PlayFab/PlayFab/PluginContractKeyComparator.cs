using System.Collections.Generic;

namespace PlayFab
{
    public class PluginContractKeyComparator : EqualityComparer<PluginContractKey>
    {
        public override bool Equals(PluginContractKey x, PluginContractKey y)
        {
            return false;
        }

        public override int GetHashCode(PluginContractKey obj)
        {
            return 0;
        }
    }
}