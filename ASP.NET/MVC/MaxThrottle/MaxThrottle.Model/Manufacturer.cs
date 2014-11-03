using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaxThrottle.Model
{
    public class Manufacturer
    {
        public Manufacturer()
        {
            this.CarModels = new HashSet<CarModel>();
            this.Cars = new HashSet<Car>();
        }

        public int Id { get; set; }

        public string Name { get; set; }

        public virtual ICollection<Car> Cars { get; set; }

        public virtual ICollection<CarModel> CarModels { get; set; }
    }
}
