using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Lessons_Sept_27th_part_1._5
{
    class Movie
    {
        private static int NextId { get; set; } = 1; // each Id is going to be different

        public int Id { get; set; }
        public string Title { get; set; }
        public string Genre { get; set; }
        public string Rating { get; set; } = "PG";
        public int Released { get; set; } // year only
        public int RuntimeInMinutes{ get; set; }
        public string Director { get; set; }

        public string print()
        {
            return $"{Id} | {Title} | {Genre} | {NextId}";
        }

        public int GetId()
        {
            return this.Id;
        }

        public string GetTitle()
        {
            return this.Title;
        }

        public string GetGenre()
        {
            return this.Genre;
        }

        public int GetReleased()
        {
            return this.Released;
        }

        public static int CalcRuntimeInMinutes(int Hours, int Minutes)
        {
            return Hours * 60 + Minutes;
        }

        public string GetRating()
        {
            return this.Rating;
        }

        public void SetRating(string rating)
        {
            Rating = rating;
        }

        public void SetRuntimeInMinutes(int Hours, int Minutes)
        {
            this.RuntimeInMinutes = Hours * 60 + Minutes;
        }

        public string GetDirector()
        {
            return this.Director;
        }

        public Movie() { }
        public Movie(string title, string genre, string rating, int released, int runtimeInMinutes, string director) 
        {
            this.Id = NextId++;
            //if (NextId > 3)
            //{
            //    NextId = 1;
            //}
            this.Title = title;
            this.Genre = genre;
            this.Rating = rating;
            this.Released = released;
            this.RuntimeInMinutes = runtimeInMinutes;
            this.Director = director;
        }
    }
}
