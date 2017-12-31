namespace SC_TC_Conversion
{
    partial class MainForm
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
            this.SC_TextBox = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.TC_TextBox = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // SC_TextBox
            // 
            this.SC_TextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SC_TextBox.Location = new System.Drawing.Point(3, 17);
            this.SC_TextBox.Multiline = true;
            this.SC_TextBox.Name = "SC_TextBox";
            this.SC_TextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.SC_TextBox.Size = new System.Drawing.Size(374, 105);
            this.SC_TextBox.TabIndex = 0;
            this.SC_TextBox.TextChanged += new System.EventHandler(this.SC_TextBox_TextChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.SC_TextBox);
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(380, 125);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "简体";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.TC_TextBox);
            this.groupBox2.Location = new System.Drawing.Point(0, 125);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(0);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(380, 125);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "繁体";
            // 
            // TC_TextBox
            // 
            this.TC_TextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TC_TextBox.Location = new System.Drawing.Point(3, 17);
            this.TC_TextBox.Multiline = true;
            this.TC_TextBox.Name = "TC_TextBox";
            this.TC_TextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.TC_TextBox.Size = new System.Drawing.Size(374, 105);
            this.TC_TextBox.TabIndex = 0;
            this.TC_TextBox.TextChanged += new System.EventHandler(this.TC_TextBox_TextChanged);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(380, 248);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "MainForm";
            this.Text = "繁简转换";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.SizeChanged += new System.EventHandler(this.MainForm_SizeChanged);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox SC_TextBox;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox TC_TextBox;
    }
}

