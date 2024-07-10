using Dom.Composite;
using Logic;
using Logic.Exceptions;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI___Froms
{
    public partial class StartForm : Form
    {
        public StartForm()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnZObjectSearch_Click(object sender, EventArgs e)
        {
            if (txtZObject.Text == "")
            {
                MessageBox.Show("El programa no puede ser nulo.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            ObjetoZ objetoZ = default;

            try
            {
                objetoZ = ObjetoZService.Instance.GetByName(txtZObject.Text);
            }
            catch (ObjectDoesNotExistException ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            MainForm.Instance.objetoZ = objetoZ;

            MainForm.Instance.Show();
        }
    }
}
