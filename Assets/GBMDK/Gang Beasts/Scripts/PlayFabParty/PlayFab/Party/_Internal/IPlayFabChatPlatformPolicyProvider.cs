using System;
using System.Collections.Generic;
using PartyCSharpSDK;

namespace PlayFab.Party._Internal
{
    internal interface IPlayFabChatPlatformPolicyProvider
    {
        void SignIn();

        void SendPlatformSpecificUserId(List<PlayFabPlayer> targetPlayers);

        PARTY_VOICE_CHAT_TRANSCRIPTION_OPTIONS GetPlatformUserChatTranscriptionPreferences();

        bool IsTextToSpeechEnabled();

        PARTY_CHAT_PERMISSION_OPTIONS GetChatPermissions(PlayFabPlayer targetPlayer);

        void CreateOrUpdatePlatformUser(PlayFabPlayer player, bool isLocal);

        void ProcessEndpointMessage(PlayFabPlayer fromPlayer, IntPtr messageBuffer, uint messageSize,
            out bool isInternalMessage);

        void ProcessQueuedOperations();

        void ProcessStateChanges();

        bool CleanUp();
    }
}