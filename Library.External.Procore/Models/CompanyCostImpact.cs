﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Library.External.Procore.Models
{
    public class CompanyCostImpact
    {
        [JsonPropertyName("status")]
        public string Status { get; set; }
        [JsonPropertyName("value")]
        public float? Value { get; set; }
    }
}
