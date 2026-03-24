using System;
using System.Runtime.InteropServices;

namespace PartyCSharpSDK.Interop
{
    internal class PFPInterop
    {
        private const string ThunkDllName = "PartyWin32";

        [PreserveSig]
        internal static extern uint PartyChatControlSendText(PARTY_CHAT_CONTROL_HANDLE chatControl,
            uint targetChatControlCount, IntPtr targetChatControls, byte[] chatText, uint dataBufferCount,
            IntPtr dataBuffers);

        [PreserveSig]
        internal static extern uint PartyChatControlGetAudioEncoderBitrate(PARTY_CHAT_CONTROL_HANDLE chatControl,
            out uint bitrate);

        [PreserveSig]
        internal static extern uint PartyChatControlSetAudioEncoderBitrate(PARTY_CHAT_CONTROL_HANDLE chatControl,
            uint bitrate, IntPtr asyncIdentifier);

        [PreserveSig]
        internal unsafe static extern uint PartyChatControlConfigureAudioManipulationCaptureStream(
            PARTY_CHAT_CONTROL_HANDLE chatControl, PARTY_AUDIO_MANIPULATION_SINK_STREAM_CONFIGURATION* configuration,
            IntPtr asyncIdentifier);

        [PreserveSig]
        internal unsafe static extern uint PartyChatControlGetPropertyKeys(PARTY_CHAT_CONTROL_HANDLE chatControl,
            out uint propertyCount, out UTF8StringPtr* keys);

        [PreserveSig]
        internal static extern uint PartyChatControlSetTextToSpeechProfile(PARTY_CHAT_CONTROL_HANDLE chatControl,
            PARTY_SYNTHESIZE_TEXT_TO_SPEECH_TYPE type, byte[] profileIdentifier, IntPtr asyncIdentifier);

        [PreserveSig]
        internal static extern uint PartyChatControlGetTextToSpeechProfile(PARTY_CHAT_CONTROL_HANDLE chatControl,
            PARTY_SYNTHESIZE_TEXT_TO_SPEECH_TYPE type, out PARTY_TEXT_TO_SPEECH_PROFILE_HANDLE profile);

        [PreserveSig]
        internal static extern uint PartyTextToSpeechProfileGetName(PARTY_TEXT_TO_SPEECH_PROFILE_HANDLE profile,
            out UTF8StringPtr name);

        [PreserveSig]
        internal static extern uint PartyTextToSpeechProfileGetGender(PARTY_TEXT_TO_SPEECH_PROFILE_HANDLE profile,
            out PARTY_GENDER gender);

        [PreserveSig]
        internal static extern uint PartyChatControlGetLanguage(PARTY_CHAT_CONTROL_HANDLE chatControl,
            out UTF8StringPtr languageCode);

        [PreserveSig]
        internal static extern uint PartyChatControlSetAudioOutput(PARTY_CHAT_CONTROL_HANDLE chatControl,
            PARTY_AUDIO_DEVICE_SELECTION_TYPE audioDeviceSelectionType, byte[] audioDeviceSelectionContext,
            IntPtr asyncIdentifier);

        [PreserveSig]
        internal static extern uint PartyChatControlGetAudioOutput(PARTY_CHAT_CONTROL_HANDLE chatControl,
            out PARTY_AUDIO_DEVICE_SELECTION_TYPE audioDeviceSelectionType,
            out UTF8StringPtr audioDeviceSelectionContext, out UTF8StringPtr deviceId);

        [PreserveSig]
        internal static extern uint PartyChatControlSetLanguage(PARTY_CHAT_CONTROL_HANDLE chatControl,
            byte[] languageCode, IntPtr asyncIdentifier);

        [PreserveSig]
        internal static extern uint PartyChatControlGetDevice(PARTY_CHAT_CONTROL_HANDLE chatControl,
            out PARTY_DEVICE_HANDLE device);

        [PreserveSig]
        internal static extern uint PartyChatControlSetProperties(PARTY_CHAT_CONTROL_HANDLE chatControl,
            uint propertyCount, [In] UTF8StringPtr[] keys, [In] PARTY_DATA_BUFFER[] values);

        [PreserveSig]
        internal static extern uint PartyChatControlGetAvailableTextToSpeechProfiles(
            PARTY_CHAT_CONTROL_HANDLE chatControl, out uint profileCount, out IntPtr profiles);

