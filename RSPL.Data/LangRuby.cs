using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RSPL.Data
{
    public class LangRuby : ILanguageble
    {
        public byte Persent { get; set; }
        public ushort Year { get; set; }
        public string Region { get; set; }
    }
}
