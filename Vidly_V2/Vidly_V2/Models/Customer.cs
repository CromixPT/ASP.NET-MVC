using System;
using System.ComponentModel.DataAnnotations;

namespace Vidly_V2.Models
{
    public class Customer
    {
        public int Id { get; set; }

        //Use of DataAnnotations to be able to change EntityFramework default conventions
        // in this case a string being null and unlimited size.
        [Required]
        [StringLength(255)]
        public string Name { get; set; }

        public bool IsSubscribedToNewsletter { get; set; }

        public MembershipType MembershipType { get; set; }

        [Display(Name = "Membership Type")]
        public byte MembershipTypeId { get; set; }

        //One way to change the information that appears on a label for the field is to 
        //change its Display annotation
        [Display(Name = "Date of Birth")]
        [DataType(DataType.Date)]
        public DateTime? BirthDate { get; set; }
    }
}