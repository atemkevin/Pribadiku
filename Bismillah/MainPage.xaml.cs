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
using Windows.UI.Xaml.Media.Animation;
using Windows.UI.Popups;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234238

namespace Bismillah
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class Menu : Page
    {
        public Menu()
        {
            this.InitializeComponent();
        }
        private void button_Click(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(ISTJ));
        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(ISTP));
        }

        private void button2_Click(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(ESTP));
        }

        private void button3_Click(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(ESTJ));
        }

        private void button4_Click(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(ISFJ));
        }

        private void button5_Click(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(ISFP));
        }

        private void button6_Click(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(ESFP));
        }

        private void button7_Click(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(ESFJ));
        }

        private void button8_Click(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(INFJ));
        }

        private void button9_Click(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(INFP));
        }

        private void button10_Click(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(ENFP));
        }

        private void button11_Click(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(ENFJ));
        }

        private void button12_Click(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(INTJ));
        }

        private void button13_Click(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(INTP));
        }

        private void button14_Click(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(ENTP));
        }

        private void button15_Click(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(ENTJ));
        }

        private void appButton1_Click(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(PenjelasanAwal));
        }

        private void appbutton3_Click(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(about));
        }

        private async void appbutton2_Click(object sender, RoutedEventArgs e)
        {
            MessageDialog showdialog = new MessageDialog("Are you sure to exit?");
            showdialog.Commands.Add(new UICommand("Yes")
            {
                Id = 0
            });
            showdialog.Commands.Add(new UICommand("No")
            {
                Id = 1
            });
            showdialog.DefaultCommandIndex = 0;
            showdialog.CancelCommandIndex = 1;
            var result = await showdialog.ShowAsync();
            if ((int)result.Id == 0)
            {
                Application.Current.Exit();
            }
            else
            {

            }
        }
    }
    
}
