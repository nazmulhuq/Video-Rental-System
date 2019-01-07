using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using Vidly.Models;
namespace Vidly.ViewModels
{
    public class CustomerFormViewModel
    {
        public IEnumerable<MembershipType> MembershipTypes  { get; set; }

        [Required]
        public int? Id { get; set; }

        [Required]
        [StringLength(255)]
        public string Name { get; set; }

        public bool IsSubscribedToNewsLetter { get; set; }

        [Display(Name = "Date of Birth")]
        [Min18YearsIfAMember]
        [Required]
        public DateTime? DateOfBirth { get; set; }

        [Display(Name = "Membership Type")]
        [Required(ErrorMessage = "You must select a Membership Type")]
        public byte? MembershipTypeId { get; set; }

        public static readonly byte NewCustomer = 0;

        //--------------Methods-------------

        public string Title
        {
            get
            {
                return Id!=NewCustomer ? "Edit Customer"
                    : "New Customer";
            }
        }
        public CustomerFormViewModel()
        {
            Id = NewCustomer;
        }
        public CustomerFormViewModel(Customer customer)
        {
            Id = customer.Id;
            Name = customer.Name;
            DateOfBirth = customer.DateOfBirth;
            MembershipTypeId = customer.MembershipTypeId;
            IsSubscribedToNewsLetter = customer.IsSubscribedToNewsLetter;

        }

    }
}