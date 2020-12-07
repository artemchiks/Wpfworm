using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WpfApp2
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "MagazDataSet.DataTable3". При необходимости она может быть перемещена или удалена.
            this.DataTable3TableAdapter.Fill(this.MagazDataSet.DataTable3);

            this.reportViewer1.RefreshReport();
        }
    }
}
