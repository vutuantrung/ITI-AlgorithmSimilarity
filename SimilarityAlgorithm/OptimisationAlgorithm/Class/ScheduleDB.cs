using OptimisationAlgorithm.Helper;
using CL_Helper;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace OptimisationAlgorithm.Class
{
    public class ScheduleDB
    {
        public List<Schedule> ListSchedule;

        public int ListCount
        {
            get
            {
                if ( ListSchedule == null ) return 0;
                return ListSchedule.Count;
            }
        }

        public ScheduleDB( Builder builder )
        {
            ListSchedule = builder.ListSchedule;
        }

        public class Builder
        {
            private string[] datas;

            public List<Schedule> ListSchedule = new List<Schedule>();

            public Builder LoadDB( string path )
            {
                if ( string.IsNullOrEmpty( path ) ) throw new DirectoryNotFoundException( $"{path} not found." );
                this.datas = File.ReadAllText( path ).SplitString( "\n" );

                return this;
            }

            public Builder GetAllSchedulesFromDB()
            {
                foreach ( var data in this.datas )
                {
                    if ( !string.IsNullOrEmpty( data ) )
                    {
                        ListSchedule.Add( ScheduleHelper.GetDataScheduleFromString( data ) );
                    }
                }

                return this;
            }

            public ScheduleDB Build()
            {
                return new ScheduleDB( this );
            }
        }
    }
}
