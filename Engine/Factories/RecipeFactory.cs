using Engine.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine.Factories
{
    public static class RecipeFactory
    {
        private static readonly List<Recipe> _recipes = new List<Recipe>();
        static RecipeFactory()
        {
            Recipe oracleApple = new Recipe(1, "Oracle's Apple");
            oracleApple.AddIngredient(31, 1);
            oracleApple.AddIngredient(32, 1);
            oracleApple.AddIngredient(33, 1);
            oracleApple.AddOutputItem(200, 1);
            _recipes.Add(oracleApple);
        }
        public static Recipe RecipeByID(int id)
        {
            return _recipes.FirstOrDefault(x => x.ID == id);
        }
    }
}
