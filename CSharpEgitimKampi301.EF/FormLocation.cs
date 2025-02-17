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
    public partial class FormLocation : Form
    {
        EgitimKampiEFDbEntities db=new EgitimKampiEFDbEntities();
        public FormLocation()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnList_Click(object sender, EventArgs e)
        {
            var values = db.Location.ToList();
            dataGridView1.DataSource = values;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Location location = new Location();
            location.LocationCapacity=byte.Parse(numericCapacity.Value.ToString());
            location.LocationCity=textCity.Text;
            location.LocationCountry=textCountry.Text;
            location.LocationPrice = decimal.Parse(textPrice.Text);
            location.DayNight=textNight.Text;
            location.GuideId = int.Parse(comboGuide.SelectedValue.ToString());
            db.Location.Add(location);
            db.SaveChanges();
            MessageBox.Show("Ekleme İşlemi Başarılı");
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void FormLocation_Load(object sender, EventArgs e)
        {
            var values = db.Guide.Select(x => new
            {
                FullName = x.GuideName + " " + x.GuideSurname
            }).ToList();
            comboGuide.DisplayMember = "FullName";
            comboGuide.ValueMember = "GuideId";
            comboGuide.DataSource = values;
        }

        private void textId_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int id=int.Parse(textId.Text);
            var deletedValue = db.Location.Find(id);
            db.Location.Remove(deletedValue);
            db.SaveChanges();
            MessageBox.Show("Silme İşlemi Başarılı");
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            int id =int.Parse(textId.Text);
            var updatedValue = db.Location.Find(id);
            updatedValue.DayNight=textNight.Text;
            updatedValue.LocationPrice=decimal.Parse(textPrice.Text);
            updatedValue.LocationCapacity = byte.Parse(numericCapacity.Value.ToString());
            updatedValue.LocationCity = textCity.Text;
            updatedValue.LocationCountry=textCountry.Text;
            updatedValue.GuideId=int.Parse(comboGuide.SelectedValue.ToString());
            db.SaveChanges();
            MessageBox.Show("Güncelleme İşlemi Başarılı");
        }
    }
}
