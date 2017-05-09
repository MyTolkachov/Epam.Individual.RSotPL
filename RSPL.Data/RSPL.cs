namespace RSPL.Data
{
    using System.Data.Entity;

    public partial class Rspl : DbContext
    {
        public Rspl()
            : base("name=RSPL.Model")
        {
        }
        

        public virtual DbSet<LangCPlus> CPluses { get; set; }
        public virtual DbSet<LangCSharp> CSharps { get; set; }
        public virtual DbSet<LangJAVA> Javas { get; set; }
        public virtual DbSet<LangJS> JSs { get; set; }
        public virtual DbSet<LangPHP> Phps { get; set; }
        public virtual DbSet<LangPyton> Pytons { get; set; }
        public virtual DbSet<LangRuby> Rubies { get; set; }
        public virtual DbSet<LangSwift> Swifts { get; set; }
    }
}