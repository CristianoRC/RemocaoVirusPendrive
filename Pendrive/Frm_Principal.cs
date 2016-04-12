using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.IO;

namespace Pendrive
{
    public partial class Frm_Principal : Form
    {
        List<DriveInfo> ListaDePendrives = new List<DriveInfo>();
        DriveInfo PendriveAtual;

        public Frm_Principal()
        {
            InitializeComponent();
        }

        private void Frm_Principal_Load(object sender, EventArgs e)
        {
            AtualizarListaDePendrives();
        }

        private void AtualizarListaDePendrives()
        {
            ListaDePendrives.Clear();

            ListaDePendrives = Ferramentas.listarPendrives();

            combo_Pendrive.Items.Clear();

            foreach (var item in ListaDePendrives)
            {
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

        private void AtualizarLabels(DriveInfo InformacoesPendrive)
        {
            Lbl_Nome.Text = InformacoesPendrive.VolumeLabel.ToLower();
            Lbl_Livre.Text = $"{ConverterEmGigabytes(InformacoesPendrive.AvailableFreeSpace).ToString("0.00")} GB";
            Lbl_SistemaDeArquivos.Text = InformacoesPendrive.DriveFormat;
            Lbl_TamanhoTotal.Text = $"{ConverterEmGigabytes(InformacoesPendrive.TotalSize).ToString("0.00")} GB";

            float Utilizado = ConverterEmGigabytes(InformacoesPendrive.TotalSize) - ConverterEmGigabytes(InformacoesPendrive.AvailableFreeSpace);

            Lbl_Utilizado.Text = $"{Utilizado.ToString("0.00")} GB";


            PendriveAtual = InformacoesPendrive;
        }

        static float ConverterEmGigabytes(float bytes)
        {
            return (bytes / 1073741824);
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

                    AtualizarLabels(item);
                }
            }
        }

        private void Btm_Reparar_Click(object sender, EventArgs e)
        {

            if (combo_Pendrive.Items.Count != 0)
            {
                if (PendriveAtual.IsReady)
                {
                    Ferramentas.RepararPendrive(PendriveAtual);

                    MessageBox.Show("Processo finalizado com sucesso", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Insira um pendrive", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Insira um pendrive", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
