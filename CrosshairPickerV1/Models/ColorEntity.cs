using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Media;

namespace CrosshairPickerV1.Models
{
    public class ColorEntity
    {
        public string? Name { get; set; }
        public SolidColorBrush? Brush { get; set; }

        public override string ToString()
        {
            return Name ?? "No brush name";
        }
    }
    public class ColorFileData
    {
        public int Size { get; set; }
        public SolidColorBrush? Brush { get; set; }
        public int Gap { get; set; }
        public int Thickness { get;  set; }
    }
}
