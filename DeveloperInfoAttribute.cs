using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metodichka
{
    [AttributeUsage(AttributeTargets.Class,AllowMultiple = true)]
    class DeveloperInfoAttribute : Attribute
    {
        public string name;
        public DateTime date;
        public DeveloperInfoAttribute(string name)
        {
            this.name = name;
            this.date = DateTime.Now;
        }
        public override string ToString()
        {
            return $"{name}  {date}";
        }
    }
}
