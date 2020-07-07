using CL_Helper;
using SimilarityAlgorithm.Class;
using SimilarityAlgorithm.HelperClass;
using System;
using System.Collections.Generic;

namespace SimilarityAlgorithm
{
    class Program
    {
        #region Static variables
        static float[,] maTrixUserBasedExample = new float[,]
        {
            { 4, 3, 0, 0, 5, 0 },
            { 5, 0, 4, 0, 4, 0 },
            { 4, 0, 5, 3, 4, 0 },
            { 0, 3, 0, 0, 0, 5 },
            { 0, 4, 0, 0, 0, 4 },
            { 0, 0, 2, 4, 0, 5 }
        };

        #endregion

        static void Main( string[] args )
        {
            var personDB = new PersonDB.Builder().LoadDB( StaticData.PersonsDataPath )
                                                 .GetAllPersonsFromDB()
                                                 .Build();

            var movieDB = new MovieDB.Builder().LoadDB( StaticData.MoviesDataPath )
                                               .GetAllMoviesFromDB()
                                               .Build();

            var ratingDB = new RatingDB.Builder().LoadDB( StaticData.RatingsDataPath )
                                                 .GetAllRatingsFromDB()
                                                 .Build();

            var listPerson = personDB.ListPerson;
            var listMovie = movieDB.ListMovie;
            var listRating = ratingDB.ListRating;

            var movieArrayTwoDimensions = MovieHelper.CreateArrayTwoDimension
            (
                rowsLength: listPerson.Count + 1,
                colsLength: listMovie.Count + 1,
                listRating: listRating
            );
            var movieSimilarityArray = SimilarityHelper.CalculateSimilarityMatrix( movieArrayTwoDimensions );


            Console.Read();
        }
    }
}
