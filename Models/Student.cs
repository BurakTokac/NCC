using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace NCC
{
    public class Student
    {
        public int custID { get; set; }

        [Required(ErrorMessage = "First Name is required.")]

        [DisplayName("First Name")]
        public string firstName { get; set; }

        [DisplayName("Middle Name")]
        public string middleName { get; set; }

        [Required(ErrorMessage = "Last Name is required.")]

        [DisplayName("Last Name")]
        public string lastName { get; set; }

        [Required(ErrorMessage = "Address is required.")]

        [DisplayName("Address")]
        public string address { get; set; }

        [DisplayName("Suite/Appt. Number")]
        public string address2 { get; set; }

        [Required(ErrorMessage = "City is required.")]

        [DisplayName("City")]
        public string city { get; set; }

        [Required(ErrorMessage = "State is required.")]

        [DisplayName("State")]
        public string state { get; set; }

        [Required(ErrorMessage = "Zip Code is required.")]

        [DisplayName("Zip Code")]
        public int zipCode { get; set; }

    }
}