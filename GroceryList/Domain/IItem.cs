namespace Domain
{
    public interface IItem
    {
        public string Name { get; set; }
        public string Description { get; set; }

        public ItemType Type { get; set; }

    }

    public enum ItemType
    {
        Recipe,
        Snack
    } 
}