﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebERP.Models
{
    public class Item_Master
    {
        public int ID { get; set; }
        [Required]
        public string NAME { get; set; }
        public int UOM_CODE  { get; set; }
        public int HSN_CODE  { get; set; }
        public int MIN_STOCK { get; set; }
        public int MAX_STOCK { get; set; }
        public string ACTIVE_TAG { get; set; }
        public string REMARKS { get; set; }
        public DateTime INS_DATE { get; set; }
        public string INS_UID { get; set; }
        public DateTime UDT_DATE { get; set; }
        public string UDT_UID { get; set; }
    }
}