        [PreserveSig]
        internal static extern uint PartyChatControlGetCustomContext(PARTY_CHAT_CONTROL_HANDLE chatControl,
            out IntPtr customContext);

        [PreserveSig]
        internal static extern uint PartyTextToSpeechProfileGetLanguageCode(PARTY_TEXT_TO_SPEECH_PROFILE_HANDLE profile,
            out UTF8StringPtr languageCode);

        [PreserveSig]
        internal static extern uint PartyChatControlSetCustomContext(PARTY_CHAT_CONTROL_HANDLE chatControl,
            IntPtr customContext);

        [PreserveSig]
        internal static extern uint PartyChatControlIsLocal(PARTY_CHAT_CONTROL_HANDLE chatControl, out byte isLocal);

        [PreserveSig]
        internal static extern uint PartyChatControlGetIncomingTextMuted(PARTY_CHAT_CONTROL_HANDLE chatControl,
            PARTY_CHAT_CONTROL_HANDLE targetChatControl, out byte muted);

        [PreserveSig]
        internal static extern uint PartyChatControlSetIncomingTextMuted(PARTY_CHAT_CONTROL_HANDLE chatControl,
            PARTY_CHAT_CONTROL_HANDLE targetChatControl, byte muted);

        [PreserveSig]
        internal static extern uint PartyChatControlSetPermissions(PARTY_CHAT_CONTROL_HANDLE chatControl,
            PARTY_CHAT_CONTROL_HANDLE targetChatControl, PARTY_CHAT_PERMISSION_OPTIONS chatPermissionOptions);

        [PreserveSig]
        internal static extern uint PartyChatControlGetPermissions(PARTY_CHAT_CONTROL_HANDLE chatControl,
            PARTY_CHAT_CONTROL_HANDLE targetChatControl, out PARTY_CHAT_PERMISSION_OPTIONS chatPermissionOptions);

        [PreserveSig]
        internal static extern uint PartyChatControlGetNetworks(PARTY_CHAT_CONTROL_HANDLE chatControl,
            out uint networkCount, out IntPtr networks);

        [PreserveSig]
        internal unsafe static extern uint PartyChatControlConfigureAudioManipulationVoiceStream(
            PARTY_CHAT_CONTROL_HANDLE chatControl, PARTY_AUDIO_MANIPULATION_SOURCE_STREAM_CONFIGURATION* configuration,
            IntPtr asyncIdentifier);

        [PreserveSig]
        internal static extern uint PartyChatControlGetLocalChatIndicator(PARTY_CHAT_CONTROL_HANDLE chatControl,
            out PARTY_LOCAL_CHAT_CONTROL_CHAT_INDICATOR chatIndicator);

        [PreserveSig]
        internal unsafe static extern uint PartyChatControlGetProperty(PARTY_CHAT_CONTROL_HANDLE chatControl,
            byte[] key, out PARTY_DATA_BUFFER* value);

        [PreserveSig]
        internal static extern uint PartyChatControlGetAudioInputMuted(PARTY_CHAT_CONTROL_HANDLE chatControl,
            out byte muted);

        [PreserveSig]
        internal static extern uint PartyChatControlSetAudioInputMuted(PARTY_CHAT_CONTROL_HANDLE chatControl,
            byte muted);

        [PreserveSig]
        internal static extern uint PartyChatControlSetAudioRenderVolume(PARTY_CHAT_CONTROL_HANDLE chatControl,
            PARTY_CHAT_CONTROL_HANDLE targetChatControl, float volume);

        [PreserveSig]
        internal unsafe static extern uint PartyChatControlConfigureAudioManipulationRenderStream(
            PARTY_CHAT_CONTROL_HANDLE chatControl, PARTY_AUDIO_MANIPULATION_SINK_STREAM_CONFIGURATION* configuration,
            IntPtr asyncIdentifier);

        [PreserveSig]
        internal static extern uint PartyChatControlGetAudioRenderVolume(PARTY_CHAT_CONTROL_HANDLE chatControl,
            PARTY_CHAT_CONTROL_HANDLE targetChatControl, out float volume);

