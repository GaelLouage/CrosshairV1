using CrosshairPickerV1.Singleton;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Media;

namespace CrosshairPickerV1.Helpers
{
    public  class CrosshairHelpers
    {
        public static void UpdateCrosshairSize(int size)
        {
            CrosshairCrossSingleton.Instance.CrosshairCross.VerticalLineTop.Y2 = size * -1;
            CrosshairCrossSingleton.Instance.CrosshairCross.VerticalLineBottom.Y2 = size;
            CrosshairCrossSingleton.Instance.CrosshairCross.HorizontalLineLeft.X2 = size * -1;
            CrosshairCrossSingleton.Instance.CrosshairCross.HorizontalLineRight.X2 = size;
        }

        public static void UpdateCrosshairStrokeThickness(int thickness)
        {
            CrosshairCrossSingleton.Instance.CrosshairCross.VerticalLineTop.StrokeThickness = thickness;
            CrosshairCrossSingleton.Instance.CrosshairCross.VerticalLineBottom.StrokeThickness = thickness;
            CrosshairCrossSingleton.Instance.CrosshairCross.HorizontalLineLeft.StrokeThickness = thickness;
            CrosshairCrossSingleton.Instance.CrosshairCross.HorizontalLineRight.StrokeThickness = thickness;
        }

        public static void UpdateCrosshairColor(SolidColorBrush colorValue)
        {
            CrosshairCrossSingleton.Instance.CrosshairCross.VerticalLineTop.Stroke = colorValue;
            CrosshairCrossSingleton.Instance.CrosshairCross.VerticalLineBottom.Stroke = colorValue;
            CrosshairCrossSingleton.Instance.CrosshairCross.HorizontalLineLeft.Stroke = colorValue;
            CrosshairCrossSingleton.Instance.CrosshairCross.HorizontalLineRight.Stroke = colorValue;
        }
    }
}
