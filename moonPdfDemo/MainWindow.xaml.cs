using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.IO;
using MoonPdfLib;

namespace moonPdfDemo
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        private void Pdf_Click(object sender, RoutedEventArgs e)
        {
            var fileName = @"Resource\1Where Do My Thoughts Go.pdf";
            var filePath = System.IO.Path.Combine(AppDomain.CurrentDomain.BaseDirectory, fileName);

            pdfPanel.OpenFile(filePath);
            pdfPanel.Zoom(1.0);
            this.pdfPanel.ViewType = ViewType.SinglePage;
        }
        private void next_Click(object sender, RoutedEventArgs e)
        {
            pdfPanel.GotoNextPage();
            pdfPanel.Zoom(1.0);
            this.pdfPanel.ViewType = ViewType.SinglePage;
        }

    }
    }
}