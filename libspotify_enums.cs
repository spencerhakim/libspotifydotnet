using System;
// ReSharper disable InconsistentNaming

namespace libspotifydotnet
{
    public enum sp_search_type
    {
        STANDARD = 0,
        SUGGEST = 1,
    }

    public enum sp_albumtype
    {
        ALBUM = 0,
        SINGLE = 1,
        COMPILATION = 2,
        UNKNOWN = 3
    }

    public enum sp_artistbrowse_type
    {
        [Obsolete("The FULL mode has been deprecated and will be removed in a future release.")]
        FULL = 0,
        NO_TRACKS = 1,
        NO_ALBUMS = 2
    }

    public enum sp_error
    {
        OK = 0,
        BAD_API_VERSION = 1,
        API_INITIALIZATION_FAILED = 2,
        TRACK_NOT_PLAYABLE = 3,
        APPLICATION_KEY = 5,
        BAD_USERNAME_OR_PASSWORD = 6,
        USER_BANNED = 7,
        UNABLE_TO_CONTACT_SERVER = 8,
        CLIENT_TOO_OLD = 9,
        OTHER_PERMANENT = 10,
        BAD_USER_AGENT = 11,
        MISSING_CALLBACK = 12,
        INVALID_INDATA = 13,
        INDEX_OUT_OF_RANGE = 14,
        USER_NEEDS_PREMIUM = 15,
        OTHER_TRANSIENT = 16,
        IS_LOADING = 17,
        NO_STREAM_AVAILABLE = 18,
        PERMISSION_DENIED = 19,
        INBOX_IS_FULL = 20,
        NO_CACHE = 21,
        NO_SUCH_USER = 22,
        NO_CREDENTIALS = 23,
        NETWORK_DISABLED = 24,
        INVALID_DEVICE_ID = 25,
        CANT_OPEN_TRACE_FILE = 26,
        APPLICATION_BANNED = 27,
        OFFLINE_TOO_MANY_TRACKS = 31,
        OFFLINE_DISK_CACHE = 32,
        OFFLINE_EXPIRED = 33,
        OFFLINE_NOT_ALLOWED = 34,
        OFFLINE_LICENSE_LOST = 35,
        OFFLINE_LICENSE_ERROR = 36
    }

    public enum sp_imageformat
    {
        UNKNOWN = -1,
        JPEG = 0
    }

    public enum sp_connectionstate
    {
        LOGGED_OUT = 0,
        LOGGED_IN = 1,
        DISCONNECTED = 2,
        UNDEFINED = 3,
        OFFLINE = 4
    }

    public enum sp_sampletype
    {
        INT16_NATIVE_ENDIAN = 0
    }

    public enum sp_bitrate
    {
        BITRATE_160k = 0,
        BITRATE_320k = 1,
        BITRATE_96k = 2
    }

    public enum sp_playlist_type
    {
        PLAYLIST = 0,
        START_FOLDER = 1,
        END_FOLDER = 2,
        PLACEHOLDER = 3
    }

    public enum sp_playlist_offline_status
    {
        NO = 0,
        YES = 1,
        DOWNLOADING = 2,
        WAITING = 3
    }

    public enum sp_availability
    {
        UNAVAILABLE = 0,
        AVAILABLE = 1,
        NOT_STREAMABLE = 2,
        BANNED_BY_ARTIST = 3
    }

    public enum sp_track_offline_status
    {
        NO = 0,
        WAITING = 1,
        DOWNLOADING = 2,
        DONE = 3,
        ERROR = 4,
        DONE_EXPIRED = 5,
        LIMIT_EXCEEDED = 6,
        DONE_RESYNC = 7
    }

    public enum sp_image_size
    {
        NORMAL = 0,
        SMALL = 1,
        LARGE = 2
    }

    public enum sp_connection_type
    {
        UNKNOWN = 0,
        NONE = 1,
        MOBILE = 2,
        MOBILE_ROAMING = 3,
        WIFI = 4,
        WIRED = 5
    }

    public enum sp_connection_rules
    {
        NETWORK = 0x1,
        NETWORK_IF_ROAMING = 0x2,
        ALLOW_SYNC_OVER_MOBILE = 0x4,
        ALLOW_SYNC_OVER_WIFI = 0x8
    }

    public enum sp_social_provider
    {
        SPOTIFY,
        FACEBOOK,
        LASTFM,
    }

    public enum sp_scrobbling_state
    {
        USE_GLOBAL_SETTING = 0,
        LOCAL_ENABLED = 1,
        LOCAL_DISABLED = 2,
        GLOBAL_ENABLED = 3,
        GLOBAL_DISABLED = 4,
    }

    public enum sp_linktype
    {
        INVALID = 0,
        TRACK = 1,
        ALBUM = 2,
        ARTIST = 3,
        SEARCH = 4,
        PLAYLIST = 5,
        PROFILE = 6,
        STARRED = 7,
        LOCALTRACK = 8,
        IMAGE = 9
    }

    public enum sp_toplisttype
    {
        ARTISTS = 0,
        ALBUMS = 1,
        TRACKS = 2
    }

    public enum sp_toplistregion
    {
        EVERYWHERE = 0,
        USER = 1
    }

    public enum sp_relation_type
    {
        UNKNOWN = 0,
        NONE = 1,
        UNIDIRECTIONAL = 2,
        BIDIRECTIONAL = 3
    }
}
