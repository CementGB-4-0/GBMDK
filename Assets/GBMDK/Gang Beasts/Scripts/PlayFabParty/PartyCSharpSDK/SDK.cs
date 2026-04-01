using System;
using System.Collections.Generic;

namespace PartyCSharpSDK
{
    public class SDK
    {
        internal static ObjectPool objectPool;

        static SDK()
        {
        }

        public static uint PartyInitialize(string titleId, out PARTY_HANDLE handle)
        {
            handle = null;
            return 0u;
        }

        public static uint PartyCleanup(PARTY_HANDLE handle)
        {
            return 0u;
        }

        public static uint PartyCreateLocalUser(PARTY_HANDLE handle, string entityId, string titlePlayerEntityToken,
            out PARTY_LOCAL_USER_HANDLE localUser)
        {
            localUser = null;
            return 0u;
        }

        public static uint PartyCreateNewNetwork(PARTY_HANDLE handle, PARTY_LOCAL_USER_HANDLE localUser,
            PARTY_NETWORK_CONFIGURATION networkConfiguration, PARTY_REGION[] regions,
            PARTY_INVITATION_CONFIGURATION initialInvitationConfiguration, object asyncIdentifier,
            out PARTY_NETWORK_DESCRIPTOR networkDescriptor, out string appliedInitialInvitationIdentifier)
        {
            networkDescriptor = null;
            appliedInitialInvitationIdentifier = null;
            return 0u;
        }

        public static uint PartyConnectToNetwork(PARTY_HANDLE handle, PARTY_NETWORK_DESCRIPTOR networkDescriptor,
            object asyncIdentifier, out PARTY_NETWORK_HANDLE network)
        {
            network = null;
            return 0u;
        }

        public static uint PartyStartProcessingStateChanges(PARTY_HANDLE handle,
            out List<PARTY_STATE_CHANGE> stateChanges)
        {
            stateChanges = null;
            return 0u;
        }

        public static uint PartyFinishProcessingStateChanges(PARTY_HANDLE handle, List<PARTY_STATE_CHANGE> stateChanges)
        {
            return 0u;
        }

        public static uint PartyDestroyLocalUser(PARTY_HANDLE handle, PARTY_LOCAL_USER_HANDLE localUser,
            object asyncIdentifier)
        {
            return 0u;
        }

        public static uint PartyGetErrorMessage(uint error, out string errorMessage)
        {
            errorMessage = null;
            return 0u;
        }

        public static uint PartyGetRegions(PARTY_HANDLE handle, out PARTY_REGION[] regionList)
        {
            regionList = null;
            return 0u;
        }

        public static uint PartyGetLocalDevice(PARTY_HANDLE handle, out PARTY_DEVICE_HANDLE localDevice)
        {
            localDevice = null;
            return 0u;
        }

        public static uint PartyGetLocalUsers(PARTY_HANDLE handle, out PARTY_LOCAL_USER_HANDLE[] users)
        {
            users = null;
            return 0u;
        }

        public static uint PartyLocalUserGetEntityId(PARTY_LOCAL_USER_HANDLE localUser, out string entityId)
        {
            entityId = null;
            return 0u;
        }

        public static uint PartyLocalUserUpdateEntityToken(PARTY_LOCAL_USER_HANDLE localUser,
            string titlePlayerEntityToken)
        {
            return 0u;
        }

        public static uint PartyLocalUserGetCustomContext(PARTY_LOCAL_USER_HANDLE localUser, out object customContext)
        {
            customContext = null;
            return 0u;
        }

        public static uint PartyLocalUserSetCustomContext(PARTY_LOCAL_USER_HANDLE localUser, object customContext)
        {
            return 0u;
        }

        public static uint PartyGetNetworks(PARTY_HANDLE handle, out PARTY_NETWORK_HANDLE[] networks)
        {
            networks = null;
            return 0u;
        }

        public static uint PartySetOption(object contextObject, PARTY_OPTION option, object value)
        {
            return 0u;
        }

