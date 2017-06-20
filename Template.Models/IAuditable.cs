using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Template.Models
{
    public interface IAuditable
    {
        DateTimeOffset DateCreated { get; set; }

        DateTimeOffset? DateEdited { get; set; }

        string MemberCreatedId { get; set; }

        string MemberEditedId { get; set; }
    }
}
