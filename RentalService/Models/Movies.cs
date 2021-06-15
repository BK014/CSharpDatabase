using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentalService.Models
{
    public class Movies
    {
        public int MovieId { get; set; }
        public string Rating { get; set; }
        public string Title { get; set; }
        public string Year { get; set; }
        public decimal? Rental_Cost { get; set; }
        public string Copies { get; set; }
        public string Plot { get; set; }
        public string Genre { get; set; }
    }
}
