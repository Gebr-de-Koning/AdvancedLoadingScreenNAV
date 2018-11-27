using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using StartupWizard4PS.SystemServiceTestRef;
using StartupWizard4PS.NST100TestContosoProfielOverzichtRef;

namespace StartupWizard4PS
{
    //hack: 
    //<description>
    //Speciaal voor opstarten 4PS
    //</description.
    //Form Opstartkeuze
    public partial class Opstartkeuze : Form
    {
        string cur = "Test";
        string baseurl; //dkp-appl
        string NST; //test, prod, ontw (op dit niveau zitten bedrijfen SystemService)
        string bedrijf; // contoso, sim2 , materieel sim2 (leeg) (hier zitten overige pagina's b.v. ProfielOverzicht)

        public Opstartkeuze()
        {
            InitializeComponent();
            SetCompany("Test");
        }

        private void SetCompany(string CompanyName)
        {
            //Default is Test omgeving geselecteerd in radio buttons
            //Lees dan ook hiervan bedrijven lijst in.
            //create the SystemService Client
            baseurl = "http://DKP-APPL-01.gebrdekoning.local:7047";
            baseurl += ReadCompanyList(CompanyName);
            cmbCompany.Items.Clear();
            SystemService_PortClient systemService = new SystemService_PortClient("SystemService_Port", baseurl + "SystemService");
            string[] companies = systemService.Companies();
            foreach (string company in companies)
                cmbCompany.Items.Add(company);
        }

        private string ReadCompanyList(string SelectedCompany)
        {
            switch (SelectedCompany)
            {
                case "Test":
                    {
                        // You can use the parentheses in a case body.
                        return "/NST100TestWS/WS/";
                    }
                case "Ontwikkel":
                    { 
                    return "/NST100OntwWS/WS/";
                    }
                case "Productie":
                    {
                        return "/NST100ProdWS/WS/";
                    }
                default:
                    return "invalid";
            }
            
        }

        private void StartNavision()
        {
            //
            string strCmdText;
            strCmdText = @"""C:\Program Files (x86)\Microsoft Dynamics NAV\100\RoleTailored Client\Microsoft.Dynamics.Nav.Client.exe"" -settings:""\\DKP-FP-01\APPL\NAV Client Installation 2017\Settings\NST100Test.config"" -profile:""PROJECT MANAGER""";
            Console.WriteLine(strCmdText);
            Process cmd = new Process();
            cmd.StartInfo.FileName = "cmd.exe";
            cmd.StartInfo.RedirectStandardInput = true;
            cmd.StartInfo.RedirectStandardOutput = true;
            cmd.StartInfo.CreateNoWindow = true;
            cmd.StartInfo.UseShellExecute = false;
            cmd.Start();
            cmd.StandardInput.WriteLine(strCmdText);
            Application.Exit();
        }

        private void cmbCompany_SelectedIndexChanged(object sender, EventArgs e)
        {
            string baseurl = "http://DKP-APPL-01.gebrdekoning.local:7047/NST100ONTWWS/WS/";

            baseurl = "http://DKP-APPL-01.gebrdekoning.local:7047/NST100TestWS/WS/";
            //create the ProfielOverzicht Client
            ProfielOverzicht_PortClient ProfielOverzicht = new ProfielOverzicht_PortClient("ProfielOverzicht_Port", baseurl + Uri.EscapeDataString(cur) + "/Page/ProfielOverzicht");

            ProfielOverzicht_Filter filter1 = new ProfielOverzicht_Filter();
            filter1.Field = ProfielOverzicht_Fields.Profile_ID;
            filter1.Criteria = "*";

            ProfielOverzicht_Filter[] filters = new ProfielOverzicht_Filter[] { filter1 };
            ProfielOverzicht[] Profielen = ProfielOverzicht.ReadMultiple(filters, null, 0);
            foreach (ProfielOverzicht profiel in Profielen)
            {
                Console.WriteLine(profiel.Description);
                if (profiel.Profile_ID != null) cmbRole.Items.Add(profiel.Profile_ID);
            }
                
                
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            StartNavision();
        }

        private void rBtnOntwikkel_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton rb = sender as RadioButton;
            if (rb != null) if (rb.Checked) SetCompany("Ontwikkel");
        }

        private void rBtnTest_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton rb = sender as RadioButton;
            if (rb != null) if (rb.Checked) SetCompany("Test");

        }

        private void rBtnProductie_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton rb = sender as RadioButton;
            if (rb != null) if (rb.Checked) SetCompany("Productie");

        }
    }
}
