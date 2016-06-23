using System.Windows.Forms;
using Bootverhuur__t_Sloepke.Classes;

namespace Bootverhuur__t_Sloepke
{
    public partial class Huurcontracten : Form
    {
        public Huurcontracten(Huur hr)
        {
            InitializeComponent();
            lbHuurcontracten.DataSource = hr.GetAllHuren();
        }
    }
}
