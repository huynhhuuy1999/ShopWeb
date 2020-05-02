using System;
using System.Collections.Generic;

namespace Shop.Models
{
    public partial class Phiship
    {
        public Phiship()
        {
            Hoadon = new HashSet<Hoadon>();
        }

        public int PhiShipId { get; set; }
        public string Quan { get; set; }
        public int? ChiPhi { get; set; }

        public ICollection<Hoadon> Hoadon { get; set; }
    }
}
