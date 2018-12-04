using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace git22
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.Rows.Add(1, "Преступление и наказание", "10", "1000");
            dataGridView1.Rows.Add(2, "Война и мир", "20", "900");
            dataGridView1.Rows.Add(3, "Отцы и дети", "15", "500");
            dataGridView1.Rows.Add(4, "Мастер и Маргарита", "12", "600");
            dataGridView1.Rows.Add(5, "Горе от ума", "18", "1100");
            dataGridView1.Rows.Add(6, "Мертвые души", "14", "250");
            dataGridView1.Rows.Add(7, "Обломов", "12", "720");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string text = textBox1.Text;
            if (text != "")
            {
                MessageBox.Show("Куплен билет № " + text + ".", "Уведомление", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Ошибка, билет не выбран", "Уведомление", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.dataGridView1.Sort(this.dataGridView1.Columns["Column2"], ListSortDirection.Ascending);
        }
    }
}
