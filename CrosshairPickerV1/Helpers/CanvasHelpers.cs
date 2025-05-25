using CrosshairPickerV1.Crosshairs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows;

namespace CrosshairPickerV1.Helpers
{
    public static class CanvasHelpers
    {

        public static void CanvasCrosshairDisplay(this CrosshairCross crosshairCross )
        {
            Canvas.SetLeft(crosshairCross.VerticalLineTop, (SystemParameters.PrimaryScreenWidth + 15) / 2);
            Canvas.SetTop(crosshairCross.VerticalLineTop, (SystemParameters.PrimaryScreenHeight - (5 + crosshairCross.CrosshairGap)) / 2);

            Canvas.SetLeft(crosshairCross.VerticalLineBottom, (SystemParameters.PrimaryScreenWidth + 15) / 2);
            Canvas.SetTop(crosshairCross.VerticalLineBottom, (SystemParameters.PrimaryScreenHeight + (25 + crosshairCross.CrosshairGap)) / 2);

            Canvas.SetLeft(crosshairCross.HorizontalLineLeft, (SystemParameters.PrimaryScreenWidth - (1 + crosshairCross.CrosshairGap)) / 2);
            Canvas.SetTop(crosshairCross.HorizontalLineLeft, (SystemParameters.PrimaryScreenHeight + 10) / 2);

            Canvas.SetLeft(crosshairCross.HorizontalLineRight, (SystemParameters.PrimaryScreenWidth + (30 + crosshairCross.CrosshairGap)) / 2);
            Canvas.SetTop(crosshairCross.HorizontalLineRight, (SystemParameters.PrimaryScreenHeight + 10) / 2);
        }
    }
}
