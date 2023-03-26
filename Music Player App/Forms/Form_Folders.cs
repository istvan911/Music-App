using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Music_Player_App
{
    public partial class Form_Folders : Form
    {
        List<String> Folders = new List<String>();
        public bool have = false;
        public string currItem;
        public Form_Folders()
        {
            InitializeComponent();
        }

        private void iconPictureBox1_Click(object sender, EventArgs e)
        {
            using (var fbd = new FolderBrowserDialog())
            {
                DialogResult result = fbd.ShowDialog();

                if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(fbd.SelectedPath))
                {
                    foreach (var item in Folders)
                    {
                        if(item == fbd.SelectedPath)
                            have = true;
                    }
                    if(!have)
                    {
                        lstFolders.Items.Add(fbd.SelectedPath);
                        Folders.Add(fbd.SelectedPath);
                        StreamWriter sw = new StreamWriter("folders.txt");
                        foreach (var item in Folders)
                        {
                            sw.WriteLine(item);
                        }
                        sw.Close();
                    }
                    else
                    {
                        MessageBox.Show("A mappa már megtalálható az eltárolt mappák között!");
                    }
                }
            }
        }

        private void Form_Folders_Load(object sender, EventArgs e)
        {
            try
            {
                String ln;
                StreamReader sr = new StreamReader("folders.txt");
                while ((ln = sr.ReadLine()) != null)
                {
                    Folders.Add(ln);
                }
                ToolTip tooltip = new ToolTip();
                tooltip.AutoPopDelay = 5000;
                tooltip.InitialDelay = 1000;
                tooltip.ReshowDelay = 500;
                tooltip.ShowAlways = true;
                tooltip.BackColor = Color.FromArgb(30, 30, 90);
                tooltip.ForeColor = Color.White;

                tooltip.SetToolTip(this.iconAddFolder, "Mappa hozzáadása");
                tooltip.SetToolTip(this.iconDeleteFolder, "Mappa eltávolítása");
                if(Folders.Count() > 0)
                {
                    foreach (var item in Folders)
                    {
                        lstFolders.Items.Add(item);
                    }
                }
                else
                {
                    MessageBox.Show("Nincs megjeleníthető mappa! Kérem adjon hozzá egyet!");
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }
        private void iconAddFolder_MouseLeave(object sender, EventArgs e)
        {
            iconAddFolder.BackColor = Color.FromArgb(30, 30, 90);
            iconAddFolder.ForeColor = Color.White;
        }

        private void iconAddFolder_MouseEnter(object sender, EventArgs e)
        {
            iconAddFolder.BackColor = Color.FromArgb(30, 30, 50);
            iconAddFolder.ForeColor = Color.FromArgb(228, 172, 20);
        }

        private void iconDeleteFolder_MouseEnter(object sender, EventArgs e)
        {
            iconDeleteFolder.BackColor = Color.FromArgb(30, 30, 50);
            iconDeleteFolder.ForeColor = Color.FromArgb(228, 172, 20);
        }

        private void iconDeleteFolder_MouseLeave(object sender, EventArgs e)
        {
            iconDeleteFolder.BackColor = Color.FromArgb(30, 30, 90);
            iconDeleteFolder.ForeColor = Color.White;
        }

        private void iconDeleteFolder_Click(object sender, EventArgs e)
        {
            try
            {
                if(Folders.Count > 0)
                {
                    DialogResult result = MessageBox.Show("Kijelölte a törölni kívánt elemet?", "Visszajelzés kérése", MessageBoxButtons.YesNo);
                    if (result == DialogResult.Yes)
                    {
                        List<string> list = new List<string>();
                        if (lstFolders.SelectedItems != null)
                        {
                            currItem = lstFolders.SelectedItem.ToString();
                        }
                        foreach (var item in Folders)
                        {
                            if (item != currItem)
                            {
                                list.Add(item);
                            }
                        }
                        Folders.Clear();
                        lstFolders.Items.Clear();
                        foreach (var item in list)
                        {
                            Folders.Add(item);
                            lstFolders.Items.Add(item);
                        }
                        StreamWriter sw = new StreamWriter("folders.txt");
                        foreach (var item in Folders)
                        {
                            sw.WriteLine(item);
                        }
                        sw.Close();
                    }
                }
                else
                {
                    MessageBox.Show("Lista nem tartalmaz törölhető elemeket!");
                }
            }
            catch(NullReferenceException ex)
            {
                MessageBox.Show(ex.Message + "A törléshez jelöljön ki egy listamezőt!");
            }
        }
    }
}
