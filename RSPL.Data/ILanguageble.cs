using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RSPL.Data
{
    public interface ILanguageble
    {
        [Key]
        int Id { get; set; }
        byte Persent { get; set; }
        Year Year  { get; set; }
        Region Region { get; set; }
    }
}
