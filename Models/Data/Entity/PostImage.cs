﻿namespace GOREV_9.Models.Data.Entity
{
    public class PostImage
    {
        public int Id { get; set; }
        public int PostId { get; set; }
        public string? Url { get; set; }

        public Post? Post { get; set; }




    }
}
