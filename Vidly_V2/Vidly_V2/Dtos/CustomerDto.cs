using System;
using System.ComponentModel.DataAnnotations;
using Vidly_V2.Models;

namespace Vidly_V2.Dtos
{
    public class CustomerDto
    {
        public int Id { get; set; }

        //Use of DataAnnotations to be able to change EntityFramework default conventions
        // in this case a string being null and unlimited size.
        [Required]
        [StringLength(255)]
        public string Name { get; set; }

        public bool IsSubscribedToNewsletter { get; set; }


        public byte MembershipTypeId { get; set; }

        //One way to change the information that appears on a label for the field is to 
        //change its Display annotation
        [DataType(DataType.Date)]
       //[Min18YearsIfAMember]
        public DateTime? BirthDate { get; set; }

    }
}