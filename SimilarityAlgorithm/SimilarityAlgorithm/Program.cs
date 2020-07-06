using SimilarityAlgorithm.HelperClass;
using System;

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
            var similarityMatrix = Helper.CalculateSimilarityMatrix( maTrixUserBasedExample );

            Console.Read();
        }
    }
}
