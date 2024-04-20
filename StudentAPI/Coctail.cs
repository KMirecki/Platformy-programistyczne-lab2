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

        public override string ToString()
        {
            return $"Id: {idDrink}, Name: {strDrink}, Instructions: {strInstructions}";
        }
    }
    internal class DrinkRoot
    {
        public Coctail[] drinks { get; set; }
    }
}
