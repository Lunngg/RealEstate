﻿using System;
using System.Collections.Generic;

namespace RealEstate.Models;

public partial class ChuDauTu
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public virtual ICollection<Property> Property { get; set; } = new List<Property>();
}
