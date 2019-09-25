using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace trader_app.PL.AC
{
    public partial class frm_daily_journal : PL.order_frm
    {
        public frm_daily_journal()
        {
            InitializeComponent();
        }
        DAL.Databas_Class DB = new DAL.Databas_Class();
        DAL.DataAccessLayer dal = new DAL.DataAccessLayer();

        private void frm_daily_journal_Load(object sender, EventArgs e)
        {
            
            DB.LoadCombo(cbx_doc_type, "select ID, convert(nvarchar,Type_num) +''+A_N A_N from AM_Documant_Type where Type='Daily_Journa'", "A_N", "ID",1);
        }

        private void groupBox_Data_Enter(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btn_add_Click(object sender, EventArgs e)
        {

        }
    }
}
