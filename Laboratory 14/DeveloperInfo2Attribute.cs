using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratory_14
{
    [AttributeUsage(AttributeTargets.Class, AllowMultiple = true)]
    internal class DeveloperInfo2Attribute : Attribute
    {
        public string DeveloperName1 { get; set; }
        public DateTime DevelopmentDate { get; set; }
        public DeveloperInfo2Attribute(string developerName1, string developmentDate)
        {
            DeveloperName1 = developerName1;
            DevelopmentDate = DateTime.Parse(developmentDate);
        }
    }  
}
