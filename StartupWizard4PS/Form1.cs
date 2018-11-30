using System;
using System.Diagnostics;
using System.Windows.Forms;
using StartupWizard4PS.SystemServiceTestRef;
using StartupWizard4PS.NST100TestContosoProfielOverzichtRef;
using System.ServiceModel;

namespace StartupWizard4PS
{
    public partial class Opstartkeuze : Form
    {
        string BaseURL { get; set; } //Dit is de URL van de APPL-server
        string NST { get; set; } //Dit is de NST die gebruikt wordt in de cmd String
        string Bedrijf { get; set; } //Het bedrijf waarin de applicatie moet worden opgestart
        string Rol { get; set; } //De rol waarmee je wilt inloggen

        public Opstartkeuze()
        {
            //Instellen van de base URL en de Default NST: Test
            BaseURL = "http://DKP-APPL-01.gebrdekoning.local:7047";
            NST = "Test";
            Bedrijf = "";
            Rol = "";

            //Formulier opbouwen en bedrijf instellen
            InitializeComponent();
            SetCompany(NST);
        }

        private void SetCompany(string CompanyName)
        {
            cmbCompany.Items.Clear();
            string companyURL = BaseURL + GetCompanyList();
            SystemService_PortClient systemService = new SystemService_PortClient("SystemService_Port", companyURL + "SystemService");
            string[] companies = systemService.Companies();
            foreach (string company in companies)
                cmbCompany.Items.Add(company);
        }

        // deze methode schrijft de company lijst weg
        private string GetCompanyList()
        {
            switch (NST)
            {
                case "Test":
                    {
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
                    return "Invalid";
            }
            
        }

        private void StartNavision()
        {
            string strCmdText;

            string NSTFinal = "NST100" + NST.Substring(0,4) + ".config";

            strCmdText = @"""C:\Program Files (x86)\Microsoft Dynamics NAV\100\RoleTailored Client\Microsoft.Dynamics.Nav.Client.exe""";
            strCmdText += @" ""dynamicsnav://DKP-APPL-01:7046/NST100" + NST.Substring(0,4) + @"/" + Bedrijf + @"/""";
            strCmdText += @" -settings:""\\DKP-FP-01\APPL\NAV Client Installation 2017\Settings\";
            strCmdText += NSTFinal + @""" -profile:""" + Rol + @""" ";
            if (rBtnConfig.Checked) strCmdText += "-configure";

            if (rBtnDev.Checked)
                {
                strCmdText = @"""C:\Program Files (x86)\Microsoft Dynamics NAV\100\RoleTailored Client\finsql.exe"" servername=DKP-4PS-01\";
                string strDatabase = NST.Substring(0,4);
                if (strDatabase=="Ontw") strDatabase = "Test";
                strCmdText += strDatabase;
                strCmdText += ",database=NAV100" + NST.Substring(0,4) + ",id=" + NST.Substring(0,4);
                }

            Console.WriteLine(strCmdText);
            Process cmd = new Process();
            cmd.StartInfo.FileName = "cmd.exe";
            cmd.StartInfo.RedirectStandardInput = true;
            cmd.StartInfo.RedirectStandardOutput = true;
            cmd.StartInfo.CreateNoWindow = true;
            cmd.StartInfo.UseShellExecute = false;
            cmd.Start();
            cmd.StandardInput.WriteLine(strCmdText);
            cmd.WaitForExit(1000);
            if (chkClose.Checked) Application.Exit();
        }

        private void CmbCompany_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbRole.Items.Clear();
            Bedrijf = cmbCompany.Text;
            string RoleURL = BaseURL + GetCompanyList() + Uri.EscapeDataString(cmbCompany.Text) + "/Page/ProfielOverzicht";

            //create the ProfielOverzicht Client
            ProfielOverzicht_PortClient ProfielOverzicht = new ProfielOverzicht_PortClient("ProfielOverzicht_Port", RoleURL);

            ProfielOverzicht_Filter filter1 = new ProfielOverzicht_Filter
            {
                Field = ProfielOverzicht_Fields.Profile_ID,
                Criteria = "*"
            };

            ProfielOverzicht_Filter[] filters = new ProfielOverzicht_Filter[] { filter1 };
            ProfielOverzicht[] Profielen = ProfielOverzicht.ReadMultiple(filters, null, 0);
            foreach (ProfielOverzicht profiel in Profielen)
            {
                if (profiel.Profile_ID != null) cmbRole.Items.Add(profiel.Profile_ID);
            }     
        }

        private void CmbRole_SelectedIndexChanged(object sender, EventArgs e)
        {
            Rol = cmbRole.Text;
        }

        private void ClearComboBoxes()
        {
            cmbRole.Text = "";
            cmbCompany.Text = "";
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            StartNavision();
        }

        private void rBtnOntwikkel_CheckedChanged(object sender, EventArgs e)
        {
            if (sender is RadioButton rb)
            {
                if (rb.Checked)
                {
                    try { 
                    ClearComboBoxes();
                    NST = "Ontwikkel";
                    SetCompany("Ontwikkel");
                    }
                    catch(ServerTooBusyException ex)
                    {
                        MessageBox.Show("De service van de Ontwikkel NST is niet online. Neem contact op met de systeembeheerder", "NST Fout", MessageBoxButtons.OK);
                        rBtnOntwikkel.Checked = false;
                    }
                }
            }
        }

        private void rBtnTest_CheckedChanged(object sender, EventArgs e)
        {
            if (sender is RadioButton rb)
            {
                if (rb.Checked)
                {
                    try { 
                    ClearComboBoxes();
                    NST = "Test";
                    SetCompany("Test");
                    }
                    catch(ServerTooBusyException ex)
                    {
                        MessageBox.Show("De service van de Test NST is niet online. Neem contact op met de systeembeheerder", "NST Fout", MessageBoxButtons.OK);
                        rBtnTest.Checked = false;
                    }
                }
            }
        }

        private void rBtnProductie_CheckedChanged(object sender, EventArgs e)
        {
            if (sender is RadioButton rb)
            {
                if (rb.Checked)
                {
                    try { 
                    ClearComboBoxes();
                    NST = "Productie";
                    SetCompany("Productie");
                    }
                    catch(ServerTooBusyException ex)
                    {
                        MessageBox.Show("De service van de Productie NST is niet online. Neem contact op met de systeembeheerder", "NST Fout", MessageBoxButtons.OK);
                        rBtnProductie.Checked = false;
                    }
                }
            }
        }

        private void Opstartkeuze_Load(object sender, EventArgs e)
        {

        }
    }
}
