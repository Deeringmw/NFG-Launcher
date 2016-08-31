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

            #region Insurgency Mods


            var addonList = new List<AddonsPvp>();


            var tryk = new AddonsPvp
            {
                IsRequired = true,
                LocalDirectory = @"",
                Url = "",
                ModName = "TRYK's Multi-Play Unifroms Pack"
            };

            addonList.Add(tryk);

            var Kunduz = new AddonsPvp
            {
                IsRequired = false,
                LocalDirectory = @"doesnt matter yet",
                Url = "",
                ModName = "Kunduz, Afghanistan"
            };

            addonList.Add(Kunduz);

            var cupTerrain = new AddonsPvp
            {
                IsRequired = false,
                LocalDirectory = @"doesnt matter yet",
                Url = "",
                ModName = "CUP Terrains- Maps 1.2.0"
            };

            addonList.Add(cupTerrain);

            var cupCore = new AddonsPvp
            {
                IsRequired = false,
                LocalDirectory = @"doesnt matter yet",
                Url = "",
                ModName = "CUP Terrains- Core 1.2.0"
            };

            addonList.Add(cupCore);

            var mrtAcc = new AddonsPvp
            {
                IsRequired = false,
                LocalDirectory = @"doesnt matter yet",
                Url = "",
                ModName = "MRT Acessory Functions"
            };

            addonList.Add(mrtAcc);

            var fhqAcc = new AddonsPvp
            {
                IsRequired = false,
                LocalDirectory = @"doesnt matter yet",
                Url = "",
                ModName = "FHQ Accessories Pack"
            };

            addonList.Add(fhqAcc);

            var fhqWep = new AddonsPvp
            {
                IsRequired = false,
                LocalDirectory = @"doesnt matter yet",
                Url = "",
                ModName = "FHQ_Weapons"
            };

            addonList.Add(fhqWep);

            var niArsenal = new AddonsPvp
            {
                IsRequired = false,
                LocalDirectory = @"doesnt matter yet",
                Url = "",
                ModName = "NIArsenal"
            };

            addonList.Add(niArsenal);

            var cba = new AddonsPvp
            {
                IsRequired = false,
                LocalDirectory = @"doesnt matter yet",
                Url = "",
                ModName = "CBA 3.0"
            };

            addonList.Add(cba);

            var blCore = new AddonsPvp
            {
                IsRequired = false,
                LocalDirectory = @"doesnt matter yet",
                Url = "",
                ModName = "BlastCore: Phoenix"
            };

            addonList.Add(blCore);

            var jsrs = new AddonsPvp
            {
                IsRequired = false,
                LocalDirectory = @"doesnt matter yet",
                Url = "",
                ModName = "JSRS3: DragonFyre EDEN 1.2"
            };

            addonList.Add(jsrs);

            var ericJ = new AddonsPvp
            {
                IsRequired = false,
                LocalDirectory = @"doesnt matter yet",
                Url = "",
                ModName = "EricJ Weapons Pack"
            };

            addonList.Add(ericJ);

           


            // ...

            lstAddonsInsurgency.ItemsSource = addonList;

            #endregion


        }

        #region Click Handlers

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

        public void btnInstallPvp_Click(object sender, RoutedEventArgs e)
        {
            foreach (object obj in lstAddonsPvp.SelectedItems)
            {
                var theAddon = obj as AddonsPvp;
                MessageBox.Show(theAddon.ModName);
                System.Diagnostics.Process.Start(theAddon.Url);
            }
        }

        private void btnInstallInsurgency_Click(object sender, RoutedEventArgs e)
        {
            foreach (object obj in lstAddonsInsurgency.SelectedItems)
            {
                var theAddon = obj as AddonsPvp;
                MessageBox.Show(theAddon.ModName);
                System.Diagnostics.Process.Start(theAddon.Url);
            }
        }

        #endregion
    }
}
