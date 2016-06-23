using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Bootverhuur__t_Sloepke.Classes;

namespace Bootverhuur__t_Sloepke
{
    public partial class Huurcontracten : Form
    {
        private Huur Hr;
        public Huurcontracten(Huur hr)
        {
            InitializeComponent();
            Hr = hr;
            lbHuurcontracten.DataSource = Hr.GetAllHuren();
        }
    }
}
