using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Appli2
{
    public partial class FRM_Appli2 : Form
    {
        public FRM_Appli2()
        {
            InitializeComponent();
            this.Gbx_Parametres.Visible = false;
            this.Cbx_Vitesse.Items.AddRange(new string[] { "100", "200", "300", "500"});
            this.Cbx_Temperature.Items.AddRange(new string[] { "50", "80", "100"});
        }

        private void Btn_OK_Click(object sender, EventArgs e)
        {
            
            if (this.Cbx_Vitesse.Text == "")
            {
                MessageBox.Show("Veuillez choisir une vitesse");
                Btn_Retablir_Click(sender, e);
            }else if (this.Cbx_Temperature.Text == "")
                {
                MessageBox.Show("Veuillez choisir une température");
                Btn_Retablir_Click(sender, e);
            }else if (this.Cbx_Vitesse.SelectedItem != null && this.Cbx_Temperature.SelectedItem != null)
            {
                this.Txt_Vitesse_retenue.Text = this.Cbx_Vitesse.Text;
                this.Txt_Temp_retenue.Text = this.Cbx_Temperature.Text;
                this.Cbx_Temperature.Enabled = false;
                this.Cbx_Vitesse.Enabled = false;
                this.Gbx_Parametres.Visible = true;
            }
            
        }

        private void Btn_Retablir_Click(object sender, EventArgs e)
        {
            this.Cbx_Temperature.Enabled = true;
            this.Cbx_Vitesse.Enabled = true;
            this.Gbx_Parametres.Visible = false;
            this.Cbx_Vitesse.ResetText();
            this.Cbx_Temperature.ResetText();
            this.Txt_Vitesse_retenue.ResetText();
            this.Txt_Temp_retenue.ResetText();
        }

        private void Btn_Quitter_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

    }
}
