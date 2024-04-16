namespace Domain
{
    internal interface IComponent
    {
        string Name { get; set; }
        double Quantity { get; set; }
        Measurement Measurement { get; set; }

    }

    public enum Measurement
    {
        Each,
        Quart,
        Liter,
        Gallon,
        Cup,
        Box
    }
}
