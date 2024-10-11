using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _01Assignment2
{
    public partial class ControlPanelForm : Form
    {
        public ControlPanelForm()
        {
            InitializeComponent();
        }

        private void btnDesign_Click(object sender, EventArgs e)
        {
            //Calling the DesignerForm
            //https://www.youtube.com/watch?v=7Vhl6GDNU7k&list=PLx4x_zx8csUglgKTmgfVFEhWWBQCasNGi&index=64
            DesignerForm form = new DesignerForm();
            form.ShowDialog();

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
