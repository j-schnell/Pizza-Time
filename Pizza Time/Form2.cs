using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pizza_Time
{
    public partial class frmDelivery : Form
    {
        public frmDelivery()
        {
            InitializeComponent();
        }

        private void TextBox_Enter(object sender, EventArgs e)
        {
            (sender as TextBox).Text = "";
        }

        private void TextBox_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace((sender as TextBox).Text))
            {
                (sender as TextBox).Text = (sender as TextBox).AccessibleDescription;
            }
        }

        private void CmbProvince_Enter(object sender, EventArgs e)
        {
            (sender as ComboBox).Text = "";
        }

        private void CmbProvince_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace((sender as ComboBox).Text))
            {
                (sender as ComboBox).Text = (sender as ComboBox).AccessibleDescription;
            }
        }

        private void CmbProvince_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void BtnConfirm_Click(object sender, EventArgs e)
        {
            foreach (Control c in this.Controls)
            {
                if (c.GetType() != typeof(Button))
                {
                    if ((string.IsNullOrWhiteSpace(c.Text) || c.Text == c.AccessibleDescription) && !c.Equals(txtAddress2))
                    {
                        MessageBox.Show("Certaines formes n'ont pas été complété", "Avertissement");
                        return;
                    }
                }
            }
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
