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
    public partial class ListBook : Form
    {
        private LogicLayer Business;

        public object C { get; private set; }

        public ListBook()
        {
            InitializeComponent();
            this.Business = new LogicLayer();
            this.Load += ListBook_Load;
            this.btnNew.Click += btnNew_Click;
            this.btnEdit.Click += btnEdit_Click;
            this.btnDelete.Click += btnDelete_Click;
            this.grdBooks.DoubleClick += grdBooks_DoubleClick;

        }

        private void ShowAllStudents()
        {
            //this.grdStudents.DataSource = this.Business.GetStudents();
            var students = this.Business.GetStudents();
            var studentViews = new BookView[students.Length];

            for (int i = 0; i < students.Length; i++)
            {
                studentViews[i] = new BookView(students[i]);
            }

            this.grdBooks.DataSource = studentViews;
        }

        private void ListBook_Load(object sender, EventArgs e)
        {
            this.ShowAllStudents();
        }

        void btnNew_Click(object sender, EventArgs e)
        {
            var ListBook = new CreateBook();
            ListBook.ShowDialog();
        }

        void btnEdit_Click(object sender, EventArgs e)
        {
            var ListBook = new UpdateBook();
            ListBook.ShowDialog();
        }

        void btnDelete_Click(object sender, EventArgs e)
        {
            if (this.grdBooks.SelectedRows.Count == 1)
            {
                if (MessageBox.Show("Do you want to delete this?", "Confirm",
                    MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
                {
                    var row = (Book)this.grdBooks.SelectedRows[0].DataBoundItem;
                    this.Business.DeleteBook(row.ID);
                    MessageBox.Show("Delete class successfully.");
                    this.ShowAllStudents();
                }
            }
        }

        void grdBooks_DoubleClick(object sender, EventArgs e)
        {
            if (grdBooks.SelectedRows.Count == 1)
            {
                var row = this.grdBooks.SelectedRows[0];
                var BookView = (BookView)row.DataBoundItem;
                (new UpdateBook(BookView.ID)).ShowDialog();
            }
        }
    }
}