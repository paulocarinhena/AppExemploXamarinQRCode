using System.Threading.Tasks;

namespace AppExemploXamarinQRCode.Service
{
    public interface IQrCodeScanningService
    {
        Task<string> ScanAsync();
    }
}