        public static uint PartyGetOption(object contextObject, PARTY_OPTION option, out object value)
        {
            value = null;
            return 0u;
        }

        public static uint PartySetThreadAffinityMask(PARTY_THREAD_ID threadId, ulong threadAffinityMask)
        {
            return 0u;
        }

        public static uint PartyGetThreadAffinityMask(PARTY_THREAD_ID threadId, out ulong threadAffinityMask)
        {
            threadAffinityMask = default(ulong);
            return 0u;
        }

        public static uint PartySetWorkMode(PARTY_THREAD_ID threadId, PARTY_WORK_MODE workMode)
        {
            return 0u;
        }

        public static uint PartyGetWorkMode(PARTY_THREAD_ID threadId, out PARTY_WORK_MODE workMode)
        {
            workMode = default(PARTY_WORK_MODE);
            return 0u;
        }

        public static uint PartyDoWork(PARTY_HANDLE handle, PARTY_THREAD_ID threadId)
        {
            return 0u;
        }

        public static uint PartyGetChatControls(PARTY_HANDLE handle, out PARTY_CHAT_CONTROL_HANDLE[] chatControls)
        {
            chatControls = null;
            return 0u;
        }

        public static uint PartyNetworkAuthenticateLocalUser(PARTY_NETWORK_HANDLE network,
            PARTY_LOCAL_USER_HANDLE localUser, string invitationIdentifier, object asyncIdentifier)
        {
            return 0u;
        }

        public static uint PartyNetworkGetNetworkDescriptor(PARTY_NETWORK_HANDLE network,
            out PARTY_NETWORK_DESCRIPTOR networkDescriptor)
        {
            networkDescriptor = null;
            return 0u;
        }

        public static uint PartyNetworkCreateInvitation(PARTY_NETWORK_HANDLE network, PARTY_LOCAL_USER_HANDLE localUser,
            PARTY_INVITATION_CONFIGURATION invitationConfiguration, object asyncIdentifier,
            out PARTY_INVITATION_HANDLE invitation)
        {
            invitation = null;
            return 0u;
        }

        public static uint PartyNetworkDestroyEndpoint(PARTY_NETWORK_HANDLE network,
            PARTY_ENDPOINT_HANDLE localEndpoint, object asyncIdentifier)
        {
            return 0u;
        }

        public static uint PartyNetworkGetChatControls(PARTY_NETWORK_HANDLE network,
            out PARTY_CHAT_CONTROL_HANDLE[] chatControls)
        {
            chatControls = null;
            return 0u;
        }

        public static uint PartyNetworkFindEndpointByUniqueIdentifier(PARTY_NETWORK_HANDLE network,
            ushort uniqueIdentifier, out PARTY_ENDPOINT_HANDLE endpoint)
        {
            endpoint = null;
            return 0u;
        }

        public static uint PartyNetworkGetCustomContext(PARTY_NETWORK_HANDLE network, out object customContext)
        {
            customContext = null;
            return 0u;
        }

        public static uint PartyNetworkSetCustomContext(PARTY_NETWORK_HANDLE network, object customContext)
        {
            return 0u;
        }

        public static uint PartyNetworkGetDevices(PARTY_NETWORK_HANDLE network, out PARTY_DEVICE_HANDLE[] devices)
        {
            devices = null;
            return 0u;
        }

        public static uint PartyNetworkGetEndpoints(PARTY_NETWORK_HANDLE network, out PARTY_ENDPOINT_HANDLE[] endpoints)
        {
            endpoints = null;
            return 0u;
        }

        public static uint PartyNetworkGetInvitations(PARTY_NETWORK_HANDLE network,
            out PARTY_INVITATION_HANDLE[] invitations)
        {
            invitations = null;
            return 0u;
        }

        public static uint PartyNetworkGetLocalUsers(PARTY_NETWORK_HANDLE network, out PARTY_LOCAL_USER_HANDLE[] users)
        {
            users = null;
            return 0u;
        }

