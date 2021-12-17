using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metodichka
{
    [AttributeUsage(AttributeTargets.Class, AllowMultiple = true)]
    public class OrganizationInfoAttribute:Attribute
    {
        string Name;
        string Organization;
        public OrganizationInfoAttribute(string name, string org)
        {
            Name = name;
            Organization = org;
        }
        public override string ToString()
        {
            return $"{Name}, {Organization}";
        }
    }
}
