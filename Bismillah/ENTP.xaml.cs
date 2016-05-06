using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Popups;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234238

namespace Bismillah
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class ENTP : Page
    {
        public ENTP()
        {
            this.InitializeComponent();
        }

        private void appbutton3_Click(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(PenjelasanAwal));
        }

        private void appButton1_Click(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(Menu));
        }

        private async void appexit_Click(object sender, RoutedEventArgs e)
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

        private void button_Click(object sender, RoutedEventArgs e)
        {
            ResultTextBlock.Text = " - Gesit, kreatif, inovatif, cerdik, logis, baik dalam banyak hal. \r\n - Banyak bicara dan punya kemampuan debat yang baik. \r\n - Bisa berargumentasi untuk senang-senang saja tanpa merasa bersalah. \r\n - Fleksibel. Punya banyak cara untuk memecahkan masalah dan tantangan. \r\n - Kurang konsisten. Cenderung untuk melakukan hal baru yang menarik hati setelah melakukan sesuatu yang lain. \r\n - Punya keinginan kuat untuk mengembangkan diri.";
        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            ResultTextBlock.Text = " - Cobalah untuk win-win solution. Jangan ingin menang sendiri. \r\n - Belajarlah untuk disiplin dan konsisten. \r\n - Hindari perdebatan tidak penting. \r\n - Belajarlah untuk sedikit waspada. \r\n - Belajarlah untuk memberi perhatian pada perasaan orang lain.";
        }

        private void button2_Click(object sender, RoutedEventArgs e)
        {
            ResultTextBlock.Text = " - Berorientasi pada proyek. \r\n - Merasa senang ketika membuat ide dan teori. \r\n - Kreatif dan berbakat. \r\n - Cerdas dan mampu. \r\n - Fleksibel dan multi talent. \r\n - Keterampilan komunikasi yang baik. \r\n - Senang memperdebatkan suatu masalah dengan orang lain. \r\n - Seorang yang memiliki keterampilan yang baik. \r\n - Pemimpin alami, tapi tidak suka mengontrol orang lain. \r\n - Menolak untuk dikendalikan oleh orang lain. \r\n - Bersemangat dan energik; mampu memotivasi orang lain. \r\n - Sangat menghargai Pengetahuan dan kompetensi. \r\n - Logis, pemikir rasional. \r\n - Mampu memahami konsep-konsep yang sulit dan teori. \r\n - Senang memecahkan masalah yang sulit. \r\n - Tidak suka dibatasi jadwal dan lingkungan. \r\n - Tidak menukai rutinitas, tugas-tugas terperinci.";
        }

        private void button3_Click(object sender, RoutedEventArgs e)
        {
            ResultTextBlock.Text = " - Thomas Edison, inventor \r\n - John Adams, U.S. president \r\n - Theodore Roosevelt, U.S. president \r\n - Alexander the Great, king and military leader \r\n - Lewis Carroll, author \r\n - Julia Child, cook \r\n - Alfred Hitchcock, director \r\n - Walt Disney, filmmaker";
        }

        private void button4_Click(object sender, RoutedEventArgs e)
        {
            ResultTextBlock.Text = " - Pengacara \r\n - Psikolog \r\n - Pebisnis \r\n - Fotografer \r\n - Konsultant \r\n - Insinyur \r\n - Ahli Keilmuan \r\n - Aktor \r\n - Staf Penjualan \r\n - Staf Pemasaran \r\n - Programmer Atau Sistem Analis";
        }
    }
}
