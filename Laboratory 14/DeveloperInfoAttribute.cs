﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratory_14
{
    [AttributeUsage(AttributeTargets.Class)]
    internal class DeveloperInfoAttribute : Attribute
    {
        public string DeveloperName { get; set; }
        public string OrganizationName { get; set; }
        public DeveloperInfoAttribute(string developerName, string organizationName)
        {
            DeveloperName = developerName;
            OrganizationName = organizationName;
        }
    }
}

