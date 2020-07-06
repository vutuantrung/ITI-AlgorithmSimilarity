using System;

namespace SimilarityAlgorithm
{
    class Program
    {
        #region Static variables
        static float[,] maTrixUserBased = new float[,]
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
            float[,] similarityMatrix = new float[6, 6];

            for ( int i = 0; i < maTrixUserBased.GetLength( 1 ); i++ )
            {
                for ( int j = 0; j < maTrixUserBased.GetLength( 1 ); j++ )
                {
                    similarityMatrix[i, j] = GetCosineSimilarity( maTrixUserBased, i, j );
                }
            }

            Console.Read();
        }

        public static float GetCosineSimilarity( float[,] UserMatrix, int userAidx, int userBidx )
        {
            int N = UserMatrix.GetLength( 1 );

            float dot = 0.0f;
            float mag1 = 0.0f;
            float mag2 = 0.0f;
            for ( int n = 0; n < N; n++ )
            {
                dot += UserMatrix[userAidx, n] * UserMatrix[userBidx, n];
                mag1 += UserMatrix[userAidx, n] * UserMatrix[userAidx, n];
                mag2 += UserMatrix[userBidx, n] * UserMatrix[userBidx, n];
            }
            return dot / (float)( Math.Sqrt( mag1 ) * Math.Sqrt( mag2 ) );
        }
    }
}
