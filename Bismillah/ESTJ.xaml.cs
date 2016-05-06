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
    public sealed partial class ESTJ : Page
    {
        public ESTJ()
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
            ResultTextBlock.Text = " - Praktis, realistis, berpegang pada fakta, dengan dorongan alamiah untuk bisnis dan mekanistis. \r\n - Sangat sistematis, procedural dan terencana. \r\n - Disiplin, on time dan pekerja keras. \r\n - Konservatif dan cenderung kaku. \r\n - Tidak tertarik pada subject yang tidak berguna baginya, tapi dapat menyesuaikan diri jika diperlukan.";
        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            ResultTextBlock.Text = " - Kurangi keinginan untuk mengontrol dan memaksa orang lain. \r\n - Belajarlah untuk mengontrol emosi dan amarah Anda. \r\n - Cobalah untuk introspeksi diri dan meluangkan waktu sejenak untuk merenung. \r\n - Belajarlah untuk lebih sabar dan low profile \r\n - Belajarlah untuk memahami orang lain.";
        }

        private void button2_Click(object sender, RoutedEventArgs e)
        {
            ResultTextBlock.Text = " - Pemimpin alami – mereka ingin bertanggung jawab. \r\n - Menggenggam nilai keamanan dan tradisi. \r\n - Setia \r\n - Pekerja keras dan dapat diandalkan \r\n - Biasanya gemar berolahraga dan sehat. \r\n - Memiliki aturan standar dan keyakinan yang mereka hidup dengan itu. \r\n - Tidak ada kesabaran dengan ketidakmampuan atau ketidakefisienan. \r\n - Kemampuan organisasi baik. \r\n - Senang menciptakan ketertiban dan struktur. \r\n - Sangat teliti \r\n - Akan mengikuti sebuah pekerjaan sampai selesai. \r\n - Selalu Berterus terang dan jujur. \r\n - Selalu terdorong untuk memenuhi tugas mereka.";
        }

        private void button3_Click(object sender, RoutedEventArgs e)
        {
            ResultTextBlock.Text = " - James Monroe, U.S. President \r\n - Harry S.Truman, U.S. President \r\n - George W. Bush, U.S. President \r\n - Sam Walton, businessman \r\n - John D. Rockefeller, philanthropist and industrialist \r\n - Billy Graham, evangelist \r\n - Bette Davis, actress";
        }

        private void button4_Click(object sender, RoutedEventArgs e)
        {
            ResultTextBlock.Text = " - Pimpinan Militer \r\n - Pengelola Usaha and Manajer \r\n - Polisi / Detektif \r\n - Hakim \r\n - Petugas Keuangan \r\n - Pengajar \r\n - Tenaga Penjualan";
        }
    }
}
