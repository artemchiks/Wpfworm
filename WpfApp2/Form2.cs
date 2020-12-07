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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "magazDataSet.DataTable2". При необходимости она может быть перемещена или удалена.
            this.dataTable2TableAdapter.Fill(this.magazDataSet.DataTable2);

        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            Form3 rer = new Form3();
            rer.Show();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            this.dataTable2TableAdapter.Fill(this.magazDataSet.DataTable2);
        }
        
    }
}
