using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EasyTabs;
namespace trader_app.PL
{
    public partial class main : Form
    {
      static  DAL.Databas_Class DB=new DAL.Databas_Class();
        private int childFormNumber = 0;
        public static string Use_id = "1";
        public static int Btanch_ID = 1;
        public static int Fyear = 2019;
        public static DataRow currenc_locally = DB.select_Row("AM_Currency", "locally", "1");
        public main()
        {
            InitializeComponent();
           
        }
       
        private Point _imageLocation = new Point(13, 5);
        private Point _imgHitArea = new Point(13, 2);

        private void ShowNewForm(object sender, EventArgs e)
        {


        }

        private void OpenFile(object sender, EventArgs e)
        {


        }

        private void SaveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {


        }

        private void ExitToolsStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CutToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void CopyToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void PasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void ToolBarToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void StatusBarToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void CascadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.Cascade);
        }

        private void TileVerticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileVertical);
        }

        private void TileHorizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void ArrangeIconsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.ArrangeIcons);
        }

        private void CloseAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form childForm in MdiChildren)
            {
                childForm.Close();
            }
        }

        private void saveToolStripButton_Click(object sender, EventArgs e)
        {

        }

        private void انواعالصرفToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void انواعالاصناقToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PL.Am.Form_product_type frm = new Am.Form_product_type();
            frm.MdiParent = this;
            frm.Show();
        }
        public Image CloseImage;
        private void main_Load(object sender, EventArgs e)
        {
           // tabControl1.DrawMode = TabDrawMode.Normal;
          //  tabControl1.DrawItem += tabControl1_DrawItem;
            Image CloseImage = trader_app.Properties.Resources.Close_16;
          
        }

        private void مجموعاتالحساباتToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PL.AC.frm_Account_Group frm = new AC.frm_Account_Group();
            frm.MdiParent = this;
            frm.Show();
        }

        private void انواعالحساباتToolStripMenuItem_Click(object sender, EventArgs e)
        {

            PL.AC.frm_Account_type frm = new AC.frm_Account_type();
            frm.MdiParent = this;
            frm.Show();
        }

        private void وحداتالقياسToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void الاقاليموالدولToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PL.Am.frm_Country frm = new Am.frm_Country();
            frm.MdiParent = this.MdiParent;
            frm.Show();
           
        }

        private void العملاتToolStripMenuItem_Click(object sender, EventArgs e)
        {

            PL.Am.Frm_currency frm = new Am.Frm_currency();
            frm.MdiParent = this.MdiParent;
            frm.Show();
            //this.AddOwnedForm(frm);
        }

        private void المحافظاتToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PL.Am.frm_Governorates frm = new Am.frm_Governorates();
            frm.MdiParent = this;
            frm.Show();
        }

        private void المدنToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PL.Am.frm_Distinct frm = new Am.frm_Distinct();
            frm.MdiParent = this;
            frm.Show();
        }

        private void الشركاتToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PL.Am.Frm_Campny frm = new Am.Frm_Campny();
            frm.MdiParent = this;
            frm.Show();
        }

        private void الفروعToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PL.Am.frm_Branch frm = new Am.frm_Branch();
            frm.MdiParent = this;
            frm.Show();
        }

        private void المخازنToolStripMenuItem1_Click(object sender, EventArgs e)
        {

            PL.INV.Form_invantory frm = new INV.Form_invantory();
            frm.MdiParent = this;
            frm.Show();

        }

        private void تهيئةالنToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void امرتحويلمخزنيToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PL.INV.frm_INV_Mov_order frm = new INV.frm_INV_Mov_order("1", "امر تحويل مخزني");
            frm.MdiParent = this;
            frm.Show();
        }

        private void امرتوريدمخزنيToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PL.INV.form_INV_sup_ordar frm = new INV.form_INV_sup_ordar();
            frm.MdiParent = this;
            frm.Show();
        }

        private void استلامتحويلمخزنيToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PL.INV.frm_INV_Mov_order frm = new INV.frm_INV_Mov_order("2", "استلام_تحويل");
            frm.MdiParent = this;
            frm.Show();
        }

        private void عملياتالمخازنToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void الاصنافToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PL.INV.frm_Product frm = new INV.frm_Product();
            frm.MdiParent = this;
            frm.Show();
        }

        private void الدليلالمحاسبيToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PL.AC.frm_Account frm = new PL.AC.frm_Account();
            frm.MdiParent = this;
            frm.Show();
        }

        private void الموظفينToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PL.Am.Frm_Employees frm = new Am.Frm_Employees();
            frm.MdiParent = this;
            frm.Show();
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void tabControl1_MouseDown(object sender, MouseEventArgs e)
        {

        }

        private void المجموعاتالتفصيلبToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PL.INV.Form_Inventory_group frm = new INV.Form_Inventory_group();
            frm.MdiParent = this;
            frm.Show();
        }

        private void المجموعاتالرئسيةToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PL.INV.frm_product_Category frm = new INV.frm_product_Category();
            frm.MdiParent = this;
            frm.Show();
        }
   
        private void tabControl1_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        private void tabControl1_MouseDown_1(object sender, MouseEventArgs e)
        {

          
        }

        private void toolStripStatusLabel1_Click(object sender, EventArgs e)
        {

        }

        private void الصناديقToolStripMenuItem_Click(object sender, EventArgs e)
        {

            PL.AC.Frm_Cash_in_hand frm = new PL.AC.Frm_Cash_in_hand();
            frm.MdiParent = this;
            frm.Show();
        }

        private void البنوكToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PL.AC.Frm_CASH_AT_BANK frm =new AC.Frm_CASH_AT_BANK();
            frm.MdiParent = this;
            frm.Show();
        }

        private void طلبفتححسابToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PL.AC.frm_Account_request frm = new AC.frm_Account_request();
            frm.MdiParent = this;
            frm.Show();
        }

        private void تهيToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PL.AC.frm_Account_LMT frm = new AC.frm_Account_LMT();
            frm.MdiParent = this;
            frm.Show();
        }

        private void متغيراتنToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void تهيئةالعملاءToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void انواعبطايقالائتمانToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void انواعالموردينToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PL.SUP.frm_VENDOR_CLASS frm = new SUP.frm_VENDOR_CLASS();
            frm.MdiParent = this;
            frm.Show();
        }

        private void درجاتالموردينToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PL.SUP.frm_VENDOR_DEGREE frm = new SUP.frm_VENDOR_DEGREE();
            frm.MdiParent = this;
            frm.Show();
        }

        private void انواعاوامرالشراءToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PL.SUP.frm_IAS_PORDER_TYPES frm = new SUP.frm_IAS_PORDER_TYPES();
            frm.MdiParent = this;
            frm.Show();
        }

        private void انواعطلباتالشراءToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PL.SUP.frm_PREQ_TYPES frm = new SUP.frm_PREQ_TYPES();
            frm.MdiParent = this;
            frm.Show();
        }

        private void مجموعاتالموردينToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PL.SUP.FRM_VENDOR_GROUP frm = new SUP.FRM_VENDOR_GROUP();
            frm.MdiParent = this;
            frm.Show();
        }

        private void بياناتالموردينToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PL.SUP.FRM_V_DETAILS frm = new SUP.FRM_V_DETAILS();
            frm.MdiParent = this;
            frm.Show();
        }

        private void بياناتالتوريدToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PL.SUP.frm_VI_DETAILS frm = new SUP.frm_VI_DETAILS();
            frm.MdiParent = this;
            frm.Show();
        }
    }
}
