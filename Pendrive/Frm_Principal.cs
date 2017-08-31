using System;
using System.Windows.Forms;
using System.IO;

namespace Pendrive
{
    public partial class Frm_Principal : Form
    {
        Pendrive pendrive = new Pendrive();

        public Frm_Principal()
        {
            InitializeComponent();
        }

        private void Frm_Principal_Load(object sender, EventArgs e)
        {
            AtualizarComboBoxPendrives();
        }

        private void btn_Atualizar_Click(object sender, EventArgs e)
        {
            combo_Pendrive.Items.Clear();

            AtualizarComboBoxPendrives();
        }

        private void combo_Pendrive_SelectedIndexChanged(object sender, EventArgs e)
        {
            foreach (var item in Pendrive.listar())
            {
                if (item.RootDirectory.ToString() == combo_Pendrive.Text)
                {
                    Txt_NomePendrive.Text = item.VolumeLabel.ToString();

                    AtualizarLabels(item);

                    pendrive.Informacoes = item;
                }
            }
        }

        private void Btm_Reparar_Click(object sender, EventArgs e)
        {
            reparar();
        }

        private void reparar()
        {
            if (combo_Pendrive.Items.Count != 0)
            {
                if (pendrive.Informacoes.IsReady)
                {
                    try
                    {
                        pendrive.Reparar();

                        MessageBox.Show($"Pendrive reparado com sucesso!",
                                        "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Ocorreu um erro ao tentar reparar o pendrive: {ex.Message}",
                                        "Erro", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }

                }
                else
                {
                    var resutado = MessageBox.Show("Ocorreu um erro ao fazer a comunicação com o pendrive!, verifique o pendrive e tente novamente!",
                         "Erro", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);

                    if (resutado == DialogResult.Retry)
                    {
                        reparar();
                    }
                }
            }
            else
            {
                MessageBox.Show("Insira um pendrive!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }


        private void AtualizarComboBoxPendrives()
        {
            foreach (var item in Pendrive.listar())
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
            Lbl_Livre.Text = $"{Ferramentas.ConverterEmGigabytes(InformacoesPendrive.AvailableFreeSpace).ToString("0.00")} GB";
            Lbl_SistemaDeArquivos.Text = InformacoesPendrive.DriveFormat;
            Lbl_TamanhoTotal.Text = $"{Ferramentas.ConverterEmGigabytes(InformacoesPendrive.TotalSize).ToString("0.00")} GB";

            var Utilizado = Ferramentas.ConverterEmGigabytes(InformacoesPendrive.TotalSize) - Ferramentas.ConverterEmGigabytes(InformacoesPendrive.AvailableFreeSpace);

            Lbl_Utilizado.Text = $"{Utilizado.ToString("0.00")} GB";
        }
    }
}
