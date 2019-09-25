namespace trader_app.PL.Am
{
    partial class frm_Account_request_dgv
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
            this.dgv_Account_request = new System.Windows.Forms.DataGridView();
            this.txt_search = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Account_request)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_Account_request
            // 
            this.dgv_Account_request.AllowUserToAddRows = false;
            this.dgv_Account_request.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_Account_request.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Account_request.Location = new System.Drawing.Point(4, 144);
            this.dgv_Account_request.MultiSelect = false;
            this.dgv_Account_request.Name = "dgv_Account_request";
            this.dgv_Account_request.RowTemplate.Height = 24;
            this.dgv_Account_request.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_Account_request.Size = new System.Drawing.Size(1203, 479);
            this.dgv_Account_request.TabIndex = 0;
            this.dgv_Account_request.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_Account_request_CellContentClick);
            // 
            // txt_search
            // 
            this.txt_search.Location = new System.Drawing.Point(350, 89);
            this.txt_search.Multiline = true;
            this.txt_search.Name = "txt_search";
            this.txt_search.Size = new System.Drawing.Size(612, 29);
            this.txt_search.TabIndex = 1;
            this.txt_search.TextChanged += new System.EventHandler(this.txt_search_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(252, 92);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 17);
            this.label2.TabIndex = 13;
            this.label2.Text = "رقم الاحساب";
            // 
            // frm_Account_request_dgv
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1209, 623);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_search);
            this.Controls.Add(this.dgv_Account_request);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm_Account_request_dgv";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.Text = "frm_Account_request_dgv";
            this.Load += new System.EventHandler(this.frm_Account_request_dgv_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Account_request)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.DataGridView dgv_Account_request;
        private System.Windows.Forms.TextBox txt_search;
        private System.Windows.Forms.Label label2;
    }
}