using System;
using System.Runtime.InteropServices;
// ReSharper disable InconsistentNaming

namespace libspotifydotnet
{
    [StructLayout(LayoutKind.Sequential)]
    public struct sp_audioformat
    {
        public int sample_type;
        public int sample_rate;
        public int channels;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct sp_audio_buffer_stats
    {
        public int samples;
        public int stutter;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct sp_subscribers
    {
        public uint count;
        public IntPtr subscribers;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct sp_offline_sync_status
    {
        public int queued_tracks;
        public int done_tracks;
        public int copied_tracks;
        public int willnotcopy_tracks;
        public int error_tracks;
        public bool syncing;
    }

    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    public struct sp_session_config
    {
        public int api_version;
        public string cache_location;
        public string settings_location;
        public IntPtr application_key;
        public int application_key_size;
        public string user_agent;
        public IntPtr callbacks;
        public IntPtr userdata;
        public bool compress_playlists;
        public bool dont_save_metadata_for_playlists;
        public bool initially_unload_playlists;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct sp_session_callbacks
    {
        public logged_in_cb logged_in;
        public logged_out_cb logged_out;
        public metadata_updated_cb metadata_updated;
        public connection_error_cb connection_error;
        public message_to_user_cb message_to_user;
        public notify_main_thread_cb notify_main_thread;
        public music_delivery_cb music_delivery;
        public play_token_lost_cb play_token_lost;
        public log_message_cb log_message;
        public end_of_track_cb end_of_track;
        public streaming_error_cb streaming_error;
        public userinfo_updated_cb userinfo_updated;
        public start_playback_cb start_playback;
        public stop_playback_cb stop_playback;
        public get_audio_buffer_stats_cb get_audio_buffer_stats;
        public offline_status_updated_cb offline_status_updated;
        public offline_error_cb offline_error;
        public credentials_blod_updated_cb credentials_blob_updated;
        public connectionstate_updated_cb connectionstate_updated;
        public scrobble_error_cb scrobble_error;
        public private_session_mode_changed_cb private_session_mode_changed;

        public IntPtr ToIntPtr()
        {
            var ptr = Marshal.AllocHGlobal( Marshal.SizeOf(this) );
            Marshal.StructureToPtr(this, ptr, true);
            return ptr;
        }

        public static void FreeIntPtr(IntPtr ptr)
        {
            Marshal.DestroyStructure(ptr, typeof(sp_session_callbacks));
            Marshal.FreeHGlobal(ptr);
        }
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct sp_playlist_callbacks
    {
        public IntPtr tracks_added;
        public IntPtr tracks_removed;
        public IntPtr tracks_moved;
        public IntPtr playlist_renamed;
        public IntPtr playlist_state_changed;
        public IntPtr playlist_update_in_progress;
        public IntPtr playlist_metadata_updated;
        public IntPtr track_created_changed;
        public IntPtr track_seen_changed;
        public IntPtr description_changed;
        public IntPtr image_changed;
        public IntPtr track_message_changed;
        public IntPtr subscribers_changed;

        public IntPtr ToIntPtr()
        {
            var ptr = Marshal.AllocHGlobal( Marshal.SizeOf(this) );
            Marshal.StructureToPtr(this, ptr, true);
            return ptr;
        }

        public static void FreeIntPtr(IntPtr ptr)
        {
            Marshal.DestroyStructure(ptr, typeof(sp_playlist_callbacks));
            Marshal.FreeHGlobal(ptr);
        }
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct sp_playlistcontainer_callbacks
    {
        public IntPtr playlist_added;
        public IntPtr playlist_removed;
        public IntPtr playlist_moved;
        public IntPtr container_loaded;

        public IntPtr ToIntPtr()
        {
            var ptr = Marshal.AllocHGlobal( Marshal.SizeOf(this) );
            Marshal.StructureToPtr(this, ptr, true);
            return ptr;
        }

        public static void FreeIntPtr(IntPtr ptr)
        {
            Marshal.DestroyStructure(ptr, typeof(sp_playlistcontainer_callbacks));
            Marshal.FreeHGlobal(ptr);
        }
    }
}
