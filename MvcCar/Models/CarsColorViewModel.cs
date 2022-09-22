using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MvcCar.Models
{
    public class CarsColorViewModel
    {
        public List<Car> Cars { get; set; }
        public SelectList Colors { get; set; }
        public string CarColor { get; set; }
        public string SearchString { get; set; }
    }
}
