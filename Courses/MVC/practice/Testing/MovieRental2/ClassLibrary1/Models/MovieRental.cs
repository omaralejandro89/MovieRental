using System;

namespace ClassLibrary1.Models
{
    public class MovieRental
    {
        public int MovieRentalId { get; set; }
        public int MovieId { get; set; }
        public int CustomerId { get; set; }
        public DateTime DateTaken { get; set; }
        public DateTime? DateReturned { get; set; }
    }
}