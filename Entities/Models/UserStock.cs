﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Entities.Models;

public partial class UserStock
{
 
    public int UserStockId { get; set; }

    public int UserId { get; set; }
   
    public int StockId { get; set; }

    public virtual StockDatum Stock { get; set; }

    public virtual User User { get; set; }
}