using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QPReadWriteRegistry
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
        private const string SQLKEY = @"DT3\SQL_Installed";
        private const string DACKEY = @"DT3\DAC_Installed";
        private const string FLUMEKEY = @"DT3\Flume_Installed";
        private const string SEVENZIPKEY = @"DT3\S7Zip_Installed";
        private const string DOTNETKEY = @"DT3\DotNet_Installed";

        private const string SQLKEYNAME = "sql_installed";
        private const string DACKEYNAME = "dac_installed";
        private const string FLUMEKEYNAME = "flume_installed";
        private const string SEVENZIPKEYNAME = "7zip_installed";
        private const string DOTNETKEYNAME = "dotnet_installed";

        public static void WriteKeys()
        {
            //accessing the LocalMachine root element  
            RegistryKey keySQL = Registry.CurrentUser.CreateSubKey(SQLKEY);
            RegistryKey keyDAC = Registry.CurrentUser.CreateSubKey(DACKEY);
            RegistryKey keyFlume = Registry.CurrentUser.CreateSubKey(FLUMEKEY);
            RegistryKey key7Zip = Registry.CurrentUser.CreateSubKey(SEVENZIPKEY);
            RegistryKey keyDotNet = Registry.CurrentUser.CreateSubKey(DOTNETKEY);


            keySQL.SetValue(SQLKEYNAME, 0);
            keyDAC.SetValue(DACKEYNAME, 0);
            keyFlume.SetValue(FLUMEKEYNAME, 0);
            key7Zip.SetValue(SEVENZIPKEYNAME, 0);
            keyDotNet.SetValue(DOTNETKEYNAME, 0);
        }

        public static void ReadKeys()
        {
            //opening the subkey  
            RegistryKey key1 = Registry.CurrentUser.OpenSubKey(SQLKEY);
            RegistryKey key2 = Registry.CurrentUser.OpenSubKey(DACKEY);
            RegistryKey key3 = Registry.CurrentUser.OpenSubKey(FLUMEKEY);
            RegistryKey key4 = Registry.CurrentUser.OpenSubKey(SEVENZIPKEY);
            RegistryKey key5 = Registry.CurrentUser.OpenSubKey(DOTNETKEY);

            //if it does exist, retrieve the stored values  
            if (key1 != null)
            {
                MessageBox.Show(key1.GetValue(SQLKEYNAME).ToString());
                key1.Close();
            }
            //if it does exist, retrieve the stored values  
            if (key2 != null)
            {
                MessageBox.Show(key2.GetValue(DACKEYNAME).ToString());
                key2.Close();
            }
            //if it does exist, retrieve the stored values  
            if (key3 != null)
            {
                MessageBox.Show(key3.GetValue(FLUMEKEYNAME).ToString());
                key3.Close();
            }
            //if it does exist, retrieve the stored values  
            if (key4 != null)
            {
                MessageBox.Show(key4.GetValue(SEVENZIPKEYNAME).ToString());
                key4.Close();
            }
            //if it does exist, retrieve the stored values  
            if (key5 != null)
            {
                MessageBox.Show(key5.GetValue(DOTNETKEYNAME).ToString());
                key5.Close();
            }
        }
    }
}
