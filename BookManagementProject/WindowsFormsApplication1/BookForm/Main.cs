using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace WindowsFormsApplication1
{
    public partial class Main : Form
    {
        private BookManagement control;
        public Main()
        {
            this.control = new BookManagement();
            InitializeComponent();
            this.linkLabel2.Click += linkLabel2_Click;
        }

        void linkLabel2_Click(object sender, EventArgs e)
        {           
            //(new ListBook()).Show(); 
            var f = new ListBook();
            f.Show();
            this.Hide(); 
        }
        
    }

}