        public static uint PartyNetworkGetNetworkConfiguration(PARTY_NETWORK_HANDLE network,
            out PARTY_NETWORK_CONFIGURATION networkConfiguration)
        {
            networkConfiguration = null;
            return 0u;
        }

        public static uint PartyNetworkGetNetworkStatistics(PARTY_NETWORK_HANDLE network,
            PARTY_NETWORK_STATISTIC[] statisticTypes, out ulong[] statisticValues)
        {
            statisticValues = null;
            return 0u;
        }

        public static uint PartyNetworkKickDevice(PARTY_NETWORK_HANDLE network, PARTY_DEVICE_HANDLE targetDevice,
            object asyncIdentifier)
        {
            return 0u;
        }

        public static uint PartyNetworkKickUser(PARTY_NETWORK_HANDLE network, string targetEntityId,
            object asyncIdentifier)
        {
            return 0u;
        }

        public static uint PartyNetworkLeaveNetwork(PARTY_NETWORK_HANDLE network, object asyncIdentifier)
        {
            return 0u;
        }

        public static uint PartyNetworkRemoveLocalUser(PARTY_NETWORK_HANDLE network, PARTY_LOCAL_USER_HANDLE localUser,
            object asyncIdentifier)
        {
            return 0u;
        }

        public static uint PartyNetworkRevokeInvitation(PARTY_NETWORK_HANDLE network, PARTY_LOCAL_USER_HANDLE localUser,
            PARTY_INVITATION_HANDLE invitation, object asyncIdentifier)
        {
            return 0u;
        }

        public static uint PartySerializeNetworkDescriptor(PARTY_NETWORK_DESCRIPTOR networkDescriptor,
            out string serializedNetworkDescriptorString)
        {
            serializedNetworkDescriptorString = null;
            return 0u;
        }

        public static uint PartyDeserializeNetworkDescriptor(string serializedNetworkDescriptorString,
            out PARTY_NETWORK_DESCRIPTOR networkDescriptor)
        {
            networkDescriptor = null;
            return 0u;
        }

        public static uint PartyNetworkConnectChatControl(PARTY_NETWORK_HANDLE network,
            PARTY_CHAT_CONTROL_HANDLE chatControl, object asyncIdentifier)
        {
            return 0u;
        }

        public static uint PartyNetworkDisconnectChatControl(PARTY_NETWORK_HANDLE network,
            PARTY_CHAT_CONTROL_HANDLE chatControl, object asyncIdentifier)
        {
            return 0u;
        }

        public static uint PartyInvitationGetCreatorEntityId(PARTY_INVITATION_HANDLE invitation, out string entityId)
        {
            entityId = null;
            return 0u;
        }

        public static uint PartyInvitationGetInvitationConfiguration(PARTY_INVITATION_HANDLE invitation,
            out PARTY_INVITATION_CONFIGURATION configuration)
        {
            configuration = null;
            return 0u;
        }

        public static uint PartyInvitationGetCustomContext(PARTY_INVITATION_HANDLE invitation, out object customContext)
        {
            customContext = null;
            return 0u;
        }

        public static uint PartyInvitationSetCustomContext(PARTY_INVITATION_HANDLE invitation, object customContext)
        {
            return 0u;
        }

        public static uint PartyNetworkCreateEndpoint(PARTY_NETWORK_HANDLE network, PARTY_LOCAL_USER_HANDLE localUser,
            Dictionary<string, byte[]> keyValuePairs, object asyncIdentifier, out PARTY_ENDPOINT_HANDLE endpoint)
        {
            endpoint = null;
            return 0u;
        }

        public static uint PartyEndpointSendMessage(PARTY_ENDPOINT_HANDLE endpoint,
            PARTY_ENDPOINT_HANDLE[] targetEndpoints, PARTY_SEND_MESSAGE_OPTIONS options,
            PARTY_SEND_MESSAGE_QUEUING_CONFIGURATION queuingConfiguration, byte[] dataBuffer)
        {
            return 0u;
        }

