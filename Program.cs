using System;
using System.Collections.Generic;
using System.Windows.Forms;
using ESRI.ArcGIS.esriSystem;

namespace gdb_domain_manager
{
    static class Program
    {
        private static LicenseInitializer m_AOLicenseInitializer = new gdb_domain_manager.LicenseInitializer();
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            //ESRI License Initializer generated code.
            if (!m_AOLicenseInitializer.InitializeApplication(new esriLicenseProductCode[] { esriLicenseProductCode.esriLicenseProductCodeArcEditor },
            new esriLicenseExtensionCode[] { }))
            {
                System.Windows.Forms.MessageBox.Show(m_AOLicenseInitializer.LicenseMessage() +
                "\n\nThis application could not initialize with the correct ArcGIS license and will shutdown.",
                "ArcGIS License Failure");
                m_AOLicenseInitializer.ShutdownApplication();
                Application.Exit();
                return;
            }
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainForm());
            //ESRI License Initializer generated code.
            //Do not make any call to ArcObjects after ShutDownApplication()
            m_AOLicenseInitializer.ShutdownApplication();
        }
    }
}