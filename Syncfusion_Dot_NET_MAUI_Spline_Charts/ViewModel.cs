using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Syncfusion_Dot_NET_MAUI_Spline_Charts
{
    public class ViewModel
    {
        public List<Model> Data { get; set; }

        public ViewModel()
        {
            Data = new List<Model>()
        {
            new Model ("Sun",7),
            new Model ("Mon",18),
            new Model ("Tue", 33),
            new Model ("Wed",30),
            new Model ("Thu",26),
            new Model ("Fri",18),
            new Model ("Sat",16)
        };
        }
    }

    public class Model
    {
        public string Name { get; set; }
        public double Height { get; set; }

        public Model(string name, double height)
        {
            Name = name;
            Height = height;
        }

    }
}
