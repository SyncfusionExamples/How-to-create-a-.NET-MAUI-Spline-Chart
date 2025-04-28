namespace SplineCharts
{
    public class ViewModel
    {
        public List<Model> Data { get; set; }

        public ViewModel()
        {
            Data =
            [
                new Model ("Sun",7),
                new Model ("Mon",18),
                new Model ("Tue", 33),
                new Model ("Wed",30),
                new Model ("Thu",26),
                new Model ("Fri",18),
                new Model ("Sat",16)
            ];
        }
    }

    public class Model(string name, double height)
    {
        public string Name { get; set; } = name;
        public double Height { get; set; } = height;
    }
}
