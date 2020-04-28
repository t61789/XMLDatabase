using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Linq;

namespace XMLDatabase
{
    public partial class Main_form : Form
    {
        private OpenFileDialog openFileDialog;

        private SaveFileDialog saveFileDialog;

        private Database curDatabase;

        public static Main_form instance;

        public Main_form()
        {
            InitializeComponent();
            instance = this;
        }

        private void OpenFile_ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (openFileDialog == null)
            {
                openFileDialog = new OpenFileDialog();
                openFileDialog.InitialDirectory = AppDomain.CurrentDomain.SetupInformation.ApplicationBase;
                openFileDialog.Filter = "xml数据库|*.xml";
                openFileDialog.RestoreDirectory = true;
            }
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    curDatabase = new Database(openFileDialog.FileName,Main_DataGridView);
                }
                catch (Exception)
                {
                    Log("XML数据库载入失败");
                    return;
                }
                Log("XML数据库载入成功");
            }
        }

        private void SaveFile_ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (curDatabase != null)
            {
                curDatabase.Save();
                Log("保存完成");
            }
        }

        private void SaveAs_ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (curDatabase != null)
            {
                if (saveFileDialog == null)
                {
                    saveFileDialog = new SaveFileDialog();
                    saveFileDialog.Filter="xml数据库|*.xml";
                    saveFileDialog.InitialDirectory = AppDomain.CurrentDomain.SetupInformation.ApplicationBase;
                    saveFileDialog.RestoreDirectory = true;
                }

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        curDatabase.Save(saveFileDialog.FileName);
                    }
                    catch (Exception)
                    {
                        Log("保存失败");
                        return;
                    }
                    Log("保存完成");
                }
            }
        }

        private void Main_form_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.Modifiers== Keys.Control&&e.KeyCode== Keys.S)
            {
                SaveFile_ToolStripMenuItem_Click(null,null);
            }
        }

        private void Log(string message)
        {
            Message_label.Text = message+" " + DateTime.Now;
        }

        public void SetTitle(string filePath)
        {
            Text = "XML数据库编辑器：" + filePath;
        }
    }
}
