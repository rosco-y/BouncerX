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
        Occasion _occasion;

        public MainPage()
        {
            this.InitializeComponent();
            _occasion = new Occasion();
        }

        void MainPage_Loaded(object sender, RoutedEventArgs e)
        {
            DisplayAttendants();
        }


        void DisplayAttendants()
        {
            txt_attendants.DataContext = null;
            txt_attendants.DataContext = _occasion;
        }

        void Btn_add_Click(object sender, RoutedEventArgs e)
        {
            _occasion.Enter();
            DisplayAttendants();
        }

        void RemoveAttendant(object sender, RoutedEventArgs e)
        {
            _occasion.Leave();
            DisplayAttendants();
        }

        void ResetAttendants(object sender, RoutedEventArgs e)
        {
            _occasion = new Occasion();
            DisplayAttendants();
        }
    }
}
