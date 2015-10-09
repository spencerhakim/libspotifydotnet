/*-
 * Copyright (c) 2015 Software Development Solutions, Inc.
 * All rights reserved.
 *
 * Redistribution and use in source and binary forms, with or without
 * modification, are permitted provided that the following conditions
 * are met:
 * 1. Redistributions of source code must retain the above copyright
 *    notice, this list of conditions and the following disclaimer.
 * 2. Redistributions in binary form must reproduce the above copyright
 *    notice, this list of conditions and the following disclaimer in the
 *    documentation and/or other materials provided with the distribution.
 *
 * THIS SOFTWARE IS PROVIDED BY THE AUTHOR AND CONTRIBUTORS ``AS IS'' AND
 * ANY EXPRESS OR IMPLIED WARRANTIES, INCLUDING, BUT NOT LIMITED TO, THE
 * IMPLIED WARRANTIES OF MERCHANTABILITY AND FITNESS FOR A PARTICULAR PURPOSE
 * ARE DISCLAIMED.  IN NO EVENT SHALL THE AUTHOR OR CONTRIBUTORS BE LIABLE
 * FOR ANY DIRECT, INDIRECT, INCIDENTAL, SPECIAL, EXEMPLARY, OR CONSEQUENTIAL
 * DAMAGES (INCLUDING, BUT NOT LIMITED TO, PROCUREMENT OF SUBSTITUTE GOODS
 * OR SERVICES; LOSS OF USE, DATA, OR PROFITS; OR BUSINESS INTERRUPTION)
 * HOWEVER CAUSED AND ON ANY THEORY OF LIABILITY, WHETHER IN CONTRACT, STRICT
 * LIABILITY, OR TORT (INCLUDING NEGLIGENCE OR OTHERWISE) ARISING IN ANY WAY
 * OUT OF THE USE OF THIS SOFTWARE, EVEN IF ADVISED OF THE POSSIBILITY OF
 * SUCH DAMAGE.
 */

using System;
using System.Runtime.InteropServices;

namespace libspotifydotnet {

    public static partial class libspotify {

        public const int SPOTIFY_API_VERSION = 12;

        /// <summary>
        /// All libspotify calls should lock on this object first,
        /// as libspotify is NOT thread-safe
        /// </summary>
        public static readonly object SyncRoot = new object();

        [DllImport("libspotify")]
        public static extern sp_error sp_session_create(ref sp_session_config config, out IntPtr sessionPtr);

        [DllImport("libspotify")]
        public static extern sp_error sp_session_release(IntPtr sessionPtr);

        [DllImport("libspotify")]
        public static extern sp_error sp_session_login(IntPtr sessionPtr, [MarshalAs(UnmanagedType.LPStr)]string username, [MarshalAs(UnmanagedType.LPStr)]string password, bool rememberMe, [MarshalAs(UnmanagedType.LPStr)]string blob);

        [DllImport("libspotify")]
        public static extern sp_error sp_session_login(IntPtr sessionPtr, [MarshalAs(UnmanagedType.LPStr)]string username, IntPtr securePassword, bool rememberMe, [MarshalAs(UnmanagedType.LPStr)]string blob);

        [DllImport("libspotify")]
        public static extern sp_error sp_session_relogin(IntPtr sessionPtr);

        [DllImport("libspotify")]
        public static extern int sp_session_remembered_user(IntPtr sessionPtr, [MarshalAs(UnmanagedType.LPStr)]string buffer, int buffer_size);

        [DllImport("libspotify")]
        public static extern IntPtr sp_session_user_name(IntPtr sessionPtr);

        [DllImport("libspotify")]
        public static extern sp_error sp_session_forget_me(IntPtr sessionPtr);

        [DllImport("libspotify")]
        public static extern IntPtr sp_session_user(IntPtr sessionPtr);

        [DllImport("libspotify")]
        public static extern sp_error sp_session_logout(IntPtr sessionPtr);

        [DllImport("libspotify")]
        public static extern sp_error sp_session_flush_caches(IntPtr sessionPtr);

        [DllImport("libspotify")]
        public static extern sp_connectionstate sp_session_connectionstate(IntPtr sessionPtr);

        [DllImport("libspotify")]
        public static extern IntPtr sp_session_userdata(IntPtr sessionPtr);

