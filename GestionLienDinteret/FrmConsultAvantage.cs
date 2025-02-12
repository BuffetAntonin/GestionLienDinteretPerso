using GesLienBLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GesLienGUI
{
    public partial class FrmConsultAvantage : Form
    {
        public FrmConsultAvantage()
        {
            InitializeComponent();
            // Pour envoyer les Produit au DATAGRID
            this.dtgAvantages.DataSource = AvantageManager.GetInstance().GetAvantage();
            this.dtgAvantages.Columns["id"].Visible = false;
            this.dtgAvantages.Columns["unBeneficiaire"].Visible = false;
            this.dtgAvantages.Columns["unEmploye"].Visible = false;
            this.dtgAvantages.Columns["uneNature"].Visible = false;
        }
    }
}
