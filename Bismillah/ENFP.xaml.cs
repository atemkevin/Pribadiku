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
    public sealed partial class ENFP : Page
    {
        public ENFP()
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
            ResultTextBlock.Text = " - Ramah, hangat, enerjik, optimis, antusias, semangat tinggi, fun. \r\n - Imaginatif, penuh ide, kreatif, inovatif. \r\n - Mampu beradaptasi dengan beragam situasi dan perubahan. \r\n - Pandai berkomunikasi, senang bersosialisasi & membawa suasana positif. \r\n - Mudah membaca perasaan dan kebutuhan orang lain.";
        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            ResultTextBlock.Text = " - Belajarlah untuk fokus, disiplin, tegas dan konsisten. \r\n - Belajarlah untuk menghadapi konflik dan kritik. \r\n - Pikirkan kebutuhan diri sendiri. \r\n - Jangan melupakannya karena terlalu peduli pada kebutuhan orang lain. \r\n - Jangan terlalu boros. Belajarlah untuk mengelola keuangan sedikit demi sedikit.";
        }

        private void button2_Click(object sender, RoutedEventArgs e)
        {
            ResultTextBlock.Text = " - Berorientasi pada Proyek. \r\n - Cerdas dan mampu. \r\n - Hangat, benar-benar tertarik pada orang; orang dengan keterampilan baik. \r\n - Sangat intuitif dan perseptif tentang orang lain. \r\n - Mampu berhubungan dengan orang lain yang berada di tingkat mereka sendiri, \r\n - Berorientasi pada pelayanan; cenderung menempatkan kebutuhan orang lain di atas kebutuhan mereka sendiri. \r\n - Berorientasi pada masa depan. \r\n - Tidak suka melakukan tugas-tugas rutin. \r\n - Memerlukan persetujuan dan penghargaan dari orang lain. \r\n - Dapat bekerja sama dan ramah. \r\n - Kreatif dan energik. \r\n - Memiliki keterampilan komunikasi verbal dan tertulis yang baik. \r\n - Pemimpin alami, tapi tidak suka mengontrol orang. \r\n - Menolak untuk dikendalikan oleh orang lain. \r\n - Dapat bekerja secara logis dan rasional. \r\n - Biasanya mampu memahami konsep-konsep dan teori yang sulit.";
        }

        private void button3_Click(object sender, RoutedEventArgs e)
        {
            ResultTextBlock.Text = " - Andy Kaufmann, comedian \r\n - Bob Dylan, singer/songwriter \r\n - Charles Dickins, author \r\n - Dr. Seuss, children’s author \r\n - Robin Williams, actor \r\n - Will Smith, actor \r\n - Charlotte Bronte, author";
        }

        private void button4_Click(object sender, RoutedEventArgs e)
        {
            ResultTextBlock.Text = " - Konsultan \r\n - Psikolog \r\n - Pengusaha \r\n - Aktor \r\n - Guru \r\n - Penasihat \r\n - Politikus \r\n - Penulis/Jurnalis \r\n - Reporter Televisi \r\n - Programmer/System Analyst \r\n - Pakar Ilmu Pengetahuan \r\n - Insinyur \r\n - Seniman";
        }
    }
}
