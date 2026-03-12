namespace PartyCSharpSDK.Interop
{
    internal struct PARTY_REGIONS_CHANGED_STATE_CHANGE
    {
        internal readonly PARTY_STATE_CHANGE stateChange;

        internal readonly PARTY_STATE_CHANGE_RESULT result;

        internal readonly uint errorDetail;
    }
}