using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using BrightIdeasSoftware;

namespace EasyNMR.Internal
{
    public enum PeakType
    {
        Singlet = 0,
        Doublet = 1,
        Triplet = 2,
        Multiplet = 3
    }

    class PeakInfo
    {
        [OLVColumn(Width = 75, DisplayIndex = 1)]
        public PeakType Type { get; set; }
        
        [OLVColumn(Width = 50, DisplayIndex = 0)]
        public float Shift { get; set; }

        [OLVColumn(Width = 100, DisplayIndex = 2)]
        public int HydrogenCount { get; set; }

        [OLVColumn(DisplayIndex = 4, FillsFreeSpace = true)]
        public string Description { get; set; }

        [OLVColumn(DisplayIndex = 3, Width = 75)]
        public string Coupling { get; set; }

        public override string ToString()
        {
            if (string.IsNullOrEmpty(Coupling) || Coupling == "None")
                return String.Format("{0:0.00} ({1}, {2}H, {3})", Shift, Type.ToString().ToLower()[0], HydrogenCount, Description);
            return String.Format("{0:0.00} ({1}, J = {4:0.0}, {2}H, {3})", Shift, Type.ToString().ToLower()[0], HydrogenCount, Description, float.Parse(Coupling));
        }
    }
}
