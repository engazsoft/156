namespace trader_app.PL.INV
{
    partial class frm_INV_Mov_order
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.cbx_inv_to = new System.Windows.Forms.ComboBox();
            this.label_from = new System.Windows.Forms.Label();
            this.dtb_mov_date = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.dgv_mov_line = new System.Windows.Forms.DataGridView();
            this.M = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.product_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.A_N = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Product_disc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Unit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quantityin = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txt_Reason = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txt_Note = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.cbx_cost_canter = new System.Windows.Forms.ComboBox();
            this.chbx_stope = new System.Windows.Forms.CheckBox();
            this.chbx_deported = new System.Windows.Forms.CheckBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.button2 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
            this.txt_tran_Num = new System.Windows.Forms.TextBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cbx_Inv_from = new System.Windows.Forms.ComboBox();
            this.label_to = new System.Windows.Forms.Label();
            this.txt_refer_num = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox_Data.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_mov_line)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // label9
            // 
            this.label9.Location = new System.Drawing.Point(776, 49);
            this.label9.Size = new System.Drawing.Size(87, 13);
            this.label9.Text = "رقم سند التجويل ";
            // 
            // txt_id
            // 
            this.txt_id.BackColor = System.Drawing.Color.White;
            this.txt_id.Location = new System.Drawing.Point(606, 48);
            this.txt_id.ReadOnly = true;
            this.txt_id.Tag = "Movmant_num";
            // 
            // groupBox1
            // 
            this.groupBox1.Location = new System.Drawing.Point(0, 427);
            this.groupBox1.Size = new System.Drawing.Size(964, 60);
            // 
            // groupBox2
            // 
            this.groupBox2.Size = new System.Drawing.Size(94, 427);
            // 
            // btn_edit
            // 
            this.btn_edit.Click += new System.EventHandler(this.btn_edit_Click);
            // 
            // btn_seve
            // 
            this.btn_seve.Click += new System.EventHandler(this.btn_seve_Click);
            // 
            // btn_view
            // 
            this.btn_view.Click += new System.EventHandler(this.btn_view_Click);
            // 
            // btn_add
            // 
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // groupBox_Data
            // 
            this.groupBox_Data.Controls.Add(this.txt_refer_num);
            this.groupBox_Data.Controls.Add(this.label14);
            this.groupBox_Data.Controls.Add(this.groupBox3);
            this.groupBox_Data.Controls.Add(this.chbx_deported);
            this.groupBox_Data.Controls.Add(this.chbx_stope);
            this.groupBox_Data.Controls.Add(this.label11);
            this.groupBox_Data.Controls.Add(this.cbx_cost_canter);
            this.groupBox_Data.Controls.Add(this.txt_Note);
            this.groupBox_Data.Controls.Add(this.txt_Reason);
            this.groupBox_Data.Controls.Add(this.label3);
            this.groupBox_Data.Controls.Add(this.dtb_mov_date);
            this.groupBox_Data.Controls.Add(this.label10);
            this.groupBox_Data.Controls.Add(this.label_from);
            this.groupBox_Data.Controls.Add(this.label8);
            this.groupBox_Data.Controls.Add(this.label_to);
            this.groupBox_Data.Controls.Add(this.cbx_inv_to);
            this.groupBox_Data.Controls.Add(this.cbx_Inv_from);
            this.groupBox_Data.Size = new System.Drawing.Size(870, 202);
            this.groupBox_Data.Tag = "INV_Product_Movmant";
            this.groupBox_Data.Enter += new System.EventHandler(this.groupBox_Data_Enter);
            this.groupBox_Data.Controls.SetChildIndex(this.cbx_Inv_from, 0);
            this.groupBox_Data.Controls.SetChildIndex(this.cbx_inv_to, 0);
            this.groupBox_Data.Controls.SetChildIndex(this.label_to, 0);
            this.groupBox_Data.Controls.SetChildIndex(this.label8, 0);
            this.groupBox_Data.Controls.SetChildIndex(this.label_from, 0);
            this.groupBox_Data.Controls.SetChildIndex(this.label10, 0);
            this.groupBox_Data.Controls.SetChildIndex(this.dtb_mov_date, 0);
            this.groupBox_Data.Controls.SetChildIndex(this.label3, 0);
            this.groupBox_Data.Controls.SetChildIndex(this.txt_Reason, 0);
            this.groupBox_Data.Controls.SetChildIndex(this.txt_Note, 0);
            this.groupBox_Data.Controls.SetChildIndex(this.cbx_cost_canter, 0);
            this.groupBox_Data.Controls.SetChildIndex(this.label11, 0);
            this.groupBox_Data.Controls.SetChildIndex(this.chbx_stope, 0);
            this.groupBox_Data.Controls.SetChildIndex(this.chbx_deported, 0);
            this.groupBox_Data.Controls.SetChildIndex(this.groupBox3, 0);
            this.groupBox_Data.Controls.SetChildIndex(this.txt_id, 0);
            this.groupBox_Data.Controls.SetChildIndex(this.label9, 0);
            this.groupBox_Data.Controls.SetChildIndex(this.label14, 0);
            this.groupBox_Data.Controls.SetChildIndex(this.txt_refer_num, 0);
            // 
            // cbx_inv_to
            // 
            this.cbx_inv_to.FormattingEnabled = true;
            this.cbx_inv_to.Location = new System.Drawing.Point(339, 14);
            this.cbx_inv_to.Name = "cbx_inv_to";
            this.cbx_inv_to.Size = new System.Drawing.Size(160, 21);
            this.cbx_inv_to.TabIndex = 2;
            // 
            // label_from
            // 
            this.label_from.AutoSize = true;
            this.label_from.Location = new System.Drawing.Point(509, 14);
            this.label_from.Name = "label_from";
            this.label_from.Size = new System.Drawing.Size(96, 13);
            this.label_from.TabIndex = 3;
            this.label_from.Text = "المخزن المخول الية ";
            // 
            // dtb_mov_date
            // 
            this.dtb_mov_date.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtb_mov_date.Location = new System.Drawing.Point(339, 42);
            this.dtb_mov_date.Name = "dtb_mov_date";
            this.dtb_mov_date.Size = new System.Drawing.Size(160, 20);
            this.dtb_mov_date.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(532, 48);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "تاريخ التحويل";
            // 
            // dgv_mov_line
            // 
            this.dgv_mov_line.BackgroundColor = System.Drawing.Color.GhostWhite;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_mov_line.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_mov_line.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_mov_line.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.M,
            this.product_ID,
            this.A_N,
            this.Product_disc,
            this.Unit,
            this.Quantity,
            this.Quantityin});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(77)))), ((int)(((byte)(147)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_mov_line.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgv_mov_line.Location = new System.Drawing.Point(94, 208);
            this.dgv_mov_line.MultiSelect = false;
            this.dgv_mov_line.Name = "dgv_mov_line";
            this.dgv_mov_line.Size = new System.Drawing.Size(870, 219);
            this.dgv_mov_line.TabIndex = 13;
            this.dgv_mov_line.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_mov_line_CellContentClick);
            this.dgv_mov_line.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_mov_line_CellEndEdit);
            this.dgv_mov_line.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_mov_line_CellValueChanged_1);
            this.dgv_mov_line.Enter += new System.EventHandler(this.dgv_mov_line_Enter);
            this.dgv_mov_line.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dgv_mov_line_KeyDown);
            // 
            // M
            // 
            this.M.Frozen = true;
            this.M.HeaderText = "م";
            this.M.Name = "M";
            this.M.Width = 40;
            // 
            // product_ID
            // 
            this.product_ID.HeaderText = "رقم المنتج";
            this.product_ID.Name = "product_ID";
            // 
            // A_N
            // 
            this.A_N.HeaderText = "اسم المنتج";
            this.A_N.Name = "A_N";
            this.A_N.Width = 200;
            // 
            // Product_disc
            // 
            this.Product_disc.HeaderText = "وصف المنتج";
            this.Product_disc.Name = "Product_disc";
            this.Product_disc.Width = 200;
            // 
            // Unit
            // 
            this.Unit.HeaderText = "الوحدة";
            this.Unit.Name = "Unit";
            this.Unit.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // Quantity
            // 
            this.Quantity.HeaderText = "الكمية";
            this.Quantity.Name = "Quantity";
            // 
            // Quantityin
            // 
            this.Quantityin.HeaderText = "الكمية المتوفرة";
            this.Quantityin.Name = "Quantityin";
            // 
            // txt_Reason
            // 
            this.txt_Reason.Location = new System.Drawing.Point(8, 14);
            this.txt_Reason.Name = "txt_Reason";
            this.txt_Reason.Size = new System.Drawing.Size(285, 20);
            this.txt_Reason.TabIndex = 6;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(299, 14);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(39, 13);
            this.label8.TabIndex = 3;
            this.label8.Text = "السبب";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(299, 49);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(31, 13);
            this.label10.TabIndex = 3;
            this.label10.Text = "البيان";
            // 
            // txt_Note
            // 
            this.txt_Note.Location = new System.Drawing.Point(8, 46);
            this.txt_Note.Name = "txt_Note";
            this.txt_Note.Size = new System.Drawing.Size(285, 20);
            this.txt_Note.TabIndex = 6;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(776, 77);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(63, 13);
            this.label11.TabIndex = 8;
            this.label11.Text = "مركز التكلفة";
            // 
            // cbx_cost_canter
            // 
            this.cbx_cost_canter.FormattingEnabled = true;
            this.cbx_cost_canter.Location = new System.Drawing.Point(606, 74);
            this.cbx_cost_canter.Name = "cbx_cost_canter";
            this.cbx_cost_canter.Size = new System.Drawing.Size(160, 21);
            this.cbx_cost_canter.TabIndex = 7;
            // 
            // chbx_stope
            // 
            this.chbx_stope.AutoSize = true;
            this.chbx_stope.Location = new System.Drawing.Point(91, 74);
            this.chbx_stope.Name = "chbx_stope";
            this.chbx_stope.Size = new System.Drawing.Size(88, 17);
            this.chbx_stope.TabIndex = 9;
            this.chbx_stope.Text = "تعليق العملة ";
            this.chbx_stope.UseVisualStyleBackColor = true;
            // 
            // chbx_deported
            // 
            this.chbx_deported.AutoSize = true;
            this.chbx_deported.Enabled = false;
            this.chbx_deported.Location = new System.Drawing.Point(5, 73);
            this.chbx_deported.Name = "chbx_deported";
            this.chbx_deported.Size = new System.Drawing.Size(52, 17);
            this.chbx_deported.TabIndex = 10;
            this.chbx_deported.Text = "مرحل";
            this.chbx_deported.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.button2);
            this.groupBox3.Controls.Add(this.textBox1);
            this.groupBox3.Controls.Add(this.button1);
            this.groupBox3.Controls.Add(this.label13);
            this.groupBox3.Controls.Add(this.txt_tran_Num);
            this.groupBox3.Controls.Add(this.comboBox2);
            this.groupBox3.Controls.Add(this.label12);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.comboBox1);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox3.Location = new System.Drawing.Point(3, 118);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(864, 81);
            this.groupBox3.TabIndex = 15;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "انزال الاصناف و التكاليف";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(304, 48);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 18;
            this.button2.Text = "النزال ";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(385, 50);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(115, 20);
            this.textBox1.TabIndex = 17;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(304, 19);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 18;
            this.button1.Text = "النزال ";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(507, 53);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(77, 13);
            this.label13.TabIndex = 16;
            this.label13.Text = "رقم امر التحويل";
            // 
            // txt_tran_Num
            // 
            this.txt_tran_Num.Location = new System.Drawing.Point(385, 21);
            this.txt_tran_Num.Name = "txt_tran_Num";
            this.txt_tran_Num.Size = new System.Drawing.Size(115, 20);
            this.txt_tran_Num.TabIndex = 17;
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(590, 48);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(160, 21);
            this.comboBox2.TabIndex = 2;
            this.comboBox2.SelectedIndexChanged += new System.EventHandler(this.cbx_Inv_from_SelectedIndexChanged);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(507, 24);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(77, 13);
            this.label12.TabIndex = 16;
            this.label12.Text = "رقم امر التحويل";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(756, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "طريقة تكاليف الاصناف";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(590, 19);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(160, 21);
            this.comboBox1.TabIndex = 2;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.cbx_Inv_from_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(756, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "انزال الاصناف من";
            // 
            // cbx_Inv_from
            // 
            this.cbx_Inv_from.FormattingEnabled = true;
            this.cbx_Inv_from.Location = new System.Drawing.Point(606, 14);
            this.cbx_Inv_from.Name = "cbx_Inv_from";
            this.cbx_Inv_from.Size = new System.Drawing.Size(160, 21);
            this.cbx_Inv_from.TabIndex = 2;
            this.cbx_Inv_from.SelectedIndexChanged += new System.EventHandler(this.cbx_Inv_from_SelectedIndexChanged);
            // 
            // label_to
            // 
            this.label_to.AutoSize = true;
            this.label_to.Location = new System.Drawing.Point(776, 14);
            this.label_to.Name = "label_to";
            this.label_to.Size = new System.Drawing.Size(93, 13);
            this.label_to.TabIndex = 3;
            this.label_to.Text = "المخزن المحول منة";
            // 
            // txt_refer_num
            // 
            this.txt_refer_num.Location = new System.Drawing.Point(458, 74);
            this.txt_refer_num.Name = "txt_refer_num";
            this.txt_refer_num.Size = new System.Drawing.Size(78, 20);
            this.txt_refer_num.TabIndex = 21;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(542, 77);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(58, 13);
            this.label14.TabIndex = 20;
            this.label14.Text = "رقم المرجع";
            // 
            // frm_INV_Mov_order
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(964, 487);
            this.Controls.Add(this.dgv_mov_line);
            this.Name = "frm_INV_Mov_order";
            this.Tag = "INV_Product_Movmant";
            this.Text = "frm_INV_order";
            this.Load += new System.EventHandler(this.frm_INV_order_Load);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.frm_INV_Mov_order_KeyUp);
            this.Controls.SetChildIndex(this.dgv_mov_line, 0);
            this.Controls.SetChildIndex(this.groupBox1, 0);
            this.Controls.SetChildIndex(this.groupBox2, 0);
            this.Controls.SetChildIndex(this.groupBox_Data, 0);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox_Data.ResumeLayout(false);
            this.groupBox_Data.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_mov_line)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dtb_mov_date;
        private System.Windows.Forms.Label label_from;
        private System.Windows.Forms.ComboBox cbx_inv_to;
        private System.Windows.Forms.DataGridView dgv_mov_line;
        private System.Windows.Forms.TextBox txt_Note;
        private System.Windows.Forms.TextBox txt_Reason;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox cbx_cost_canter;
        private System.Windows.Forms.CheckBox chbx_deported;
        private System.Windows.Forms.CheckBox chbx_stope;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridViewTextBoxColumn M;
        private System.Windows.Forms.DataGridViewTextBoxColumn product_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn A_N;
        private System.Windows.Forms.DataGridViewTextBoxColumn Product_disc;
        private System.Windows.Forms.DataGridViewTextBoxColumn Unit;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quantityin;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txt_tran_Num;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label_to;
        private System.Windows.Forms.ComboBox cbx_Inv_from;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_refer_num;
        private System.Windows.Forms.Label label14;
    }
}