using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace boiduongLeQuyDon.GUI
{
    public partial class DS_GuiEmail : Form
    {
        public DS_GuiEmail(DataTable dt)
        {
            InitializeComponent();
            this.dt = dt;
            
        }
        DataTable dt = new DataTable();
        private void DS_GuiEmail_Load(object sender, EventArgs e)
        {
            gridControl1.DataSource = dt;
        }
    }
}
