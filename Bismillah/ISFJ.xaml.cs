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
    public sealed partial class ISFJ : Page
    {
        public ISFJ()
        {
            this.InitializeComponent();
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

        private void appbutton3_Click(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(PenjelasanAwal));
        }

        private void appButton1_Click(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(Menu));
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            ResultTextBlock.Text = " - Penuh pertimbangan, hati-hati, teliti dan akurat. \r\n - Serius, tenang, stabil namun sensitif. \r\n - Ramah, perhatian pada perasaan & kebutuhan orang lain, setia, kooperatif, pendengar yang baik. \r\n - Punya kemampuan mengorganisasi, detail, teliti, sangat bertanggungjawab & bisa diandalkan.";
        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            ResultTextBlock.Text = " - Lihat lebih dalam, lebih antusias, & lebih semangat. \r\n - Belajarlah mengatakan AtidakA. Jangan menyenangkan semua orang atau Anda dianggap plin plan. \r\n - Jangan terjebak zona nyaman dan rutinitas. Cobalah hal baru.";
        }

        private void button2_Click(object sender, RoutedEventArgs e)
        {
            ResultTextBlock.Text = " - Seorang yang kaya akan informasi yang mereka kumpulkan mengenai manusia. \r\n - Sangat jeli dalam memahami perasaan, dan reaksi orang lain. \r\n - Memiliki ingatan yang baik untuk hal-hal rincin yang penting bagi mereka. \r\n - Sangat selaras dengan lingkungan sekitar mereka. \r\n - Dapat diandalkan untuk mengikuti hal-hal sampai selesai. \r\n - Stabil, praktis, bersahaja mereka tidak suka bekerja dengan teori dan pemikiran abstrak. \r\n - Tidak suka melakukan hal-hal yang tidak masuk akal bagi mereka \r\n - Memegang nilai keamanan, tradisi, dan hidup damai \r\n - Berorientasi pada layanan: berfokus pada apa yang orang butuhkan dan inginkan. \r\n - Baik dan penuh perhatian. \r\n - Cenderung menempatkan kebutuhan orang lain di atas mereka sendiri. \r\n - Mereka belajar dengan baik dengan turun tangan langsung. \r\n - Senang menciptakan struktur dan ketertiban. \r\n - Mereka mengmbil tanggung jawab dengan serius. \r\n - Sangat tidak nyaman dengan konflik dan konfrontasi.";
        }

        private void button3_Click(object sender, RoutedEventArgs e)
        {
            ResultTextBlock.Text = " - Mother Teresa, nun and humanitarian \r\n - Louisa May Alcott, author \r\n - Elizabeth II, Queen of England \r\n - Robert E. Lee, general \r\n - Mary I, Queen of England \r\n - Kristi Yamaguchi, figure skater \r\n - Michael Caine, actor \r\n - Alfred, Lord Tennyson, poet";
        }

        private void button4_Click(object sender, RoutedEventArgs e)
        {
            ResultTextBlock.Text = "Dekorator Interior \r\n - Desainer \r\n - Perawat \r\n - Pengelola, dan Manajer \r\n - Asisten Administratif \r\n - Pemerhati Anak / Early Childhood Development \r\n - Pekerja Sosial / Penasihat \r\n - Pembantu Pengacara \r\n - Bidang Keagamaan \r\n - Pimpinan Usaha \r\n - Pemilik Toko \r\n - Manager Keuangan \r\n - Konsultan Ekonomi Rumahan";
        }
    }
}
