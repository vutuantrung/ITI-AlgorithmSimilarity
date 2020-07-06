using SimilarityAlgorithm.Class;
using System;
using System.Collections.Generic;
using System.Text;

namespace SimilarityAlgorithm.HelperClass
{
    public static class RatingHelper
    {
        public static Rating GetDataRatingFromString( string movieDataString )
        {
            string[] datas = movieDataString.SplitString( "::" );

            var rating = new Rating
            {
                UserID = Convert.ToInt32(datas[0]),
                MovieID = Convert.ToInt32(datas[1]),
                RatingNote = Convert.ToInt32(datas[2]),
            };

            return rating;
        }
    }
}
