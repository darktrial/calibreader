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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle16 = new System.Windows.Forms.DataGridViewCellStyle();
            this.viewcali = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lens_type = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.focus_idx = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.zoom_idx = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.inf_tele_focus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.inf_wide_focus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.focus_dynamic_offset = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.focus_value = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.icr_mode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.production = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.awb_low_adj = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.awb_high_info = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.awb_low_info = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lens_info = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cali_log = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productoin_time = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.openFolderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem4 = new System.Windows.Forms.ToolStripMenuItem();
            this.importxml = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripTextBox4 = new System.Windows.Forms.ToolStripMenuItem();
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
            this.focus_value,
            this.icr_mode,
            this.production,
            this.awb_low_adj,
            this.awb_high_info,
            this.awb_low_info,
            this.lens_info,
            this.cali_log,
            this.productoin_time});
            this.viewcali.Location = new System.Drawing.Point(0, 27);
            this.viewcali.Name = "viewcali";
            this.viewcali.RowTemplate.Height = 24;
            this.viewcali.Size = new System.Drawing.Size(1597, 525);
            this.viewcali.TabIndex = 0;
            // 
            // id
            // 
            this.id.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.id.HeaderText = "ID";
            this.id.Name = "id";
            // 
            // lens_type
            // 
            this.lens_type.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.lens_type.DefaultCellStyle = dataGridViewCellStyle9;
            this.lens_type.HeaderText = "lens_type";
            this.lens_type.Name = "lens_type";
            // 
            // focus_idx
            // 
            this.focus_idx.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.focus_idx.HeaderText = "focus_idx";
            this.focus_idx.Name = "focus_idx";
            // 
            // zoom_idx
            // 
            this.zoom_idx.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.zoom_idx.HeaderText = "zoom_idx";
            this.zoom_idx.Name = "zoom_idx";
            // 
            // inf_tele_focus
            // 
            this.inf_tele_focus.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.inf_tele_focus.HeaderText = "inf_tele_focus";
            this.inf_tele_focus.Name = "inf_tele_focus";
            // 
            // inf_wide_focus
            // 
            this.inf_wide_focus.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.inf_wide_focus.HeaderText = "inf_wide_focus";
            this.inf_wide_focus.Name = "inf_wide_focus";
            // 
            // focus_dynamic_offset
            // 
            this.focus_dynamic_offset.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.focus_dynamic_offset.HeaderText = "focus_dynamic_offset";
            this.focus_dynamic_offset.Name = "focus_dynamic_offset";
            // 
            // focus_value
            // 
            this.focus_value.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.focus_value.HeaderText = "focus_value";
            this.focus_value.Name = "focus_value";
            // 
            // icr_mode
            // 
            this.icr_mode.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.icr_mode.HeaderText = "icr_mode";
            this.icr_mode.Name = "icr_mode";
            // 
            // production
            // 
            this.production.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.production.DefaultCellStyle = dataGridViewCellStyle10;
            this.production.HeaderText = "production";
            this.production.Name = "production";
            // 
            // awb_low_adj
            // 
            this.awb_low_adj.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.awb_low_adj.DefaultCellStyle = dataGridViewCellStyle11;
            this.awb_low_adj.HeaderText = "awb_low_adj";
            this.awb_low_adj.Name = "awb_low_adj";
            // 
            // awb_high_info
            // 
            this.awb_high_info.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.awb_high_info.DefaultCellStyle = dataGridViewCellStyle12;
            this.awb_high_info.HeaderText = "awb_high_info";
            this.awb_high_info.Name = "awb_high_info";
            // 
            // awb_low_info
            // 
            this.awb_low_info.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle13.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.awb_low_info.DefaultCellStyle = dataGridViewCellStyle13;
            this.awb_low_info.HeaderText = "awb_low_info";
            this.awb_low_info.Name = "awb_low_info";
            // 
            // lens_info
            // 
            this.lens_info.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.lens_info.DefaultCellStyle = dataGridViewCellStyle14;
            this.lens_info.HeaderText = "lens_info";
            this.lens_info.Name = "lens_info";
            // 
            // cali_log
            // 
            this.cali_log.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle15.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.cali_log.DefaultCellStyle = dataGridViewCellStyle15;
            this.cali_log.HeaderText = "cali_log";
            this.cali_log.Name = "cali_log";
            // 
            // productoin_time
            // 
            this.productoin_time.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle16.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.productoin_time.DefaultCellStyle = dataGridViewCellStyle16;
            this.productoin_time.HeaderText = "productoin_time";
            this.productoin_time.Name = "productoin_time";
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.toolStripMenuItem3});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1597, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openFolderToolStripMenuItem,
            this.toolStripMenuItem2,
            this.toolStripMenuItem4,
            this.importxml});
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(39, 20);
            this.toolStripMenuItem1.Text = "File";
            // 
            // openFolderToolStripMenuItem
            // 
            this.openFolderToolStripMenuItem.Name = "openFolderToolStripMenuItem";
            this.openFolderToolStripMenuItem.Size = new System.Drawing.Size(147, 22);
            this.openFolderToolStripMenuItem.Text = "Open File";
            this.openFolderToolStripMenuItem.Click += new System.EventHandler(this.onOpenFileClick);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(147, 22);
            this.toolStripMenuItem2.Text = "Open Folder";
            this.toolStripMenuItem2.Click += new System.EventHandler(this.onOpenFolder);
            // 
            // toolStripMenuItem4
            // 
            this.toolStripMenuItem4.Name = "toolStripMenuItem4";
            this.toolStripMenuItem4.Size = new System.Drawing.Size(147, 22);
            this.toolStripMenuItem4.Text = "Export stats";
            this.toolStripMenuItem4.Click += new System.EventHandler(this.exportFile);
            // 
            // importxml
            // 
            this.importxml.Name = "importxml";
            this.importxml.Size = new System.Drawing.Size(147, 22);
            this.importxml.Text = "Import Stats";
            this.importxml.Click += new System.EventHandler(this.importFromXML);
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripTextBox4});
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(46, 20);
            this.toolStripMenuItem3.Text = "Tool";
            // 
            // toolStripTextBox4
            // 
            this.toolStripTextBox4.Name = "toolStripTextBox4";
            this.toolStripTextBox4.Size = new System.Drawing.Size(180, 22);
            this.toolStripTextBox4.Text = "Clear data";
            this.toolStripTextBox4.Click += new System.EventHandler(this.OnClearData);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1597, 551);
            this.Controls.Add(this.viewcali);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Production log reader";
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
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem openFolderToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem4;
        private System.Windows.Forms.ToolStripMenuItem importxml;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn lens_type;
        private System.Windows.Forms.DataGridViewTextBoxColumn focus_idx;
        private System.Windows.Forms.DataGridViewTextBoxColumn zoom_idx;
        private System.Windows.Forms.DataGridViewTextBoxColumn inf_tele_focus;
        private System.Windows.Forms.DataGridViewTextBoxColumn inf_wide_focus;
        private System.Windows.Forms.DataGridViewTextBoxColumn focus_dynamic_offset;
        private System.Windows.Forms.DataGridViewTextBoxColumn focus_value;
        private System.Windows.Forms.DataGridViewTextBoxColumn icr_mode;
        private System.Windows.Forms.DataGridViewTextBoxColumn production;
        private System.Windows.Forms.DataGridViewTextBoxColumn awb_low_adj;
        private System.Windows.Forms.DataGridViewTextBoxColumn awb_high_info;
        private System.Windows.Forms.DataGridViewTextBoxColumn awb_low_info;
        private System.Windows.Forms.DataGridViewTextBoxColumn lens_info;
        private System.Windows.Forms.DataGridViewTextBoxColumn cali_log;
        private System.Windows.Forms.DataGridViewTextBoxColumn productoin_time;
        private System.Windows.Forms.ToolStripMenuItem toolStripTextBox4;
    }
}

