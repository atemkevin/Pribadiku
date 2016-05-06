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
    public sealed partial class ESFP : Page
    {
        public ESFP()
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
            ResultTextBlock.Text = "- Outgoing, easygoing, mudah berteman, bersahabat, sangat sosial, ramah, hangat, & menyenangkan.\r\n - Optimis, ceria, antusias, fun, menghibur, suka menjadi perhatian. \r\n - Punya interpersonal skill yang baik, murah hati, mudah simpatik dan mengenali perasaan orang lain. \r\n - Menghindari konflik dan menjaga keharmonisan suatu hubungan. \r\n - Mengetahui apa yang terjadi di sekelilingnya dan ikut serta dalam kegiatan tersebut. \r\n - Sangat baik dalam keadaan yang membutuhkan common sense, tindakan cepat dan ketrampilan praktis.";
        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            ResultTextBlock.Text = " - Jangan terburu-buru dalam mengambil keputusan. Belajarlah untuk focus dan tidak mudah berubah-ubah terutama untuk hal yang penting. \r\n - Jangan menyenangkan semua orang. Begitu pula sebaliknya, tidak semua orang bisa menyenangkan Anda. \r\n - Belajarlah menghadapi kritik dan konflik. Jangan lari. \r\n - Anda punya kecenderungan meterialistis. Hati-hati, tidak semua hal bisa diukur dengan materi ataupun uang.";
        }

        private void button2_Click(object sender, RoutedEventArgs e)
        {
            ResultTextBlock.Text = " - Hidup di saat sekarang. \r\n - Merasa bersemangat dan gembira dengan pengalaman baru. \r\n - Praktis dan realistis. \r\n - Hangat, dan tertarik pada hubungan dengan orang lain. \r\n - Tahu bagaimana memiliki waktu yang menyenangkan, dan bagaimana menciptakan hal-hal yang menyenangkan untuk orang lain \r\n - Independen dan cerdas. \r\n - Spontan – jarang merencanakan. \r\n - Tidak menyukai struktur dan rutin \r\n - Tidak menyukai teori, dan penjelasan panjang yang tertulis. \r\n - Merasa memiliki ikatan khusus dengan anak-anak, dan binatang. \r\n - Apresiasi estetika sangat dikembangkan untuk hal-hal \r\n - Seorang dengan keterampilan yang hebat.";
        }

        private void button3_Click(object sender, RoutedEventArgs e)
        {
            ResultTextBlock.Text = " - Bill Clinton, U.S. President \r\n - Ronald Reagan, U.S. President \r\n - Bob Hope, actor \r\n - Marilyn Monroe, actress \r\n - Pablo Picasso, artist \r\n - Woody Harrelson, actor \r\n - Goldie Hawn, actress \r\n - Saint Mark, apostle";
        }

        private void button4_Click(object sender, RoutedEventArgs e)
        {
            ResultTextBlock.Text = " - Seniman, Performers and Actors \r\n - Tenaga Penjualan \r\n - Penasihat / Pekerja Sosial \r\n - Pemerhati Anak \r\n - Desainer Pakaian \r\n - Dekorator Interior \r\n - Konsultan \r\n - Fotografer";
        }
    }
}