        [DllImport("libspotify")]
        public static extern IntPtr sp_session_set_cache_size(IntPtr sessionPtr, int size);

        [DllImport("libspotify")]
        public static extern sp_error sp_session_process_events(IntPtr sessionPtr, out int next_timeout);

        [DllImport("libspotify")]
        public static extern sp_error sp_session_player_load(IntPtr sessionPtr, IntPtr trackPtr);

        [DllImport("libspotify")]
        public static extern sp_error sp_session_player_seek(IntPtr sessionPtr, int offset);

        [DllImport("libspotify")]
        public static extern sp_error sp_session_player_play(IntPtr sessionPtr, bool play);

        [DllImport("libspotify")]
        public static extern sp_error sp_session_player_unload(IntPtr sessionPtr);

        [DllImport("libspotify")]
        public static extern sp_error sp_session_player_prefetch(IntPtr sessionPtr, IntPtr trackPtr);

        [DllImport("libspotify")]
        public static extern IntPtr sp_session_playlistcontainer(IntPtr sessionPtr);

        [DllImport("libspotify")]
        public static extern IntPtr sp_session_inbox_create(IntPtr sessionPtr);

        [DllImport("libspotify")]
        public static extern IntPtr sp_session_starred_create(IntPtr sessionPtr);

        [DllImport("libspotify")]
        public static extern IntPtr sp_session_starred_for_user_create(IntPtr sessionPtr, [MarshalAs(UnmanagedType.LPStr)]string canonical_username);

        [DllImport("libspotify")]
        public static extern IntPtr sp_session_publishedcontainer_for_user_create(IntPtr sessionPtr, [MarshalAs(UnmanagedType.LPStr)]string canonical_username);

        [DllImport("libspotify")]
        public static extern sp_error sp_session_preferred_bitrate(IntPtr sessionPtr, sp_bitrate bitrate);

        [DllImport("libspotify")]
        public static extern sp_error sp_session_preferred_offline_bitrate(IntPtr sessionPtr, sp_bitrate bitrate, bool allow_resync);

        [DllImport("libspotify")]
        public static extern bool sp_session_get_volume_normalization(IntPtr sessionPtr);

        [DllImport("libspotify")]
        public static extern bool sp_session_set_volume_normalization(IntPtr sessionPtr, bool on);

        [DllImport("libspotify")]
        public static extern sp_error sp_session_set_private_session(IntPtr sessionPtr, bool enabled);

        [DllImport("libspotify")]
        public static extern bool sp_session_is_private_session(IntPtr sessionPtr);

        [DllImport("libspotify")]
        public static extern sp_error sp_session_set_scrobbling(IntPtr sessionPtr, sp_social_provider provider, sp_scrobbling_state state);

        [DllImport("libspotify")]
        public static extern sp_error sp_session_is_scrobbling(IntPtr sessionPtr, sp_social_provider provider, sp_scrobbling_state state);

        [DllImport("libspotify")]
        public static extern sp_error sp_session_is_scrobbling_possible(IntPtr sessionPtr, sp_social_provider provider, out bool isPossible);

        [DllImport("libspotify")]
        public static extern sp_error sp_session_set_social_credentials(IntPtr sessionPtr, sp_social_provider provider, [MarshalAs(UnmanagedType.LPStr)]string username, [MarshalAs(UnmanagedType.LPStr)]string password);

        [DllImport("libspotify")]
        public static extern sp_error sp_session_set_connection_type(IntPtr sessionPtr, sp_connection_type type);

        [DllImport("libspotify")]
        public static extern sp_error sp_session_set_connection_rules(IntPtr sessionPtr, sp_connection_rules rules);

        [DllImport("libspotify")]
        public static extern int sp_offline_tracks_to_sync(IntPtr sessionPtr);

        [DllImport("libspotify")]
        public static extern int sp_offline_num_playlists(IntPtr sessionPtr);

        [DllImport("libspotify")]
        public static extern bool sp_offline_sync_get_status(IntPtr sessionPtr, IntPtr status);

        [DllImport("libspotify")]
        public static extern int sp_offline_time_left(IntPtr sessionPtr);

        [DllImport("libspotify")]
        public static extern int sp_session_user_country(IntPtr sessionPtr);

    }

}
