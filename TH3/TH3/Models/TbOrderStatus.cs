﻿using System;
using System.Collections.Generic;

namespace TH3.Models;

public partial class TbOrderStatus
{
    public int OrderStatusId { get; set; }

    public string? Name { get; set; }

    public string? Description { get; set; }
}
