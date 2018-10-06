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
    public partial class Form1 : Form
    {
        private IList<Mahasiswa> listOfMahasiswa = new List<Mahasiswa>();
        private Frmmhs frmEntry;
        public Form1()
        {
            InitializeComponent();
            InisialisasiListView();
            InisialisasiDataDummy();
           
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            InisialisasiListView();
            InisialisasiDataDummy();
        }
      
        private void InisialisasiListView()
        {
            lvwMahasiswa.View = System.Windows.Forms.View.Details;
            lvwMahasiswa.FullRowSelect = true;
            lvwMahasiswa.GridLines = true;

            lvwMahasiswa.Columns.Add("No.", 30, HorizontalAlignment.Center);
            lvwMahasiswa.Columns.Add("Nim", 91, HorizontalAlignment.Left);
            lvwMahasiswa.Columns.Add("Name", 200, HorizontalAlignment.Left);
            lvwMahasiswa.Columns.Add("Jenis Kelamin", 90, HorizontalAlignment.Left);
            lvwMahasiswa.Columns.Add("Tempat lahir", 200, HorizontalAlignment.Left);
            lvwMahasiswa.Columns.Add("Tanggal lahir", 91, HorizontalAlignment.Left);
        }

        private void InisialisasiDataDummy()
        {
            listOfMahasiswa.Add(new Mahasiswa { Nim = "10.11.0001", Name = "BUDI", Gender = "Laki-laki", Alamat="JAKARTA",Date="10/10/1990" });
            listOfMahasiswa.Add(new Mahasiswa { Nim = "17.11.0002", Name = "SANTI", Gender = "Perempuan",Alamat="JAKARTA",Date="10/10/1990" });
           

            foreach (var obj in listOfMahasiswa)
            {
                FillToListView(true, obj);
            }
        }

      
        private void FillToListView(bool isNewData, Mahasiswa mhs)
        {
            if (isNewData) 
            {
                int noUrut = lvwMahasiswa.Items.Count + 1;

                ListViewItem item = new ListViewItem(noUrut.ToString());
                item.SubItems.Add(mhs.Nim);
                item.SubItems.Add(mhs.Name);
                item.SubItems.Add(mhs.Gender);
                item.SubItems.Add(mhs.Alamat);
                item.SubItems.Add(mhs.Date);

                lvwMahasiswa.Items.Add(item);
            }
            else 
            {
                int row = lvwMahasiswa.SelectedIndices[0];

                ListViewItem itemRow = lvwMahasiswa.Items[row];
                itemRow.SubItems[1].Text = mhs.Nim;
                itemRow.SubItems[2].Text = mhs.Name;
                itemRow.SubItems[3].Text = mhs.Gender;
                itemRow.SubItems[4].Text = mhs.Alamat;
                itemRow.SubItems[5].Text = mhs.Date;
            }
        }

        private void btnTambah_Click(object sender, EventArgs e)
        {
            frmEntry = new Frmmhs("Tambah Data Mahasiswa");
            frmEntry.OnSave += Frmmhs_OnSave; 
            frmEntry.ShowDialog();
        }
        
        private void Frmmhs_OnSave(Mahasiswa obj)
        {
            listOfMahasiswa.Add(obj);
            FillToListView(true, obj);
        }

        private void btnUbah_Click(object sender, EventArgs e)
        {
            if (lvwMahasiswa.SelectedItems.Count > 0)
            {
                var mhs = listOfMahasiswa[lvwMahasiswa.SelectedIndices[0]];
                
                frmEntry = new Frmmhs("Edit Data Mahasiswa", mhs);

                frmEntry.OnUpdate += Frmmhs_OnUpdate;
           
                frmEntry.ShowDialog();
            }
            else
            {
                MessageBox.Show("Data belum dipilih", "Peringatan", MessageBoxButtons.OK,
                        MessageBoxIcon.Exclamation);
            }
        }
        private void Frmmhs_OnUpdate(Mahasiswa obj)
        {
            FillToListView(false, obj);
        }
        private void btnHapus_Click(object sender, EventArgs e)
        {
            if (lvwMahasiswa.SelectedItems.Count > 0)
            {
                var mhs = listOfMahasiswa[lvwMahasiswa.SelectedIndices[0]];

                var msg = string.Format("Apakah data mahasiswa '{0}' ingin dihapus ?", mhs.Name);

                if (MessageBox.Show(msg, "Konfirmasi", MessageBoxButtons.YesNo,
                        MessageBoxIcon.Exclamation) == DialogResult.Yes)
                {
                    listOfMahasiswa.Remove(mhs); 

                    lvwMahasiswa.Items.Clear();
                    foreach (var obj in listOfMahasiswa)
                    {
                        FillToListView(true, obj);
                    }
                }
            }
            else 
            {
                MessageBox.Show("Data belum dipilih", "Peringatan", MessageBoxButtons.OK,
                        MessageBoxIcon.Exclamation);
            }
        }

        private void btnTutup_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void lvwMahasiswa_DoubleClick(object sender, EventArgs e)
        {
            if (lvwMahasiswa.SelectedItems.Count > 0)
            {
                var mhs = listOfMahasiswa[lvwMahasiswa.SelectedIndices[0]];

                frmEntry = new Frmmhs("Edit Data Mahasiswa", mhs);
                frmEntry.OnUpdate += Frmmhs_OnUpdate;
                frmEntry.ShowDialog();
            }
            else
            {
                MessageBox.Show("Data belum dipilih", "Peringatan", MessageBoxButtons.OK,
                        MessageBoxIcon.Exclamation);
            }
        }
    }
}
