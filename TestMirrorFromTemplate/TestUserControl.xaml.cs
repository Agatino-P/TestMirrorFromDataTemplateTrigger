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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace TestMirrorFromTemplate
{
    /// <summary>
    /// Interaction logic for TestUserControl.xaml
    /// </summary>
    public partial class TestUserControl : UserControl
    {


        public string Testo
        {
            get { return (string)GetValue(TestoProperty); }
            set { SetValue(TestoProperty, value); }
        }

        // Using a DependencyProperty as the backing store for Testo.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty TestoProperty =
            DependencyProperty.Register("Testo", typeof(string), typeof(TestUserControl), new PropertyMetadata("TestUserControl"));


        public TestUserControl()
        {
            InitializeComponent();
        }
    }
}