        [PreserveSig]
        internal static extern uint PartyChatControlGetEntityId(PARTY_CHAT_CONTROL_HANDLE chatControl,
            out UTF8StringPtr entityId);

        [PreserveSig]
        internal static extern uint PartyChatControlGetTranscriptionOptions(PARTY_CHAT_CONTROL_HANDLE chatControl,
            out PARTY_VOICE_CHAT_TRANSCRIPTION_OPTIONS options);

        [PreserveSig]
        internal static extern uint PartyTextToSpeechProfileGetIdentifier(PARTY_TEXT_TO_SPEECH_PROFILE_HANDLE profile,
            out UTF8StringPtr identifier);

        [PreserveSig]
        internal static extern uint PartyChatControlSetTranscriptionOptions(PARTY_CHAT_CONTROL_HANDLE chatControl,
            PARTY_VOICE_CHAT_TRANSCRIPTION_OPTIONS options, IntPtr asyncIdentifier);

        [PreserveSig]
        internal static extern uint PartyTextToSpeechProfileSetCustomContext(
            PARTY_TEXT_TO_SPEECH_PROFILE_HANDLE profile, IntPtr customContext);

        [PreserveSig]
        internal static extern uint PartyTextToSpeechProfileGetCustomContext(
            PARTY_TEXT_TO_SPEECH_PROFILE_HANDLE profile, out IntPtr customContext);

        [PreserveSig]
        internal static extern uint PartyChatControlPopulateAvailableTextToSpeechProfiles(
            PARTY_CHAT_CONTROL_HANDLE chatControl, IntPtr asyncIdentifier);

        [PreserveSig]
        internal static extern uint PartyChatControlGetChatIndicator(PARTY_CHAT_CONTROL_HANDLE chatControl,
            PARTY_CHAT_CONTROL_HANDLE targetChatControl, out PARTY_CHAT_CONTROL_CHAT_INDICATOR chatIndicator);

        [PreserveSig]
        internal static extern uint PartyChatControlSetTextChatOptions(PARTY_CHAT_CONTROL_HANDLE chatControl,
            PARTY_TEXT_CHAT_OPTIONS options, IntPtr asyncIdentifier);

        [PreserveSig]
        internal static extern uint PartyChatControlGetTextChatOptions(PARTY_CHAT_CONTROL_HANDLE chatControl,
            out PARTY_TEXT_CHAT_OPTIONS options);

        [PreserveSig]
        internal static extern uint PartyChatControlGetIncomingAudioMuted(PARTY_CHAT_CONTROL_HANDLE chatControl,
            PARTY_CHAT_CONTROL_HANDLE targetChatControl, out byte muted);

        [PreserveSig]
        internal static extern uint PartyChatControlSetIncomingAudioMuted(PARTY_CHAT_CONTROL_HANDLE chatControl,
            PARTY_CHAT_CONTROL_HANDLE targetChatControl, byte muted);

        [PreserveSig]
        internal static extern uint PartyChatControlGetLocalUser(PARTY_CHAT_CONTROL_HANDLE chatControl,
            out PARTY_LOCAL_USER_HANDLE localUser);

        [PreserveSig]
        internal static extern uint PartyChatControlSetAudioInput(PARTY_CHAT_CONTROL_HANDLE chatControl,
            PARTY_AUDIO_DEVICE_SELECTION_TYPE audioDeviceSelectionType, byte[] audioDeviceSelectionContext,
            IntPtr asyncIdentifier);

        [PreserveSig]
        internal static extern uint PartyChatControlGetAudioInput(PARTY_CHAT_CONTROL_HANDLE chatControl,
            out PARTY_AUDIO_DEVICE_SELECTION_TYPE audioDeviceSelectionType,
            out UTF8StringPtr audioDeviceSelectionContext, out UTF8StringPtr deviceId);

        [PreserveSig]
        internal static extern uint PartyChatControlSynthesizeTextToSpeech(PARTY_CHAT_CONTROL_HANDLE chatControl,
            PARTY_SYNTHESIZE_TEXT_TO_SPEECH_TYPE type, byte[] textToSynthesize, IntPtr asyncIdentifier);

        [PreserveSig]
        internal unsafe static extern uint PartyDeviceGetProperty(PARTY_DEVICE_HANDLE device, byte[] key,
            out PARTY_DATA_BUFFER* value);

