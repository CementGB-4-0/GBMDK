using System;
using System.Collections.Generic;
using PlayFab.EventsModels;

namespace PlayFab.Public
{
    public class ScreenTimeTracker : IScreenTimeTracker
    {
        private const string eventNamespace = "com.playfab.events.sessions";

        private const int maxBatchSizeInEvents = 10;

        private EntityKey entityKey;

        private PlayFabEventsInstanceAPI eventApi;

        private Queue<EventContents> eventsRequests;
        private Guid focusId;

        private DateTime focusOffDateTime;

        private DateTime focusOnDateTime;

        private Guid gameSessionID;

        private bool initialFocus;

        private bool isSending;

        public void ClientSessionStart(string entityId, string entityType, string playFabUserId)
        {
        }

        public void OnApplicationFocus(bool isFocused)
        {
        }

        public void Send()
        {
        }

        public void OnEnable()
        {
        }

        public void OnDisable()
        {
        }

        public void OnDestroy()
        {
        }

        public void OnApplicationQuit()
        {
        }

        private void EnsureSingleGameSessionId()
        {
        }

        private void EventSentSuccessfulCallback(WriteEventsResponse response)
        {
        }

        private void EventSentErrorCallback(PlayFabError response)
        {
        }
    }
}