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
        private int BookId;
        private LogicLayer Business;
        public UpdateBook(int id)
        {
            InitializeComponent();
            this.BookId = id;
            this.Business = new LogicLayer();
            this.Load += UpdateForm_Load;
        }

        void UpdateForm_Load(object sender, EventArgs e)
        {
            var bk = this.Business.GetBook(this.BookId);
            this.cbxAuthor.DataSource = this.Business.GetAuthors();
            this.cbxAuthor.DisplayMember = "Name";
            this.cbxAuthor.ValueMember = "Id";
            this.cbxAuthor.SelectedValue = bk.AuthorCode;
        }
    }
}