        [PreserveSig]
        internal static extern uint PartyDeviceGetChatControls(PARTY_DEVICE_HANDLE device, out uint chatControlCount,
            out IntPtr chatControls);

        [PreserveSig]
        internal static extern uint PartyDeviceCreateChatControl(PARTY_DEVICE_HANDLE device,
            PARTY_LOCAL_USER_HANDLE localUser, byte[] languageCode, IntPtr asyncIdentifier,
            out PARTY_CHAT_CONTROL_HANDLE chatControl);

        [PreserveSig]
        internal static extern uint PartyDeviceIsLocal(PARTY_DEVICE_HANDLE device, out byte isLocal);

        [PreserveSig]
        internal static extern uint PartyDeviceSetCustomContext(PARTY_DEVICE_HANDLE device, IntPtr customContext);

        [PreserveSig]
        internal static extern uint PartyDeviceSetProperties(PARTY_DEVICE_HANDLE device, uint propertyCount,
            [In] UTF8StringPtr[] keys, [In] PARTY_DATA_BUFFER[] values);

        [PreserveSig]
        internal static extern uint PartyDeviceGetPropertyKeys(PARTY_DEVICE_HANDLE device, out uint propertyCount,
            out UTF8StringPtr[] keys);

        [PreserveSig]
        internal static extern uint PartyDeviceGetCustomContext(PARTY_DEVICE_HANDLE device, out IntPtr customContext);

        [PreserveSig]
        internal static extern uint PartyDeviceDestroyChatControl(PARTY_DEVICE_HANDLE device,
            PARTY_CHAT_CONTROL_HANDLE chatControl, IntPtr asyncIdentifier);

        [PreserveSig]
        internal static extern uint PartyEndpointGetUniqueIdentifier(PARTY_ENDPOINT_HANDLE endpoint,
            out ushort uniqueIdentifier);

        [PreserveSig]
        internal static extern uint PartyEndpointSetCustomContext(PARTY_ENDPOINT_HANDLE endpoint, IntPtr customContext);

        [PreserveSig]
        internal static extern uint PartyEndpointCancelMessages(PARTY_ENDPOINT_HANDLE endpoint,
            uint targetEndpointCount, IntPtr targetEndpoints, PARTY_CANCEL_MESSAGES_FILTER_EXPRESSION filterExpression,
            uint messageIdentityFilterMask, uint filteredMessageIdentitiesToMatch, out uint canceledMessagesCount);

        [PreserveSig]
        internal static extern uint PartyEndpointGetDevice(PARTY_ENDPOINT_HANDLE endpoint,
            out PARTY_DEVICE_HANDLE device);

        [PreserveSig]
        internal static extern uint PartyEndpointIsLocal(PARTY_ENDPOINT_HANDLE endpoint, out byte isLocal);

        [PreserveSig]
        internal unsafe static extern uint PartyEndpointSendMessage(PARTY_ENDPOINT_HANDLE endpoint,
            uint targetEndpointCount, IntPtr targetEndpoints, PARTY_SEND_MESSAGE_OPTIONS options,
            PARTY_SEND_MESSAGE_QUEUING_CONFIGURATION* queuingConfiguration, uint dataBufferCount,
            PARTY_DATA_BUFFER* dataBuffers, IntPtr messageIdentifier);

        [PreserveSig]
        internal static extern uint PartyEndpointGetCustomContext(PARTY_ENDPOINT_HANDLE endpoint,
            out IntPtr customContext);

        [PreserveSig]
        internal unsafe static extern uint PartyEndpointGetPropertyKeys(PARTY_ENDPOINT_HANDLE endpoint,
            out uint propertyCount, out UTF8StringPtr* keys);

        [PreserveSig]
        internal static extern uint
            PartyEndpointGetEntityId(PARTY_ENDPOINT_HANDLE endpoint, out UTF8StringPtr entityId);

        [PreserveSig]
        internal static extern uint PartyEndpointGetEndpointStatistics(PARTY_ENDPOINT_HANDLE endpoint,
            uint targetEndpointCount, IntPtr targetEndpoints, uint statisticCount,
            PARTY_ENDPOINT_STATISTIC[] statisticTypes, ulong[] statisticValues);

