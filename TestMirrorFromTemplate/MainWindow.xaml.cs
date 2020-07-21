using System.Windows;

namespace TestMirrorFromTemplate
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {


        public string Mirror
        {
            get { return (string)GetValue(MirrorProperty); }
            set { SetValue(MirrorProperty, value); }
        }
        public static readonly DependencyProperty MirrorProperty =
            DependencyProperty.Register("Mirror", typeof(string), typeof(MainWindow), new PropertyMetadata("1"));

        //public bool IsMirror
        //{
        //    get { return (bool)GetValue(IsMirrorProperty); }
        //    set { SetValue(IsMirrorProperty, value); }
        //}
        //public static readonly DependencyProperty IsMirrorProperty =
        //    DependencyProperty.Register("IsMirror", typeof(bool), typeof(MainWindow), new PropertyMetadata(false));

        public string Messaggio
        {
            get { return (string)GetValue(MessaggioProperty); }
            set { SetValue(MessaggioProperty, value); }
        }

        // Using a DependencyProperty as the backing store for Messaggio.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty MessaggioProperty =
            DependencyProperty.Register("Messaggio", typeof(string), typeof(MainWindow), new PropertyMetadata("Messaggio"));



        public MainWindow()
        {
            InitializeComponent();
        }
    }
}