        public static uint PartyEndpointSendMessage(PARTY_ENDPOINT_HANDLE endpoint,
            PARTY_ENDPOINT_HANDLE[] targetEndpoints, PARTY_SEND_MESSAGE_OPTIONS options,
            PARTY_SEND_MESSAGE_QUEUING_CONFIGURATION queuingConfiguration, IntPtr dataBuffer, uint dataBufferSize)
        {
            return 0u;
        }

        public static uint PartyEndpointCancelMessages(PARTY_ENDPOINT_HANDLE endpoint,
            PARTY_ENDPOINT_HANDLE[] targetEndpoints, PARTY_CANCEL_MESSAGES_FILTER_EXPRESSION filterExpression,
            uint messageIdentityFilterMask, uint filteredMessageIdentitiesToMatch, out uint canceledMessagesCount)
        {
            canceledMessagesCount = default(uint);
            return 0u;
        }

        public static uint PartyEndpointFlushMessages(PARTY_ENDPOINT_HANDLE endpoint,
            PARTY_ENDPOINT_HANDLE[] targetEndpoints)
        {
            return 0u;
        }

        public static uint PartyEndpointGetEndpointStatistics(PARTY_ENDPOINT_HANDLE endpoint,
            PARTY_ENDPOINT_HANDLE[] targetEndpoints, PARTY_ENDPOINT_STATISTIC[] statisticTypes,
            out ulong[] statisticValues)
        {
            statisticValues = null;
            return 0u;
        }

        public static uint PartyEndpointGetCustomContext(PARTY_ENDPOINT_HANDLE endpoint, out object customContext)
        {
            customContext = null;
            return 0u;
        }

        public static uint PartyEndpointSetCustomContext(PARTY_ENDPOINT_HANDLE endpoint, object customContext)
        {
            return 0u;
        }

        public static uint PartyEndpointGetDevice(PARTY_ENDPOINT_HANDLE endpoint, out PARTY_DEVICE_HANDLE device)
        {
            device = null;
            return 0u;
        }

        public static uint PartyEndpointGetEntityId(PARTY_ENDPOINT_HANDLE endpoint, out string entityId)
        {
            entityId = null;
            return 0u;
        }

        public static uint PartyEndpointGetLocalUser(PARTY_ENDPOINT_HANDLE endpoint,
            out PARTY_LOCAL_USER_HANDLE localUser)
        {
            localUser = null;
            return 0u;
        }

        public static uint PartyEndpointGetNetwork(PARTY_ENDPOINT_HANDLE endpoint, out PARTY_NETWORK_HANDLE network)
        {
            network = null;
            return 0u;
        }

        public static uint PartyEndpointGetUniqueIdentifier(PARTY_ENDPOINT_HANDLE endpoint, out ushort uniqueIdentifier)
        {
            uniqueIdentifier = default(ushort);
            return 0u;
        }

        public static uint PartyEndpointIsLocal(PARTY_ENDPOINT_HANDLE endpoint, out bool isLocal)
        {
            isLocal = default(bool);
            return 0u;
        }

        public static uint PartyDeviceIsLocal(PARTY_DEVICE_HANDLE device, out bool isLocal)
        {
            isLocal = default(bool);
            return 0u;
        }

        public static uint PartyDeviceGetCustomContext(PARTY_DEVICE_HANDLE device, out object customContext)
        {
            customContext = null;
            return 0u;
        }

        public static uint PartyDeviceSetCustomContext(PARTY_DEVICE_HANDLE device, object customContext)
        {
            return 0u;
        }

        public static uint PartyDeviceCreateChatControl(PARTY_DEVICE_HANDLE device, PARTY_LOCAL_USER_HANDLE localUser,
            string languageCode, object asyncIdentifier, out PARTY_CHAT_CONTROL_HANDLE chatControl)
        {
            chatControl = null;
            return 0u;
        }

        public static uint PartyDeviceDestroyChatControl(PARTY_DEVICE_HANDLE device,
            PARTY_CHAT_CONTROL_HANDLE chatControl, object asyncIdentifier)
        {
            return 0u;
        }

