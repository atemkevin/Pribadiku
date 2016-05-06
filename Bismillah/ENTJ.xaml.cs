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
    public sealed partial class ENTJ : Page
    {
        public ENTJ()
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

        private void appButton2_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Exit();
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
            ResultTextBlock.Text = " - Tegas, asertif, to the point, jujur terus terang, obyektif, kritis, & punya standard tinggi. \r\n - Dominan, kuat kemauannya, perfeksionis dan kompetitif. \r\n - Tangguh, disiplin, dan sangat menghargai komitmen. \r\n - Cenderung menutupi perasaan dan menyembunyikan kelemahan. \r\n - Berkarisma, komunikasi baik, mampu menggerakkan orang. \r\n - Berbakat pemimpin.";
        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            ResultTextBlock.Text = " - Belajarlah untuk relaks. Tidak perlu perfeksionis dan selalu kompetitif dengan semua orang. \r\n - Ungkapkan perasaan Anda. Menyatakan perasaan bukanlah kelemahan. \r\n - Belajarlah mengelola emosi Anda. \r\n - Jangan mudah marah. \r\n - Belajarlah untuk menghargai dan mengapresiasi orang lain. \r\n - Jangan terlalu arogan dan menganggap remeh orang lain. \r\n - Lihat sisi positifnya. Jangan hanya melihat benar dan salah saja.";
        }

        private void button2_Click(object sender, RoutedEventArgs e)
        {
            ResultTextBlock.Text = " - Terdorong untuk mengubah teori menjadi rencana. \r\n - Sangat menghargai Pengetahuan. \r\n - Berorientasi pada masa depan. \r\n - Pemimpin alami. \r\n - Tak sabar dengan sesuatu yang tidak efisien dan ketidakmampuan. \r\n - Menginginkan hal-hal terstruktur dan teratur. \r\n - Memiliki keterampilan komunikasi verbal yang baik. \r\n - Tidak menyukai rutinitas, berorientasi pada detail dalam menyelesaikan tugas. \r\n - Percaya diri. \r\n - Menentukan.";
        }

        private void button3_Click(object sender, RoutedEventArgs e)
        {
            ResultTextBlock.Text = " - Aristoteles (Tokoh Filsafat Yunani) \r\n - Margaret Thatcher, former British Prime Minister \r\n - Franklin D. Roosevelt, former U.S. President \r\n - Candace Bergen, actress \r\n - Al Gore, former U.S. Vice President \r\n - Harrison Ford, actor \r\n - David Letterman, television host \r\n - Richard M. Nixon, former U.S. President \r\n - Patrick Stewart, actor";
        }

        private void button4_Click(object sender, RoutedEventArgs e)
        {
            ResultTextBlock.Text = " - Staf Pelaksana Perusahaan \r\n - Pengusaha \r\n - Konsultan Komputer \r\n - Pengacara \r\n - Hakim \r\n - Pimpinan Usaha atau Manajer \r\n - Profesor atau Pengelola Universitas ";
        }
    }
}
