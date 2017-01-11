using System;
using System.IO;
using System.Collections.Generic;
using System.Net;
using System.Windows;
using System.Windows.Forms;
using MahApps.Metro.Controls;
using MessageBox = System.Windows.MessageBox;
using System.Windows.Controls;
using PortableSteam;
using Steam.Query;

namespace NFG_Launcher_V2
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : MetroWindow
    {
        private Server _server;

        public MainWindow()
        {
            InitializeComponent();
            SteamWebAPI.SetGlobalKey("CD544189422768FDC60B06DEC2627CC7");
            _server = new Server(new IPEndPoint(IPAddress.Parse("108.61.135.218"), 26901));

        }






        private void btnPlay_Click(object sender, RoutedEventArgs e)
        {
            System.Diagnostics.Process.Start("steam://connect/72.185.188.0:28015");
        }

        private void btnGrandpaDonate_Click(object sender, RoutedEventArgs e)
        {
            System.Diagnostics.Process.Start("http://oursecrets.enjin.com/donors/m/39182051/article/3886685");
        }

        private async void btnPlayGrandpa_Click(object sender, RoutedEventArgs e)
        {
            var serverInfo = await _server.GetServerInfo();
            MessageBox.Show(serverInfo.Players.ToString());

            //System.Diagnostics.Process.Start("steam://connect/108.61.135.218:26901");
        }

        private void btnPlayGrandmas_Click(object sender, RoutedEventArgs e)
        {
            System.Diagnostics.Process.Start("steam://connect/108.61.135.218:24901");
        }

        private void btnPlayDirty_Click(object sender, RoutedEventArgs e)
        {
            System.Diagnostics.Process.Start("steam://connect/108.61.135.218:29901");
        }
    }
}
