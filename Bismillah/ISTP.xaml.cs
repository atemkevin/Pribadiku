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
    public sealed partial class ISTP : Page
    {
        public ISTP()
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
            ResultTextBlock.Text = " - Tenang, pendiam, cenderung kaku, dingin, hati-hati, penuh pertimbangan. \r\n - Logis, rasional, kritis, obyektif, mampu mengesampingkan perasaan. \r\n - Mampu menghadapi perubahan mendadak dengan cepat dan tenang. \r\n - Percaya diri, tegas dan mampu menghadapi perbedaan maupun kritik. \r\n - Mampu menganalisa, mengorganisir, & mendelegasikan. \r\n - Problem solver yang baik terutama untuk masalah teknis & keadaan mendadak.";
        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            ResultTextBlock.Text = " - Observasilah kehidupan sosial, apa yang membuat orang marah, cinta, senang, termotivasi & terapkan pada hubungan Anda. \r\n - Belajarlah untuk mengenali perasaan Anda dan mengekspresikannya. \r\n - Jadilah orang yang lebih terbuka, keluar dari zona nyaman, eksplorasi ide baru, dan berdiskusi dengan orang lain. \r\n - Jangan mencari-cari kesalahan orang hanya untuk menyelesaikan masalahnya. \r\n - Jangan menyimpan informasi yang harusnya dibagi dan belajarlah mempercayakan tanggungjawab pada orang lain.";
        }

        private void button2_Click(object sender, RoutedEventArgs e)
        {
            ResultTextBlock.Text = " - Tertarik pada bagaimana dan mengapa sesuatu daoat bekerja. \r\n - Tidak berfungsi dengan baik dalam keteraturan, atau lingkungan yang terstruktur; mereka akan merasa letih atau menjadi sangat bosan. \r\n - Terus-menerus mengumpulkan fakta tentang lingkungan mereka, lalu menyimpannya. \r\n - Memiliki kemampuan yang sangat baik untuk menerapkan logika \r\n - Turun tangan langsung adalah cara belajar terbaik mereka. \r\n - Biasanya mampu menguasai teori dan pemikiran abstrak.  \r\n - Berorientasi pada tindakan. \r\n - Berfokus pada hidup di masa sekarang, bukan masa depan. \r\n - Sangat menyukai keberagaman dan pengalaman baru. \r\n - Sangat praktis dan realistis. \r\n - Pemecah masalah yang hebat, dapat dengan cepat menemukan solusi untuk berbagai masalah praktis. \r\n - Berorientasi pada hasil; mereka ingin melihat hasil yang langsung atas upaya mereka. \r\n - Biasanya santai dan sederhana dengan orang lain. \r\n - Pengambil resiko, yang tumbuh dengan tindakan. \r\n - Independen dan ditentukan – biasanya tidak suka melakukan sendiri. \r\n - Biasanya cukup percaya diri.";
        }

        private void button3_Click(object sender, RoutedEventArgs e)
        {
            ResultTextBlock.Text = " - Tom Cruise, actor \r\n - Keith Richards, musician \r\n - James Dean, actor \r\n - Clint Eastwood, actor \r\n - Zachary Taylor, U.S. President \r\n - Chuck Yeager, U.S. Air Force officer \r\n - Alan Shepherd, astronaut \r\n - Amelia Earhart, aviator \r\n - Frida Kahlo, artist \r\n - Tiger Woods, golfer";
        }

        private void button4_Click(object sender, RoutedEventArgs e)
        {
            ResultTextBlock.Text = " - Polisi atau Detektif  \r\n - Ahli Forensik \r\n - Programmer Komputer atau Sistem Analis \r\n - Insinyur \r\n - Pemahat \r\n - Mekanik \r\n - Pilot, atau Pengendara \r\n - Atlet \r\n - Pengusaha";
        }
    }
}
