using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NotSoCrud
{
    public class Player
    {
        public int PlayerId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string EmailAddress { get; set; }
        public string PhoneNumber { get; set; }
        public string? HomeAddress { get; set; }
        public string? City { get; set; }
        public int? ZipCode { get; set; }
        public int? Position { get; set; }
        public string? Gender { get; set; }
        public string? ShoeModel { get; set; }
        public int? ShoeSize { get; set; }
        public string? RacquetModel { get; set; }

    }
}
