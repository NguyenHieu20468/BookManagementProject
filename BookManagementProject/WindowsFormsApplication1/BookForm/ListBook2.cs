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
    public partial class ListBook2 : Form
    {
        private BookManagement control;
        public ListBook2()
        {
            this.control = new BookManagement();
            InitializeComponent();
            this.Search.Click += Search_Click;
        }

        void Search_Click(object sender, EventArgs e)
        {
            var target = this.txtFind.Text;
           var result = this.control.searchingName(target);
           this.dataGridView1.DataSource = result;
        }
       
    }
}
