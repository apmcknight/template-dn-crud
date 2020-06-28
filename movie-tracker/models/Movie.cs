using System;
using System.ComponentModel.DataAnnotations;

namespace movie_tracker.models
{
    public class Movie
    {
            public int ID { get; set; }
            public string Title { get; set; }

            [DataType(DataType.Date)]
            public DateTime RelaseDate { get; set; }
            public string Genere { get; set; }
            public decimal Price { get; set; }
    }
}