        public static uint PartyDeviceGetChatControls(PARTY_DEVICE_HANDLE device,
            out PARTY_CHAT_CONTROL_HANDLE[] chatControls)
        {
            chatControls = null;
            return 0u;
        }

        public static uint PartyChatControlSendText(PARTY_CHAT_CONTROL_HANDLE chatControl,
            PARTY_CHAT_CONTROL_HANDLE[] targetChatControls, string chatText, byte[][] dataBuffers)
        {
            return 0u;
        }

        public static uint PartyChatControlSetAudioInput(PARTY_CHAT_CONTROL_HANDLE chatControl,
            PARTY_AUDIO_DEVICE_SELECTION_TYPE audioDeviceSelectionType, string audioDeviceSelectionContext,
            object asyncIdentifier)
        {
            return 0u;
        }

        public static uint PartyChatControlGetAudioInput(PARTY_CHAT_CONTROL_HANDLE chatControl,
            out PARTY_AUDIO_DEVICE_SELECTION_TYPE audioDeviceSelectionType, out string audioDeviceSelectionContext,
            out string deviceId)
        {
            audioDeviceSelectionType = default(PARTY_AUDIO_DEVICE_SELECTION_TYPE);
            audioDeviceSelectionContext = null;
            deviceId = null;
            return 0u;
        }

        public static uint PartyChatControlSetAudioOutput(PARTY_CHAT_CONTROL_HANDLE chatControl,
            PARTY_AUDIO_DEVICE_SELECTION_TYPE audioDeviceSelectionType, string audioDeviceSelectionContext,
            object asyncIdentifier)
        {
            return 0u;
        }

        public static uint PartyChatControlGetAudioOutput(PARTY_CHAT_CONTROL_HANDLE chatControl,
            out PARTY_AUDIO_DEVICE_SELECTION_TYPE audioDeviceSelectionType, out string audioDeviceSelectionContext,
            out string deviceId)
        {
            audioDeviceSelectionType = default(PARTY_AUDIO_DEVICE_SELECTION_TYPE);
            audioDeviceSelectionContext = null;
            deviceId = null;
            return 0u;
        }

        public static uint PartyChatControlSetAudioEncoderBitrate(PARTY_CHAT_CONTROL_HANDLE chatControl, uint bitrate,
            object asyncIdentifier)
        {
            return 0u;
        }

        public static uint PartyChatControlGetAudioEncoderBitrate(PARTY_CHAT_CONTROL_HANDLE chatControl,
            out uint bitrate)
        {
            bitrate = default(uint);
            return 0u;
        }

        public static uint PartyChatControlSetAudioRenderVolume(PARTY_CHAT_CONTROL_HANDLE chatControl,
            PARTY_CHAT_CONTROL_HANDLE targetChatControl, float volume)
        {
            return 0u;
        }

        public static uint PartyChatControlGetAudioRenderVolume(PARTY_CHAT_CONTROL_HANDLE chatControl,
            PARTY_CHAT_CONTROL_HANDLE targetChatControl, out float volume)
        {
            volume = default(float);
            return 0u;
        }

        public static uint PartyChatControlSetAudioInputMuted(PARTY_CHAT_CONTROL_HANDLE chatControl, bool muted)
        {
            return 0u;
        }

        public static uint PartyChatControlGetAudioInputMuted(PARTY_CHAT_CONTROL_HANDLE chatControl, out bool muted)
        {
            muted = default(bool);
            return 0u;
        }

        public static uint PartyChatControlSetIncomingAudioMuted(PARTY_CHAT_CONTROL_HANDLE chatControl,
            PARTY_CHAT_CONTROL_HANDLE targetChatControl, bool muted)
        {
            return 0u;
        }

        public static uint PartyChatControlGetIncomingAudioMuted(PARTY_CHAT_CONTROL_HANDLE chatControl,
            PARTY_CHAT_CONTROL_HANDLE targetChatControl, out bool muted)
        {
            muted = default(bool);
            return 0u;
        }

