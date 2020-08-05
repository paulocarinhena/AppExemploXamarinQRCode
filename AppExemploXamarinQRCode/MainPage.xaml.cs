using AppExemploXamarinQRCode.Service;
using System;
using System.ComponentModel;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace AppExemploXamarinQRCode
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        //ação do Button
        private async void Button_Clicked(object sender, EventArgs e) => await OpenScan();
      

        //Executa a varredura com a camera aberta
        private async Task OpenScan()
        {
            var scanner = DependencyService.Get<IQrCodeScanningService>();
            var result = await scanner.ScanAsync();
            if (!string.IsNullOrEmpty(result))
            {
               //pegando os dados do qrCode
                var QrCode = result;

                //alterando o Label com o conteudo do QRCode
                LblQrCode.Text = QrCode;

            }
        }

    }
}
