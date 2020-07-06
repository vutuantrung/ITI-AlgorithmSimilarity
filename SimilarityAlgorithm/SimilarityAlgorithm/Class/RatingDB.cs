using SimilarityAlgorithm.HelperClass;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace SimilarityAlgorithm.Class
{
    public class RatingDB
    {
        public List<Rating> ListRating;

        public int ListCount
        {
            get
            {
                if ( ListRating == null ) return 0;
                return ListRating.Count;
            }
        }

        public RatingDB( Builder builder )
        {
            ListRating = builder.ListRating;
        }

        public class Builder
        {
            private string[] datas;

            public List<Rating> ListRating = new List<Rating>();

            public Builder LoadDB( string path )
            {
                if ( string.IsNullOrEmpty( path ) ) throw new DirectoryNotFoundException( $"{path} not found." );
                this.datas = File.ReadAllText( path ).SplitString( "\r\n" );

                return this;
            }

            public Builder GetAllRatingsFromDB()
            {
                foreach ( var data in this.datas )
                {
                    if ( !string.IsNullOrEmpty( data ) )
                    {
                        ListRating.Add( RatingHelper.GetDataRatingFromString( data ) );
                    }
                }

                return this;
            }

            public RatingDB Build()
            {
                return new RatingDB( this );
            }
        }
    }
}
