using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace Vidly.Models
{
    public class Customer
    {
        public int Id { get; set; }

        [Required]
        [StringLength(255)]
        public string Name { get; set; }

        public bool IsSubscribedToNewsLetter { get; set; }

        public MembershipType MembershipType { get; set; }

        [Display(Name = "Date of Birth")]
        [Min18YearsIfAMember]
        public DateTime? DateOfBirth { get; set; }


        [Display(Name= "Membership Type")]
        [Required(ErrorMessage ="You must select a Membership Type")]
        public byte MembershipTypeId { get; set; }

        public static readonly byte AgeLimit = 18;
    }
}