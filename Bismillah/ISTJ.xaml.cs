using System;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Popups;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234238

namespace Bismillah
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class ISTJ : Page

    {
        public ISTJ()
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
            ResultTextBlock.Text = " - Serius, tenang, stabil & damai. \r\n - Senang pada fakta, logis, obyektif, praktis & realistis. \r\n - Task oriented, tekun, teratur, menepati janji, dapat diandalkan & bertanggung jawab. \r\n - Pendengar yang baik, setia, hanya mau berbagi dengan orang dekat. \r\n - Memegang aturan, standar & prosedur dengan teguh.";
        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            ResultTextBlock.Text = " - Belajarlah memahami perasaan & kebutuhan orang lain. \r\n - Kurangi keinginan untuk mengontrol orang lain atau memerintah mereka untuk menegakkan aturan. \r\n - Lihatlah lebih banyak sisi positif pada orang lain atau hal lainnya. \r\n - Terbukalah terhadap perubahan.";
        }

        private void button2_Click(object sender, RoutedEventArgs e)
        {
            ResultTextBlock.Text = " - Menjunjung tinggi nilai tradisi, kesejahteraan, dan kedamaian hidup \r\n - Loyal, dan setia \r\n - Stabil, praktis dan membumi \r\n - Orinetasi Keluarga \r\n - Tidak suka melakukan hal-hal yang tidak masuk akal bagi mereka \r\n - Tidak menyukai teori abstrak, kecuali mereka melihat aplikasi praktis \r\n - Pemimpin alami \r\n - Lebih suka bekerja sendiri, tetapi bekerja dengan baik dalam tim bila diperlukan \r\n - Sangat jeli, mereka mengambil fakta melalui indera mereka dan menyimpannya secara internal \r\n - Memiliki batin yang kaya akan fakta  \r\n - Rasa menghargai yang mendalam untuk fakta dan informasi yang konkrit \r\n - Membuat keputusan secara obyektif, menerapkan logika dan berpikir rasional \r\n - Tidak menyukai perubahan, kecuali hal itu membawa manfaat secara konkrit \r\n - Memiliki pendapat yang kuat tentang bagaimana sesuatu harus dilakukan \r\n - Menghargai lingkungan yang terstruktur dan tertib \r\n - Memiliki standar yang sangat tinggi tentang perilaku mereka sendiri, ataupun perilaku orang lain \r\n - Tidak secara alami dipengaruhi oleh perasaan orang lain \r\n - Hampir mampu mencapai segala hal, jika mereka menaruh konsentrasi mereka untuk itu \r\n - Dikenal sebagai “Masyarakat yang baik”";
        }

        private void button3_Click(object sender, RoutedEventArgs e)
        {
            ResultTextBlock.Text = " - George Washington, U.S. President \r\n - Henry Ford, inventor \r\n - Johnny Carson, entertainer \r\n - Elizabeth II, Queen of England \r\n - Calvin Coolidge, U.S. President \r\n - Evander Holyfield, boxer \r\n - Warren Buffett, businessman";
        }

        private void button4_Click(object sender, RoutedEventArgs e)
        {
            ResultTextBlock.Text = " - Dokter \r\n - Eksekutif Bisnis, Administrator dan Manajer \r\n - Akuntan dan Pegawai Keuangan \r\n - Polisi dan Detektif \r\n - Hakim \r\n - Pengacara \r\n - Dokter/ Dokter Gigi \r\n - Pemrogram Komputer atau Sistem Analis \r\n - Pemimpin Militer ";
        }
    }
}
