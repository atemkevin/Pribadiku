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
    public sealed partial class INTJ : Page
    {
        public INTJ()
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
            if ((int) result.Id == 0)
            {
                Application.Current.Exit();
            }
            else
            {

            }
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            ResultTextBlock.Text = " - Visioner, punya perencanaan praktis, & biasanya memiliki ide-ide original serta dorongan kuat untuk mencapainya. \r\n - Mandiri dan percaya diri. \r\n - Punya kemampuan analisa yang bagus serta menyederhanakan sesuatu yang rumit dan abstrak menjadi sesuatu yang praktis, mudah difahami & dipraktekkan. \r\n - Skeptis, kritis, logis, menentukan (determinatif) dan kadang keras kepala. \r\n - Punya keinginan untuk berkembang serta selalu ingin lebih maju dari orang lain. \r\n - Kritik & konflik tidak menjadi masalah berarti.";
        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            ResultTextBlock.Text = " - Belajarlah mengungkapkan emosi & perasaan Anda. \r\n - Cobalah untuk lebih terbuka pada dunia luar, banyak bergaul, banyak belajar, banyak membaca, mengunjungi banyak tempat, eksplorasi hal baru, & memperluas wawasan. \r\n - Hindari perdebatan tidak penting. \r\n - Belajarlah untuk berempati, memberi perhatian dan lebih peka terhadap orang lain.";
        }

        private void button2_Click(object sender, RoutedEventArgs e)
        {
            ResultTextBlock.Text = " - Mampu menyerap teori yang sangat kompleks dan berbagai materi yang kompleks. \r\n - Terdorong untuk menciptakan keteraturan dan struktur dari abstraksi teoritis. \r\n - Ahli dalam mengatur strategi. \r\n - Berorientasi pada masa depan. \r\n - Melihat secara global, “Gambaran Besar” \r\n - Memiliki wawasan kuat dan intuisi, yang mereka percaya secara implisit. \r\n - Lebih menghargai pendapat mereka sendiri atas dibanding orang lain. \r\n - Menyukai tantangan teoritis yang sulit. \r\n - Bosan ketika berhadapan dengan rutinitas biasa. \r\n - Menghargai nilai pengetahuan dan efisiensi. \r\n - Tidak sabar dengan ketidakefisienan dan kebingungan. \r\n - Memiliki standar yang sangat tinggi untuk kinerja, yang mereka terapkan paling kuat untuk diri mereka sendiri. \r\n - Pendiam dan terpisah dari orang lain. \r\n - Tenang, mengumpulkan dan menganalisa. \r\n - Sangat logis dan rasional. \r\n - Asli dan independen. \r\n - Pemimpin alami, tetapi akan mengikuti orang-orang yang dapat mendukung mereka sepenuhnya. \r\n - Kreatif, cerdas, inovatif, dan banyak akal. \r\n - Bekerja terbaik jika sendiri, dan lebih memilih untuk bekerja sendiri.";
        }

        private void button3_Click(object sender, RoutedEventArgs e)
        {
            ResultTextBlock.Text = " - Thomas Jefferson, U.S. President \r\n - John F. Kennedy, U.S. President \r\n - C. S. Lewis, author \r\n - Jane Austen, author \r\n - Susan B. Anthony, civil rights leader \r\n - Arthur Ashe, tennis player \r\n - Emily Bronte, author";
        }

        private void button4_Click(object sender, RoutedEventArgs e)
        {
            ResultTextBlock.Text = " - Ahli Keilmuan \r\n - Insinyur \r\n - Profesor dan Pengaja \r\n - Dokter atau Dokter Gigi \r\n - Ahli Strategi Perusahaan \r\n - Pimpinan Perusahaan atau Manajer \r\n - Pimpinan Militer \r\n - Pengacara \r\n - Hakim \r\n - Programmer atau Sistem Analis";
        }
    }
}
