namespace Appli2
{
    partial class FRM_Appli2
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.Gbx_Parametres = new System.Windows.Forms.GroupBox();
            this.Txt_Temp_retenue = new System.Windows.Forms.TextBox();
            this.Txt_Vitesse_retenue = new System.Windows.Forms.TextBox();
            this.Lbl_Temp_retenue = new System.Windows.Forms.Label();
            this.Lbl_Vitesse_retenue = new System.Windows.Forms.Label();
            this.Btn_OK = new System.Windows.Forms.Button();
            this.Btn_Retablir = new System.Windows.Forms.Button();
            this.Btn_Quitter = new System.Windows.Forms.Button();
            this.Lbl_Vitesse = new System.Windows.Forms.Label();
            this.Lbl_Temperature = new System.Windows.Forms.Label();
            this.Cbx_Vitesse = new System.Windows.Forms.ComboBox();
            this.Cbx_Temperature = new System.Windows.Forms.ComboBox();
            this.Gbx_Parametres.SuspendLayout();
            this.SuspendLayout();
            // 
            // Gbx_Parametres
            // 
            this.Gbx_Parametres.Controls.Add(this.Txt_Temp_retenue);
            this.Gbx_Parametres.Controls.Add(this.Txt_Vitesse_retenue);
            this.Gbx_Parametres.Controls.Add(this.Lbl_Temp_retenue);
            this.Gbx_Parametres.Controls.Add(this.Lbl_Vitesse_retenue);
            this.Gbx_Parametres.Location = new System.Drawing.Point(22, 106);
            this.Gbx_Parametres.Name = "Gbx_Parametres";
            this.Gbx_Parametres.Size = new System.Drawing.Size(254, 114);
            this.Gbx_Parametres.TabIndex = 2;
            this.Gbx_Parametres.TabStop = false;
            this.Gbx_Parametres.Text = "Paramètres retenus";
            // 
            // Txt_Temp_retenue
            // 
            this.Txt_Temp_retenue.Enabled = false;
            this.Txt_Temp_retenue.Location = new System.Drawing.Point(85, 83);
            this.Txt_Temp_retenue.Name = "Txt_Temp_retenue";
            this.Txt_Temp_retenue.Size = new System.Drawing.Size(156, 20);
            this.Txt_Temp_retenue.TabIndex = 3;
            // 
            // Txt_Vitesse_retenue
            // 
            this.Txt_Vitesse_retenue.Enabled = false;
            this.Txt_Vitesse_retenue.Location = new System.Drawing.Point(85, 33);
            this.Txt_Vitesse_retenue.Name = "Txt_Vitesse_retenue";
            this.Txt_Vitesse_retenue.Size = new System.Drawing.Size(156, 20);
            this.Txt_Vitesse_retenue.TabIndex = 2;
            // 
            // Lbl_Temp_retenue
            // 
            this.Lbl_Temp_retenue.AutoSize = true;
            this.Lbl_Temp_retenue.Location = new System.Drawing.Point(6, 86);
            this.Lbl_Temp_retenue.Name = "Lbl_Temp_retenue";
            this.Lbl_Temp_retenue.Size = new System.Drawing.Size(73, 13);
            this.Lbl_Temp_retenue.TabIndex = 1;
            this.Lbl_Temp_retenue.Text = "Température :";
            // 
            // Lbl_Vitesse_retenue
            // 
            this.Lbl_Vitesse_retenue.AutoSize = true;
            this.Lbl_Vitesse_retenue.Location = new System.Drawing.Point(6, 36);
            this.Lbl_Vitesse_retenue.Name = "Lbl_Vitesse_retenue";
            this.Lbl_Vitesse_retenue.Size = new System.Drawing.Size(47, 13);
            this.Lbl_Vitesse_retenue.TabIndex = 0;
            this.Lbl_Vitesse_retenue.Text = "Vitesse :";
            // 
            // Btn_OK
            // 
            this.Btn_OK.Location = new System.Drawing.Point(282, 112);
            this.Btn_OK.Name = "Btn_OK";
            this.Btn_OK.Size = new System.Drawing.Size(134, 32);
            this.Btn_OK.TabIndex = 3;
            this.Btn_OK.Text = "OK";
            this.Btn_OK.UseVisualStyleBackColor = true;
            this.Btn_OK.Click += new System.EventHandler(this.Btn_OK_Click);
            // 
            // Btn_Retablir
            // 
            this.Btn_Retablir.Location = new System.Drawing.Point(282, 150);
            this.Btn_Retablir.Name = "Btn_Retablir";
            this.Btn_Retablir.Size = new System.Drawing.Size(134, 32);
            this.Btn_Retablir.TabIndex = 4;
            this.Btn_Retablir.Text = "Rétablir";
            this.Btn_Retablir.UseVisualStyleBackColor = true;
            this.Btn_Retablir.Click += new System.EventHandler(this.Btn_Retablir_Click);
            // 
            // Btn_Quitter
            // 
            this.Btn_Quitter.Location = new System.Drawing.Point(282, 188);
            this.Btn_Quitter.Name = "Btn_Quitter";
            this.Btn_Quitter.Size = new System.Drawing.Size(134, 32);
            this.Btn_Quitter.TabIndex = 5;
            this.Btn_Quitter.Text = "Quitter";
            this.Btn_Quitter.UseVisualStyleBackColor = true;
            this.Btn_Quitter.Click += new System.EventHandler(this.Btn_Quitter_Click);
            // 
            // Lbl_Vitesse
            // 
            this.Lbl_Vitesse.AutoSize = true;
            this.Lbl_Vitesse.Location = new System.Drawing.Point(19, 19);
            this.Lbl_Vitesse.Name = "Lbl_Vitesse";
            this.Lbl_Vitesse.Size = new System.Drawing.Size(101, 13);
            this.Lbl_Vitesse.TabIndex = 6;
            this.Lbl_Vitesse.Text = "Choisir une vitesse :";
            // 
            // Lbl_Temperature
            // 
            this.Lbl_Temperature.AutoSize = true;
            this.Lbl_Temperature.Location = new System.Drawing.Point(19, 66);
            this.Lbl_Temperature.Name = "Lbl_Temperature";
            this.Lbl_Temperature.Size = new System.Drawing.Size(124, 13);
            this.Lbl_Temperature.TabIndex = 7;
            this.Lbl_Temperature.Text = "Choisir une température :";
            // 
            // Cbx_Vitesse
            // 
            this.Cbx_Vitesse.FormattingEnabled = true;
            this.Cbx_Vitesse.Location = new System.Drawing.Point(144, 16);
            this.Cbx_Vitesse.Name = "Cbx_Vitesse";
            this.Cbx_Vitesse.Size = new System.Drawing.Size(272, 21);
            this.Cbx_Vitesse.TabIndex = 8;
            // 
            // Cbx_Temperature
            // 
            this.Cbx_Temperature.FormattingEnabled = true;
            this.Cbx_Temperature.Location = new System.Drawing.Point(144, 63);
            this.Cbx_Temperature.Name = "Cbx_Temperature";
            this.Cbx_Temperature.Size = new System.Drawing.Size(272, 21);
            this.Cbx_Temperature.TabIndex = 9;
            // 
            // FRM_Appli2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(433, 237);
            this.Controls.Add(this.Cbx_Temperature);
            this.Controls.Add(this.Cbx_Vitesse);
            this.Controls.Add(this.Lbl_Temperature);
            this.Controls.Add(this.Lbl_Vitesse);
            this.Controls.Add(this.Btn_Quitter);
            this.Controls.Add(this.Btn_Retablir);
            this.Controls.Add(this.Btn_OK);
            this.Controls.Add(this.Gbx_Parametres);
            this.Name = "FRM_Appli2";
            this.Text = "Paramètres de l\'analyseur";
            this.Gbx_Parametres.ResumeLayout(false);
            this.Gbx_Parametres.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox Gbx_Parametres;
        private System.Windows.Forms.Button Btn_OK;
        private System.Windows.Forms.Button Btn_Retablir;
        private System.Windows.Forms.Button Btn_Quitter;
        private System.Windows.Forms.TextBox Txt_Temp_retenue;
        private System.Windows.Forms.TextBox Txt_Vitesse_retenue;
        private System.Windows.Forms.Label Lbl_Temp_retenue;
        private System.Windows.Forms.Label Lbl_Vitesse_retenue;
        private System.Windows.Forms.Label Lbl_Vitesse;
        private System.Windows.Forms.Label Lbl_Temperature;
        private System.Windows.Forms.ComboBox Cbx_Vitesse;
        private System.Windows.Forms.ComboBox Cbx_Temperature;
    }
}