        [PreserveSig]
        internal unsafe static extern uint PartyEndpointGetProperty(PARTY_ENDPOINT_HANDLE endpoint, byte[] key,
            out PARTY_DATA_BUFFER* value);

        [PreserveSig]
        internal static extern uint PartyEndpointGetNetwork(PARTY_ENDPOINT_HANDLE endpoint,
            out PARTY_NETWORK_HANDLE network);

        [PreserveSig]
        internal static extern uint PartyEndpointFlushMessages(PARTY_ENDPOINT_HANDLE endpoint, uint targetEndpointCount,
            IntPtr targetEndpoints);

        [PreserveSig]
        internal static extern uint PartyEndpointGetLocalUser(PARTY_ENDPOINT_HANDLE endpoint,
            out PARTY_LOCAL_USER_HANDLE localUser);

        [PreserveSig]
        internal static extern uint PartyEndpointSetProperties(PARTY_ENDPOINT_HANDLE endpoint, uint propertyCount,
            [In] UTF8StringPtr[] keys, [In] PARTY_DATA_BUFFER[] values);

        [PreserveSig]
        internal static extern uint PartyNetworkSetProperties(PARTY_NETWORK_HANDLE network, uint propertyCount,
            [In] UTF8StringPtr[] keys, [In] PARTY_DATA_BUFFER[] values);

        [PreserveSig]
        internal static extern uint PartyNetworkLeaveNetwork(PARTY_NETWORK_HANDLE network, IntPtr asyncIdentifier);

        [PreserveSig]
        internal unsafe static extern uint PartyNetworkCreateInvitation(PARTY_NETWORK_HANDLE network,
            PARTY_LOCAL_USER_HANDLE localUser, PARTY_INVITATION_CONFIGURATION* invitationConfiguration,
            IntPtr asyncIdentifier, out PARTY_INVITATION_HANDLE invitation);

        [PreserveSig]
        internal static extern uint PartyNetworkGetNetworkConfiguration(PARTY_NETWORK_HANDLE network,
            out IntPtr networkConfiguration);

        [PreserveSig]
        internal unsafe static extern uint PartySerializeNetworkDescriptor(PARTY_NETWORK_DESCRIPTOR* networkDescriptor,
            IntPtr serializedNetworkDescriptorString);

        [PreserveSig]
        internal static extern uint PartyDeserializeNetworkDescriptor(byte[] serializedNetworkDescriptorString,
            out PARTY_NETWORK_DESCRIPTOR networkDescriptor);

        [PreserveSig]
        internal static extern uint PartyNetworkDestroyEndpoint(PARTY_NETWORK_HANDLE network,
            PARTY_ENDPOINT_HANDLE localEndpoint, IntPtr asyncIdentifier);

        [PreserveSig]
        internal static extern uint PartyNetworkDisconnectChatControl(PARTY_NETWORK_HANDLE network,
            PARTY_CHAT_CONTROL_HANDLE chatControl, IntPtr asyncIdentifier);

        [PreserveSig]
        internal static extern uint
            PartyNetworkGetCustomContext(PARTY_NETWORK_HANDLE network, out IntPtr customContext);

        [PreserveSig]
        internal static extern uint PartyNetworkGetDevices(PARTY_NETWORK_HANDLE network, out uint deviceCount,
            out IntPtr devices);

        [PreserveSig]
        internal static extern uint PartyNetworkSetCustomContext(PARTY_NETWORK_HANDLE network, IntPtr customContext);

        [PreserveSig]
        internal static extern uint PartyNetworkKickUser(PARTY_NETWORK_HANDLE network, byte[] targetEntityId,
            IntPtr asyncIdentifier);

        [PreserveSig]
        internal unsafe static extern uint PartyNetworkGetPropertyKeys(PARTY_NETWORK_HANDLE network,
            out uint propertyCount, out UTF8StringPtr* keys);

        [PreserveSig]
        internal static extern uint PartyNetworkConnectChatControl(PARTY_NETWORK_HANDLE network,
            PARTY_CHAT_CONTROL_HANDLE chatControl, IntPtr asyncIdentifier);

        [PreserveSig]
        internal static extern uint PartyNetworkRevokeInvitation(PARTY_NETWORK_HANDLE network,
            PARTY_LOCAL_USER_HANDLE localUser, PARTY_INVITATION_HANDLE invitation, IntPtr asyncIdentifier);

