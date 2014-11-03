using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaxThrottle.Model
{
    public class CarModel
    {
        public CarModel()
        {
            this.Engines = new HashSet<Engine>();
        }

        public int Id { get; set; }

        public string Name { get; set; }

        public int ManufacturerId { get; set; }

        public virtual Manufacturer Manufacturer { get; set; }

        public virtual ICollection<Engine> Engines { get; set; }

        public virtual ICollection<Car> Cars { get; set; }
    }
}
