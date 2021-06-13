using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Lab3.Models
{
    public class Person
    {
        public int FirstName
        {
            get;
            set;
        }

        [Required]
        [StringLength(1000)]
        public string LastName
        {
            get;
            set;
        }

        [Required]
        [StringLength(1000)]
        public string Age
        {
            get;
            set;
        }

        [Required]
        [StringLength(1000)]
        public string EmailAddress
        {
            get;
            set;
        }

        [Required]
        [DataType(DataType.Date)]
        public DateTime DateOfBirth
        {
            get;
            set;
        }

        [Required]
        [StringLength(1000)]
        public string Password
        {
            get;
            set;
        }

        [Required]
        [StringLength(1000)]
        public string Description
        {
            get;
            set;
        }

    }
}