        [PreserveSig]
        internal static extern uint PartyNetworkGetChatControls(PARTY_NETWORK_HANDLE network, out uint chatControlCount,
            out IntPtr chatControls);

        [PreserveSig]
        internal static extern uint PartyNetworkFindEndpointByUniqueIdentifier(PARTY_NETWORK_HANDLE network,
            ushort uniqueIdentifier, out PARTY_ENDPOINT_HANDLE endpoint);

        [PreserveSig]
        internal static extern uint PartyNetworkGetLocalUsers(PARTY_NETWORK_HANDLE network, out uint userCount,
            out IntPtr users);

        [PreserveSig]
        internal static extern uint PartyNetworkCreateEndpoint(PARTY_NETWORK_HANDLE network,
            PARTY_LOCAL_USER_HANDLE localUser, uint propertyCount, IntPtr keys, IntPtr values, IntPtr asyncIdentifier,
            out PARTY_ENDPOINT_HANDLE endpoint);

        [PreserveSig]
        internal static extern uint PartyNetworkGetInvitations(PARTY_NETWORK_HANDLE network, out uint invitationCount,
            out IntPtr invitations);

        [PreserveSig]
        internal static extern uint PartyNetworkGetEndpoints(PARTY_NETWORK_HANDLE network, out uint endpointCount,
            out IntPtr endpoints);

        [PreserveSig]
        internal unsafe static extern uint PartyNetworkGetProperty(PARTY_NETWORK_HANDLE network, byte[] key,
            out PARTY_DATA_BUFFER* value);

        [PreserveSig]
        internal static extern uint PartyNetworkKickDevice(PARTY_NETWORK_HANDLE network,
            PARTY_DEVICE_HANDLE targetDevice, IntPtr asyncIdentifier);

        [PreserveSig]
        internal static extern uint PartyNetworkGetNetworkStatistics(PARTY_NETWORK_HANDLE network, uint statisticCount,
            PARTY_NETWORK_STATISTIC[] statisticTypes, ulong[] statisticValues);

        [PreserveSig]
        internal static extern uint PartyNetworkGetNetworkDescriptor(PARTY_NETWORK_HANDLE network,
            out PARTY_NETWORK_DESCRIPTOR networkDescriptor);

        [PreserveSig]
        internal static extern uint PartyNetworkRemoveLocalUser(PARTY_NETWORK_HANDLE network,
            PARTY_LOCAL_USER_HANDLE localUser, IntPtr asyncIdentifier);

        [PreserveSig]
        internal static extern uint PartyNetworkAuthenticateLocalUser(PARTY_NETWORK_HANDLE network,
            PARTY_LOCAL_USER_HANDLE localUser, byte[] invitationIdentifier, IntPtr asyncIdentifier);

        [PreserveSig]
        internal static extern uint PartyInitialize(byte[] titleId, out PARTY_HANDLE handle);

        [PreserveSig]
        internal static extern uint PartyCleanup(PARTY_HANDLE handle);

        [PreserveSig]
        internal static extern uint PartyCreateLocalUser(PARTY_HANDLE handle, byte[] entityId,
            byte[] titlePlayerEntityToken, out PARTY_LOCAL_USER_HANDLE localUser);

        [PreserveSig]
        internal unsafe static extern uint PartyCreateNewNetwork(PARTY_HANDLE handle, PARTY_LOCAL_USER_HANDLE localUser,
            PARTY_NETWORK_CONFIGURATION* networkConfiguration, uint regionCount, IntPtr regions,
            PARTY_INVITATION_CONFIGURATION* initialInvitationConfiguration, IntPtr asyncIdentifier,
            out PARTY_NETWORK_DESCRIPTOR networkDescriptor, IntPtr appliedInitialInvitationIdentifier);

        [PreserveSig]
        internal static extern uint PartyGetNetworks(PARTY_HANDLE handle, out uint networkCount, out IntPtr networks);

        [PreserveSig]
        internal static extern uint PartyInvitationGetCreatorEntityId(PARTY_INVITATION_HANDLE invitation,
            out UTF8StringPtr entityId);

