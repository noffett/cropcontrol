using Prism.Mvvm;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CropRotate
{
    public class CropPageViewModel : BindableBase
    {
        private double straighteningAngle;

        public double StraighteningAngle
        {
            get { return straighteningAngle; }
            set
            {
                base.SetProperty(ref straighteningAngle, value);
            }
        }
    }
}
