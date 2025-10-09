using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardDealerUpdated.Cars.Entities
{
    public class FuelType
    {
        public int Id { get; }
        public string Type { get; }

        public FuelType(int id, string type)
        {
            Id = id;
            Type = type;
        }
    }
}
