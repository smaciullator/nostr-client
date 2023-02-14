﻿namespace Nostr.Client.Websocket.Messages
{
    public enum NostrKind
    {
        Metadata = 0,
        ShortTextNote = 1,
        RecommendRelay = 2,
        Contacts = 3,
        EncryptedDm = 4,
        EventDeletion = 5,
        Reaction = 7,

        // nip-28 public chat
        ChannelCreation = 40,
        ChannelMetadata = 41,
        ChannelMessage = 42,
        ChannelHideMessage = 43,
        ChanelMuteUser = 44,

        // nip-28 public chat reserved [45-49]

        Reporting = 1984,

        ZapRequest = 9734,
        Zap = 9735,

        RelayListMetadata = 10002,
        ClientAuthentication = 22242,
        LongFormContent = 30023,

        // nip-16 regular events                   [ 1000- 9999]
        // nip-16 replaceable events               [10000-19999]
        // nip-16 ephemeral  events                [20000-29999]
        // nip-33 parameterized replaceable events [30000-39999]


        Unknown = int.MaxValue
    }
}
