using System;
using System.Windows.Forms;
using Bootverhuur__t_Sloepke.Classes;

namespace Bootverhuur__t_Sloepke
{
    public partial class AddVaarplaats : Form
    {
        private Vaarplaats _vp = new Vaarplaats();
        public AddVaarplaats()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(tbVaarplaats.Text)) return;
            if (_vp.AddVaarplaats(tbVaarplaats.Text))
            {
                Close();
            }
        }
    }
}
