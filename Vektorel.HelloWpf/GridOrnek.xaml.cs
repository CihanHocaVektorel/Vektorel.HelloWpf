using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace Vektorel.HelloWpf
{
    /// <summary>
    /// Interaction logic for GridOrnek.xaml
    /// </summary>
    public partial class GridOrnek : Window
    {
        public GridOrnek()
        {
            InitializeComponent();
            for (int i = 0; i < grd.RowDefinitions.Count; i++)
            {
                for (int j = 0; j < grd.ColumnDefinitions.Count; j++)
                {
                    Button btn = new Button();
                    btn.Width = 75;
                    btn.Height = 50;
                    Grid.SetRow(btn, i);
                    Grid.SetColumn(btn, j);
                    grd.Children.Add(btn);
                }
            }
        }
    }
}
