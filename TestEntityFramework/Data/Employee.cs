using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TestEntityFramework.Data
{
    public class Employee
    {
        [Key]

        public Guid Id{ get; set; }
        public String FirstName { get; set; }
        public String LastName{ get; set; }
        public String City { get; set; }
    }
}
