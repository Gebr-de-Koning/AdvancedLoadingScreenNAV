using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StartupWizard4PS
{
    public partial class Opstartkeuze : Form
    {
        public String Server { get; set; }
        public String Bedrijf { get; set; }
        public String Rol { get; set; }

        public Opstartkeuze()
        {
            InitializeComponent();
            FillServerComboBox();
        }

        private void FillServerComboBox()
        {
            ServerComboBox.Items.Add("NST Productie");
            ServerComboBox.Items.Add("NST Test");
            ServerComboBox.Items.Add("NST Klad");
        }
    }
}
