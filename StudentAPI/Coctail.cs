using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentAPI
{
    internal class Coctail
    {
        public int Id { get; set; }
        public required string idDrink { get; set; }
        public required string strDrink { get; set; }

        public required string strInstructions { get; set; }

        public required string strIngredient1 { get; set; }
        public string? strIngredient2 { get; set; }
        public string? strIngredient3 { get; set; }
        public string? strIngredient4 { get; set; }
        public string? strIngredient5 { get; set; }
        public string? strIngredient6 { get; set; }
        public string? strIngredient7 { get; set; }
        public string? strIngredient8 { get; set; }
        public string? strIngredient9 { get; set; }

        public string? strIngredient10 { get; set; }
        public string? strIngredient11 { get; set; }

        public string? strIngredient12 { get; set; }

        public string? strIngredient13 { get; set; }

        public string? strIngredient14 { get; set; }
        public string? strIngredient15 { get; set; }

        public List<string> getIngredientsList()
        {
            List<string> list = new List<string>();
            list.Add(strIngredient1);
            list.Add(strIngredient2);
            list.Add(strIngredient3);
            list.Add(strIngredient4);
            list.Add(strIngredient5);
            list.Add(strIngredient6);
            list.Add(strIngredient7);
            list.Add(strIngredient8);
            list.Add(strIngredient9);
            list.Add(strIngredient10);
            list.Add(strIngredient11);
            list.Add(strIngredient12);
            list.Add(strIngredient13);
            list.Add(strIngredient14);
            list.Add(strIngredient15);
            return list;
        }
        public override string ToString()
        {
            return $"{strDrink}";
        }
    }
    internal class DrinkRoot
    {
        public Coctail[] drinks { get; set; }
    }
}
