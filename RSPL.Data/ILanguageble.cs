using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RSPL.Data
{
    interface ILanguageble
    {
        byte Persent { get; set; }
        ushort Year  { get; set; }
        string Country { get; set; }
    }
}
