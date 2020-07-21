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

        // Using a DependencyProperty as the backing store for Mirror.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty MirrorProperty =
            DependencyProperty.Register("Mirror", typeof(string), typeof(MainWindow), new PropertyMetadata(string.Empty));



        public bool IsMirror
        {
            get { return (bool)GetValue(IsMirrorProperty); }
            set { SetValue(IsMirrorProperty, value); }
        }
        public static readonly DependencyProperty IsMirrorProperty =
            DependencyProperty.Register("IsMirror", typeof(bool), typeof(MainWindow), new PropertyMetadata(false));


        public MainWindow()
        {
            InitializeComponent();
        }
    }
}
