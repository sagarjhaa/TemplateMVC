using System.ComponentModel.DataAnnotations;

namespace Template.Models
{
    public class Member : IModel, IOrganizationModel, IMemberBase
    {
        public string Id { get; set; }
        [Required]
        [Display(Name = "First Name")]
        public string FirstName { get; set; }

        [Required]
        [Display(Name = "Last Name")]
        public string LastName { get; set; }

        [Display(Name = "Organization")]
        public Organization Organization { get; set; }

        [Required]
        public string OrganizationId { get; set; }

        [Timestamp]
        public byte[] RowVersion { get; set; }

        public override string ToString()
        {
            return string.Format("{1}, {0}", FirstName, LastName);
        }
    }
}
