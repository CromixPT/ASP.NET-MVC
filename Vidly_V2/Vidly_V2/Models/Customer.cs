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
        public byte MembershipTypeId { get; set; }
    }
}