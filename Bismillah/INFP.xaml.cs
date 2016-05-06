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
    public sealed partial class INFP : Page
    {
        public INFP()
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
            ResultTextBlock.Text = " - Sangat perhatian dan peka dengan perasaan orang lain. \r\n - Penuh dengan antusiasme dan kesetiaan, tapi biasanya hanya untuk orang dekat. \r\n - Peduli pada banyak hal. Cenderung mengambil terlalu banyak dan menyelesaikan sebagian. \r\n - Cenderung idealis dan perfeksionis. \r\n - Berpikir win-win solution, mempercayai dan mengoptimalkan orang lain.";
        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            ResultTextBlock.Text = " - Belajarlah menghadapi kritik. \r\n - Belajarlah untuk bersikap tegas. \r\n - Jangan selalu berperasaan dan menyenangkan orang dengan tindakan baik. \r\n - Jangan terlalu menyalahkan diri dan bersikap terlalu keras pada diri sendiri. \r\n - Jangan terlalu baik pada orang lain tapi melupakan diri sendiri.";
        }

        private void button2_Click(object sender, RoutedEventArgs e)
        {
            ResultTextBlock.Text = " - Sangat memegang prinsip. \r\n - Hangat, tertarik pada hubungan dengan orang lain. \r\n - Berorientasi pada pelayanan, biasanya menempatkan kebutuhan orang lain di atas kebutuhan mereka sendiri. \r\n - Loyal dan biasanya mengabdikan diri untuk orang lain. \r\n - Berorientasi ke masa depan. \r\n - Berorientasi pada pertumbuhan; selalu ingin berkembang ke arah yang positif. \r\n - Kreatif dan inspiratif. \r\n - Fleksibel dan santai, kecuali prinsip mereka dilanggar. \r\n - Sensitif dan kompleks \r\n - Tidak suka berurusan dengan rincian dan rutinitas kerja. \r\n - Original dan individualistis; “Keluar dari zona mainstream” \r\n - Kemampuan komunikasi tertulis yang baik. \r\n - Lebih suka bekerja sendiri, dan mungkin memiliki masalah dalam bekerja pada tim. \r\n - Menghargai kedalaman dan keautentikan hubungan. \r\n - Ingin dilihat dan dihargai karena siapa mereka.";
        }

        private void button3_Click(object sender, RoutedEventArgs e)
        {
            ResultTextBlock.Text = " - Aldous Huxley, author \r\n - Audrey Hepburn, actress \r\n - Helen Keller, activist and author \r\n - Isabel Myers Briggs, creator of the Myers-Briggs Type Inventory \r\n - J. R. R. Tolkien, author \r\n - Laura Ingalls Wilder, author \r\n - Princess Diana, Princess of Wales \r\n - Peter Jackson, filmmaker \r\n - William Shakespeare, playwright";
        }

        private void button4_Click(object sender, RoutedEventArgs e)
        {
            ResultTextBlock.Text = " - Penulis \r\n - Penasihat / Pekerja Sosial \r\n - Guru/Profesor \r\n - Psikolog \r\n - Psikiater \r\n - Pekerja Keagamaan";
        }
    }
}
