using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentAPI
{
    internal class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public float Average {  get; set; }
        public override string ToString()
        {
            return $"Id: {Id}\tName: {Name,-5}\tAverage: {Average:0.00}";
        }
    }
}
