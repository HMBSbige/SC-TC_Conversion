using System;
using System.IO;
using System.Windows.Forms;
using SC_TC_Conversion_Common;
using SC_TC_Conversion_File.Properties;

namespace SC_TC_Conversion_File
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var dia = new OpenFileDialog
            {
                InitialDirectory = Application.StartupPath,
                Title = @"打开",
                Filter = @"所有文件|*.*"
            };
            dia.ShowDialog();
            if (dia.FileName != string.Empty)
            {
                textBox1.Text = dia.FileName;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var dia = new OpenFileDialog
            {
                InitialDirectory = Application.StartupPath,
                Title = @"另存为",
                Filter = @"所有文件|*.*"
            };
            dia.ShowDialog();
            if (dia.FileName != string.Empty)
            {
                textBox2.Text = dia.FileName;
            }
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            var fileName = textBox1.Text;
            if (radioButton1.Checked && File.Exists(fileName))
            {
                var directoryName = Path.GetDirectoryName(fileName);
                var fileNameWithoutExtension = Path.GetFileNameWithoutExtension(fileName);
                var extension = Path.GetExtension(fileName);
                textBox2.Text = directoryName + @"\" + fileNameWithoutExtension + @"_sc" + extension;
            }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            var fileName = textBox1.Text;
            if (radioButton2.Checked && File.Exists(fileName))
            {
                var directoryName = Path.GetDirectoryName(fileName);
                var fileNameWithoutExtension = Path.GetFileNameWithoutExtension(fileName);
                var extension = Path.GetExtension(fileName);
                textBox2.Text = directoryName + @"\" + fileNameWithoutExtension + @"_tc" + extension;
            }
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            var fileName = textBox1.Text;
            if (radioButton3.Checked && File.Exists(fileName))
            {
                var directoryName = Path.GetDirectoryName(fileName);
                var fileNameWithoutExtension = Path.GetFileNameWithoutExtension(fileName);
                var extension = Path.GetExtension(fileName);
                textBox2.Text = directoryName + @"\" + fileNameWithoutExtension + @"_new" + extension;
            }
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            Icon = Resources.SC_TC;
            comboBox1.SelectedIndex = 0;
            comboBox2.SelectedIndex = 0;
        }

        #region 拖拽

        private void textBox1_DragDrop(object sender, DragEventArgs e)
        {
            textBox1.Text = ((Array)e.Data.GetData(DataFormats.FileDrop)).GetValue(0).ToString();
        }

        private void textBox1_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                e.Effect = DragDropEffects.Link;
            }
            else
            {
                e.Effect = DragDropEffects.None;
            }
        }

        private void textBox2_DragDrop(object sender, DragEventArgs e)
        {
            textBox2.Text = ((Array)e.Data.GetData(DataFormats.FileDrop)).GetValue(0).ToString();
        }

        private void textBox2_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                e.Effect = DragDropEffects.Link;
            }
            else
            {
                e.Effect = DragDropEffects.None;
            }
        }

        #endregion

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            var fileName = textBox1.Text;
            var directoryName = Path.GetDirectoryName(fileName);
            var fileNameWithoutExtension = Path.GetFileNameWithoutExtension(fileName);
            var extension = Path.GetExtension(fileName);
            if (radioButton1.Checked)
            {
                textBox2.Text = directoryName + @"\" + fileNameWithoutExtension + @"_sc" + extension;
            }
            else if (radioButton2.Checked)
            {
                textBox2.Text = directoryName + @"\" + fileNameWithoutExtension + @"_tc" + extension;
            }
            else
            {
                textBox2.Text = directoryName + @"\" + fileNameWithoutExtension + @"_new" + extension;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            var inputfileName = textBox1.Text;
            var outputfileName = textBox2.Text;
            var encodingstr1 = comboBox1.Text;
            var encodingstr2 = comboBox2.Text;

            if (!File.Exists(inputfileName))
            {
                MessageBox.Show(@"请选择需要转换的文件",@"错误！",MessageBoxButtons.OK,MessageBoxIcon.Error);
                return;
            }

            try
            {
                if (!Directory.Exists(Path.GetDirectoryName(outputfileName)))
                {
                    MessageBox.Show(@"输出文件路径出错", @"错误！", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
            catch
            {
                MessageBox.Show(@"输出文件路径出错", @"错误！", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                var origin = File.ReadAllText(inputfileName,TextEncoding.GetEncoding(encodingstr1));
                string output;
                if (radioButton1.Checked)
                {
                    output = ChineseStringUtility.ToSimplified(origin);
                }
                else if (radioButton2.Checked)
                {
                    output = ChineseStringUtility.ToTraditional(origin);
                }
                else
                {
                    output = origin;
                }
                File.WriteAllText(outputfileName,output,TextEncoding.GetEncoding(encodingstr2));
                MessageBox.Show(@"转换成功！", @"成功！", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, @"转换出错！", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
