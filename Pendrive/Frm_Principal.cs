using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace Pendrive
{
    public partial class Frm_Principal : Form
    {
        List<DriveInfo> ListaDePendrives = new List<DriveInfo>();

        public Frm_Principal()
        {
            InitializeComponent();
        }

        private void Frm_Principal_Load(object sender, EventArgs e)
        {
            Ferramentas.VerificarPastaTemp();

            AtualizarListaDePendrives();
        }

        private void AtualizarListaDePendrives()
        {
            ListaDePendrives.Clear();

            ListaDePendrives = Ferramentas.listarPendrives();

            foreach (var item in ListaDePendrives)
            {
                combo_Pendrive.Items.Clear();

                combo_Pendrive.Items.Add(item.RootDirectory.ToString());
            }

            if (combo_Pendrive.Items.Count != 0)
            {
                combo_Pendrive.SelectedItem = combo_Pendrive.Items[0];
            }
            else
            {
                combo_Pendrive.Text = string.Empty;
                Txt_NomePendrive.Text = string.Empty;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AtualizarListaDePendrives();
        }

        private void combo_Pendrive_SelectedIndexChanged(object sender, EventArgs e)
        {
            foreach (var item in ListaDePendrives)
            {
                if (item.RootDirectory.ToString() == combo_Pendrive.Text)
                {
                    Txt_NomePendrive.Text = item.VolumeLabel.ToString();
                }
            }
        }
    }
}
