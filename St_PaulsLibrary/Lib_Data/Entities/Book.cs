using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace St_PaulsLibrary.Lib_Data.Entities
{
    public class Book : BaseClass
    {
        public string ISNB { get; set; }
        public string Publisher { get; set; }
        public string YearPublished { get; set; }
    }
}
