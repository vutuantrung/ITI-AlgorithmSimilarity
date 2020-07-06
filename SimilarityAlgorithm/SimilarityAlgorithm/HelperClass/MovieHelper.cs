using SimilarityAlgorithm.Class;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace SimilarityAlgorithm.HelperClass
{
    public class MovieHelper
    {
        public static Movie GetDataMovieFromString( string movieDataString )
        {
            string[] datas = movieDataString.SplitString( "::" );

            var movie = new Movie
            {
                ID = Convert.ToSByte( datas[0] ),
                Title = datas[1],
                Genres = datas[2].Split( '|' )
            };

            return movie;
        }
    }
}
