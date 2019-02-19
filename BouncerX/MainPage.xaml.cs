using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace BouncerX
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        int _attendantCount = 0;
        public MainPage()
        {
            this.InitializeComponent();
        }

        void MainPage_Loaded(object sender, RoutedEventArgs e)
        {
            DisplayAttendants();
        }


        void DisplayAttendants()
        {
            txt_attendants.Text = $"{_attendantCount} Attendants";
        }

        void Btn_add_Click(object sender, RoutedEventArgs e)
        {
            _attendantCount++;
            DisplayAttendants();
        }

        void RemoveAttendant(object sender, RoutedEventArgs e)
        {
            if (_attendantCount > 0)
                _attendantCount--;
            DisplayAttendants();
        }

        void ResetAttendants(object sender, RoutedEventArgs e)
        {
            _attendantCount = 0;
            DisplayAttendants();
        }
    }
}
