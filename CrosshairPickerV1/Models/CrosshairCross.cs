using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;
using System.Windows.Shapes;

namespace CrosshairPickerV1.Crosshairs
{
    public class CrosshairCross
    {
        public Line VerticalLineTop { get; set; } = new Line();
        public Line VerticalLineBottom { get; set; } =  new Line();

        public Line HorizontalLineLeft { get; set; } = new Line();
        public Line HorizontalLineRight { get; set; } = new Line();
        public System.Windows.Media.SolidColorBrush? CrosshairColor { get; set; }
        public int CrosshairGap { get; set; } 
        public int CrosshairSize { get; set; } 
    }
}
