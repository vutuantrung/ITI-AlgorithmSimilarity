using System;
using System.Collections.Generic;
using System.Text;

namespace SimilarityAlgorithm.HelperClass
{
    public static class SimilarityHelper
    {
        public static float[,] CalculateSimilarityMatrix( float[,] data )
        {
            var rows = data.GetLength(0);
            var cols = data.GetLength(1);

            float[,] similarityMatrix = new float[rows, cols];

            for ( int i = 0; i < rows; i++ )
            {
                for ( int j = 0; j < cols; j++ )
                {
                    similarityMatrix[i, j] = SimilarityHelper.GetCosineSimilarity( data, i, j );
                }
            }

            return similarityMatrix;
        }

        public static float GetCosineSimilarity( float[,] matrix, int rowIdx, int colIdx )
        {
            int N = matrix.GetLength( 1 );

            float dot = 0.0f;
            float mag1 = 0.0f;
            float mag2 = 0.0f;
            for ( int n = 0; n < N; n++ )
            {
                dot += matrix[rowIdx, n] * matrix[colIdx, n];
                mag1 += matrix[rowIdx, n] * matrix[rowIdx, n];
                mag2 += matrix[colIdx, n] * matrix[colIdx, n];
            }
            return dot / (float)( Math.Sqrt( mag1 ) * Math.Sqrt( mag2 ) );
        }
    }
}
