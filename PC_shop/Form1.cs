using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace PC_shop
{
    public partial class Form1 : Form
    {
        public bool enter = false;
        public string Acs = ""; //доступ
        public Form1()
        {
            InitializeComponent();
            this.Text = "PC-Shop";
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'kR_PIDataSet.Computers' table. You can move, or remove it, as needed.
            this.computersTableAdapter.Fill(this.kR_PIDataSet.Computers);
            // TODO: This line of code loads data into the 'kR_PIDataSet.Periphery' table. You can move, or remove it, as needed.
            this.peripheryTableAdapter.Fill(this.kR_PIDataSet.Periphery);
            // TODO: This line of code loads data into the 'kR_PIDataSet.Parts' table. You can move, or remove it, as needed.
            this.partsTableAdapter.Fill(this.kR_PIDataSet.Parts);
            // TODO: This line of code loads data into the 'kR_PIDataSet.HR' table. You can move, or remove it, as needed.
            this.hRTableAdapter.Fill(this.kR_PIDataSet.HR);
            //делаем вкладки не видимыми
            tabControl1.TabPages.Remove(tabPage5);
            tabControl1.TabPages.Remove(tabPage4);
            tabControl1.TabPages.Remove(tabPage3);
            tabControl1.TabPages.Remove(tabPage2);
        }

        private void bindingNavigator1_RefreshItems(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string Login = ""; //Логин
            string Pswd = ""; //пароль
            bool nolog = false;
            if (enter)
            {
                this.button1.Text = "Вход";
                enter = false;
                switch (Acs)
                {
                    case "Admin":
                        tabControl1.TabPages.Remove(tabPage5);
                        tabControl1.TabPages.Remove(tabPage4);
                        tabControl1.TabPages.Remove(tabPage3);
                        tabControl1.TabPages.Remove(tabPage2);
                        break;
                    case "User":
                        tabControl1.TabPages.Remove(tabPage4);
                        tabControl1.TabPages.Remove(tabPage3);
                        tabControl1.TabPages.Remove(tabPage2);
                        break;
                    case "Technic":
                        tabControl1.TabPages.Remove(tabPage2);
                        break;
                    default:
                        break;
                }

            }
            else
            {
                Login = textBox1.Text;
                for (int i = 0; i < dataGridView1.RowCount - 1; i++)
                {
                    if (Login == dataGridView1[8, i].Value.ToString())
                    {
                        nolog = true;
                        Pswd = textBox2.Text;
                        if (Pswd != dataGridView1[9, i].Value.ToString())
                        {
                            Acs = "";
                            MessageBox.Show("Неверный Пароль");
                        }
                        else
                        {
                            Acs = dataGridView1[7, i].Value.ToString();
                        }
                        break;
                    }
                }
                if (!nolog)
                {
                    Acs = "";
                    MessageBox.Show("Неверный Логин");
                }
                switch (Acs)
                {
                    case "Admin":
                        this.button1.Text = "Выход";
                        enter = true;
                        tabControl1.TabPages.Insert(1, tabPage2);
                        tabControl1.TabPages.Insert(2, tabPage3);
                        tabControl1.TabPages.Insert(3, tabPage4);
                        tabControl1.TabPages.Insert(4, tabPage5);
                        break;
                    case "User":
                        this.button1.Text = "Выход";
                        enter = true;
                        tabControl1.TabPages.Insert(1, tabPage2);
                        tabControl1.TabPages.Insert(2, tabPage3);
                        tabControl1.TabPages.Insert(3, tabPage4);
                        break;
                    case "Technic":
                        this.button1.Text = "Выход";
                        enter = true;
                        tabControl1.TabPages.Insert(1, tabPage2);
                        break;
                    default:
                        break;
                }
                textBox1.Clear();//очищаем текстовое окно Логин
                textBox2.Clear();//очищаем текстовое окно Логин
            }
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            hRTableAdapter.Update(kR_PIDataSet.HR);
            kR_PIDataSet.AcceptChanges();
            MessageBox.Show("Изменения сохранены");
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            computersTableAdapter.Update(kR_PIDataSet.Computers);
            kR_PIDataSet.AcceptChanges();
            MessageBox.Show("Изменения сохранены");
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            peripheryTableAdapter.Update(kR_PIDataSet.Periphery);
            kR_PIDataSet.AcceptChanges();
            MessageBox.Show("Изменения сохранены");
        }

        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            //partsBindingSource.EndEdit();
            partsTableAdapter.Update(kR_PIDataSet.Parts);
            kR_PIDataSet.AcceptChanges();
            MessageBox.Show("Изменения сохранены");
        }

        private void dataGridView1_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            MessageBox.Show(e.Exception.Message);
            e.Cancel = true;
        }
        private void dataGridView2_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            MessageBox.Show(e.Exception.Message);
            e.Cancel = true;
        }

        private void dataGridView3_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            MessageBox.Show(e.Exception.Message);
            e.Cancel = true;
        }

        private void dataGridView4_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            MessageBox.Show(e.Exception.Message);
            e.Cancel = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label4.Text =  DateTime.Now.Hour.ToString("00") + ":" + DateTime.Now.Minute.ToString("00")
                + ":" + DateTime.Now.Second.ToString("00");
        }
    }
}