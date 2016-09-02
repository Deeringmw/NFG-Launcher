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

            #region Exile Mods

            var addonlistPvp = new List<Addons>();

            var exile = new Addons
            {
                IsRequired = true,
                LocalDirectory = @"",
                Url = "",
                ModName = "Exile 1.2",
            };
            addonlistPvp.Add(exile);




            lstAddonsPvp.ItemsSource = addonlistPvp;
            #endregion

            #region Insurgency Mods


            var addonlistInsurgency = new List<Addons>();


            var tryk = new Addons
            {
                IsRequired = true,
                LocalDirectory = @"",
                Url = "",
                ModName = "TRYK's Multi-Play Unifroms Pack"
            };

            addonlistInsurgency.Add(tryk);

            var Kunduz = new Addons
            {
                IsRequired = false,
                LocalDirectory = @"doesnt matter yet",
                Url = "",
                ModName = "Kunduz, Afghanistan"
            };

            addonlistInsurgency.Add(Kunduz);

            var cupTerrain = new Addons
            {
                IsRequired = false,
                LocalDirectory = @"doesnt matter yet",
                Url = "",
                ModName = "CUP Terrains- Maps 1.2.0"
            };

            addonlistInsurgency.Add(cupTerrain);

            var cupCore = new Addons
            {
                IsRequired = false,
                LocalDirectory = @"doesnt matter yet",
                Url = "",
                ModName = "CUP Terrains- Core 1.2.0"
            };

            addonlistInsurgency.Add(cupCore);

            var mrtAcc = new Addons
            {
                IsRequired = false,
                LocalDirectory = @"doesnt matter yet",
                Url = "",
                ModName = "MRT Acessory Functions"
            };

            addonlistInsurgency.Add(mrtAcc);

            var fhqAcc = new Addons
            {
                IsRequired = false,
                LocalDirectory = @"doesnt matter yet",
                Url = "",
                ModName = "FHQ Accessories Pack"
            };

            addonlistInsurgency.Add(fhqAcc);

            var fhqWep = new Addons
            {
                IsRequired = false,
                LocalDirectory = @"doesnt matter yet",
                Url = "",
                ModName = "FHQ_Weapons"
            };

            addonlistInsurgency.Add(fhqWep);

            var niArsenal = new Addons
            {
                IsRequired = false,
                LocalDirectory = @"doesnt matter yet",
                Url = "",
                ModName = "NIArsenal"
            };

            addonlistInsurgency.Add(niArsenal);

            var cba = new Addons
            {
                IsRequired = false,
                LocalDirectory = @"doesnt matter yet",
                Url = "",
                ModName = "CBA 3.0"
            };

            addonlistInsurgency.Add(cba);

            var blCore = new Addons
            {
                IsRequired = false,
                LocalDirectory = @"doesnt matter yet",
                Url = "",
                ModName = "BlastCore: Phoenix"
            };

            addonlistInsurgency.Add(blCore);

            var jsrs = new Addons
            {
                IsRequired = false,
                LocalDirectory = @"doesnt matter yet",
                Url = "",
                ModName = "JSRS3: DragonFyre EDEN 1.2"
            };

            addonlistInsurgency.Add(jsrs);

            var ericJ = new Addons
            {
                IsRequired = false,
                LocalDirectory = @"doesnt matter yet",
                Url = "",
                ModName = "EricJ Weapons Pack"
            };

            addonlistInsurgency.Add(ericJ);

           


            // ...

            lstAddonsInsurgency.ItemsSource = addonlistInsurgency;

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
                var theAddon = obj as Addons;
                MessageBox.Show(theAddon.ModName);
                //System.Diagnostics.Process.Start(theAddon.Url);
            }
        }

        private void btnInstallInsurgency_Click(object sender, RoutedEventArgs e)
        {
            foreach (object obj in lstAddonsInsurgency.SelectedItems)
            {
                var theAddon = obj as Addons;
                MessageBox.Show(theAddon.ModName);
            ///    System.Diagnostics.Process.Start(theAddon.Url);
            }
        }

        #endregion
    }
}
