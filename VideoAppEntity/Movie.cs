﻿using System;
using System.Collections.Generic;
using System.Text;

namespace CSVideoMenu
{
    public class Movie
    {
        
        // Enums should probably not be in the same class as the entity.
        // Did it anyway.. (Mwhaha)
        public enum Genre
        {
            NoGenre,
            Comedy,
            Horror,
            Romantique
        }

        public enum FileType
        {
            MP4,
            MKV,
            AVI
        }

        private static int _id = 0;

        public Movie()
        {
            // TODO: Find a work around.
            // Entity frameworks initialize a new Movie on every operation.
            // So each time I create/read/update/delete this will count 1 up 
            // for each of the Movies inside the list.
            _id ++;
            Id = _id;
        }

        public int Id { get; set; }
        public string Title { get; set; }
        public FileType Extention { get; set; }
        public Genre MovieGenre { get; set; }
        public long Duration { get; set; }

    }
}
