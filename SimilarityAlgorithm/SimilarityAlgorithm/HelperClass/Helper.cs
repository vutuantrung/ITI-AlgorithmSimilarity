using SimilarityAlgorithm.Enum;
using System;
using System.Collections.Generic;
using System.Text;

namespace SimilarityAlgorithm.HelperClass
{
    public static class Helper
    {
        public static Occupation ConvertStringToOccupation( string occupation )
        {
            switch ( occupation.ToLower() )
            {
                case "administrator": return Occupation.Artist;
                case "artist": return Occupation.Artist;
                case "doctor": return Occupation.Artist;
                case "educator": return Occupation.Artist;
                case "engineer": return Occupation.Artist;
                case "entertainment": return Occupation.Artist;
                case "executive": return Occupation.Artist;
                case "healthcare": return Occupation.Artist;
                case "homemaker": return Occupation.Artist;
                case "lawyer": return Occupation.Artist;
                case "librarian": return Occupation.Artist;
                case "marketing": return Occupation.Artist;
                case "none": return Occupation.Artist;
                case "other": return Occupation.Artist;
                case "programmer": return Occupation.Artist;
                case "retired": return Occupation.Artist;
                case "salesman": return Occupation.Artist;
                case "scientist": return Occupation.Artist;
                case "student": return Occupation.Artist;
                case "technician": return Occupation.Artist;
                case "writer": return Occupation.Artist;
            }

            throw new InvalidCastException( nameof( occupation ) );
        }

        public static List<MovieGenre> ConvertToMovieGenreList( string[] data )
        {
            var listMovieGenre = new List<MovieGenre>();

            for ( int i = 0; i < data.Length; i++ )
            {
                if ( i == 0 && data[i] == "1" ) listMovieGenre.Add( MovieGenre.Unknown );
                if ( i == 1 && data[i] == "1" ) listMovieGenre.Add( MovieGenre.Action );
                if ( i == 2 && data[i] == "1" ) listMovieGenre.Add( MovieGenre.Adventure );
                if ( i == 3 && data[i] == "1" ) listMovieGenre.Add( MovieGenre.Animation );
                if ( i == 4 && data[i] == "1" ) listMovieGenre.Add( MovieGenre.Children );
                if ( i == 5 && data[i] == "1" ) listMovieGenre.Add( MovieGenre.Comedy );
                if ( i == 6 && data[i] == "1" ) listMovieGenre.Add( MovieGenre.Crime );
                if ( i == 7 && data[i] == "1" ) listMovieGenre.Add( MovieGenre.Documentary );
                if ( i == 8 && data[i] == "1" ) listMovieGenre.Add( MovieGenre.Drama );
                if ( i == 9 && data[i] == "1" ) listMovieGenre.Add( MovieGenre.Fantasy );
                if ( i == 10 && data[i] == "1" ) listMovieGenre.Add( MovieGenre.FilmNoir );
                if ( i == 11 && data[i] == "1" ) listMovieGenre.Add( MovieGenre.Horror );
                if ( i == 12 && data[i] == "1" ) listMovieGenre.Add( MovieGenre.Musical );
                if ( i == 13 && data[i] == "1" ) listMovieGenre.Add( MovieGenre.Mystery );
                if ( i == 14 && data[i] == "1" ) listMovieGenre.Add( MovieGenre.Romance );
                if ( i == 15 && data[i] == "1" ) listMovieGenre.Add( MovieGenre.SciFi );
                if ( i == 16 && data[i] == "1" ) listMovieGenre.Add( MovieGenre.Thriller );
                if ( i == 17 && data[i] == "1" ) listMovieGenre.Add( MovieGenre.War );
                if ( i == 18 && data[i] == "1" ) listMovieGenre.Add( MovieGenre.Western );
            }

            return listMovieGenre;
        }

        public static string[] SplitString( this string textString, string splitString, StringSplitOptions stringSplitOptions = StringSplitOptions.None )
        {
            string[] stringArr = textString.Split( new string[] { splitString }, stringSplitOptions );
            return stringArr;
        }
    }
}
