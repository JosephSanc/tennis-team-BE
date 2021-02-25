using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace NotSoCrud
{
    public class Staff
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Position { get; set; }
        public string EmailAddress { get; set; }
        public int StaffId { get; set; }
        public string? HomeAddress { get; set; }
        public string? City { get; set; }
        public int? ZipCode { get; set; }

    }
}
