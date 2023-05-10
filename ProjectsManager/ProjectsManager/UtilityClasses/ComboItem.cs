using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectsManager
{
    public class ComboItem
    {
        public string Name { get; set; }
        public int Value { get; set; }
        public ComboItem(string name, int value) 
        {
            Name = name;
            Value = value;
        }
        public override string ToString()
        {
            return Name;
        }
    }
}
