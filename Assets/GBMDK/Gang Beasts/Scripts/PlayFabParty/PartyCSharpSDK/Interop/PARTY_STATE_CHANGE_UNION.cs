using System.Runtime.InteropServices;

namespace PartyCSharpSDK.Interop
{
    [StructLayout((LayoutKind)2)]
    internal struct PARTY_STATE_CHANGE_UNION
    {
        [FieldOffset(0)] internal readonly PARTY_STATE_CHANGE stateChange;

        [FieldOffset(0)] internal readonly PARTY_REGIONS_CHANGED_STATE_CHANGE regionsChanged;

        [FieldOffset(0)] internal readonly PARTY_CREATE_NEW_NETWORK_COMPLETED_STATE_CHANGE createNewNetworkCompleted;

        [FieldOffset(0)] internal readonly PARTY_CONNECT_TO_NETWORK_COMPLETED_STATE_CHANGE connectToNetworkCompleted;

        [FieldOffset(0)]
        internal readonly PARTY_AUTHENTICATE_LOCAL_USER_COMPLETED_STATE_CHANGE authenticateLocalUserCompleted;

        [FieldOffset(0)]
        internal readonly PARTY_NETWORK_CONFIGURATION_MADE_AVAILABLE_STATE_CHANGE networkConfigurationMadeAvailable;

        [FieldOffset(0)] internal readonly PARTY_NETWORK_DESCRIPTOR_CHANGED_STATE_CHANGE networkDescriptorChanged;

        [FieldOffset(0)] internal readonly PARTY_LOCAL_USER_REMOVED_STATE_CHANGE localUserRemoved;

        [FieldOffset(0)] internal readonly PARTY_REMOVE_LOCAL_USER_COMPLETED_STATE_CHANGE removeLocalUserCompleted;

        [FieldOffset(0)] internal readonly PARTY_DESTROY_LOCAL_USER_COMPLETED_STATE_CHANGE destroyLocalUserCompleted;

        [FieldOffset(0)] internal readonly PARTY_LOCAL_USER_KICKED_STATE_CHANGE localUserKicked;

        [FieldOffset(0)] internal readonly PARTY_CREATE_ENDPOINT_COMPLETED_STATE_CHANGE createEndpointCompleted;

        [FieldOffset(0)] internal readonly PARTY_DESTROY_ENDPOINT_COMPLETED_STATE_CHANGE destroyEndpointCompleted;

        [FieldOffset(0)] internal readonly PARTY_ENDPOINT_CREATED_STATE_CHANGE endpointCreated;

        [FieldOffset(0)] internal readonly PARTY_ENDPOINT_DESTROYED_STATE_CHANGE endpointDestroyed;

        [FieldOffset(0)] internal readonly PARTY_REMOTE_DEVICE_CREATED_STATE_CHANGE remoteDeviceCreated;

        [FieldOffset(0)] internal readonly PARTY_REMOTE_DEVICE_DESTROYED_STATE_CHANGE remoteDeviceDestroyed;

        [FieldOffset(0)] internal readonly PARTY_REMOTE_DEVICE_JOINED_NETWORK_STATE_CHANGE remoteDeviceJoinedNetwork;

        [FieldOffset(0)] internal readonly PARTY_REMOTE_DEVICE_LEFT_NETWORK_STATE_CHANGE remoteDeviceLeftNetwork;

        [FieldOffset(0)] internal readonly PARTY_DEVICE_PROPERTIES_CHANGED_STATE_CHANGE devicePropertiesChanged;

        [FieldOffset(0)] internal readonly PARTY_LEAVE_NETWORK_COMPLETED_STATE_CHANGE leaveNetworkCompleted;

        [FieldOffset(0)] internal readonly PARTY_NETWORK_DESTROYED_STATE_CHANGE networkDestroyed;

        [FieldOffset(0)] internal readonly PARTY_ENDPOINT_MESSAGE_RECEIVED_STATE_CHANGE endpointMessageReceived;

        [FieldOffset(0)] internal readonly PARTY_DATA_BUFFERS_RETURNED_STATE_CHANGE dataBuffersReturned;

        [FieldOffset(0)] internal readonly PARTY_ENDPOINT_PROPERTIES_CHANGED_STATE_CHANGE endpointPropertiesChanged;

        [FieldOffset(0)]
        internal readonly PARTY_SYNCHRONIZE_MESSAGES_BETWEEN_ENDPOINTS_COMPLETED_STATE_CHANGE
            synchronizeMessagesBetweenEndpointsCompleted;

        [FieldOffset(0)] internal readonly PARTY_CREATE_INVITATION_COMPLETED_STATE_CHANGE createInvitationCompleted;

        [FieldOffset(0)] internal readonly PARTY_REVOKE_INVITATION_COMPLETED_STATE_CHANGE revokeInvitationCompleted;

        [FieldOffset(0)] internal readonly PARTY_INVITATION_CREATED_STATE_CHANGE invitationCreated;

        [FieldOffset(0)] internal readonly PARTY_INVITATION_DESTROYED_STATE_CHANGE invitationDestroyed;

