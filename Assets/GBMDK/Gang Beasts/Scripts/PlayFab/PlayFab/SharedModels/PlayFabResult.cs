namespace PlayFab.SharedModels
{
    public class PlayFabResult<TResult> where TResult : PlayFabResultCommon
    {
        public object CustomData;
        public TResult Result;
    }
}