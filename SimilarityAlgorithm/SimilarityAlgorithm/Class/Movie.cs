using SimilarityAlgorithm.Enum;
using System;
using System.Collections.Generic;
using System.Text;

namespace SimilarityAlgorithm.Class
{
    public class Movie
    {
        public int ID { get; set; }

        public string Title { get; set; }

        public DateTime ReleaseDate { get; set; }

        public List<MovieGenre> Genres { get; set; }
    }
}
