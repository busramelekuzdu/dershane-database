using dershane_database.busradatabaseDataSetTableAdapters;
using dershane_database.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Runtime.InteropServices;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace dershane_database
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void kayitbutton_Click(object sender, EventArgs e)
        {
            busradatabaseEntities1 db = new busradatabaseEntities1();
            kayit_islem model = new kayit_islem();
            model.ID = 1;
            model.ogrenci_isim = ogrenciisimtextbox.Text;
            model.ogrenci_soyisim = ogrenciisimtextbox.Text;
            model.ogrenci_tc_no = ogrencitcnomaskedtextbox.Text;
            model.ogrenci_numara = ogrencimaskedtextbox.Text;
            model.adres = adresrichtextbox.Text;
            model.veli_isim = veliisimtextbox.Text;
            model.veli_soyisim = velisoyisimtextbox.Text;
            model.veli_tc_no = velitcnomaskedtextbox.Text;
            model.veli_numara = velinumaramaskedtextbox.Text;
            model.kayit_tarihi = kayittarihidateTimePicker.Text;
            if (kadinradiobutton.Checked)
            {
                model.cinsiyet = kadinradiobutton.Text;
            }
            else
            {
                model.cinsiyet = erkekradiobutton.Text;
            }
            kayitbutton.Text = Convert.ToString(kayitbutton);
            kayitbutton.Text = "Kayıt Eklendi";
            db.kayit_islem.Add(model);
            try
            {
                db.SaveChanges();
            }
            catch (Exception ex)
            {
                var a = ex;
                throw;
            }
            kayitbutton.Text = Convert.ToString(kayitbutton);
        }
    }
}

