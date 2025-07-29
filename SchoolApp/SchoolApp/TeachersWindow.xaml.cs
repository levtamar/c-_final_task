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
using BLL;
using Entities;

namespace SchoolApp
{
    /// <summary>
    /// Interaction logic for TeachersWindow.xaml
    /// </summary>
    public partial class TeachersWindow : Window
    {
        public List<Teachers> Teachers { get; set; }
        public TeachersWindow()
        {
            DataContext = this;
  
            function bl = new function();
            Teachers = bl.LoadTeachersDetails();
            InitializeComponent();
        }
        //public List<Teacher> Teachers { get; set; }
    }
}
