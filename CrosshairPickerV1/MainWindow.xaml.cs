﻿using CrosshairPickerV1.Crosshairs;
using CrosshairPickerV1.Extensions;
using CrosshairPickerV1.Helpers;
using CrosshairPickerV1.Models;
using CrosshairPickerV1.Services.Classes;
using CrosshairPickerV1.Services.Interfaces;
using CrosshairPickerV1.Singleton;
using System.CodeDom;
using System.Collections.ObjectModel;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace CrosshairPickerV1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private Crosshair _crosshairWindow;
        private CrosshairCrossSingleton _crosshairSingleton = CrosshairCrossSingleton.Instance;
     
        private readonly ICrosshairFileService _crosshairFileService;
        private ObservableCollection<ColorEntity> Colors { get; set; }
        public MainWindow(ICrosshairFileService crosshairFileService)
        {
            _crosshairFileService = crosshairFileService;
        }


        public MainWindow() : this(new CrosshairFileService("crosshair.json"))
        {
            InitializeComponent();
        }

        private async void mainGrid_Loaded(object sender, RoutedEventArgs e)
        {
            DataContext = null;
            //imgCrosshair.Source = new BitmapImage(new Uri(System.IO.Path.Combine(Environment.CurrentDirectory, "target.png")));
            _crosshairSingleton.CrosshairCross = new Crosshairs.CrosshairCross();
            cmbColor.PopulateColorCombobox(Colors);
            DataContext = this; // Set the DataContext to access Colors in XAML
            var crosshairData = await _crosshairFileService.GetCrosshairDataAsync();
            if (crosshairData is not null && _crosshairWindow is null)
            {
                _crosshairWindow = new Crosshair();
                _crosshairWindow.Show();

                sliderCrosshairSize.Value = crosshairData.Size;
                sliderCrosshairGap.Value = crosshairData.Gap;
              
          
                sliderStrokeThickness.Value = crosshairData.Thickness;
                cmbColor.SelectedValue = crosshairData.Brush;

                CrosshairHelpers.UpdateCrosshairStrokeThickness(crosshairData.Thickness);
                CrosshairHelpers.UpdateCrosshairSize(crosshairData.Size);
                _crosshairSingleton.CrosshairCross.CrosshairGap = crosshairData.Gap;
                CrosshairHelpers.UpdateCrosshairColor(crosshairData.Brush);
                CrosshairCrossSingleton.Instance.CanvasSetCrosshair(25, CrosshairCrossSingleton.Instance.CrosshairCross.CrosshairColor);
            }

        }
        private void Window_MouseDown(object sender, MouseButtonEventArgs e)
        {
            try
            {
                DragMove();
            }
            catch { }
        }
        private void sliderCrosshairSize_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            if (_crosshairSingleton.CrosshairCross is not null)
            {
                var sliderValue = (int)sliderCrosshairSize.Value;
                CrosshairHelpers.UpdateCrosshairSize(sliderValue);
            }
        }

        private void sliderStrokeThickness_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            if (_crosshairSingleton.CrosshairCross is not null)
            {
                var sliderValue = (int)sliderStrokeThickness.Value;
                CrosshairHelpers.UpdateCrosshairStrokeThickness(sliderValue);
            }
        }

        private void sliderCrosshairGap_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            if (_crosshairSingleton.CrosshairCross is not null)
            {
                var sliderValue = (int)sliderCrosshairGap.Value;
                _crosshairSingleton.CrosshairCross.CrosshairGap = sliderValue;
                CrosshairCrossSingleton.Instance.CanvasSetCrosshair(25, CrosshairCrossSingleton.Instance.CrosshairCross.CrosshairColor);
            }
        }

        private void cmbColor_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            // Get the selected property
            var selectedProperty = cmbColor.SelectedItem as ColorEntity;

            if (selectedProperty != null)
            {
                // Get the SolidColorBrush from the property value
                var colorValue = selectedProperty.Brush;
                CrosshairHelpers.UpdateCrosshairColor(colorValue);
            }
        }
        private void btnClose_Click(object sender, RoutedEventArgs e)
        {
            Environment.Exit(0);
        }


        private async void btnWrite_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                var sliderSize = (int)sliderCrosshairSize.Value;
                var thickness = (int)sliderStrokeThickness.Value;
                var gap = (int)sliderCrosshairGap.Value;
                var color = (cmbColor.SelectedItem as ColorEntity) ?? new ColorEntity();
                var brush = color.Brush;
                if (await _crosshairFileService.WriteCrosshairDataAsync(new ColorFileData
                {
                    Size = sliderSize,
                    Gap = gap,
                    Brush = brush,
                    Thickness = thickness,
                }) is false)
                {
                    MessageBox.Show("Failed to write new crosshair!");
                    return;
                }
            }
            catch (Exception ex) 
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}