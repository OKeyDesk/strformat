namespace StringTool
{
    partial class FormMain
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.txtUnicode = new System.Windows.Forms.TextBox();
            this.btnCopyUnicode = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.txtAnsi = new System.Windows.Forms.TextBox();
            this.txtSource = new System.Windows.Forms.TextBox();
            this.btnCopyAnsi = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(646, 428);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.txtUnicode);
            this.tabPage2.Controls.Add(this.btnCopyUnicode);
            this.tabPage2.Controls.Add(this.label7);
            this.tabPage2.Controls.Add(this.txtAnsi);
            this.tabPage2.Controls.Add(this.txtSource);
            this.tabPage2.Controls.Add(this.btnCopyAnsi);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(638, 402);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "简单转换";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // txtUnicode
            // 
            this.txtUnicode.Location = new System.Drawing.Point(79, 252);
            this.txtUnicode.Multiline = true;
            this.txtUnicode.Name = "txtUnicode";
            this.txtUnicode.Size = new System.Drawing.Size(514, 83);
            this.txtUnicode.TabIndex = 38;
            // 
            // btnCopyUnicode
            // 
            this.btnCopyUnicode.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCopyUnicode.Location = new System.Drawing.Point(79, 347);
            this.btnCopyUnicode.Name = "btnCopyUnicode";
            this.btnCopyUnicode.Size = new System.Drawing.Size(514, 30);
            this.btnCopyUnicode.TabIndex = 37;
            this.btnCopyUnicode.Text = "复制";
            this.btnCopyUnicode.UseVisualStyleBackColor = true;
            this.btnCopyUnicode.Click += new System.EventHandler(this.btnCopyUnicode_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("宋体", 9F);
            this.label7.Location = new System.Drawing.Point(20, 253);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(53, 12);
            this.label7.TabIndex = 36;
            this.label7.Text = "UNICODE:";
            // 
            // txtAnsi
            // 
            this.txtAnsi.Location = new System.Drawing.Point(79, 103);
            this.txtAnsi.Multiline = true;
            this.txtAnsi.Name = "txtAnsi";
            this.txtAnsi.Size = new System.Drawing.Size(514, 83);
            this.txtAnsi.TabIndex = 35;
            // 
            // txtSource
            // 
            this.txtSource.Location = new System.Drawing.Point(79, 28);
            this.txtSource.Multiline = true;
            this.txtSource.Name = "txtSource";
            this.txtSource.Size = new System.Drawing.Size(514, 53);
            this.txtSource.TabIndex = 31;
            this.txtSource.TextChanged += new System.EventHandler(this.txtSource_TextChanged);
            // 
            // btnCopyAnsi
            // 
            this.btnCopyAnsi.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCopyAnsi.Location = new System.Drawing.Point(79, 198);
            this.btnCopyAnsi.Name = "btnCopyAnsi";
            this.btnCopyAnsi.Size = new System.Drawing.Size(514, 30);
            this.btnCopyAnsi.TabIndex = 34;
            this.btnCopyAnsi.Text = "复制";
            this.btnCopyAnsi.UseVisualStyleBackColor = true;
            this.btnCopyAnsi.Click += new System.EventHandler(this.btnCopyAnsi_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("宋体", 9F);
            this.label5.Location = new System.Drawing.Point(38, 106);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 12);
            this.label5.TabIndex = 33;
            this.label5.Text = "ANSI:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("宋体", 9F);
            this.label6.Location = new System.Drawing.Point(26, 31);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(47, 12);
            this.label6.TabIndex = 32;
            this.label6.Text = "字符串:";
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(646, 428);
            this.Controls.Add(this.tabControl1);
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "字符串转换工具 - OKeyDesk";
            this.tabControl1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TextBox txtAnsi;
        private System.Windows.Forms.TextBox txtSource;
        private System.Windows.Forms.Button btnCopyAnsi;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtUnicode;
        private System.Windows.Forms.Button btnCopyUnicode;
        private System.Windows.Forms.Label label7;
    }
}

