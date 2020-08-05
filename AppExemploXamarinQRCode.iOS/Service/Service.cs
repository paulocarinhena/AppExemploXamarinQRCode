
using AppExemploXamarinQRCode.Service;
using System.Threading.Tasks;
using Xamarin.Forms;
using ZXing.Mobile;

[assembly: Dependency(typeof(AppExemploXamarinQRCode.iOS.Service.QrCodeScanningService))]

namespace AppExemploXamarinQRCode.iOS.Service
{
    public class QrCodeScanningService : IQrCodeScanningService
    {
        public async Task<string> ScanAsync()
        {
            var scanner = new MobileBarcodeScanner()
            {
                TopText = "Aproxime a câmera do QrCode",
                //BottomText = "Toque na tela para focar"
            };
            var scanResults = await scanner.Scan();
            //Fix by Ale
            return (scanResults != null) ? scanResults.Text : string.Empty;
        }
    }
}