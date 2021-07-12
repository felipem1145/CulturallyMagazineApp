using System;
using System.Collections.Generic;
using System.Text;

namespace AppMagazine.Models
{
    public class Issue
    {
        public string Name { get; set; }
        public string Date { get; set; }
        public string ImageUrl { get; set; }

        public override string ToString()
        {
            return Name;
        }

    }
}
