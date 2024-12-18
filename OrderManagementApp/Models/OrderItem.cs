using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderManagementApp.Models
{
    public class OrderItem
    {
        public int Id { get; set; }
        public string SteelGrade { get; set; }
        public double Diameter { get; set; }
        public double WallThickness { get; set; }
        public double Volume { get; set; }
        public string Unit { get; set; }
        public string Status { get; set; }
    }
}
