using CrosshairPickerV1.Crosshairs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows;
using System.Windows.Media;
using System.Windows.Shapes;
using CrosshairPickerV1.Extensions;
using CrosshairPickerV1.Helpers;

namespace CrosshairPickerV1.Singleton
{
    public sealed class CrosshairCrossSingleton
    {
        private static CrosshairCrossSingleton? instance = null;
        private static readonly object padlock = new object();
     
        public  CrosshairCross? CrosshairCross;
        CrosshairCrossSingleton()
        {
        }

        public static CrosshairCrossSingleton Instance
        {
            get
            {
                lock (padlock)
                {
                    if (instance == null)
                    {
                        instance = new CrosshairCrossSingleton();
                       
                    }
                    return instance;
                }
            }
        }

        public void CanvasSetCrosshair(int lineZise, SolidColorBrush? brush)
        {
            try
            {
                CrosshairCross?.CanvasCrosshairDisplay();
            }
            catch {}
        }
    }
}
