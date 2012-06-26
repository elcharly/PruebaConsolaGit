using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GitSample
{
    public class Man : Person
    {
      private Boolean hasACar;
        public string Address { get; set; }
        public DateTime BirthDate { get; set; }
        public bool Unemployed { get; set; }
    }
}