        public static uint PartyChatControlSetIncomingTextMuted(PARTY_CHAT_CONTROL_HANDLE chatControl,
            PARTY_CHAT_CONTROL_HANDLE targetChatControl, bool muted)
        {
            return 0u;
        }

        public static uint PartyChatControlGetIncomingTextMuted(PARTY_CHAT_CONTROL_HANDLE chatControl,
            PARTY_CHAT_CONTROL_HANDLE targetChatControl, out bool muted)
        {
            muted = default(bool);
            return 0u;
        }

        public static uint PartyChatControlIsLocal(PARTY_CHAT_CONTROL_HANDLE chatControl, out bool isLocal)
        {
            isLocal = default(bool);
            return 0u;
        }

        public static uint PartyChatControlSetPermissions(PARTY_CHAT_CONTROL_HANDLE chatControl,
            PARTY_CHAT_CONTROL_HANDLE targetChatControl, PARTY_CHAT_PERMISSION_OPTIONS chatPermissionOptions)
        {
            return 0u;
        }

        public static uint PartyChatControlGetPermissions(PARTY_CHAT_CONTROL_HANDLE chatControl,
            PARTY_CHAT_CONTROL_HANDLE targetChatControl, out PARTY_CHAT_PERMISSION_OPTIONS chatPermissionOptions)
        {
            chatPermissionOptions = default(PARTY_CHAT_PERMISSION_OPTIONS);
            return 0u;
        }

        public static uint PartyChatControlGetCustomContext(PARTY_CHAT_CONTROL_HANDLE chatControl,
            out object customContext)
        {
            customContext = null;
            return 0u;
        }

        public static uint PartyChatControlSetCustomContext(PARTY_CHAT_CONTROL_HANDLE chatControl, object customContext)
        {
            return 0u;
        }

        public static uint PartyChatControlGetLanguage(PARTY_CHAT_CONTROL_HANDLE chatControl, out string languageCode)
        {
            languageCode = null;
            return 0u;
        }

        public static uint PartyChatControlSetLanguage(PARTY_CHAT_CONTROL_HANDLE chatControl, string languageCode,
            object asyncIdentifier)
        {
            return 0u;
        }

        public static uint PartyChatControlSetTextChatOptions(PARTY_CHAT_CONTROL_HANDLE chatControl,
            PARTY_TEXT_CHAT_OPTIONS options, object asyncIdentifier)
        {
            return 0u;
        }

        public static uint PartyChatControlGetTextChatOptions(PARTY_CHAT_CONTROL_HANDLE chatControl,
            out PARTY_TEXT_CHAT_OPTIONS options)
        {
            options = default(PARTY_TEXT_CHAT_OPTIONS);
            return 0u;
        }

        public static uint PartyChatControlSynthesizeTextToSpeech(PARTY_CHAT_CONTROL_HANDLE chatControl,
            PARTY_SYNTHESIZE_TEXT_TO_SPEECH_TYPE type, string textToSynthesize, object asyncIdentifier)
        {
            return 0u;
        }

        public static uint PartyChatControlSetTranscriptionOptions(PARTY_CHAT_CONTROL_HANDLE chatControl,
            PARTY_VOICE_CHAT_TRANSCRIPTION_OPTIONS options, object asyncIdentifier)
        {
            return 0u;
        }

        public static uint PartyChatControlGetTranscriptionOptions(PARTY_CHAT_CONTROL_HANDLE chatControl,
            out PARTY_VOICE_CHAT_TRANSCRIPTION_OPTIONS options)
        {
            options = default(PARTY_VOICE_CHAT_TRANSCRIPTION_OPTIONS);
            return 0u;
        }

        public static uint PartyChatControlSetTextToSpeechProfile(PARTY_CHAT_CONTROL_HANDLE chatControl,
            PARTY_SYNTHESIZE_TEXT_TO_SPEECH_TYPE type, string profileIdentifier, object asyncIdentifier)
        {
            return 0u;
        }

