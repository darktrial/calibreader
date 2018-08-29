namespace calibreader
{
    partial class Form1
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.viewcali = new System.Windows.Forms.DataGridView();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripTextBox1 = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripTextBox3 = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripTextBox4 = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripTextBox5 = new System.Windows.Forms.ToolStripTextBox();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lens_type = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.focus_idx = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.zoom_idx = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.inf_tele_focus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.inf_wide_focus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.focus_dynamic_offset = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.show_log = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.viewcali)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // viewcali
            // 
            this.viewcali.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.viewcali.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.viewcali.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.viewcali.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.viewcali.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.lens_type,
            this.focus_idx,
            this.zoom_idx,
            this.inf_tele_focus,
            this.inf_wide_focus,
            this.focus_dynamic_offset,
            this.show_log});
            this.viewcali.Location = new System.Drawing.Point(0, 27);
            this.viewcali.Name = "viewcali";
            this.viewcali.RowTemplate.Height = 24;
            this.viewcali.Size = new System.Drawing.Size(887, 424);
            this.viewcali.TabIndex = 0;
            this.viewcali.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.viewcali_CellContentClick);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.toolStripMenuItem2,
            this.toolStripMenuItem3});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(887, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripTextBox1});
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(39, 20);
            this.toolStripMenuItem1.Text = "File";
            // 
            // toolStripTextBox1
            // 
            this.toolStripTextBox1.Name = "toolStripTextBox1";
            this.toolStripTextBox1.Size = new System.Drawing.Size(100, 23);
            this.toolStripTextBox1.Text = "Open";
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripTextBox3});
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(56, 20);
            this.toolStripMenuItem2.Text = "Folder";
            // 
            // toolStripTextBox3
            // 
            this.toolStripTextBox3.Name = "toolStripTextBox3";
            this.toolStripTextBox3.Size = new System.Drawing.Size(100, 23);
            this.toolStripTextBox3.Text = "Open";
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripTextBox4,
            this.toolStripTextBox5});
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(47, 20);
            this.toolStripMenuItem3.Text = "Help";
            // 
            // toolStripTextBox4
            // 
            this.toolStripTextBox4.Name = "toolStripTextBox4";
            this.toolStripTextBox4.Size = new System.Drawing.Size(100, 23);
            this.toolStripTextBox4.Text = "Check update";
            // 
            // toolStripTextBox5
            // 
            this.toolStripTextBox5.Name = "toolStripTextBox5";
            this.toolStripTextBox5.Size = new System.Drawing.Size(100, 23);
            this.toolStripTextBox5.Text = "About";
            // 
            // id
            // 
            this.id.HeaderText = "ID";
            this.id.Name = "id";
            // 
            // lens_type
            // 
            this.lens_type.HeaderText = "lens_type";
            this.lens_type.Name = "lens_type";
            // 
            // focus_idx
            // 
            this.focus_idx.HeaderText = "focus_idx";
            this.focus_idx.Name = "focus_idx";
            // 
            // zoom_idx
            // 
            this.zoom_idx.HeaderText = "zoom_idx";
            this.zoom_idx.Name = "zoom_idx";
            // 
            // inf_tele_focus
            // 
            this.inf_tele_focus.HeaderText = "inf_tele_focus";
            this.inf_tele_focus.Name = "inf_tele_focus";
            // 
            // inf_wide_focus
            // 
            this.inf_wide_focus.HeaderText = "inf_wide_focus";
            this.inf_wide_focus.Name = "inf_wide_focus";
            // 
            // focus_dynamic_offset
            // 
            this.focus_dynamic_offset.HeaderText = "focus_dynamic_offset";
            this.focus_dynamic_offset.Name = "focus_dynamic_offset";
            // 
            // show_log
            // 
            this.show_log.HeaderText = "Show_log";
            this.show_log.Name = "show_log";
            this.show_log.Text = "Show log";
            this.show_log.UseColumnTextForButtonValue = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(887, 450);
            this.Controls.Add(this.viewcali);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.viewcali)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView viewcali;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripTextBox toolStripTextBox1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.ToolStripTextBox toolStripTextBox3;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem3;
        private System.Windows.Forms.ToolStripTextBox toolStripTextBox4;
        private System.Windows.Forms.ToolStripTextBox toolStripTextBox5;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn lens_type;
        private System.Windows.Forms.DataGridViewTextBoxColumn focus_idx;
        private System.Windows.Forms.DataGridViewTextBoxColumn zoom_idx;
        private System.Windows.Forms.DataGridViewTextBoxColumn inf_tele_focus;
        private System.Windows.Forms.DataGridViewTextBoxColumn inf_wide_focus;
        private System.Windows.Forms.DataGridViewTextBoxColumn focus_dynamic_offset;
        private System.Windows.Forms.DataGridViewButtonColumn show_log;
    }
}

