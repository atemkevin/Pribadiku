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
    public sealed partial class ESFJ : Page
    {
        public ESFJ()
        {
            this.InitializeComponent();
        }

        private void appButton1_Click(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(Menu));
        }

        private void appbutton3_Click(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(PenjelasanAwal));
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
            ResultTextBlock.Text = " - Hangat, banyak bicara, populer, dilahirkan untuk bekerjasama, suportif dan anggota kelompok yang aktif. \r\n - Membutuhkan keseimbangan dan baik dalam menciptakan harmoni. \r\n - Selalu melakukan sesuatu yang manis bagi orang lain. Kerja dengan baik dalam situasi yang mendukung dan memujinya. \r\n - Santai, easy going, sederhana, tidak berfikir panjang. \r\n - Teliti dan rajin merawat apa yang ia miliki.";
        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            ResultTextBlock.Text = " - Jangan mengorbankan diri hanya untuk menyenangkan orang lain. \r\n - Jangan mengukur harga diri Anda dari perlakuan, penghargaan dan pujian orang lain. \r\n - Mintalah pertimbangan orang lain dalam mengambil keputusan. Belajarlah untuk lebih tegas. \r\n - Terima tanggungjawab hidup dan belajarlah untuk lebih dewasa. Jangan mengasihani diri sendiri. \r\n - Hadapi kritik dan konflik, jangan lari.";
        }

        private void button2_Click(object sender, RoutedEventArgs e)
        {
            ResultTextBlock.Text = " - Terorganisir. \r\n - Loyal. \r\n - Dapat diandalkan untuk mengikuti hal-hal sampai selesai. \r\n - Senang menciptakan ketertiban, struktur dan jadwal. \r\n - Senang berinteraksi dengan orang lain. \r\n - Ramah dan mudah bersimpati. \r\n - Cenderung menempatkan kebutuhan orang lain di atas mereka sendiri \r\n - Sangat baik dalam memberikan perawatan praktis. \r\n - Sangat kooperatif, anggota tim yang baik \r\n - Praktis dan bersahaja. \r\n - Memegang nilai kehidupan yang aman dan damai. \r\n - Senang pada keberagaman, namun dapat bekerja dengan baik dengan tugas-tugas rutin. \r\n - Membutuhkan persetujuan dari orang lain. \r\n - Memperoleh kepuasan dengan memberi kepada orang lain \r\n - Hidup di sini, dan saat ini – tidak suka berteori tentang masa depan.";
        }

        private void button3_Click(object sender, RoutedEventArgs e)
        {
            ResultTextBlock.Text = " - Terry Bradshaw, football player \r\n - Sally Field, actress \r\n - Bill Clinton, U.S. President \r\n - William McKinley, U.S. President \r\n - Nancy Kerrigan, figure skater";
        }

        private void button4_Click(object sender, RoutedEventArgs e)
        {
            ResultTextBlock.Text = " - Konsultan Ekonomi Rumahan \r\n - Perawat \r\n - Pengajar \r\n - Pengelola \r\n - Pemerhati Anak \r\n - Dokter Praktik Keluarga \r\n - Bidang Keagamaan \r\n - Pimpinan Usaha \r\n - Penasihat / Pekerja Sosial \r\n - Akuntan \r\n - Asisten Administratif";
        }
    }
}
