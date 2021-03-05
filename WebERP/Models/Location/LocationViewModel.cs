﻿using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebERP.Models
{
    public class LocationViewModel
    {        
        public Tab ActiveTab { get; set; }
    }

    public enum Tab
    {
        Country,
        State,
        City
    }

}
