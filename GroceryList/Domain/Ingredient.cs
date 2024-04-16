
namespace Domain
{
    public class Ingredient : IComponent
    {
        private string _name = "Ingredient";
        private double _quantity = 1.0;
        private Measurement _measurement = Measurement.Each;
        public string Name { get => _name; set => _name = value; }
        public double Quantity { get => _quantity; set => _quantity = value; }
        public Measurement Measurement { get => _measurement; set => _measurement = value; }

        public Ingredient(string name, double quantity, Measurement measurement)
        {
            Name = name;
            Quantity = quantity;
            Measurement = measurement;            
        }
    }
}
