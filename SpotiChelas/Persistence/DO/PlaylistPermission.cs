﻿namespace Persistence.DO
{
    public class PlaylistPermission
    {
        public string OwnerId { get; set; }
        public string GrantedUserId { get; set; }
        public int PlaylistId { get; set; }
        public bool Contributor { get; set; }

        public virtual UserProfile Owner { get; set; }
        public virtual UserProfile GrantedUserProfile { get; set; }
        public virtual Playlist Playlist { get; set; }
    }
}