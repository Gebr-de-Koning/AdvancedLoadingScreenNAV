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
            ServerComboBox.Items.Add("NST100Prod");
            ServerComboBox.Items.Add("NST100Test");
            ServerComboBox.Items.Add("NST100Klad");
        }

        private void CreateBedrijfKeuze()
        {
            Label BedrijfLabel = new Label
            {
                AutoSize = true,
                Font = new Font("Arial Unicode MS", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0),
                ForeColor = Color.FromArgb(27, 37, 70),
                Location = new Point(83, 147),
                Name = "BedrijfLabel",
                Size = new Size(81, 28),
                Text = "Bedrijf:"
            };
            Controls.Add(BedrijfLabel);

            ComboBox BedrijfComboBox = new ComboBox
            {
                FormattingEnabled = true,
                Font = new Font("Arial Unicode MS", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0),
                Location = new Point(170, 150),
                Name = "BedrijfComboBox",
                Size = new Size(200, 26)
            };
            Controls.Add(BedrijfComboBox);
            FillBedrijfComboBox();
        }

        private void FillBedrijfComboBox()
        {
           
        }

        private void ResetChoices()
        {
            Server = "";
            Bedrijf = "";
            Rol = "";
        }

        private void ServerComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            ResetChoices();
            Server = ServerComboBox.Text;
            CreateBedrijfKeuze();
        }
    }
}