        public static uint PartyChatControlGetTextToSpeechProfile(PARTY_CHAT_CONTROL_HANDLE chatControl,
            PARTY_SYNTHESIZE_TEXT_TO_SPEECH_TYPE type, out PARTY_TEXT_TO_SPEECH_PROFILE_HANDLE profile)
        {
            profile = null;
            return 0u;
        }

        public static uint PartyChatControlPopulateAvailableTextToSpeechProfiles(PARTY_CHAT_CONTROL_HANDLE chatControl,
            object asyncIdentifier)
        {
            return 0u;
        }

        public static uint PartyChatControlGetAvailableTextToSpeechProfiles(PARTY_CHAT_CONTROL_HANDLE chatControl,
            out PARTY_TEXT_TO_SPEECH_PROFILE_HANDLE[] profiles)
        {
            profiles = null;
            return 0u;
        }

        public static uint PartyTextToSpeechProfileGetCustomContext(PARTY_TEXT_TO_SPEECH_PROFILE_HANDLE profile,
            out object customContext)
        {
            customContext = null;
            return 0u;
        }

        public static uint PartyTextToSpeechProfileSetCustomContext(PARTY_TEXT_TO_SPEECH_PROFILE_HANDLE profile,
            object customContext)
        {
            return 0u;
        }

        public static uint PartyTextToSpeechProfileGetGender(PARTY_TEXT_TO_SPEECH_PROFILE_HANDLE profile,
            out PARTY_GENDER gender)
        {
            gender = default(PARTY_GENDER);
            return 0u;
        }

        public static uint PartyTextToSpeechProfileGetIdentifier(PARTY_TEXT_TO_SPEECH_PROFILE_HANDLE profile,
            out string identifier)
        {
            identifier = null;
            return 0u;
        }

        public static uint PartyTextToSpeechProfileGetLanguageCode(PARTY_TEXT_TO_SPEECH_PROFILE_HANDLE profile,
            out string languageCode)
        {
            languageCode = null;
            return 0u;
        }

        public static uint PartyTextToSpeechProfileGetName(PARTY_TEXT_TO_SPEECH_PROFILE_HANDLE profile, out string name)
        {
            name = null;
            return 0u;
        }

        public static uint PartyChatControlGetChatIndicator(PARTY_CHAT_CONTROL_HANDLE chatControl,
            PARTY_CHAT_CONTROL_HANDLE targetChatControl, out PARTY_CHAT_CONTROL_CHAT_INDICATOR chatIndicator)
        {
            chatIndicator = default(PARTY_CHAT_CONTROL_CHAT_INDICATOR);
            return 0u;
        }

        public static uint PartyChatControlGetLocalChatIndicator(PARTY_CHAT_CONTROL_HANDLE chatControl,
            out PARTY_LOCAL_CHAT_CONTROL_CHAT_INDICATOR chatIndicator)
        {
            chatIndicator = default(PARTY_LOCAL_CHAT_CONTROL_CHAT_INDICATOR);
            return 0u;
        }

        public static uint PartyChatControlGetDevice(PARTY_CHAT_CONTROL_HANDLE chatControl,
            out PARTY_DEVICE_HANDLE device)
        {
            device = null;
            return 0u;
        }

        public static uint PartyChatControlGetLocalUser(PARTY_CHAT_CONTROL_HANDLE chatControl,
            out PARTY_LOCAL_USER_HANDLE localUser)
        {
            localUser = null;
            return 0u;
        }

        public static uint PartyChatControlGetNetworks(PARTY_CHAT_CONTROL_HANDLE chatControl,
            out PARTY_NETWORK_HANDLE[] networks)
        {
            networks = null;
            return 0u;
        }

        public static uint PartyChatControlGetEntityId(PARTY_CHAT_CONTROL_HANDLE chatControl, out string entityId)
        {
            entityId = null;
            return 0u;
        }
    }
}