using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace trader_app.PL
{   
    public partial class tast : Form
    {
        BL.process_Class pro = new BL.process_Class();
        public tast()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = pro.select_data_row("[INV_Inventorys]", "[Invontory_ID]", 1);
        }
    }
}
