using System;
using System.Data.Entity;
using System.Windows;
using RSPL.Data;

namespace RSPL.UI
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();


            Database.SetInitializer(new DropCreateDatabaseAlways<Rspl>());

            using (Rspl db = new Rspl())
            {
                ILanguageble CSharp = new LangCSharp
                { Persent = 22, Region = Region.Europe, Year = Year.y2010 };

                ILanguageble Java = new LangJAVA()
                { Persent = 22, Region = Region.Ukraine, Year = Year.y2011 };

                db.CSharps.Add((LangCSharp)CSharp);
                db.Javas.Add((LangJAVA)Java);

                try
                {
                    db.SaveChanges();
                }
                catch (System.Data.Entity.Validation.DbEntityValidationException dbEx)
                {
                    Exception raise = dbEx;
                    foreach (var validationErrors in dbEx.EntityValidationErrors)
                    {
                        foreach (var validationError in validationErrors.ValidationErrors)
                        {
                            string message = string.Format("{0}:{1}",
                                validationErrors.Entry.Entity.ToString(),
                                validationError.ErrorMessage);
                            // raise a new exception nesting
                            // the current instance as InnerException
                            raise = new InvalidOperationException(message, raise);
                        }
                    }
                    throw raise;
                }
            }
        }
    }
}
