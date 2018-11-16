using System.Collections.Generic;
using Vidly_V2.Models;

namespace Vidly_V2.ViewModels
{
    public class CustomerFormViewModel
    {
        public IEnumerable<MembershipType> MembershipTypes { get; set; }
        public Customer Customer { get; set; }
    }
}