using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RSPL.Data
{
    [Table("Java")]
    //Review BA : Class name "LangJAVA" does not match naming rules. Suggested name is "LangJava" 
    public class LangJAVA : ILanguageble
    {
        public int Id { get; set; }
        public byte Persent { get; set; }
        public Year Year { get; set; }
        public Region Region { get; set; }
    }
}
