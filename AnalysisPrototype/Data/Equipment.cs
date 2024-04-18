using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace AnalysisPrototype.Data
{
    public class Equipment
    {
        public int Id { get; set; }
        public int CategoryId { get; set; }
        public Category Category { get; set; }
        [JsonIgnore]
        public string CategoryName => Category.Name;
        public string Name { get; set; }
        public string Description { get; set; }
        public float Cost { get; set; }
    }
}
