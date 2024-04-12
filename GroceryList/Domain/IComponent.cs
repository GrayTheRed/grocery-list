namespace Domain
{
    public interface IComponent
    {
        string Name { get; }
        decimal Quantity { get; }
        Measurement Measurement { get; }

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
