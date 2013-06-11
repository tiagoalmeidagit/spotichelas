﻿namespace Persistence.DO
{
    public class PlaylistTrack
    {
        public string UserId { get; set; }
        public int PlaylistId { get; set; }
        public string SpotifyTrackId { get; set; }
        public int Position { get; set; }

        public virtual UserProfile User { get; set; }
        public virtual Playlist Playlist { get; set; }
    }
}