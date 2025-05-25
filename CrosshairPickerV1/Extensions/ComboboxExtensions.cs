using CrosshairPickerV1.Constants;
using CrosshairPickerV1.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace CrosshairPickerV1.Extensions
{
    public static class ComboboxExtensions
    {
        public static void PopulateColorCombobox(this ComboBox cmbColor ,ObservableCollection<ColorEntity> colors)
        {
            colors = new ObservableCollection<ColorEntity>();
            var brushColors = typeof(System.Windows.Media.Brushes).GetProperties();
            foreach (var brush in brushColors)
            {
                var colorBrush = brush.GetValue(brush) as SolidColorBrush;
                if(brush.Name != Constant.TRANSPARENT)  
                colors.Add(new ColorEntity { Name = brush.Name, Brush = colorBrush });
            }
            cmbColor.ItemsSource = colors;
            var defaultColor = colors.FirstOrDefault(c => c.Name == "Green");
            if (defaultColor != null)
            {
                cmbColor.SelectedItem = defaultColor;
            }

        }
    }
}
