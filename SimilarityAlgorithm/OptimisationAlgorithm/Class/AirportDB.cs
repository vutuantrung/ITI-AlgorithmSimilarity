using OptimisationAlgorithm.Helper;
using CL_Helper;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace OptimisationAlgorithm.Class
{
    public class AirportDB
    {
        public List<Airport> ListAirport;

        public int ListCount
        {
            get
            {
                if ( ListAirport == null ) return 0;
                return ListAirport.Count;
            }
        }

        public AirportDB( Builder builder )
        {
            ListAirport = builder.ListAirport;
        }

        public class Builder
        {
            private string[] datas;

            public List<Airport> ListAirport = new List<Airport>();

            public Builder LoadDB( string path )
            {
                if ( string.IsNullOrEmpty( path ) ) throw new DirectoryNotFoundException( $"{path} not found." );
                this.datas = File.ReadAllText( path ).SplitString( "\n" );

                return this;
            }

            public Builder GetAllAirportsFromDB()
            {
                foreach ( var data in this.datas )
                {
                    if ( !string.IsNullOrEmpty( data ) )
                    {
                        ListAirport.Add( AirportHelper.GetDataAirportFromString( data ) );
                    }
                }

                return this;
            }

            public AirportDB Build()
            {
                return new AirportDB( this );
            }
        }
    }
}
