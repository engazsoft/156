namespace trader_app.PL
{
    partial class add_form
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_edit_user = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_edit_date = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_in_date = new System.Windows.Forms.TextBox();
            this.txt_by_user = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btn_repeal = new System.Windows.Forms.Button();
            this.btn_dele = new System.Windows.Forms.Button();
            this.btn_serch = new System.Windows.Forms.Button();
            this.btn_edit = new System.Windows.Forms.Button();
            this.btn_seve = new System.Windows.Forms.Button();
            this.btn_exit = new System.Windows.Forms.Button();
            this.btn_view = new System.Windows.Forms.Button();
            this.btn_add = new System.Windows.Forms.Button();
            this.groupBox_Data = new System.Windows.Forms.GroupBox();
            this.btn_ifect_account = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.txt_edit_user);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txt_edit_date);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txt_in_date);
            this.groupBox1.Controls.Add(this.txt_by_user);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox1.Location = new System.Drawing.Point(0, 398);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupBox1.Size = new System.Drawing.Size(789, 60);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::trader_app.Properties.Resources.انجاز;
            this.pictureBox1.Location = new System.Drawing.Point(387, 11);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(46, 44);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(711, 14);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(63, 13);
            this.label7.TabIndex = 8;
            this.label7.Text = "تاريخ الادخال";
            // 
            // txt_edit_user
            // 
            this.txt_edit_user.Location = new System.Drawing.Point(75, 32);
            this.txt_edit_user.Name = "txt_edit_user";
            this.txt_edit_user.Size = new System.Drawing.Size(208, 20);
            this.txt_edit_user.TabIndex = 7;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(709, 35);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(67, 13);
            this.label6.TabIndex = 6;
            this.label6.Text = "تاريخ التعديل ";
            // 
            // txt_edit_date
            // 
            this.txt_edit_date.Location = new System.Drawing.Point(486, 32);
            this.txt_edit_date.Name = "txt_edit_date";
            this.txt_edit_date.Size = new System.Drawing.Size(208, 20);
            this.txt_edit_date.TabIndex = 5;
            this.txt_edit_date.TextChanged += new System.EventHandler(this.txt_edit_date_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(291, 32);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "معدل اسجل";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(290, 15);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "مدخل السجل";
            // 
            // txt_in_date
            // 
            this.txt_in_date.Location = new System.Drawing.Point(486, 11);
            this.txt_in_date.Name = "txt_in_date";
            this.txt_in_date.Size = new System.Drawing.Size(208, 20);
            this.txt_in_date.TabIndex = 9;
            // 
            // txt_by_user
            // 
            this.txt_by_user.Location = new System.Drawing.Point(75, 10);
            this.txt_by_user.Name = "txt_by_user";
            this.txt_by_user.Size = new System.Drawing.Size(208, 20);
            this.txt_by_user.TabIndex = 3;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btn_ifect_account);
            this.groupBox2.Controls.Add(this.btn_repeal);
            this.groupBox2.Controls.Add(this.btn_dele);
            this.groupBox2.Controls.Add(this.btn_serch);
            this.groupBox2.Controls.Add(this.btn_edit);
            this.groupBox2.Controls.Add(this.btn_seve);
            this.groupBox2.Controls.Add(this.btn_exit);
            this.groupBox2.Controls.Add(this.btn_view);
            this.groupBox2.Controls.Add(this.btn_add);
            this.groupBox2.Cursor = System.Windows.Forms.Cursors.No;
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupBox2.Location = new System.Drawing.Point(0, 0);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupBox2.Size = new System.Drawing.Size(94, 398);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "البيانات";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // btn_repeal
            // 
            this.btn_repeal.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.btn_repeal.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_repeal.Enabled = false;
            this.btn_repeal.Location = new System.Drawing.Point(3, 180);
            this.btn_repeal.Name = "btn_repeal";
            this.btn_repeal.Size = new System.Drawing.Size(88, 23);
            this.btn_repeal.TabIndex = 5;
            this.btn_repeal.Text = "الغاء";
            this.btn_repeal.UseVisualStyleBackColor = true;
            this.btn_repeal.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // btn_dele
            // 
            this.btn_dele.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.btn_dele.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_dele.Enabled = false;
            this.btn_dele.Location = new System.Drawing.Point(3, 154);
            this.btn_dele.Name = "btn_dele";
            this.btn_dele.Size = new System.Drawing.Size(88, 26);
            this.btn_dele.TabIndex = 6;
            this.btn_dele.Text = "حذف اسجل";
            this.btn_dele.UseVisualStyleBackColor = true;
            this.btn_dele.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn_serch
            // 
            this.btn_serch.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.btn_serch.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_serch.Enabled = false;
            this.btn_serch.Location = new System.Drawing.Point(3, 131);
            this.btn_serch.Name = "btn_serch";
            this.btn_serch.Size = new System.Drawing.Size(88, 23);
            this.btn_serch.TabIndex = 0;
            this.btn_serch.Text = "بحث";
            this.btn_serch.UseCompatibleTextRendering = true;
            this.btn_serch.UseVisualStyleBackColor = true;
            // 
            // btn_edit
            // 
            this.btn_edit.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.btn_edit.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_edit.Enabled = false;
            this.btn_edit.Location = new System.Drawing.Point(3, 108);
            this.btn_edit.Name = "btn_edit";
            this.btn_edit.Size = new System.Drawing.Size(88, 23);
            this.btn_edit.TabIndex = 3;
            this.btn_edit.Text = "تعديل ";
            this.btn_edit.UseVisualStyleBackColor = true;
            this.btn_edit.Click += new System.EventHandler(this.btn_edit_Click);
            // 
            // btn_seve
            // 
            this.btn_seve.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.btn_seve.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_seve.Enabled = false;
            this.btn_seve.Location = new System.Drawing.Point(3, 85);
            this.btn_seve.Name = "btn_seve";
            this.btn_seve.Size = new System.Drawing.Size(88, 23);
            this.btn_seve.TabIndex = 4;
            this.btn_seve.Text = "حفظ";
            this.btn_seve.UseVisualStyleBackColor = true;
            this.btn_seve.Click += new System.EventHandler(this.btn_seve_Click);
            // 
            // btn_exit
            // 
            this.btn_exit.AccessibleDescription = "خروج ";
            this.btn_exit.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.btn_exit.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_exit.Location = new System.Drawing.Point(3, 62);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(88, 23);
            this.btn_exit.TabIndex = 6;
            this.btn_exit.Tag = "extre";
            this.btn_exit.Text = "خروج";
            this.btn_exit.UseVisualStyleBackColor = true;
            this.btn_exit.Click += new System.EventHandler(this.btn_exit_Click);
            // 
            // btn_view
            // 
            this.btn_view.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.btn_view.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_view.Enabled = false;
            this.btn_view.Location = new System.Drawing.Point(3, 39);
            this.btn_view.Name = "btn_view";
            this.btn_view.Size = new System.Drawing.Size(88, 23);
            this.btn_view.TabIndex = 0;
            this.btn_view.Tag = "";
            this.btn_view.Text = "عرض";
            this.btn_view.UseVisualStyleBackColor = true;
            this.btn_view.Click += new System.EventHandler(this.button2_Click);
            // 
            // btn_add
            // 
            this.btn_add.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.btn_add.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_add.Enabled = false;
            this.btn_add.Location = new System.Drawing.Point(3, 16);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(88, 23);
            this.btn_add.TabIndex = 2;
            this.btn_add.Text = "جديد";
            this.btn_add.UseVisualStyleBackColor = true;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // groupBox_Data
            // 
            this.groupBox_Data.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox_Data.Location = new System.Drawing.Point(94, 0);
            this.groupBox_Data.Name = "groupBox_Data";
            this.groupBox_Data.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupBox_Data.Size = new System.Drawing.Size(695, 398);
            this.groupBox_Data.TabIndex = 12;
            this.groupBox_Data.TabStop = false;
            this.groupBox_Data.Text = "البيانات";
            this.groupBox_Data.Enter += new System.EventHandler(this.groupBox3_Enter);
            // 
            // btn_ifect_account
            // 
            this.btn_ifect_account.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.btn_ifect_account.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_ifect_account.Enabled = false;
            this.btn_ifect_account.Location = new System.Drawing.Point(3, 203);
            this.btn_ifect_account.Name = "btn_ifect_account";
            this.btn_ifect_account.Size = new System.Drawing.Size(88, 23);
            this.btn_ifect_account.TabIndex = 7;
            this.btn_ifect_account.Text = "الاثر المحاسبي";
            this.btn_ifect_account.UseVisualStyleBackColor = true;
            // 
            // add_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(789, 458);
            this.Controls.Add(this.groupBox_Data);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(77)))), ((int)(((byte)(147)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "add_form";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "شركة الحوشبي";
            this.Load += new System.EventHandler(this.add_form_Load);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.add_form_KeyPress);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.add_form_KeyUp);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        protected System.Windows.Forms.GroupBox groupBox1;
        protected System.Windows.Forms.Label label7;
        protected System.Windows.Forms.TextBox txt_edit_user;
        protected System.Windows.Forms.Label label6;
        protected System.Windows.Forms.TextBox txt_edit_date;
        protected System.Windows.Forms.Label label5;
        protected System.Windows.Forms.Label label4;
        protected System.Windows.Forms.TextBox txt_in_date;
        protected System.Windows.Forms.TextBox txt_by_user;
        private System.Windows.Forms.PictureBox pictureBox1;
        protected System.Windows.Forms.GroupBox groupBox2;
        protected System.Windows.Forms.Button btn_repeal;
        protected System.Windows.Forms.Button btn_dele;
        protected System.Windows.Forms.Button btn_serch;
        protected System.Windows.Forms.Button btn_edit;
        protected System.Windows.Forms.Button btn_seve;
        protected System.Windows.Forms.Button btn_exit;
        protected System.Windows.Forms.Button btn_view;
        protected System.Windows.Forms.Button btn_add;
        protected System.Windows.Forms.GroupBox groupBox_Data;
        protected System.Windows.Forms.Button btn_ifect_account;
    }
}