using System;
using System.Windows.Forms;
using Bootverhuur__t_Sloepke.Classes;

namespace Bootverhuur__t_Sloepke
{
    public partial class HuurAanmaken : Form
    {
        private Huur hr = new Huur();
        public HuurAanmaken()
        {
            InitializeComponent();
            listVaarwater.DataSource = null;
            listBoot.DataSource = null;
            listMateriaal.DataSource = Materiaal.GetAllMateriaal();
            cbBoot.DataSource = Boot.GetTypes();
        }

        private void cbBoot_SelectedIndexChanged(object sender, EventArgs e)
        {
            listBoot.DataSource = null;
            listBoot.DataSource = Boot.GetBoats(cbBoot.SelectedValue.ToString());
            listVaarwater.DataSource = null;
            listVaarwater.DataSource = Vaarplaats.GetAllVaarplaatsen(cbBoot.SelectedValue.ToString());
        }

        private void btnBereken_Click(object sender, EventArgs e)
        {
            hr.UpdateBoot((Boot)listBoot.SelectedItem);
            hr.UpdateMateriaal(listMateriaal.SelectedItems);
            hr.UpdateVaarwater(listVaarwater.SelectedItems);
            hr.UpdateData(dtpBegin.Value, dtpEind.Value);
            lblMeren.Text = hr.CalculateVaarplaatsen(nudBudget.Value).ToString();
        }

        private void btnOpslaan_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(tbEmail.Text) || string.IsNullOrWhiteSpace(tbHuurder.Text) ||
                string.IsNullOrWhiteSpace(tbVerhuurder.Text))
            {
                MessageBox.Show("Vul alle velden in!");
                return;
            }
            bool succ = hr.AddHuur(tbEmail.Text, tbHuurder.Text, tbVerhuurder.Text, (Boot)listBoot.SelectedItem,
                listMateriaal.SelectedItems, listVaarwater.SelectedItems, dtpBegin.Value, dtpEind.Value, nudBudget.Value);
            if (!succ)
            {
                MessageBox.Show("Er is iets fout gegaan bij het toevoegen!");
            }
        }

        private void btnToon_Click(object sender, EventArgs e)
        {
            Huurcontracten show = new Huurcontracten(hr);
            show.Show();
        }

        private void btnExporteerContract_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(tbEmail.Text) || string.IsNullOrWhiteSpace(tbHuurder.Text) ||
            string.IsNullOrWhiteSpace(tbVerhuurder.Text))
            {
                MessageBox.Show("Vul alle velden in!");
                return;
            }
            FolderBrowserDialog fbd = new FolderBrowserDialog();

            DialogResult result = fbd.ShowDialog();

            if (result != DialogResult.OK) return;
            hr.UpdateHuurCompletely(tbEmail.Text, tbHuurder.Text, tbVerhuurder.Text, (Boot)listBoot.SelectedItem,
                listMateriaal.SelectedItems, listVaarwater.SelectedItems, dtpBegin.Value, dtpEind.Value, nudBudget.Value);
            hr.ExportHuur(fbd, 0);
        }

        private void btnAddVaarwater_Click(object sender, EventArgs e)
        {
            AddVaarplaats show = new AddVaarplaats();
            show.ShowDialog();
        }

        private void btnExportHTML_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(tbEmail.Text) || string.IsNullOrWhiteSpace(tbHuurder.Text) ||
            string.IsNullOrWhiteSpace(tbVerhuurder.Text))
            {
                MessageBox.Show("Vul alle velden in!");
                return;
            }
            FolderBrowserDialog fbd = new FolderBrowserDialog();

            DialogResult result = fbd.ShowDialog();

            if (result != DialogResult.OK) return;
            hr.UpdateHuurCompletely(tbEmail.Text, tbHuurder.Text, tbVerhuurder.Text, (Boot)listBoot.SelectedItem,
                listMateriaal.SelectedItems, listVaarwater.SelectedItems, dtpBegin.Value, dtpEind.Value, nudBudget.Value);
            hr.ExportHuur(fbd, 1);
        }
    }
}

