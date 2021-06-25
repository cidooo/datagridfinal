using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms


namespace datagridfinal
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int i = dataGridView1.RowCount-1;
            
            int ort = (Convert.ToInt32(textBox3.Text) + Convert.ToInt32(textBox4.Text)) / 2;
            

              dataGridView1.Rows.Add(textBox1.Text, textBox2.Text,comboBox1.SelectedItem, textBox3.Text, textBox4.Text, ort.ToString());
            if (ort < 35)
            {
                dataGridView1.Rows[i].Cells[6].Value = "kaldı";
                dataGridView1.Rows[i].Cells[6].Style.BackColor = Color.Red;
            }
            else
            { 
                dataGridView1.Rows[i].Cells[6].Value = "gecti";
                dataGridView1.Rows[i].Cells[6].Style.BackColor = Color.Green;// her seferinde eklendiğinde nası yapacam????
            }
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (comboBox2.SelectedIndex >= 0)
            {
                int adet = 0;
                int tplm = 0;
                for (int i = 0; i < dataGridView1.RowCount-1; i++)
                {
                    if (dataGridView1.Rows[i].Cells[2].Value == comboBox2.SelectedItem)
                    {
                        adet++;
                        tplm += Convert.ToInt32(dataGridView1.Rows[i].Cells[5].Value);                        
                    }
                }
                dataGridView2.Rows.Add(comboBox2.SelectedItem, tplm / adet);
            }
            else
            {
                int tplm = 0;
                for (int i = 0; i < dataGridView1.RowCount-1; i++)
                {
                    tplm += Convert.ToInt32(dataGridView1.Rows[i].Cells[5].Value);
                    
                }
                dataGridView2.Rows.Add("tümü", tplm / dataGridView1.Rows.Count-1);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (comboBox2.SelectedIndex >= 0)
            {                
                int[] dizi = new int[1];
                for (int i = 0; i < dataGridView1.RowCount - 1; i++)
                {
                    if (dataGridView1.Rows[i].Cells[2].Value == comboBox2.SelectedItem) 
                    {
                        dizi[dizi.Length-1] = Convert.ToInt32(dataGridView1.Rows[i].Cells[5].Value);
                        Array.Resize(ref dizi, dizi.Length + 1);                    
                    }
                }                               
                Array.Sort(dizi);
                dataGridView3.Rows.Add(comboBox2.SelectedItem,  dizi[dizi.Length-1], dizi[1]);
            }
            else
            {
                int[] dizi = new int[dataGridView1.RowCount - 1];
                for (int i = 0; i < dataGridView1.RowCount - 1; i++)
                {
                    dizi[i] = Convert.ToInt32(dataGridView1.Rows[i].Cells[5].Value);
                }
                Array.Sort(dizi);
                dataGridView3.Rows.Add("tüm dersler", dizi[dataGridView1.RowCount - 2], dizi[1]);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int sayi = 0;
            if (comboBox2.SelectedIndex >= 0)
            {
                
                for (int i = 0; i < dataGridView1.RowCount - 1; i++)
                {
                    if (dataGridView1.Rows[i].Cells[2].Value == comboBox2.SelectedItem)
                    {
                        if (dataGridView1.Rows[i].Cells[6].Value.ToString() == "gecti")
                            sayi++;
                    }
                }
                dataGridView4.Rows.Add(comboBox2.SelectedItem, sayi.ToString());
            }
            else
            {     
                for (int i = 0; i < dataGridView1.RowCount - 1; i++)
                {
                if (dataGridView1.Rows[i].Cells[6].Value.ToString() == "gecti")
                sayi++;                    
                }
            dataGridView4.Rows.Add("tumunden", sayi.ToString());
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (comboBox2.SelectedIndex >= 0)
            {                
                int[] dizi = new int[1];
                for (int i = 0; i < dataGridView1.RowCount - 1; i++)
                {
                    if (dataGridView1.Rows[i].Cells[2].Value == comboBox2.SelectedItem)
                    {
                        dizi[dizi.GetUpperBound(0)] = Convert.ToInt32(dataGridView1.Rows[i].Cells[1].Value);
                        Array.Resize(ref dizi, dizi.Length + 1); 
                    }
                }
                Array.Sort(dizi);
                dataGridView5.Rows.Add(comboBox2.SelectedItem, dizi[dizi.Length - 1], dizi[1]);
            }
            else
            {
                int[] dizi = new int[dataGridView1.RowCount - 1];
                for (int i = 0; i < dataGridView1.RowCount - 1; i++)
                {
                    dizi[i] = Convert.ToInt32(dataGridView1.Rows[i].Cells[1].Value);
                }
                Array.Sort(dizi);
                dataGridView5.Rows.Add("tüm dersler",dizi[dataGridView1.RowCount - 2], dizi[1]);
            }
        }

        private void dataGridView3_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

       
    }
}
