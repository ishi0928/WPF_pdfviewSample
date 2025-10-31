using System;
using System.Threading.Tasks;
using System.Windows;
using Microsoft.Web.WebView2.Wpf;
using Microsoft.Web.WebView2.Core;


namespace PDFAPP
{
    public partial class MainWindow : Window
    {
        private readonly pdfApp _pdfApp;

        public MainWindow()
        {
            InitializeComponent();

            _pdfApp = new PDF();

        }

        private async void Window_Loaded(object sender, RoutedEventArgs e)
        {
            // PDFを表示
            await DisplayPdfAsync();
        }

        private async Task DisplayPdfAsync()
        {
            await pdfViewer.EnsureCoreWebView2Async();

            if (System.IO.File.Exists(_pdfApp.filepath))
            {
                string filePath = _pdfApp.filepath.Replace("\\", "/");
                pdfViewer.CoreWebView2.Navigate($"file:///{filePath}");
            }
            else
            {
                MessageBox.Show($"PDFが見つかりません。\n{_pdfApp.filepath}");
            }
        }
    }
}
