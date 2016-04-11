namespace Pendrive
{
    partial class Frm_Principal
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Principal));
            this.combo_Pendrive = new System.Windows.Forms.ComboBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.Txt_NomePendrive = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Btm_Reparar = new System.Windows.Forms.Button();
            this.progressBarReparo = new System.Windows.Forms.ProgressBar();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // combo_Pendrive
            // 
            this.combo_Pendrive.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.combo_Pendrive.FormattingEnabled = true;
            this.combo_Pendrive.Location = new System.Drawing.Point(15, 139);
            this.combo_Pendrive.Name = "combo_Pendrive";
            this.combo_Pendrive.Size = new System.Drawing.Size(38, 21);
            this.combo_Pendrive.TabIndex = 0;
            this.combo_Pendrive.SelectedIndexChanged += new System.EventHandler(this.combo_Pendrive_SelectedIndexChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Pendrive.Properties.Resources.post_montar_um_pendrive_de_boot;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(172, 120);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // button1
            // 
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gainsboro;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(16, 176);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(168, 37);
            this.button1.TabIndex = 2;
            this.button1.Text = "Atualizar Lista";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Txt_NomePendrive
            // 
            this.Txt_NomePendrive.Enabled = false;
            this.Txt_NomePendrive.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_NomePendrive.Location = new System.Drawing.Point(59, 138);
            this.Txt_NomePendrive.Name = "Txt_NomePendrive";
            this.Txt_NomePendrive.Size = new System.Drawing.Size(125, 22);
            this.Txt_NomePendrive.TabIndex = 3;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.progressBarReparo);
            this.panel1.Controls.Add(this.Btm_Reparar);
            this.panel1.Location = new System.Drawing.Point(190, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(311, 231);
            this.panel1.TabIndex = 4;
            // 
            // Btm_Reparar
            // 
            this.Btm_Reparar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gainsboro;
            this.Btm_Reparar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btm_Reparar.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btm_Reparar.Location = new System.Drawing.Point(3, 172);
            this.Btm_Reparar.Name = "Btm_Reparar";
            this.Btm_Reparar.Size = new System.Drawing.Size(301, 37);
            this.Btm_Reparar.TabIndex = 5;
            this.Btm_Reparar.Text = "Reparar Dispositivo";
            this.Btm_Reparar.UseVisualStyleBackColor = true;
            // 
            // progressBarReparo
            // 
            this.progressBarReparo.Location = new System.Drawing.Point(3, 133);
            this.progressBarReparo.Name = "progressBarReparo";
            this.progressBarReparo.Size = new System.Drawing.Size(301, 23);
            this.progressBarReparo.TabIndex = 5;
            // 
            // Frm_Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(501, 233);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.Txt_NomePendrive);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.combo_Pendrive);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Frm_Principal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Remover Vírus do Pendrive";
            this.Load += new System.EventHandler(this.Frm_Principal_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox combo_Pendrive;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox Txt_NomePendrive;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button Btm_Reparar;
        private System.Windows.Forms.ProgressBar progressBarReparo;
    }
}