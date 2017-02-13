namespace ConsoleApplication6.Model
{
    class Produce // define custom classes
    {
        public Produce()
        {

        }// no-argument constructor

        public Produce(string name, double weight, int quantity) //custom constructor
        {
            Name = name;
            Weight = weight;
            Quantity = quantity; // calling the property object and that implicilty is calling the set method
        }

        private string name; // this is a field with and  identifier known as name or name field
        public string Name // the Name property
        {
            get { return name.ToUpper(); }
            set { name = value; }
        }

        private double weight;
        public double Weight
        {
            get { return weight; }
            set { weight = value; }
        }

        public int Quantity { get; set; } // shorthand set and get declarations
        public override string ToString()
        {
            return Name + "(" + Weight + "oz): " + Quantity;
        }
    }

    class Fruit : Produce// Fruit is a subclass (derived class) of produce (base class)
    {
        public Fruit()
        {

        }

        public Fruit(string name, double weight, int quantity) : base(name, weight, quantity)
        {

        }
    }

    class Vegetable : Produce
    {
        public Vegetable()
        {

        }

        public Vegetable(string name, double weight, int quantity) : base(name, weight, quantity)
        {

        }
    }
}
