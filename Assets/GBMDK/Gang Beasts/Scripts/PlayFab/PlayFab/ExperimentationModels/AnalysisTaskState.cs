namespace PlayFab.ExperimentationModels
{
    public enum AnalysisTaskState
    {
        Waiting = 0,
        ReadyForSubmission = 1,
        SubmittingToPipeline = 2,
        Running = 3,
        Completed = 4,
        Failed = 5,
        Canceled = 6
    }
}