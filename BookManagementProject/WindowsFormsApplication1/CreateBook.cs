using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class CreateBook : Form
    {
        string imgLoc = "";
        public CreateBook()
        {
            InitializeComponent();
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            {
                try
                {
                    OpenFileDialog dlg = new OpenFileDialog();
                    dlg.Filter = "JPG Files (*.jpg)|*.ipg|GIF File (*.gif)|*.gif|All Files (*.*)|*.*";
                    dlg.Title = "Select Picture";
                    if (dlg.ShowDialog() == DialogResult.OK)
                    {
                        imgLoc = dlg.FileName.ToString();
                        pictureBox1.ImageLocation = imgLoc;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

    }
}
