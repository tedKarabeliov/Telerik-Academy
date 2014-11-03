using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MaxThrottle.Model
{
    public class Engine
    {
        public Engine()
        {
            this.CarModels = new HashSet<CarModel>();
            this.Cars = new HashSet<Car>();
        }

        public int Id { get; set; }

        public string Name { get; set; }

        public int HorsePower { get; set; }

        public int NumberOfValves { get; set; }

        public virtual ICollection<CarModel> CarModels { get; set; }

        public virtual ICollection<Car> Cars { get; set; }

        public virtual EngineType EngineType { get; set; }
    }
}
