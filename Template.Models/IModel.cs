﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Template.Models
{
    public interface IModel
    {
        string Id { get; set; }
        byte[] RowVersion { get; set; }
    }
}
