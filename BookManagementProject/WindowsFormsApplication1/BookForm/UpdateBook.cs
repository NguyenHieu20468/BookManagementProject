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
    public partial class UpdateBook : Form
    {
        string imgLoc = "";
        private int BookId;
        private LogicLayer Business;
        public UpdateBook(int id)
        {
            InitializeComponent();
            this.BookId = id;
            this.Business = new LogicLayer();
            this.Load += UpdateForm_Load;
        }

        public UpdateBook()
        {
            // TODO: Complete member initialization
        }

        void UpdateForm_Load(object sender, EventArgs e)
        {
            var bk = this.Business.GetBook(this.BookId);
            this.cbxAuthor.DataSource = this.Business.GetAuthors();
            this.cbxAuthor.DisplayMember = "Name";
            this.cbxAuthor.ValueMember = "Id";
            this.cbxAuthor.SelectedValue = bk.AuthorCode;
        }

        void btnBrowse_Click(object sender, EventArgs e)
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
