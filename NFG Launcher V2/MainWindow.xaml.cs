using System.IO;
using System.Collections.Generic;
using System.Net;
using System.Windows;
using System.Windows.Forms;
using MahApps.Metro.Controls;

namespace NFG_Launcher_V2
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : MetroWindow
    {

        private Settings _settings;

        public MainWindow()
        {

            InitializeComponent();

            _settings = new Settings();
            

            #region Exile Mods

            var addonlistPvp = new List<Addons>();

            var exile = new Addons
            {
                IsRequired = true,
                Url = "",
                ModName = "Exile 1.0.1",
            };
            addonlistPvp.Add(exile);




            lstAddonsPvp.ItemsSource = addonlistPvp;
            #endregion

            #region Insurgency Mods


            var addonlistInsurgency = new List<Addons>();


            var tryk = new Addons
            {
                IsRequired = true,
                Url = "",
                ModName = "TRYK's Multi-Play Unifroms Pack"
            };

            addonlistInsurgency.Add(tryk);

            var Kunduz = new Addons
            {
                IsRequired = false,
                Url = "",
                ModName = "Kunduz, Afghanistan"
            };

            addonlistInsurgency.Add(Kunduz);

            var cupTerrain = new Addons
            {
                IsRequired = false,
                Url = "",
                ModName = "CUP Terrains- Maps 1.2.0"
            };

            addonlistInsurgency.Add(cupTerrain);

            var cupCore = new Addons
            {
                IsRequired = false,
                Url = "",
                ModName = "CUP Terrains- Core 1.2.0"
            };

            addonlistInsurgency.Add(cupCore);

            var mrtAcc = new Addons
            {
                IsRequired = false,
                Url = "",
                ModName = "MRT Acessory Functions"
            };

            addonlistInsurgency.Add(mrtAcc);

            var fhqAcc = new Addons
            {
                IsRequired = false,
                Url = "",
                ModName = "FHQ Accessories Pack"
            };

            addonlistInsurgency.Add(fhqAcc);

            var fhqWep = new Addons
            {
                IsRequired = false,
                Url = "",
                ModName = "FHQ_Weapons"
            };

            addonlistInsurgency.Add(fhqWep);

            var niArsenal = new Addons
            {
                IsRequired = false,
                Url = "",
                ModName = "NIArsenal"
            };

            addonlistInsurgency.Add(niArsenal);

            var cba = new Addons
            {
                IsRequired = false,
                Url = "",
                ModName = "CBA 3.0"
            };

            addonlistInsurgency.Add(cba);

            var blCore = new Addons
            {
                IsRequired = false,
                Url = "http://149.56.47.26/Insurgencymods/Bc.zip",
                ModName = "BlastCore: Phoenix",
                FileName = "Bc.zip"
                
            };

            addonlistInsurgency.Add(blCore);

            var jsrs = new Addons
            {
                IsRequired = false,
                Url = "",
                ModName = "JSRS3: DragonFyre EDEN 1.2"
            };

            addonlistInsurgency.Add(jsrs);

            var ericJ = new Addons
            {
                IsRequired = false,
                Url = "",
                ModName = "EricJ Weapons Pack"
            };

            addonlistInsurgency.Add(ericJ);




            // ...

            lstAddonsInsurgency.ItemsSource = addonlistInsurgency;

            #endregion
            var localD = new Settings
            {
                LocalDirectory = txtPath.Text,
            };

        }

        #region Click Handlers

        private void btnPath_Click(object sender, RoutedEventArgs e)
        {
            FolderBrowserDialog path = new FolderBrowserDialog();
            DialogResult result = path.ShowDialog();

            if (string.IsNullOrWhiteSpace(path.SelectedPath)) return;

            txtPath.Text = path.SelectedPath;
            _settings.LocalDirectory = path.SelectedPath;
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

        public void btnInstallPvp_Click(object sender, RoutedEventArgs e)
        {
            foreach (var obj in lstAddonsPvp.SelectedItems)
            {
                var theAddon = obj as Addons;
                System.Windows.Forms.MessageBox.Show(theAddon.ModName);
         //       WebClient Client = new WebClient();
        //       Client.DownloadFile(theAddon.Url, theAddon.LocalDirectory);
            }
        }

        private void btnInstallInsurgency_Click(object sender, RoutedEventArgs e)
        {
            foreach (var obj in lstAddonsInsurgency.SelectedItems)
            {
                var theAddon = obj as Addons;
                System.Windows.Forms.MessageBox.Show("Now Downloading" + theAddon?.ModName);
                using (var client = new WebClient())
                {
                    client.DownloadFile(theAddon.Url, $@"{_settings.LocalDirectory}\{theAddon.FileName}");
                }


            }
        }

        #endregion


    }
}
