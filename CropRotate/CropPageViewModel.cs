using Prism.Mvvm;
using System;
using Windows.Foundation;

namespace CropRotate
{
    public class CropPageViewModel : BindableBase
    {
        private Rect cropArea;
        private double straighteningAngle;

        public Rect CropArea
        {
            get { return cropArea; }
            set
            {
                base.SetProperty(ref cropArea, value);
                base.OnPropertyChanged(nameof(InfoText));
            }
        }

        public double StraighteningAngle
        {
            get { return straighteningAngle; }
            set
            {
                base.SetProperty(ref straighteningAngle, value);
            }
        }

        public string InfoText
        {
            get
            {
                return $"X: {Math.Round(CropArea.X, 0)}\nY: {Math.Round(CropArea.Y, 0)}\nW: {Math.Round(CropArea.Width, 0)}\nH: {Math.Round(CropArea.Height, 0)}";
            }
        }
    }
}
