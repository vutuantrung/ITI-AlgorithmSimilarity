using SimilarityAlgorithm.HelperClass;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using CL_Helper;

namespace SimilarityAlgorithm.Class
{
    public class PersonDB
    {
        public List<Person> ListPerson;

        public int ListCount
        {
            get
            {
                if ( ListPerson == null ) return 0;
                return ListPerson.Count;
            }
        }

        public PersonDB( Builder builder )
        {
            ListPerson = builder.ListPerson;
        }

        public class Builder
        {
            private string[] datas;

            public List<Person> ListPerson = new List<Person>();

            public Builder LoadDB( string path )
            {
                if ( string.IsNullOrEmpty( path ) ) throw new DirectoryNotFoundException( $"{path} not found." );
                this.datas = File.ReadAllText( path ).SplitString( "\r\n" );

                return this;
            }

            public Builder GetAllPersonsFromDB()
            {
                foreach ( var data in this.datas )
                {
                    if ( !string.IsNullOrEmpty( data ) )
                    {
                        ListPerson.Add( PersonHelper.GetPersonDataFromString( data ) );
                    }
                }

                return this;
            }

            public PersonDB Build()
            {
                return new PersonDB( this );
            }
        }
    }
}
