﻿
using Android.App;
using Android.Content.PM;
using Android.OS;
using Android.Runtime;
using ZXing.Mobile;

namespace AppExemploXamarinQRCode.Droid
{
    [Activity(Label = "AppExemploXamarinQRCode", Icon = "@mipmap/icon", Theme = "@style/MainTheme", MainLauncher = true, ConfigurationChanges = ConfigChanges.ScreenSize | ConfigChanges.Orientation)]
    public class MainActivity : global::Xamarin.Forms.Platform.Android.FormsAppCompatActivity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            TabLayoutResource = Resource.Layout.Tabbar;
            ToolbarResource = Resource.Layout.Toolbar;
            base.OnCreate(savedInstanceState);

            MobileBarcodeScanner.Initialize(this.Application);
            Xamarin.Essentials.Platform.Init(this, savedInstanceState);

            //colocando pacote de material (Estilizar)
            global::Xamarin.Forms.FormsMaterial.Init(this, savedInstanceState);

            //Inicializando form com progresso de camera
            global::Xamarin.Forms.Forms.Init(this, savedInstanceState);
            LoadApplication(new App());
        }
        public override void OnRequestPermissionsResult(int requestCode, string[] permissions, [GeneratedEnum] Android.Content.PM.Permission[] grantResults)
        {
            Xamarin.Essentials.Platform.OnRequestPermissionsResult(requestCode, permissions, grantResults);
            //Adicioinando Permissão
            global::ZXing.Net.Mobile.Android.PermissionsHandler.OnRequestPermissionsResult(requestCode, permissions, grantResults);
            base.OnRequestPermissionsResult(requestCode, permissions, grantResults);
        }
    }
}