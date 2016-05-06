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
    public sealed partial class ESTP : Page
    {
        public ESTP()
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
            ResultTextBlock.Text = " - Komunikator, asertif, to the point, ceplas-ceplos, berkarisma, punya interpersonal skill yang baik. \r\n - Baik dalam pemecahan masalah langsung di tempat. Mampu menghadapi masalah, konflik dan kritik. Tidak khawatir, menikmati apapun yang terjadi. \r\n - Cenderung untuk menyukai sesuatu yang mekanistis, kegiatan bersama dan olahraga. \r\n - Mudah beradaptasi, toleran, pada umumnya konservatif tentang nilai-nilai. \r\n - Tidak suka penjelasan terlalu panjang. Paling baik dalam hal-hal nyata yang dapat dilakukan. \r\n - Spontan, Aktif, Enerjik, Cekatan, Cepat, Sigap, Antusias, Fun dan penuh variasi.";
        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            ResultTextBlock.Text = " - Belajarlah memahami perasaan dan pemikiran orang lain terutama saat bicara dengan mereka. \r\n - Belajarlah untuk sabar, menikmati proses, tidak semua hal bisa dicapai dengan cepat. \r\n - Sesekali luangkan waktu untuk merenung dan merencanakan masa depan Anda. \r\n - Cobalah untuk mencatat pengamatan-pengamatan Anda termasuk detailnya.";
        }

        private void button2_Click(object sender, RoutedEventArgs e)
        {
            ResultTextBlock.Text = " - Berorientasi pada tindakan. \r\n - Hidup pada saat ini. \r\n - Tidak menyukai teori abstrak tanpa aplikasi praktis. \r\n - Ingin melihat hasil yang langsung atas tindakan mereka. \r\n - Serba cepat dan energik \r\n - Fleksibel dan mudah beradaptasi. \r\n - Banyak akal \r\n - Jarang bekerja dengan perencanaan – melakukan sesuatu sesuai keadaan. \r\n - Menyenangkan berada di sekitar mereka. \r\n - Sangat jeli. \r\n - Memori yang sangat baik untuk rincian. \r\n - Seorang yang berketerampilan baik. \r\n - Bersifat baik hati. \r\n - Kemampuan yang sangat baik untuk melihat masalah dengan segera, dan cepat dalam menemukan solusi. \r\n - Tertarik dengan petualangan dan risiko. \r\n - Biasanya mencolok atau mengesankan.";
        }

        private void button3_Click(object sender, RoutedEventArgs e)
        {
            ResultTextBlock.Text = " - James Buchanan, U.S. President \r\n - Madonna, singer \r\n - Chuck Yeager, U.S. Air Force General and pilot \r\n - Donald Trump, businessman \r\n - Lucille Ball, actress";
        }

        private void button4_Click(object sender, RoutedEventArgs e)
        {
            ResultTextBlock.Text = " - Tenaga Penjualan \r\n - Tenaga Pemasaran \r\n - Polisi / Detektif \r\n - Paramedis \r\n - Teknisi Komputer atau Teknisi Pengkabelan Jaringan \r\n - Technical Support Komputer \r\n - Pengusaha \r\n - Atlet";
        }
    }
}
