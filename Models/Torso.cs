using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class Torso
    {
        public decimal ChestMeasurements { get; set; }
        public decimal WaistMeasurements    { get; set; }

        public Torso (decimal chestMeasurements, decimal waistMeasurements)
        {
            ChestMeasurements = chestMeasurements;
            WaistMeasurements = waistMeasurements;
        }
    }
}
