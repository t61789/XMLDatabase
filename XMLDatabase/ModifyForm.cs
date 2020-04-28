using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace XMLDatabase
{
    public partial class Modify_Form : Form
    {
        public Modify_Form()
        {
            InitializeComponent();
        }

        public Modify_Form(string value)
        {
            this.value = value;
            InitializeComponent();
        }

        public string value;

        private void Confirm_Button_Click(object sender, EventArgs e)
        {
            value = Value_TextBox.Text;
            Close();
        }

        private void Cancel_Button_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Value_TextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode== Keys.Enter)
            {
                value = Value_TextBox.Text;
                Close();
            }else if(e.KeyCode == Keys.Escape)
            {
                Close();
            }
        }
    }
}
