using SimilarityAlgorithm.HelperClass;
using System;
using System.Collections.Generic;
using System.IO;

namespace SimilarityAlgorithm.Class
{
    public class MovieDB
    {
        public List<Movie> ListMovie;

        public int ListCount
        {
            get
            {
                if ( ListMovie == null ) return 0;
                return ListMovie.Count;
            }
        }

        public MovieDB( Builder builder )
        {
            ListMovie = builder.ListMovie;
        }

        public class Builder
        {
            private string[] datas;

            public List<Movie> ListMovie = new List<Movie>();

            public Builder LoadDB( string path )
            {
                if ( string.IsNullOrEmpty( path ) ) throw new DirectoryNotFoundException( $"{path} not found." );
                this.datas = File.ReadAllText( path ).SplitString( "\r\n" );

                return this;
            }

            public Builder GetAllMoviesFromDB()
            {
                foreach ( var data in this.datas )
                {
                    if ( !string.IsNullOrEmpty( data ) )
                    {
                        ListMovie.Add( MovieHelper.GetDataMovieFromString( data ) );
                    }
                }

                return this;
            }

            public MovieDB Build()
            {
                return new MovieDB( this );
            }
        }
    }
}
