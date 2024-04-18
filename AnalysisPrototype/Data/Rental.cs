using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace AnalysisPrototype.Data
{
    public class Rental
    {
        public int Id {  get; set; }
        public int CustomerId { get; set; }
        public Customer Customer { get; set; }
        public ICollection<Equipment> Equipment { get; } = new List<Equipment>();
        public DateTime RentalDate { get; set; }
        public DateTime ReturnDate {  get; set; }
        [JsonIgnore]
        public float TotalCost => Equipment.Sum(p => p.Cost);
    }
}
