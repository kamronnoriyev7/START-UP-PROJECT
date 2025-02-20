using System;
using System.Data;

namespace SportTime.DAL.Entities
{
    public class User
    {
        public long UserId { get; set; }
        public string? Name { get; set; }
        public int? Number { get; set; }
        public string? Password { get; set; }
        public DateTime CreatedDate { get; set; }
        public Stadium? Stadium { get; set; }
        public ICollection<Booking>? Bookings { get; set; }

    }
}
