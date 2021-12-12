using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab7
{
    public class CarBase
    {
        public List<CarsMark> CarsList { get; set; }
        public CarBase()
        {
            CarsList = new List<CarsMark>();
        }
        public void FillCarsList()
        {            
            CarsList = Enum.GetValues(typeof(CarsMark)).Cast<CarsMark>().ToList();
        }
    }
    
}
