using DemoCodeFirst.BusinessLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DemoCodeFirst.GUI
{
    public partial class UI_Student : Form
    {
        public UI_Student()
        {
            InitializeComponent();
            setCombobox();
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            loadData(((ComboboxItem)cbbIdClass.SelectedItem).sId);
        }
        public void setCombobox()
        {
            cbbIdClass.Items.AddRange(BusinessLayer_Student.instance.setCombobox().ToArray());
        }
        public void loadData(string sIdClass)
        {
            dgvStudent.DataSource = BusinessLayer_Student.instance.loadStudent(sIdClass);
        }
    }
}
