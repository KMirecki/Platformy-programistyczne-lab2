using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentAPI
{
    internal class Coctail
    {
        public string idDrink { get; set; }
        public string strDrink { get; set; }

        public string strInstructions { get; set; }

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
