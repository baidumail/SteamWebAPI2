﻿using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SteamWebAPI2.Models.Economy
{
    public class EconItemEquipped
    {
        [JsonProperty(PropertyName = "class")]
        public int ClassId { get; set; }
        public int Slot { get; set; }
    }
}