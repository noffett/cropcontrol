using Prism.Mvvm;
using System;
using Windows.Foundation;

namespace CropRotate
{
    public class CropPageViewModel : BindableBase
    {
        private Rect cropArea = new Rect(0.0, 0.0, 1.0, 1.0);
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
                return $"X: {Math.Round(CropArea.X, 3)}\nY: {Math.Round(CropArea.Y, 3)}\nW: {Math.Round(CropArea.Width, 3)}\nH: {Math.Round(CropArea.Height, 3)}";
            }
        }
    }
}
