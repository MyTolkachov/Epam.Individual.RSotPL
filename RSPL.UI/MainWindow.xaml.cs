using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Windows;
using System.Windows.Controls;
using LiveCharts.Wpf;
using RSPL.Data;

namespace RSPL.UI
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        void Select(int region, int lang)
        {
            using (Rspl db = new Rspl())
            {

                var cSharpResult = from item in db.CSharps
                                   where item.Region == (Region)region
                                   select item;

                List<byte> Procent = new List<byte>(); 
                List<short> Years = new List<short>();

                foreach (var item in cSharpResult)
                {
                    Procent.Add(item.Persent);
                    Years.Add((short)item.Year);
                }

                //CC.Series[0].


            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
