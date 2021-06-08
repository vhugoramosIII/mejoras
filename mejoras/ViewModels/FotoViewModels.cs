using mejoras.Models;
using Plugin.Media.Abstractions;
using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace mejoras.ViewModels
{
    public class FotoViewModels:FotoModels
    {
        public Command CapturarComando { get; set; }

        public FotoViewModels()
        {
            CapturarComando = new Command(TomarFoto);
        }

        private async void TomarFoto()
        {
            var camara = new StoreCameraMediaOptions();
            camara.PhotoSize = PhotoSize.Full;
            camara.SaveToAlbum = true;
            var foto = await Plugin.Media.CrossMedia.Current.TakePhotoAsync(camara);
            if (foto != null)
            {
                Fotico = ImageSource.FromStream(() =>
                 {
                     return foto.GetStream();
                     });
            }
        }


    }
}
