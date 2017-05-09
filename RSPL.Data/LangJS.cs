using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RSPL.Data
{
    [Table("JS")]
    public class LangJS : ILanguageble
    {
        public int Id { get; set; }
        public byte Persent { get; set; }
        public Year Year { get; set; }
        public Region Region { get; set; }
    }
}
