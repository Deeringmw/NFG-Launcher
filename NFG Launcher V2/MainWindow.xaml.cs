using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using MahApps.Metro.Controls;

namespace NFG_Launcher_V2
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : MetroWindow
    {
        public MainWindow()
        {



            InitializeComponent();
            ListBoxItem itm1 = new ListBoxItem();
            itm1.Content = "TRYK's Multi-Play Unifroms Pack";

            lstAddonsInsurgency.Items.Add(itm1);

            //      InitializeComponent();
            //      ListBoxItem itm2 = new ListBoxItem();
            //      itm2.Content = "@U100";

            //      lstAddonsInsurgency.Items.Add(itm2);

            ListBoxItem itm3 = new ListBoxItem();
            itm3.Content = "Kunduz, Afghanistan";
            lstAddonsInsurgency.Items.Add(itm3);

            ListBoxItem itm4 = new ListBoxItem();
            itm4.Content = "CUP Terrains- Maps 1.2.0";
            lstAddonsInsurgency.Items.Add(itm4);

            ListBoxItem itm5 = new ListBoxItem();
            itm5.Content = "CUP Terrains- Core 1.2.0";
            lstAddonsInsurgency.Items.Add(itm5);

            ListBoxItem itm6 = new ListBoxItem();
            itm6.Content = "MRT Acessory Functions";
            lstAddonsInsurgency.Items.Add(itm6);

            ListBoxItem itm7 = new ListBoxItem();
            itm7.Content = "FHQ Accessories Pack";
            lstAddonsInsurgency.Items.Add(itm7);

            ListBoxItem itm8 = new ListBoxItem();
            itm8.Content = "FHQ Options";
            lstAddonsInsurgency.Items.Add(itm8);

            ListBoxItem itm9 = new ListBoxItem();
            itm9.Content = "NIArsenal";
            lstAddonsInsurgency.Items.Add(itm9);

            ListBoxItem itm10 = new ListBoxItem();
            itm10.Content = "CBA 3.0";
            lstAddonsInsurgency.Items.Add(itm10);

            ListBoxItem itm11 = new ListBoxItem();
            itm11.Content = "BlastCore: Phoenix";
            lstAddonsInsurgency.Items.Add(itm11);

            ListBoxItem itm12 = new ListBoxItem();
            itm12.Content = "JSRS3: DragonFyre EDEN 1.2";
            lstAddonsInsurgency.Items.Add(itm12);

            ListBoxItem itm13 = new ListBoxItem();
            itm13.Content = "EricJ Weapons Pack";
            lstAddonsInsurgency.Items.Add(itm13);

            //Exile test below this point//
        }


        private void btnAgree_Click(object sender, RoutedEventArgs e)
        {
            voicealert.Visibility = Visibility.Hidden;
        }

        private void btnTsDownload_Click(object sender, RoutedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.teamspeak.com/downloads");
        }

        private void btnTsCancel_Click(object sender, RoutedEventArgs e)
        {
            tabInsurgency.Visibility = Visibility.Hidden;
            voicealert.Visibility = Visibility.Hidden;
            grdModInsurgency.Visibility = Visibility.Hidden;
        }

        public void button_Click(object sender, RoutedEventArgs e)
        {
            foreach (Object obj in lstAddonsInsurgency.SelectedItems)
            {

            }
        }
    }
}
