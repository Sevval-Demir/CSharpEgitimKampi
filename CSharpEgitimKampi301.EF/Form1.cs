using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSharpEgitimKampi301.EF
{
    public partial class Form1 : Form
    {
        EgitimKampiEFDbEntities db = new EgitimKampiEFDbEntities();
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            int id = int.Parse(textId.Text);
            var updateValue = db.Guide.Find(id);
            updateValue.GuideName=textName.Text;
            updateValue.GuideSurname=textSurname.Text;
            db.SaveChanges();
            MessageBox.Show("Rehber Başarıyla Güncellendi", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnList_Click(object sender, EventArgs e)
        {
           
            var values = db.Guide.ToList();
            dataGridView1.DataSource = values;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Guide guide=new Guide();
            guide.GuideName=textName.Text;
            guide.GuideSurname = textSurname.Text;
            db.Guide.Add(guide);
            db.SaveChanges();
            MessageBox.Show("Rehber Başarıyla Eklendi");
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int id = int.Parse(textId.Text);
            var removeValue = db.Guide.Find(id);
            db.Guide.Remove(removeValue);
            db.SaveChanges();
            MessageBox.Show("Rehber Başarıyla Silindi");
        }

        private void btnGetById_Click(object sender, EventArgs e)
        {
            int id=int.Parse(textId.Text);
            var values=db.Guide.Where(x=>x.GuideId==id).ToList();
            dataGridView1.DataSource=values;
        }
    }
}
