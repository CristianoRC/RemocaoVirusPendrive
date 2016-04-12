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
            this.Lbl_Utilizado = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.Lbl_Livre = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Lbl_Nome = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Lbl_TamanhoTotal = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Lbl_SistemaDeArquivos = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // combo_Pendrive
            // 
            this.combo_Pendrive.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.combo_Pendrive.FormattingEnabled = true;
            this.combo_Pendrive.Location = new System.Drawing.Point(11, 139);
            this.combo_Pendrive.Name = "combo_Pendrive";
            this.combo_Pendrive.Size = new System.Drawing.Size(62, 21);
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
            this.button1.Location = new System.Drawing.Point(12, 178);
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
            this.Txt_NomePendrive.Location = new System.Drawing.Point(79, 138);
            this.Txt_NomePendrive.Name = "Txt_NomePendrive";
            this.Txt_NomePendrive.Size = new System.Drawing.Size(101, 22);
            this.Txt_NomePendrive.TabIndex = 3;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.Btm_Reparar);
            this.panel1.Controls.Add(this.Lbl_Utilizado);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.Lbl_Livre);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.Lbl_Nome);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.Lbl_TamanhoTotal);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.Lbl_SistemaDeArquivos);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(190, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(369, 240);
            this.panel1.TabIndex = 4;
            // 
            // Btm_Reparar
            // 
            this.Btm_Reparar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Btm_Reparar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btm_Reparar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Btm_Reparar.Location = new System.Drawing.Point(6, 174);
            this.Btm_Reparar.Name = "Btm_Reparar";
            this.Btm_Reparar.Size = new System.Drawing.Size(352, 37);
            this.Btm_Reparar.TabIndex = 16;
            this.Btm_Reparar.Text = "Desinfectar Pendrive";
            this.Btm_Reparar.UseVisualStyleBackColor = true;
            this.Btm_Reparar.Click += new System.EventHandler(this.Btm_Reparar_Click);
            // 
            // Lbl_Utilizado
            // 
            this.Lbl_Utilizado.AutoSize = true;
            this.Lbl_Utilizado.Font = new System.Drawing.Font("Calibri Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Utilizado.Location = new System.Drawing.Point(102, 82);
            this.Lbl_Utilizado.Name = "Lbl_Utilizado";
            this.Lbl_Utilizado.Size = new System.Drawing.Size(0, 15);
            this.Lbl_Utilizado.TabIndex = 15;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(3, 84);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(101, 15);
            this.label6.TabIndex = 14;
            this.label6.Text = "Espaço Utilizado:";
            // 
            // Lbl_Livre
            // 
            this.Lbl_Livre.AutoSize = true;
            this.Lbl_Livre.Font = new System.Drawing.Font("Calibri Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Livre.Location = new System.Drawing.Point(81, 58);
            this.Lbl_Livre.Name = "Lbl_Livre";
            this.Lbl_Livre.Size = new System.Drawing.Size(0, 15);
            this.Lbl_Livre.TabIndex = 13;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(3, 58);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 15);
            this.label4.TabIndex = 12;
            this.label4.Text = "Espaço Livre:";
            // 
            // Lbl_Nome
            // 
            this.Lbl_Nome.AutoSize = true;
            this.Lbl_Nome.Font = new System.Drawing.Font("Calibri Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Nome.Location = new System.Drawing.Point(44, 8);
            this.Lbl_Nome.Name = "Lbl_Nome";
            this.Lbl_Nome.Size = new System.Drawing.Size(0, 15);
            this.Lbl_Nome.TabIndex = 11;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(3, 8);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 15);
            this.label2.TabIndex = 10;
            this.label2.Text = "Nome:";
            // 
            // Lbl_TamanhoTotal
            // 
            this.Lbl_TamanhoTotal.AutoSize = true;
            this.Lbl_TamanhoTotal.Font = new System.Drawing.Font("Calibri Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_TamanhoTotal.Location = new System.Drawing.Point(92, 33);
            this.Lbl_TamanhoTotal.Name = "Lbl_TamanhoTotal";
            this.Lbl_TamanhoTotal.Size = new System.Drawing.Size(0, 15);
            this.Lbl_TamanhoTotal.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(3, 32);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 15);
            this.label3.TabIndex = 8;
            this.label3.Text = "Tamanho total:";
            // 
            // Lbl_SistemaDeArquivos
            // 
            this.Lbl_SistemaDeArquivos.AutoSize = true;
            this.Lbl_SistemaDeArquivos.Font = new System.Drawing.Font("Calibri Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_SistemaDeArquivos.Location = new System.Drawing.Point(124, 114);
            this.Lbl_SistemaDeArquivos.Name = "Lbl_SistemaDeArquivos";
            this.Lbl_SistemaDeArquivos.Size = new System.Drawing.Size(0, 15);
            this.Lbl_SistemaDeArquivos.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 113);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 15);
            this.label1.TabIndex = 6;
            this.label1.Text = "Sistema de Arquivos:";
            // 
            // Frm_Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(562, 242);
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
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox combo_Pendrive;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox Txt_NomePendrive;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label Lbl_Livre;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label Lbl_Nome;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label Lbl_TamanhoTotal;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label Lbl_SistemaDeArquivos;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label Lbl_Utilizado;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button Btm_Reparar;
    }
}