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

namespace Test_ASM_UWP
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        private string CurrentTag = "";

        public MainPage()
        {
            this.InitializeComponent();
            this.My_Frame.Navigate(typeof(Views.Home));
        }

        private void RadioButton_Click(object sender, RoutedEventArgs e)
        {
            RadioButton radio = sender as RadioButton;
            if (CurrentTag == radio.Tag.ToString())
            {
                return;
            }
            switch (radio.Tag.ToString())
            {
                case "Home":
                    CurrentTag = "Home";
                    this.My_Frame.Navigate(typeof(Views.Home));
                    break;
                case "loginPage":
                    CurrentTag = "loginPage";
                    this.My_Frame.Navigate(typeof(Views.Login));
                    break;
                case "registerPage":
                    CurrentTag = "registerPage";
                    this.My_Frame.Navigate(typeof(Views.RegisterPage));
                    break;
                case "addSong":
                    CurrentTag = "addSong";
                    this.My_Frame.Navigate(typeof(Views.AddMusic));
                    break;
                case "listSong":
                    CurrentTag = "listSong";
                    this.My_Frame.Navigate(typeof(Views.ListMusic));
                    break;
                case "Logout":
                    CurrentTag = "Logout";
                    /*Logout(); */
                    var rootFrame = Window.Current.Content as Frame;
                    rootFrame.Navigate(typeof(Views.Login));
                    break;
            }
        }

        private void btn_bar_Click(object sender, RoutedEventArgs e)
        {
            this.My_SplitView.IsPaneOpen = !this.My_SplitView.IsPaneOpen;
        }
    }
}
