using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace form_entry_mahasiswa
{
    public partial class Frmmhs : Form
    {
        
        public delegate void SaveUpdateEventHandler(Mahasiswa obj);
        public event SaveUpdateEventHandler OnSave;
        public event SaveUpdateEventHandler OnUpdate;

        private bool isNewData = true;
        private Mahasiswa mhs = null;
        public Frmmhs()
        {
            InitializeComponent();
        }
        public Frmmhs(string header)
		: this()
	{
            this.Text = header;
        }
        public Frmmhs(string header, Mahasiswa obj)
		: this()
	{
          
            this.Text = header;
            this.isNewData = false;
            this.mhs = obj;

            txtNim.Text = this.mhs.Nim;
            txtName.Text = this.mhs.Name;

            if (this.mhs.Gender == "Laki-laki")
                rdoLakilaki.Checked = true;
            else
                rdoPerempuan.Checked = true;
            
            txtAlamat.Text = this.mhs.Alamat;
            dtpDate.Value=DateTime.Parse(this.mhs.Date);
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnSelesai_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSimpan_Click(object sender, EventArgs e)
        {
            
            if (isNewData)
                mhs = new Mahasiswa();

            mhs.Nim = txtNim.Text;
            mhs.Name = txtName.Text;
            mhs.Gender = rdoLakilaki.Checked ? "Laki-laki" : "Perempuan";
            mhs.Alamat = txtAlamat.Text;
            mhs.Date = dtpDate.Value.ToString("dd/MM/yyyy");

            if (isNewData) // data baru
            {
                OnSave(mhs); // panggil event OnSave

                // reset form input
                txtNim.Clear();
                txtName.Clear();
                rdoLakilaki.Checked = true;
                txtAlamat.Clear();
                dtpDate.Value = DateTime.Today;
             

                txtNim.Focus();
            }
            else
            {
                OnUpdate(mhs); // panggil event OnUpdate
                this.Close();
            }
        }
    }
}
