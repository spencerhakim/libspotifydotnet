using System;
using System.Runtime.InteropServices;
// ReSharper disable InconsistentNaming

namespace libspotifydotnet
{
    public delegate void inboxpost_complete_cb(IntPtr result, IntPtr userDataPtr);
    public delegate void image_loaded_cb(IntPtr imagePtr, IntPtr userDataPtr);
    public delegate void artistbrowse_complete_cb(IntPtr result, IntPtr userDataPtr);
    public delegate void albumbrowse_complete_cb(IntPtr result, IntPtr userDataPtr);
    public delegate void search_complete_cb(IntPtr searchPtr, IntPtr userDataPtr);

    //Session callbacks
    public delegate void logged_in_cb(IntPtr sessionPtr, sp_error error);
    public delegate void logged_out_cb(IntPtr sessionPtr);
    public delegate void metadata_updated_cb(IntPtr sessionPtr);
    public delegate void connection_error_cb(IntPtr sessionPtr, sp_error error);
    public delegate void message_to_user_cb(IntPtr sessionPtr, [MarshalAs(UnmanagedType.LPStr)]string message);
    public delegate void notify_main_thread_cb(IntPtr sessionPtr);
    public delegate  int music_delivery_cb(IntPtr sessionPtr, ref sp_audioformat format, IntPtr frames, int num_frames);
    public delegate void play_token_lost_cb(IntPtr sessionPtr);
    public delegate void log_message_cb(IntPtr sessionPtr, [MarshalAs(UnmanagedType.LPStr)]string data);
    public delegate void end_of_track_cb(IntPtr sessionPtr);
    public delegate void streaming_error_cb(IntPtr sessionPtr, sp_error error);
    public delegate void userinfo_updated_cb(IntPtr sessionPtr);
    public delegate void start_playback_cb(IntPtr sessionPtr);
    public delegate void stop_playback_cb(IntPtr sessionPtr);
    public delegate void get_audio_buffer_stats_cb(IntPtr sessionPtr, ref sp_audio_buffer_stats stats);
    public delegate void offline_status_updated_cb(IntPtr sessionPtr);
    public delegate void offline_error_cb(IntPtr sessionPtr);
    public delegate void credentials_blod_updated_cb(IntPtr sessionPtr, [MarshalAs(UnmanagedType.LPStr)]string blob);
    public delegate void connectionstate_updated_cb(IntPtr sessionPtr);
    public delegate void scrobble_error_cb(IntPtr sessionPtr, sp_error error);
    public delegate void private_session_mode_changed_cb(IntPtr sessionPtr, bool is_private);

    //Playlist callbacks
    public delegate void tracks_added_cb(IntPtr playlistPtr, IntPtr tracksPtr, int num_tracks, int position, IntPtr userdata);
    public delegate void tracks_removed_cb(IntPtr playlistPtr, [MarshalAs(UnmanagedType.LPArray, SizeParamIndex=2)]int[] tracks, int num_tracks, IntPtr userdata);
    public delegate void tracks_moved_cb(IntPtr playlistPtr, [MarshalAs(UnmanagedType.LPArray, SizeParamIndex=2)]int[] tracks, int num_tracks, int new_position, IntPtr userdata);
    public delegate void playlist_renamed_cb(IntPtr playlistPtr, IntPtr userdata);
    public delegate void playlist_state_changed_cb(IntPtr playlistPtr, IntPtr userdata);
    public delegate void playlist_update_in_progress_cb(IntPtr playlistPtr, bool done, IntPtr userdata);
    public delegate void playlist_metadata_updated_cb(IntPtr playlistPtr, IntPtr userdata);
    public delegate void track_created_changed_cb(IntPtr playlistPtr, int position, IntPtr userPtr, int timestamp, IntPtr userdata);
    public delegate void track_seen_changed_cb(IntPtr playlistPtr, int position, bool seen, IntPtr userdata);
    public delegate void description_changed_cb(IntPtr playlistPtr, [MarshalAs(UnmanagedType.LPStr)]string desc, IntPtr userdata);
    public delegate void image_changed_cb(IntPtr playlistPtr, IntPtr image, IntPtr userdata);
    public delegate void track_message_changed_cb(IntPtr playlistPtr, int position, [MarshalAs(UnmanagedType.LPStr)]string message, IntPtr userdata);
    public delegate void subscribers_changed_cb(IntPtr playlistPtr, IntPtr userdata);

    //Playlist container callbacks
    public delegate void playlist_added_cb(IntPtr playlistContPtr, IntPtr playlistPtr, int position, IntPtr userdata);
    public delegate void playlist_removed_cb(IntPtr playlistContPtr, IntPtr playlistPtr, int position, IntPtr userdata);
    public delegate void playlist_moved_cb(IntPtr playlistContPtr, IntPtr playlistPtr, int position, int new_position, IntPtr userdata);
    public delegate void container_loaded_cb(IntPtr playlistContPtr, IntPtr userdata);
}
