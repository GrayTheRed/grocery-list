using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain;

namespace TestRepository
{
    internal class GroceryListUser : IUser
    {
        private Guid _id;
        private string _name = "doe";
        private string _emailAddress = "fake@fake.com";
        private List<Recipe> _recipes = new List<Recipe>();
        public Guid Id { get => _id; set => _id = value; }
        public string Name { get => _name; set => _name = value; }
        public string EmailAddress { get => _emailAddress; set => _emailAddress = value; }
        public List<Recipe> Recipes { get => _recipes; set => _recipes = value; }

        public GroceryListUser(Guid id, string name, string emailAddress, List<Recipe> recipes)
        {
            Id = id;
            Name = name;
            EmailAddress = emailAddress;
            Recipes = recipes;
        }
    }
}