        [PreserveSig]
        internal static extern uint PartySynchronizeMessagesBetweenEndpoints(PARTY_HANDLE handle, uint endpointCount,
            [In] PARTY_ENDPOINT_HANDLE[] endpoints, PARTY_SYNCHRONIZE_MESSAGES_BETWEEN_ENDPOINTS_OPTIONS options,
            IntPtr asyncIdentifier);

        [PreserveSig]
        internal static extern uint PartyInvitationSetCustomContext(PARTY_INVITATION_HANDLE invitation,
            IntPtr customContext);

        [PreserveSig]
        internal static extern uint PartyGetChatControls(PARTY_HANDLE handle, out uint chatControlCount,
            out IntPtr chatControls);

        [PreserveSig]
        internal static extern uint PartyInvitationGetInvitationConfiguration(PARTY_INVITATION_HANDLE invitation,
            out IntPtr configuration);

        [PreserveSig]
        internal static extern uint PartyInvitationGetCustomContext(PARTY_INVITATION_HANDLE invitation,
            out IntPtr customContext);

        [PreserveSig]
        internal static extern uint PartyFinishProcessingStateChanges(PARTY_HANDLE handle, uint stateChangeCount,
            IntPtr stateChanges);

        [PreserveSig]
        internal static extern uint PartySetOption(IntPtr Object, PARTY_OPTION option, IntPtr value);

        [PreserveSig]
        internal static extern uint PartyLocalUserGetEntityId(PARTY_LOCAL_USER_HANDLE localUser,
            out UTF8StringPtr entityId);

        [PreserveSig]
        internal unsafe static extern uint PartyConnectToNetwork(PARTY_HANDLE handle,
            PARTY_NETWORK_DESCRIPTOR* networkDescriptor, IntPtr asyncIdentifier, out PARTY_NETWORK_HANDLE network);

        [PreserveSig]
        internal static extern uint PartyGetRegions(PARTY_HANDLE handle, out uint regionListCount,
            out IntPtr regionList);

        [PreserveSig]
        internal static extern uint PartyLocalUserUpdateEntityToken(PARTY_LOCAL_USER_HANDLE localUser,
            byte[] titlePlayerEntityToken);

        [PreserveSig]
        internal static extern uint PartyDestroyLocalUser(PARTY_HANDLE handle, PARTY_LOCAL_USER_HANDLE localUser,
            IntPtr asyncIdentifier);

        [PreserveSig]
        internal static extern uint PartySetThreadAffinityMask(PARTY_THREAD_ID threadId, ulong threadAffinityMask);

        [PreserveSig]
        internal static extern uint PartySetWorkMode(PARTY_THREAD_ID threadId, PARTY_WORK_MODE workMode);

        [PreserveSig]
        internal static extern uint PartyDoWork(PARTY_HANDLE handle, PARTY_THREAD_ID threadId);

        [PreserveSig]
        internal static extern uint PartyGetOption(IntPtr Object, PARTY_OPTION option, IntPtr value);

        [PreserveSig]
        internal static extern uint PartyLocalUserGetCustomContext(PARTY_LOCAL_USER_HANDLE localUser,
            out IntPtr customContext);

        [PreserveSig]
        internal static extern uint PartyGetErrorMessage(uint error, out UTF8StringPtr errorMessage);

        [PreserveSig]
        internal static extern uint PartyGetThreadAffinityMask(PARTY_THREAD_ID threadId, out ulong threadAffinityMask);

        [PreserveSig]
        internal static extern uint PartyGetWorkMode(PARTY_THREAD_ID threadId, out PARTY_WORK_MODE workMode);

        [PreserveSig]
        internal static extern uint PartyStartProcessingStateChanges(PARTY_HANDLE handle, out uint stateChangeCount,
            out IntPtr stateChanges);

        [PreserveSig]
        internal static extern uint PartyGetLocalDevice(PARTY_HANDLE handle, out PARTY_DEVICE_HANDLE localDevice);

        [PreserveSig]
        internal static extern uint PartyLocalUserSetCustomContext(PARTY_LOCAL_USER_HANDLE localUser,
            IntPtr customContext);

        [PreserveSig]
        internal static extern uint PartyGetLocalUsers(PARTY_HANDLE handle, out uint userCount, out IntPtr users);
    }
}