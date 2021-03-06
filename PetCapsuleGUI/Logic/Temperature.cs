﻿using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetCapsuleGUI.Logic
{
    [JsonObject(MemberSerialization.OptIn)]
    class Temperature
    {
        public string info = "";
        private float minTemperature = 10;
        private float maxTemperature = 25;
        private float temperature = 20;

        [JsonProperty]
        public float CurrentTemperature
        {
            get
            {
                return temperature;
            }
            set
            {
                if (value < minTemperature)
                {
                    info = "Set to minimum: " + minTemperature;
                    value = minTemperature;
                }
                else if (value > maxTemperature)
                {
                    info = "Set to maximum: " + maxTemperature;
                    value = maxTemperature;
                }
                else
                {
                    info = "Set to: " + temperature;
                    temperature = value;
                }
            }
        }
    }
}