        [FieldOffset(0)] internal readonly PARTY_NETWORK_PROPERTIES_CHANGED_STATE_CHANGE networkPropertiesChanged;

        [FieldOffset(0)] internal readonly PARTY_KICK_DEVICE_COMPLETED_STATE_CHANGE kickDeviceCompleted;

        [FieldOffset(0)] internal readonly PARTY_KICK_USER_COMPLETED_STATE_CHANGE kickUserCompleted;

        [FieldOffset(0)] internal readonly PARTY_CREATE_CHAT_CONTROL_COMPLETED_STATE_CHANGE createChatControlCompleted;

        [FieldOffset(0)]
        internal readonly PARTY_DESTROY_CHAT_CONTROL_COMPLETED_STATE_CHANGE destroyChatControlCompleted;

        [FieldOffset(0)] internal readonly PARTY_CHAT_CONTROL_CREATED_STATE_CHANGE chatControlCreated;

        [FieldOffset(0)] internal readonly PARTY_CHAT_CONTROL_DESTROYED_STATE_CHANGE chatControlDestroyed;

        [FieldOffset(0)]
        internal readonly PARTY_SET_CHAT_AUDIO_ENCODER_BITRATE_COMPLETED_STATE_CHANGE
            setChatAudioEncoderBitrateCompleted;

        [FieldOffset(0)] internal readonly PARTY_CHAT_TEXT_RECEIVED_STATE_CHANGE chatTextReceived;

        [FieldOffset(0)]
        internal readonly PARTY_VOICE_CHAT_TRANSCRIPTION_RECEIVED_STATE_CHANGE voiceChatTranscriptionReceived;

        [FieldOffset(0)] internal readonly PARTY_SET_CHAT_AUDIO_INPUT_COMPLETED_STATE_CHANGE setChatAudioInputCompleted;

        [FieldOffset(0)]
        internal readonly PARTY_SET_CHAT_AUDIO_OUTPUT_COMPLETED_STATE_CHANGE setChatAudioOutputCompleted;

        [FieldOffset(0)] internal readonly PARTY_LOCAL_CHAT_AUDIO_INPUT_CHANGED_STATE_CHANGE localChatAudioInputChanged;

        [FieldOffset(0)]
        internal readonly PARTY_LOCAL_CHAT_AUDIO_OUTPUT_CHANGED_STATE_CHANGE localChatAudioOutputChanged;

        [FieldOffset(0)]
        internal readonly PARTY_SET_TEXT_TO_SPEECH_PROFILE_COMPLETED_STATE_CHANGE setTextToSpeechProfileCompleted;

        [FieldOffset(0)]
        internal readonly PARTY_SYNTHESIZE_TEXT_TO_SPEECH_COMPLETED_STATE_CHANGE synthesizeTextToSpeechCompleted;

        [FieldOffset(0)] internal readonly PARTY_SET_LANGUAGE_COMPLETED_STATE_CHANGE setLanguageCompleted;

        [FieldOffset(0)]
        internal readonly PARTY_SET_TRANSCRIPTION_OPTIONS_COMPLETED_STATE_CHANGE setTranscriptionOptionsCompleted;

        [FieldOffset(0)]
        internal readonly PARTY_SET_TEXT_CHAT_OPTIONS_COMPLETED_STATE_CHANGE setTextChatOptionsCompleted;

        [FieldOffset(0)]
        internal readonly PARTY_CHAT_CONTROL_PROPERTIES_CHANGED_STATE_CHANGE chatControlPropertiesChanged;

        [FieldOffset(0)] internal readonly PARTY_CHAT_CONTROL_JOINED_NETWORK_STATE_CHANGE chatControlJoinedNetwork;

        [FieldOffset(0)] internal readonly PARTY_CHAT_CONTROL_LEFT_NETWORK_STATE_CHANGE chatControlLeftNetwork;

        [FieldOffset(0)]
        internal readonly PARTY_CONNECT_CHAT_CONTROL_COMPLETED_STATE_CHANGE connectChatControlCompleted;

        [FieldOffset(0)]
        internal readonly PARTY_DISCONNECT_CHAT_CONTROL_COMPLETED_STATE_CHANGE disconnectChatControlCompleted;

        [FieldOffset(0)]
        internal readonly PARTY_POPULATE_AVAILABLE_TEXT_TO_SPEECH_PROFILES_COMPLETED_STATE_CHANGE
            populateAvailableTextToSpeechProfilesCompleted;

        [FieldOffset(0)]
        internal readonly PARTY_CONFIGURE_AUDIO_MANIPULATION_VOICE_STREAM_COMPLETED_STATE_CHANGE
            configureAudioManipulationVoiceStreamCompleted;

        [FieldOffset(0)]
        internal readonly PARTY_CONFIGURE_AUDIO_MANIPULATION_CAPTURE_STREAM_COMPLETED_STATE_CHANGE
            configureAudioManipulationCaptureStreamCompleted;

        [FieldOffset(0)]
        internal readonly PARTY_CONFIGURE_AUDIO_MANIPULATION_RENDER_STREAM_COMPLETED_STATE_CHANGE
            configureAudioManipulationRenderStreamCompleted;
    }
}