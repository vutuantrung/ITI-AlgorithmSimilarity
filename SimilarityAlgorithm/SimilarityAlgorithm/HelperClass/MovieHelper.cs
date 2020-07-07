using SimilarityAlgorithm.Class;
using System;
using System.Collections.Generic;
using CL_Helper;
using System.Linq;
using System.Text;

namespace SimilarityAlgorithm.HelperClass
{
    public static class MovieHelper
    {
        public static Movie GetDataMovieFromString( string movieDataString )
        {
            string[] datas = movieDataString.SplitString( "::" );

            var movie = new Movie
            {
                ID = Convert.ToInt32( datas[0] ),
                Title = datas[1],
                Genres = datas[2].Split( '|' )
            };

            return movie;
        }

        public static float[,] CreateArrayTwoDimension( int rowsLength, int colsLength, List<Rating> listRating )
        {
            float[,] newArr = new float[rowsLength, colsLength];
            foreach ( var rating in listRating )
            {
                newArr[rating.UserID, rating.MovieID] = rating.RatingNote;
            }

            return newArr;
        }
    }
}
