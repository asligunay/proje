using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MEETING_ORGANIZER
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

        private void btnRandevuKayit_Click(object sender, EventArgs e)
        {
            if (DateTime.Now<dateTimePicker1.Value)
            {
                using (MeetingDBEntities db = new MeetingDBEntities())
                {
                    Randevular rnd = new Randevular();

                    rnd.ToplantiKonusu = txtToplantiKonusu.Text;
                    rnd.Tarih = dateTimePicker1.Value.ToShortDateString();
                    rnd.BaslangicSaati = txtBaslangicSaati.Text;
                    rnd.BitisSaati = txtBitisSaati.Text;
                    rnd.Katilimcilar = txtKatilimcilar.Text;

                    db.Randevulars.Add(rnd);
                    db.SaveChanges();
                }            }
            else
            {
                MessageBox.Show("Geçmiş Tarihe Randevu Alınamaz !");
            }
            gridDoldur();
        }

        private void btnYeniRandevu_Click(object sender, EventArgs e)
        {
            temizle();
        }

        private void temizle()
        {
            foreach (Control item in this.Controls)
            {
                if (item is TextBox)
                {
                    TextBox txt = item as TextBox;
                    txt.Clear();

                    dateTimePicker1.Value = DateTime.Now;

                    DataGrid.Columns.Clear();
                }
            }
        }

        private void btnRandevuListele_Click(object sender, EventArgs e)
        {
            gridDoldur();
        }

        private void btnRandevuGuncelle_Click(object sender, EventArgs e)
        {
            int rndID = 0;

            if (DataGrid.SelectedRows.Count > 0)
            {
                rndID = (int)DataGrid.SelectedRows[0].Cells[0].Value;
            }
            using (MeetingDBEntities db = new MeetingDBEntities())
            {
                Randevular rnd = db.Randevulars.Find(rndID);

                rnd.ToplantiKonusu = txtToplantiKonusu.Text;
                rnd.Tarih = dateTimePicker1.Value.ToShortDateString();
                rnd.BaslangicSaati = txtBaslangicSaati.Text;
                rnd.BitisSaati = txtBitisSaati.Text;
                rnd.Katilimcilar = txtKatilimcilar.Text;

                db.SaveChanges();
            }
            gridDoldur();
        }

        private void btnRandevuSil_Click(object sender, EventArgs e)
        {
            int rndID = 0;
            if (DataGrid.SelectedRows.Count > 0)
            {
                rndID = (int)DataGrid.SelectedRows[0].Cells[0].Value;
            }

            using (MeetingDBEntities db = new MeetingDBEntities())
            {
                Randevular rnd = db.Randevulars.Find(rndID);

                db.Randevulars.Remove(rnd);

                db.SaveChanges();

            }
            gridDoldur();
        }

        private void gridDoldur()
        {
            using (MeetingDBEntities db = new MeetingDBEntities())
            {
                var sonuc = from randevu in db.Randevulars
                            select new
                            {
                                randevu.ID,
                                randevu.ToplantiKonusu,
                                randevu.Tarih,
                                randevu.BaslangicSaati,
                                randevu.BitisSaati,
                                randevu.Katilimcilar
                            };

                DataGrid.DataSource = sonuc.ToList();
                DataGrid.SelectedRows[0].Selected = true;
            }
        }
    }
}
