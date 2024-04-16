using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class Recipe : IItem
    {
        private string _name = "Doe";
        private string _description = "Please put your description here";
        private ItemType _type = ItemType.Recipe;
        private List<Ingredient> _ingredients = new List<Ingredient>();
        
        public string Name { get => _name; set => _name = value; }
        public string Description { get => _description; set => _description = value; }
        public ItemType Type { get => _type;}
        public List<Ingredient> Ingredients { get => _ingredients; set => _ingredients = value; }

        public Recipe(string name, string description) {
            Name = name;
            Description = description;
        }
    }
}
