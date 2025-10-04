using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarDealer.Cars
{
    public class FuelType
    {
        public int Id { get; set; }
        public string Type { get; set; }

        public FuelType(int id, string type)
        {
            Id = id;
            Type = type;
        }
    }
}
