using System;
using System.Windows.Forms;
using SC_TC_Conversion.Properties;

namespace SC_TC_Conversion
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }
        
        private void Form1_Load(object sender, EventArgs e)
        {
            Icon = Resources.SC_TC;
            ChangeSize();
            const string testString = @"abc123书樂う반~√";
            try
            {
                SC_TextBox.Text = ChineseStringUtility.ToSimplified(testString);
                TC_TextBox.Text = ChineseStringUtility.ToTraditional(testString);
            }
            catch
            {
                // ignored
            }
        }

        private void SC_TextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (SC_TextBox.Focused)
                {
                    SC_TextBox.Text = ChineseStringUtility.ToSimplified(SC_TextBox.Text);
                    SC_TextBox.SelectionStart = SC_TextBox.Text.Length;
                    TC_TextBox.Text = ChineseStringUtility.ToTraditional(SC_TextBox.Text);
                }
            }
            catch
            {
                TC_TextBox.Text = @"ERROR!";
            }
        }

        private void TC_TextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (TC_TextBox.Focused)
                {
                    TC_TextBox.Text = ChineseStringUtility.ToTraditional(TC_TextBox.Text);
                    TC_TextBox.SelectionStart = TC_TextBox.Text.Length;
                    SC_TextBox.Text = ChineseStringUtility.ToSimplified(TC_TextBox.Text);
                }
            }
            catch
            {
                SC_TextBox.Text = @"ERROR!";
            }
        }

        private void ChangeSize()
        {
            groupBox1.Width = ClientRectangle.Width;
            groupBox2.Width = ClientRectangle.Width;
            groupBox1.Height = ClientRectangle.Height / 2;
            groupBox2.Top = groupBox1.Height;
            groupBox2.Height = ClientRectangle.Height / 2;
        }
        private void MainForm_SizeChanged(object sender, EventArgs e)
        {
            ChangeSize();
        }
    }
}