using System;
using Windows.UI.Popups;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234238

namespace Bismillah
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class ENFJ : Page
    {
        public object PresetPopup { get; private set; }

        public ENFJ()
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
            ResultTextBlock.Text = " - Kreatif, imajinatif, peka, sensitive, loyal. \r\n - Pada umumnya peduli pada apa kata orang atau apa yang orang lain inginkan. \r\n - Cenderung melakukan sesuatu dengan memperhatikan perasaan orang lain. \r\n - Pandai bergaul, meyakinkan, ramah, fun, populer, simpatik. \r\n - Responsif pada kritik dan pujian. \r\n - Menyukai variasi dan tantangan baru. \r\n - Butuh apresiasi dan penerimaan";
        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            ResultTextBlock.Text = " - Jangan mengorbankan diri hanya untuk menyenangkan orang lain. \r\n - Jangan mengukur harga diri Anda dari perlakuan orang lain. \r\n - Belajarlah untuk tegas dan mengambil keputusan. \r\n - Jangan terlalu bersikap keras terhadap diri sendiri. \r\n - Jangan mudah kecewa jika mereka tidak seperti yang Anda inginkan.";
        }

        private void button2_Click(object sender, RoutedEventArgs e)
        {
            ResultTextBlock.Text = " - Benar-benar hangat dan tertarik pada orang lain. \r\n - Memegang nilai-nilai tentang perasaan orang lain. \r\n - Memegang nilai-nilai Struktur dan organisasi. \r\n - Memegang nilai-nilai harmoni, dan baik dalam menciptakan hal itu. \r\n - Memiliki keterampilan yang sangat baik. \r\n - Tidak menyukai logika impersonal dan analisis.Kemampuan organisasi yang kuat.\r\n - Loyal dan jujur. \r\n - Kreatif dan imajinatif. \r\n - Menyukai variasi dan tantangan baru. \r\n - Mendapatkan kepuasan pribadi dengan membantu orang lain. \r\n - Sangat sensitif terhadap kritik dan perpecahan. \r\n - Membutuhkan persetujuan dari orang lain untuk merasa baik tentang diri mereka sendiri.";
        }

        private void button3_Click(object sender, RoutedEventArgs e)
        {
            ResultTextBlock.Text = " - Abraham Lincoln, U.S. president \r\n - Sean Connery, actor \r\n - Dennis Hopper, actor \r\n - Diane Sawyer, journalist \r\n - Johnny Depp, actor \r\n - Oprah Winfrey, TV personality \r\n - Abraham Maslow, psychologist \r\n - Ronald Reagan, U.S. president \r\n - Peyton Manning, football player \r\n - Barack Obama, U.S. president";
        }

        private void button4_Click(object sender, RoutedEventArgs e)
        {
            ResultTextBlock.Text = " - Konsultan \r\n - Psikolog \r\n - Pekerja Sosial/Penasihat \r\n - Pengajar \r\n - Bidang Keagamaan \r\n - Tenaga Penjualan \r\n - Pengelola SDM \r\n - Manajer \r\n - Koordinator Acara \r\n - Politikus/Diplomat \r\n - Penulis \r\n - Fasilitator";
        }
    }
}