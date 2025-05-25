using CrosshairPickerV1.Crosshairs;
using CrosshairPickerV1.Singleton;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Interop;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using System.Windows.Threading;

namespace CrosshairPickerV1
{
    /// <summary>
    /// Interaction logic for Crosshiar.xaml
    /// </summary>
    public partial class Crosshair : Window
    {

        private Ellipse _ellipse;
  
        public Crosshair()
        {
            InitializeComponent();
            this.WindowState = WindowState.Maximized;
        }
        private void PositionOverlayOnTop()
        {
            var hwnd = new WindowInteropHelper(this).Handle;
            DllHelper.SetWindowPos(
                hwnd,
                DllHelper.HWND_TOPMOST, 
                0, 
                0, 
                (int)SystemParameters.PrimaryScreenWidth,
                (int)SystemParameters.PrimaryScreenHeight, 
                DllHelper.SWP_NOMOVE |
                DllHelper.SWP_NOSIZE |
                DllHelper.SWP_NOACTIVATE |
                DllHelper.SWP_SHOWWINDOW
                );
        }


        private async void Crosshair_Loaded(object sender, RoutedEventArgs e)
        {
            PositionOverlayOnTop();
            DrawOverlay();
        }

        private async void DrawOverlay()
        {
            CrosshairCrossSingleton.Instance.CanvasSetCrosshair(25, CrosshairCrossSingleton.Instance.CrosshairCross.CrosshairColor);

            OverlayCanvas.Children.Add(CrosshairCrossSingleton.Instance.CrosshairCross.VerticalLineTop);
            OverlayCanvas.Children.Add(CrosshairCrossSingleton.Instance.CrosshairCross.VerticalLineBottom);
       
            //horizontal Lines
            OverlayCanvas.Children.Add(CrosshairCrossSingleton.Instance.CrosshairCross.HorizontalLineLeft);
            OverlayCanvas.Children.Add(CrosshairCrossSingleton.Instance.CrosshairCross.HorizontalLineRight);


            CrosshairCrossSingleton.Instance.CrosshairCross.VerticalLineTop.Visibility = Visibility.Visible;
            CrosshairCrossSingleton.Instance.CrosshairCross.VerticalLineBottom.Visibility = Visibility.Visible;
            CrosshairCrossSingleton.Instance.CrosshairCross.HorizontalLineLeft.Visibility = Visibility.Visible;
            CrosshairCrossSingleton.Instance.CrosshairCross.HorizontalLineRight.Visibility = Visibility.Visible;
            // functionality to come later
            // a switch button to make it hide for 1fps aim shooters
            await Task.Run(async () =>
            {
                while (true)
                {
                    Dispatcher?.Invoke(() =>
                    {
                        if (DllHelper.MouseRightButtonIsPressed())
                        {
                            CrosshairCrossSingleton.Instance.CrosshairCross.VerticalLineTop.Visibility = Visibility.Collapsed;
                            CrosshairCrossSingleton.Instance.CrosshairCross.VerticalLineBottom.Visibility = Visibility.Collapsed;
                            CrosshairCrossSingleton.Instance.CrosshairCross.HorizontalLineLeft.Visibility = Visibility.Collapsed;
                            CrosshairCrossSingleton.Instance.CrosshairCross.HorizontalLineRight.Visibility = Visibility.Collapsed;
                        }
                        else
                        {
                            CrosshairCrossSingleton.Instance.CrosshairCross.VerticalLineTop.Visibility = Visibility.Visible;
                            CrosshairCrossSingleton.Instance.CrosshairCross.VerticalLineBottom.Visibility = Visibility.Visible;
                            CrosshairCrossSingleton.Instance.CrosshairCross.HorizontalLineLeft.Visibility = Visibility.Visible;
                            CrosshairCrossSingleton.Instance.CrosshairCross.HorizontalLineRight.Visibility = Visibility.Visible;
                        }
                    });
                    await Task.Delay(125);
                }
            });

        }


    }
}
