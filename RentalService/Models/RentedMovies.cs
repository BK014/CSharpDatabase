using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentalService.Models
{
    public class RentedMovies
    {
        public int RMID { get; set; }
        public int MovieIDFK { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }
        public string Title { get; set; }
        public decimal Rental_Cost { get; set; }
        public int CustIDFK { get; set; }
        public DateTime DateRented { get; set; }
        public DateTime? DateReturned { get; set; }
    }
}
