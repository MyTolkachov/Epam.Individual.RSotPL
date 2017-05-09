using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RSPL.Data
{
    [Table("Years")]
    public class Year
    {
        [Key]
        public int Id { get; set; }

        public Year(int year)
        {
            Id = year;
        }
    }
}
