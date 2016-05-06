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
    public sealed partial class INFJ : Page
    {
        public INFJ()
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
            ResultTextBlock.Text = " - Perhatian, empati, sensitif & berkomitmen terhadap sebuah hubungan. \r\n - Sukses karena ketekunan, originalitas dan keinginan kuat untuk melakukan apa saja. \r\n - Idealis, perfeksionis, memegang teguh prinsip. \r\n - Visioner, penuh ide, kreatif, suka merenung dan inspiring. \r\n - Biasanya diikuti dan dihormati karena kejelasan visi serta dedikasi pada hal-hal baik.";
        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            ResultTextBlock.Text = " - Seimbangkan cara pandang Anda. Jangan hanya melihat sisi negatif & resiko. Namun,lihatlah sisi positif dan peluangnya. \r\n - Bersabarlah, jangan mudah marah dan menyalahkan orang lain atau situasi. \r\n - Rileks dan jangan terus menerus berfikir atau menyelesaikan tanggungjawab.";
        }

        private void button2_Click(object sender, RoutedEventArgs e)
        {
            ResultTextBlock.Text = " - Intuitif dalam memahami orang dan situasi. \r\n - Idealistis, dan Perfeksionis. \r\n - Berorientasi pada Masa Depan. \r\n - Memegang Teguh prinsip. \r\n - Kompleks dan mendalam. \r\n - Pemimpin alami. \r\n - Sensitif dan penuh kasih terhadap orang lain. \r\n - Berorientasi pada Pelayanan. \r\n - Pendiman dan kadang nampak tak ramah, adalah gambaran ekspresi sejati merka. \r\n - Menghargai hubungan autentik dengan mendalam. \r\n - Berkomitmen terhadap sebuah hubungan. \r\n - Tidak suka berurusan rincian kecuali itu kaitannya dalam meningkatkan visi mereka. \r\n - Terus-menerus mencari makna dan tujuan dalam segala hal. \r\n - Visioner, Penuh Ide, Kreatif, Suka Merenung dan Menginspirasi. \r\n - Biasanya diikuti dan dihormati karena kejelasan visi serta dedikasi pada hal-hal baik. \r\n - Bersemangat, dan Mudah merasa terlukai (sensitif). \r\n - Mampu bekerja secara logis dan rasional, menggunakan intuisi mereka untuk memahami tujuan dan bekerja untuk mencapai tujuan tersebut.";
        }

        private void button3_Click(object sender, RoutedEventArgs e)
        {
            ResultTextBlock.Text = " - Billy Crystal, actor \r\n - Plato, Tokoh Filsafat Yunani \r\n - Carl Gustav Jung, Psychiatrist \r\n - Niels Bohr, Physicist \r\n - Mary Wollstonecraft, Philosopher \r\n - Adolf Hitler, Nazi \r\n - George Harrison(The Beatles) \r\n - Chaucer, poet \r\n - Gillian Anderson, actress \r\n -Nathaniel Hawthorne, author \r\n - Robert Burns, poet \r\n - Nicole Kidman, actress \r\n - Nelson Mandela, former President of South Africa \r\n - Johann Wolfgang von Goethe, writer \r\n - Robert Burns, poet \r\n - Martin Luther King, Jr., civil rights leader";
        }

        private void button4_Click(object sender, RoutedEventArgs e)
        {
            ResultTextBlock.Text = " - Penasihat atau Pekerja Sosial. \r\n - Psikiater. \r\n - Psikolog. \r\n - Bidang Keagamaan. \r\n - Pengajar/Pendidik/Guru/Pelatih. \r\n - Pemasaran. \r\n - Artis (seniman). \r\n - Dokter. \r\n - Tenaga Kesehatan Alternatif (Chiropraktor, refleksologi). \r\n - Fotografer. \r\n - Pemerhati anak / Early Childhood Development.";
        }
    }
}
