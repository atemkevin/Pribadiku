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
    public sealed partial class ISFP : Page
    {
        public ISFP()
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
            ResultTextBlock.Text = " - Berpikiran simpel & praktis, fleksibel, sensitif, ramah, tidak menonjolkan diri, rendah hati pada kemampuannya. \r\n - Menghindari konflik, tidak memaksakan pendapat atau nilai-nilainya pada orang lain. \r\n - Biasanya tidak mau memimpin tetapi menjadi pengikut dan pelaksana yang setia. \r\n - Seringkali santai menyelesaikan sesuatu, karena sangat menikmati apa yang terjadi saat ini. \r\n - Menunjukkan perhatian lebih banyak melalui tindakan dibandingkan kata-kata.";
        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            ResultTextBlock.Text = " - Jangan takut pada penolakan dan konflik. Anda tidak perlu menyenangkan semua orang. \r\n - Cobalah untuk mulai memikirkan dampak jangka panjang dari keputusan-keputusan kecil di hari ini. \r\n - Asah dan kembangkan sisi kreatifitas dan seni dalam diri Anda sebagai modal bagus dalam diri Anda. \r\n - Cobalah untuk lebih terbuka dan mengekspresikan perasaan Anda.";
        }

        private void button2_Click(object sender, RoutedEventArgs e)
        {
            ResultTextBlock.Text = " - Kesadaran yang mendalam mengenai lingkungan mereka. \r\n - Hidup di saat sekarang. \r\n - Menyukai pergerakan yang lebih lambat – mereka ingin memiliki waktu untuk menikmati saat-saat mereka. \r\n - Tidak suka berurusan dengan teori atau pemikiran abstrak , kecuali mereka melihat aplikasi praktis. \r\n - Setia dan loyal kepada orang-orang dan ide-ide yang penting bagi mereka. \r\n - Individualistis, tidak memiliki keinginan untuk memimpin ataupun mengikuti. \r\n - Menyikapi sesuatu dengan serius, meskipun sering kali tak nampka. \r\n - Merasa memiliki ikatan khusus dengan anak-anak, dan binatang. \r\n - Tenang dan pendiam, kecuali dengan orang yang mereka kenal sangat baik. \r\n - Mempercayai, sensitif, dan baik hati. \r\n - Berorientasi pada pelayanan; mereka tergerakkan untuk membantu orang lain. \r\n - Apresiasi yang sangat baik untuk keindahan estetika. \r\n - Kemungkinan besar memiliki tindakan dan pemikiran yang orisinil dan tidak konvensional. \r\n - Turun tangan langsung adalah cara belajar terbaik mereka. \r\n - Tidak suka dibatasi oleh jadwal yang ketat ataupun aturan-aturan kehidupan. \r\n - Membutuhkan ruang dan kebebasan untuk melakukan hal-hal dengan cara mereka sendiri. \r\n - Tidak menyukai hal-hal biasa, tugas-tugas rutin, tetapi mereka akan melakukannya jika perlu.";
        }

        private void button3_Click(object sender, RoutedEventArgs e)
        {
            ResultTextBlock.Text = " - Fred Astaire, dancer \r\n - Marilyn Monroe, actress \r\n - Marie Antoinette, \r\n - Elizabeth Taylor, actress \r\n - Barbara Streisand, singer \r\n - Paul McCartney, musician \r\n - Auguste Rodin, sculptor \r\n - Wolfgang Amadeus Mozart, composer";
        }

        private void button4_Click(object sender, RoutedEventArgs e)
        {
            ResultTextBlock.Text = " - Seniman \r\n - Desainer \r\n - Pemerhati Anak \r\n - Pekerja Sosial/ Penasihat \r\n - Guru \r\n - Psikolog \r\n - Dokter Hewan \r\n - Polisi Hutan \r\n - Dokter Anak";
        }
    }
}
