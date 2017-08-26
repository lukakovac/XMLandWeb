using System.Windows;
using XMLandWebServices.ServiceReference1;

namespace XMLandWebServices
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private int counter = 0;
        private Service1Client service;
        public MainWindow()
        {
            InitializeComponent();
            service = new Service1Client();

        }

    }
}
