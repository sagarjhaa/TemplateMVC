using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Template.Models
{
    public interface IOrganizationBase
    {
        string Id { get; set; }
        string Name { get; set; }
        string StreetAddress1 { get; set; }
        string StreetAddress2 { get; set; }
        string Suite { get; set; }
        string City { get; set; }
        string StateProvince { get; set; }
        string PostalCode { get; set; }
    }
}
