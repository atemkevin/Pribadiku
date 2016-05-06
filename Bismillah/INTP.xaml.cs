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
    public sealed partial class INTP : Page
    {
        public INTP()
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
            ResultTextBlock.Text = " - Sangat menghargai intelektualitas dan pengetahuan. Menikmati hal-hal teoritis dan ilmiah. \r\n - Senang memecahkan masalah dengan logika dan analisa. \r\n - Diam dan menahan diri. Lebih suka bekerja sendiri. \r\n - Cenderung kritis, skeptis, mudah curiga dan pesimis. \r\n - Tidak suka memimpin dan bisa menjadi pengikut yang tidak banyak menuntut. \r\n - Cenderung memiliki minat yang jelas. Membutuhkan karir dimana minatnya bisa berkembang dan bermanfaat..";
        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            ResultTextBlock.Text = " - Belajarlah membangun hubungan dengan orang lain. Belajar berempati, mendengar aktif, memberi perhatian dan bertukar pendapat. \r\n - Relaks. Jangan terlalu banyak berfikir. Nikmati hidup Anda tanpa harus bertanya mengapa dan bagaimana. \r\n - Cobalah menemukan satu ide, merencanakan dan mewujudkannya. \r\n - Jangan terlalu sering berganti-ganti ide tetapi tidak satupun yang terwujud.";
        }

        private void button2_Click(object sender, RoutedEventArgs e)
        {
            ResultTextBlock.Text = " - Mencintai teori dan ide-ide abstrak. \r\n - Pencari Kebenaran – mereka ingin memahami segala sesuatu dengan menganalisis prinsip-prinsip dan struktur yang mendasarinya. \r\n - Menilai pengetahuan dan kompetensi di atas segalanya. \r\n - Memiliki standar yang sangat tinggi tentang kinerja, yang mereka terapkan untuk diri mereka sendiri. \r\n - Independen dan orisinil, mungkin eksentrik. \r\n - Bekerja sangat baik saat sendiri, dan menghargai nilai otonomi. \r\n - Tidak punya keinginan untuk memimpin atau mengikuti. \r\n - Tidak menyukai detail biasa. \r\n - Tidak terlalu tertarik pada aplikasi praktis dari pekerjaan mereka. \r\n - Kreatif dan berwawasan. \r\n - Berorientasi masa depan. \r\n - Biasanya brilian, dan berbakat. \r\n - Percaya bahwa wawasan dan pendapat mereka sendiri di atas orang lain \r\n - Kehidupan mereka utamanya di dalam pikiran mereka sendiri, dan mungkin tampak terlepas dan tidak terlibat dengan orang lain.";
        }

        private void button3_Click(object sender, RoutedEventArgs e)
        {
            ResultTextBlock.Text = " - Albert Einstein, scientist \r\n - Charles Darwin, naturalist \r\n - William James, psychologist and philosopher \r\n - Dwight D. Eisenhower, U.S. President \r\n - C. G. Jung, psychiatrist \r\n - Socrates, philosopher \r\n - Sir Isaac Newton, mathematician, physicist and astronomer \r\n - J.K. Rowling, author \r\n - Abraham Lincoln, U.S. President";
        }

        private void button4_Click(object sender, RoutedEventArgs e)
        {
            ResultTextBlock.Text = " - Ahli Keilmuan – terutama Fisika dan Kimia \r\n - Fotografer \r\n - Perencana Strategi \r\n - Ahli Ilmu Pasti \r\n - Profesor \r\n - Programmer atau Sistem Analis \r\n - Penulis Teknis \r\n - Insinyur \r\n - Pengacara \r\n - Hakim \r\n - Penyidik Forensik \r\n - Ilmu Kehutanan atau Polisi Hutan";
        }
    }
}
