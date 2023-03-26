using FontAwesome.Sharp;
using NAudio.Wave;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Music_Player_App.Forms
{
    public partial class FormResponsiveMain : Form
    {
        List<String> Fav = new List<String>();
        List<String> Folders = new List<String>();
        List<Music> Musics = new List<Music>();
        List<String> one = new List<string>();
        List<String> two = new List<string>();
        List<String> three = new List<string>();
        List<String> four = new List<string>();
        List<String> five = new List<string>();
        private IconButton currentBtn;
        private double volume = 0.5;
        public bool moved = false, repeat = false, add_favourite = false, remove_favourite = false, add_to_list = false, remove_from_list = false;
        private bool musics = false, favourites = false, list1 = false, list2 = false, list3 = false, list4 = false, list5 = false, stopped = false, completed = false;
        private bool changevolume = false;
        System.Windows.Media.MediaPlayer player = new System.Windows.Media.MediaPlayer();
        public int full, part, x, y, progress = 0, lastprog = 0, rawvol;
        private Form currentChildForm;

        public FormResponsiveMain()
        {
            InitializeComponent();
        }
        private struct Colors
        {
            public static Color color1 = Color.Red;
        }
        protected override bool ProcessDialogKey(Keys keyData)
        {
            if (Form.ModifierKeys == Keys.None && keyData == Keys.Space && stopped)
            {
                iconPause.BringToFront();
                player.Play();
                stopped = false;
                Timer1.Start();
            }
            else if (Form.ModifierKeys == Keys.None && keyData == Keys.Space && !stopped)
            {
                iconPlay.BringToFront();
                player.Pause();
                stopped = true;
                Timer1.Stop();
            }
            else if (Form.ModifierKeys == Keys.None && keyData == Keys.Escape)
            {
                WindowState = FormWindowState.Minimized;
            }
            else if (Form.ModifierKeys == Keys.None && keyData == Keys.Left)
            {
                Backward();
            }
            else if (Form.ModifierKeys == Keys.None && keyData == Keys.Right)
            {
                Forward();
            }
            else if (Form.ModifierKeys == Keys.None && keyData == Keys.F)
            {
                IconFAV_Click();
            }
            else if (Form.ModifierKeys == Keys.None && keyData == Keys.L)
            {
                IconAddToList_Click();
            }
            else if (Form.ModifierKeys == Keys.F && keyData == Keys.R)
            {
                IconFavRem_Click();
            }
            else if (Form.ModifierKeys == Keys.L && keyData == Keys.R)
            {
                IconListRemove_Click();
            }
            return base.ProcessDialogKey(keyData);
        }
        private void Button_Enable(Button sender, Color color)
        {
            if (sender != null)
            {
                Button_Disable();
                currentBtn = (IconButton)sender;
                currentBtn.ForeColor = color;
                currentBtn.TextAlign = ContentAlignment.MiddleCenter;
                currentBtn.IconColor = color;
                currentBtn.TextImageRelation = TextImageRelation.TextBeforeImage;
                currentBtn.ImageAlign = ContentAlignment.MiddleRight;
            }
        }
        private void Button_Disable()
        {
            if (currentBtn != null)
            {
                currentBtn.ForeColor = Color.White;
                currentBtn.TextAlign = ContentAlignment.MiddleCenter;
                currentBtn.IconColor = Color.White;
                currentBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
                currentBtn.ImageAlign = ContentAlignment.MiddleLeft;
            }
        }
        private void iconPictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void iconPictureBox1_MouseLeave(object sender, EventArgs e)
        {
            IconClose.ForeColor = Color.White;
        }

        private void IconMinimize_MouseLeave(object sender, EventArgs e)
        {
            IconMinimize.ForeColor = Color.White;
        }
        private void CloseChildForm()
        {
            if (currentChildForm != null)
            {
                currentChildForm.Close();
            }
        }
        private void OpenChildForm(Form childForm)
        {
            CloseChildForm();
            currentChildForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            PanelMain.Controls.Add(childForm);
            PanelMain.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }


        private void ListButton(object sender, EventArgs e)
        {
            IconButton button = (IconButton)sender;
            string text = button.Text;
            iconPause.BringToFront();
            switch (text)
            {
                case "1. Lista":
                    if (one.Count > 0)
                    {
                        if (!list1)
                        {
                            Button_Enable((IconButton)sender, Colors.color1);
                            CloseChildForm();
                            IconListMinus.BringToFront();
                            ListNumber.Visible = false;
                            BoolReset();
                            lstMusicList.Items.Clear();
                            foreach (var item in one.OrderBy(x => x))
                            {
                                lstMusicList.Items.Add(item);
                            }
                            list1 = true;
                            lstMusicList.SelectedIndex = 0;
                            PlayMusic();
                            IconVisible();
                        }
                        else { CloseChildForm(); Button_Enable((IconButton)sender, Colors.color1); }
                    }
                    break;
                case "2. Lista":
                    if (two.Count > 0)
                    {
                        if (!list2)
                        {
                            Button_Enable((IconButton)sender, Colors.color1);
                            CloseChildForm();
                            IconListMinus.BringToFront();
                            ListNumber.Visible = false;
                            BoolReset();
                            lstMusicList.Items.Clear();
                            foreach (var item in two.OrderBy(x => x))
                            {
                                lstMusicList.Items.Add(item);
                            }
                            list2 = true;
                            lstMusicList.SelectedIndex = 0;
                            PlayMusic();
                            IconVisible();
                        }
                        else { CloseChildForm(); Button_Enable((IconButton)sender, Colors.color1); }
                    }
                    break;
                case "3. Lista":
                    if (three.Count > 0)
                    {
                        if (!list3)
                        {
                            Button_Enable((IconButton)sender, Colors.color1);
                            CloseChildForm();
                            IconListMinus.BringToFront();
                            ListNumber.Visible = false;
                            BoolReset();
                            lstMusicList.Items.Clear();
                            foreach (var item in three.OrderBy(x => x))
                            {
                                lstMusicList.Items.Add(item);
                            }
                            list3 = true;
                            lstMusicList.SelectedIndex = 0;
                            PlayMusic();
                            IconVisible();
                        }
                        else { CloseChildForm(); Button_Enable((IconButton)sender, Colors.color1); }
                    }
                    break;
                case "4. Lista":
                    if (four.Count > 0)
                    {
                        if (!list4)
                        {
                            Button_Enable((IconButton)sender, Colors.color1);
                            CloseChildForm();
                            IconListMinus.BringToFront();
                            ListNumber.Visible = false;
                            BoolReset();
                            lstMusicList.Items.Clear();
                            foreach (var item in four.OrderBy(x => x))
                            {
                                lstMusicList.Items.Add(item);
                            }
                            list4 = true;
                            lstMusicList.SelectedIndex = 0;
                            PlayMusic();
                            IconVisible();
                        }
                        else { CloseChildForm(); Button_Enable((IconButton)sender, Colors.color1); }
                    }
                    break;
                case "5. Lista":
                    if (five.Count > 0)
                    {
                        if (!list5)
                        {
                            Button_Enable((IconButton)sender, Colors.color1);
                            CloseChildForm();
                            IconListMinus.BringToFront();
                            ListNumber.Visible = false;
                            BoolReset();
                            lstMusicList.Items.Clear();
                            foreach (var item in five.OrderBy(x => x))
                            {
                                lstMusicList.Items.Add(item);
                            }
                            list5 = true;
                            lstMusicList.SelectedIndex = 0;
                            PlayMusic();
                            IconVisible();
                        }
                        else { CloseChildForm(); Button_Enable((IconButton)sender, Colors.color1); }
                    }
                    break;
            }
        }
        private void CreateButtonDelegate(int count)
        {
            for (int i = 1; i <= count; i++)
            {
                IconButton NewButton = new IconButton();
                this.Controls.Add(NewButton);
                NewButton.Text = $"{i}. Lista";
                NewButton.Tag = i;
                NewButton.Location = new Point(0, 225 + i * 50);
                NewButton.Size = (Size)new Point(250, 50);
                NewButton.Visible = true;
                NewButton.BringToFront();
                NewButton.IconChar = IconChar.List;
                NewButton.BackColor = Color.FromArgb(30, 30, 80);
                NewButton.ForeColor = Color.White;
                NewButton.IconColor = Color.White;
                NewButton.TextImageRelation = TextImageRelation.ImageBeforeText;
                NewButton.ImageAlign = ContentAlignment.MiddleLeft;
                NewButton.TextAlign = ContentAlignment.MiddleRight;
                NewButton.FlatStyle = FlatStyle.Flat;
                NewButton.FlatAppearance.BorderSize = 0;
                NewButton.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
                NewButton.Click += new EventHandler(this.ListButton);
            }
        }
        private void btnSzamok_Click(object sender, EventArgs e)
        {
            Button_Enable((IconButton)sender, Colors.color1);
            MusicsEnabled();
            iconFavouriteAdd.BringToFront();
            IconADDToList.BringToFront();
            ListNumber.Visible = false;
            CloseChildForm();
            if (stopped)
            {
                Timer1.Start();
                stopped = false;
                iconPause.BringToFront();
            }
            if (!musics)
            {
                BoolReset();
                musics = true;
            }
            IconVisible();
        }
        private void btnFavourite_Click(object sender, EventArgs e)
        {
            Button_Enable((IconButton)sender, Colors.color1);
            FavEnabled();
            ListNumber.Visible = false;
            CloseChildForm();
            if (stopped)
            {
                Timer1.Start();
                stopped = false;
                iconPause.BringToFront();
            }
            if (!favourites)
            {
                BoolReset();
                favourites = true;
            }
            IconVisible();
        }
        private void BoolReset()
        {
            add_to_list = false;
            remove_from_list = false;
            add_favourite = false;
            remove_favourite = false;
            IconFavRemove.ForeColor = Color.White;
            iconFavouriteAdd.ForeColor = Color.White;
            IconListMinus.ForeColor = Color.White;
            IconADDToList.ForeColor = Color.White;
            musics = false;
            favourites = false;
            list1 = false;
            list2 = false;
            list3 = false;
            list4 = false;
            list5 = false;
        }
        private void IconVisible()
        {
            if (list1 || list2 || list3 || list4 || list5)
            {
                iconFavouriteAdd.Visible = true;
                IconFavRemove.Visible = false;
                IconListMinus.Visible = true;
                IconADDToList.Visible = false;
            }
            else if (favourites)
            {
                iconFavouriteAdd.Visible = false;
                IconFavRemove.Visible = true;
                IconListMinus.Visible = false;
                IconADDToList.Visible = true;
            }
            else
            {
                iconFavouriteAdd.Visible = true;
                IconFavRemove.Visible = false;
                IconListMinus.Visible = false;
                IconADDToList.Visible = true;
            }
        }
        private void FavEnabled()
        {
            if (!favourites)
            {
                if (Fav.Count > 0)
                {
                    lstMusicList.BringToFront();
                    IconFavRemove.BringToFront();
                    lstMusicList.Items.Clear();
                    foreach (var item in Fav.OrderBy(x => x))
                    {
                        lstMusicList.Items.Add(item);
                    }
                    BoolReset();
                    lstMusicList.SelectedIndex = 0;
                }
                else
                {
                    MessageBox.Show("Nincs megjeleníthető zene!");
                    btnMusics.PerformClick();
                }
            }
        }
        private void MusicsEnabled()
        {
            if (!musics)
            {
                if (Musics.Count() > 0)
                {
                    lstMusicList.BringToFront();
                    iconFavouriteAdd.BringToFront();
                    lstMusicList.Items.Clear();
                    foreach (var item in Musics.OrderBy(x => x.title))
                    {
                        lstMusicList.Items.Add(item.title);
                    }
                    lstMusicList.SelectedIndex = 0;
                    BoolReset();
                }
                else
                {
                    btnFolders.PerformClick();
                }
            }
        }


        private void btnFolders_Click(object sender, EventArgs e)
        {
            Button_Enable((IconButton)sender, Colors.color1);
            OpenChildForm(new Form_Folders());
        }
        private void PanelMove_MouseDown(object sender, MouseEventArgs e)
        {
            moved = true;
            x = e.X + 250;
            y = e.Y;
        }

        private void PanelMove_MouseMove(object sender, MouseEventArgs e)
        {
            if (moved)
            {
                this.SetDesktopLocation(MousePosition.X - x, MousePosition.Y - y);
            }
        }

        private void IconMinimize_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void PlayMusic()
        {
            try
            {

                foreach (var item in Musics)
                {
                    if (item.title == lstMusicList.SelectedItem.ToString())
                    {
                        Mp3FileReader reader = new Mp3FileReader(item.path);
                        TimeSpan fulltime = reader.TotalTime;
                        lblfull.Text = fulltime.Days.ToString() + ":" + fulltime.Hours.ToString() + ":" + fulltime.Minutes.ToString() + ":" + fulltime.Seconds.ToString();
                        player.Volume = 0.5f;
                        lblVolume.Text = Convert.ToString(Convert.ToDouble(player.Volume) * 100);
                        trackBar1.Value = 50;
                        player.Open(new Uri(item.path.ToString()));
                        player.Play();
                        full = (Convert.ToInt32(fulltime.Days.ToString()) * 24 * 60 * 60) + (Convert.ToInt32(fulltime.Hours.ToString()) * 60 * 60) + (Convert.ToInt32(fulltime.Minutes.ToString()) * 60) + (Convert.ToInt32(fulltime.Seconds.ToString()));
                        progBar.Maximum = full;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void AddFavourite()
        {
            bool reserved = false;
            if (add_favourite)
            {
                foreach (var item in Fav)
                {
                    if (item == lstMusicList.SelectedItem.ToString())
                    {
                        reserved = true;
                    }
                }
                if (!reserved)
                {
                    Fav.Add(Convert.ToString(lstMusicList.SelectedItem));
                    Fav.OrderBy(x => x);
                    StreamWriter sw = new StreamWriter("favourite.txt");
                    foreach (var item in Fav)
                    {
                        sw.WriteLine(item);
                    }
                    sw.Close();

                }
            }
        }
        private void RemoveFavourite()
        {
            string currItem = "";
            List<string> list = new List<string>();
            if (lstMusicList.SelectedItems != null)
            {
                currItem = lstMusicList.SelectedItem.ToString();
                foreach (var item in Fav)
                {
                    if (item != currItem)
                    {
                        list.Add(item);
                    }
                }
                Fav.Clear();
                lstMusicList.Items.Clear();
                foreach (var item in list)
                {
                    Fav.Add(item);
                    lstMusicList.Items.Add(item);
                }
                StreamWriter sw = new StreamWriter("favourite.txt");
                foreach (var item in list)
                {
                    sw.WriteLine(item);
                }
                sw.Close();
            }
        }
        private void lstMusicList_SelectedIndexChanged(object sender, EventArgs e)
        {
            if ((!add_favourite) && (!remove_favourite) && (!add_to_list) && (!remove_from_list))
            {
                PlayMusic();
            }
            else if (add_favourite)
            {
                AddFavourite();
            }
            else if (remove_favourite)
            {
                RemoveFavourite();
            }
            else if (add_to_list)
            {
                AddToList();
            }
            else if (remove_from_list)
            {
                RemoveFromList();
            }
        }
        private void RemoveFromList()
        {
            if (list1)
            {
                string currItem = "";
                List<string> list = new List<string>();
                if (lstMusicList.SelectedItems != null)
                {
                    currItem = lstMusicList.SelectedItem.ToString();
                    foreach (var item in one)
                    {
                        if (item != currItem)
                        {
                            list.Add(item);
                        }
                    }
                    one.Clear();
                    lstMusicList.Items.Clear();
                    StreamWriter sw = new StreamWriter("one.txt");
                    foreach (var item in list)
                    {
                        one.Add(item);
                        lstMusicList.Items.Add(item);
                        sw.WriteLine(item);
                    }
                    sw.Close();
                }
            }
            else if (list2)
            {
                string currItem = "";
                List<string> list = new List<string>();
                if (lstMusicList.SelectedItems != null)
                {
                    currItem = lstMusicList.SelectedItem.ToString();
                    foreach (var item in two)
                    {
                        if (item != currItem)
                        {
                            list.Add(item);
                        }
                    }
                    two.Clear();
                    lstMusicList.Items.Clear();
                    StreamWriter sw = new StreamWriter("two.txt");
                    foreach (var item in list)
                    {
                        two.Add(item);
                        lstMusicList.Items.Add(item);
                        sw.WriteLine(item);
                    }
                    sw.Close();
                }
            }
            else if (list3)
            {
                string currItem = "";
                List<string> list = new List<string>();
                if (lstMusicList.SelectedItems != null)
                {
                    currItem = lstMusicList.SelectedItem.ToString();
                    foreach (var item in three)
                    {
                        if (item != currItem)
                        {
                            list.Add(item);
                        }
                    }
                    three.Clear();
                    lstMusicList.Items.Clear();
                    StreamWriter sw = new StreamWriter("three.txt");
                    foreach (var item in list)
                    {
                        three.Add(item);
                        lstMusicList.Items.Add(item);
                        sw.WriteLine(item);
                    }
                    sw.Close();
                }
            }
            else if (list4)
            {
                string currItem = "";
                List<string> list = new List<string>();
                if (lstMusicList.SelectedItems != null)
                {
                    currItem = lstMusicList.SelectedItem.ToString();
                    foreach (var item in four)
                    {
                        if (item != currItem)
                        {
                            list.Add(item);
                        }
                    }
                    four.Clear();
                    lstMusicList.Items.Clear();
                    StreamWriter sw = new StreamWriter("four.txt");
                    foreach (var item in list)
                    {
                        four.Add(item);
                        lstMusicList.Items.Add(item);
                        sw.WriteLine(item);
                    }
                    sw.Close();
                }
            }
            else if (list5)
            {
                string currItem = "";
                List<string> list = new List<string>();
                if (lstMusicList.SelectedItems != null)
                {
                    currItem = lstMusicList.SelectedItem.ToString();
                    foreach (var item in five)
                    {
                        if (item != currItem)
                        {
                            list.Add(item);
                        }
                    }
                    five.Clear();
                    lstMusicList.Items.Clear();
                    StreamWriter sw = new StreamWriter("five.txt");
                    foreach (var item in list)
                    {
                        five.Add(item);
                        lstMusicList.Items.Add(item);
                        sw.WriteLine(item);
                    }
                    sw.Close();
                }
            }
        }
        private void AddToList()
        {
            int listnumber = Convert.ToInt32(ListNumber.Text);
            switch (listnumber)
            {
                case 1:
                    if (one.Count(x => x.Equals(lstMusicList.SelectedItem.ToString())) == 0)
                    {
                        one.Add(Convert.ToString(lstMusicList.SelectedItem));
                        StreamWriter sw1 = new StreamWriter("one.txt");
                        foreach (var item in one)
                        {
                            sw1.WriteLine(item);
                        }
                        sw1.Close();
                    }
                    break;
                case 2:
                    if (one.Count(x => x.Equals(lstMusicList.SelectedItem.ToString())) == 0)
                    {
                        two.Add(Convert.ToString(lstMusicList.SelectedItem));
                        StreamWriter sw2 = new StreamWriter("two.txt");
                        foreach (var item in two)
                        {
                            sw2.WriteLine(item);
                        }
                        sw2.Close();
                    }
                    break;
                case 3:
                    if (one.Count(x => x.Equals(lstMusicList.SelectedItem.ToString())) == 0)
                    {
                        three.Add(Convert.ToString(lstMusicList.SelectedItem));
                        StreamWriter sw3 = new StreamWriter("three.txt");
                        foreach (var item in three)
                        {
                            sw3.WriteLine(item);
                        }
                        sw3.Close();
                    }
                    break;
                case 4:
                    if (one.Count(x => x.Equals(lstMusicList.SelectedItem.ToString())) == 0)
                    {
                        four.Add(Convert.ToString(lstMusicList.SelectedItem));
                        StreamWriter sw4 = new StreamWriter("four.txt");
                        foreach (var item in four)
                        {
                            sw4.WriteLine(item);
                        }
                        sw4.Close();
                    }
                    break;
                case 5:
                    if (five.Count(x => x.Equals(lstMusicList.SelectedItem.ToString())) == 0)
                    {
                        five.Add(Convert.ToString(lstMusicList.SelectedItem));
                        StreamWriter sw5 = new StreamWriter("five.txt");
                        foreach (var item in five)
                        {
                            sw5.WriteLine(item);
                        }
                        sw5.Close();
                    }
                    break;
            }
        }

        private void IconClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void IconClose_MouseEnter(object sender, EventArgs e)
        {
            IconClose.ForeColor = Color.Red;

        }

        private void IconMinimize_MouseEnter(object sender, EventArgs e)
        {
            IconMinimize.ForeColor = Color.Yellow;
        }

        private void ASD(int prog, int lastprog)
        {
        }
        private void Timer_Tick(object sender, EventArgs e)
        {

            try
            {
                lblPos.Text = player.Position.Days.ToString() + ":" + player.Position.Hours.ToString() + ":" + player.Position.Minutes.ToString() + ":" + player.Position.Seconds.ToString();
                part = (Convert.ToInt32(player.Position.Days.ToString()) * 24 * 60 * 60) + (Convert.ToInt32(player.Position.Hours.ToString()) * 60 * 60) + (Convert.ToInt32(player.Position.Minutes.ToString()) * 60) + (Convert.ToInt32(player.Position.Seconds.ToString()));
                int current = (Convert.ToInt32(player.Position.Days.ToString()) * 24 * 60 * 60) + (Convert.ToInt32(player.Position.Hours.ToString()) * 60 * 60) + (Convert.ToInt32(player.Position.Minutes.ToString()) * 60) + (Convert.ToInt32(player.Position.Seconds.ToString()));

                //int progress = (int)((current / full));
                progBar.Value = current;
                if (part == full)
                {
                    if (repeat)
                    {
                        lstMusicList.SelectedIndex += 1;
                        lstMusicList.SelectedIndex -= 1;
                    }
                    else
                    {
                        if (lstMusicList.SelectedIndex < lstMusicList.Items.Count - 1)
                        {
                            lstMusicList.SelectedIndex += 1;
                        }
                        else if (lstMusicList.SelectedIndex == lstMusicList.Items.Count - 1)
                        {
                            lstMusicList.SelectedIndex = 0;
                        }
                    }

                }
            }
            catch (IndexOutOfRangeException ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void SetVolume()
        {
            if (changevolume)
                volume = rawvol / 100;
            player.Volume = volume;
        }
        private void btnSettings_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Form_Settings());

        }

        private void IconListRemove_Click()
        {
            if (!remove_from_list)
            {
                remove_from_list = true;
                IconListMinus.ForeColor = Color.Red;
            }
            else
            {
                remove_from_list = false;
                IconListMinus.ForeColor = Color.White;
            }
        }
        private void IconListMinus_Click(object sender, EventArgs e)
        {
            IconListRemove_Click();
        }

        private void IconRepeat_Click(object sender, EventArgs e)
        {
            if (repeat)
            {
                repeat = false;
                IconRepeat.ForeColor = Color.White;
            }
            else
            {
                repeat = true;
                IconRepeat.ForeColor = Color.Red;
            }
        }
        private void IconAddToList_Click()
        {
            if (!add_to_list)
            {
                add_to_list = true;
                IconADDToList.ForeColor = Color.Red;
                ListNumber.Visible = true;
            }
            else
            {
                add_to_list = false;
                IconADDToList.ForeColor = Color.White;
                ListNumber.Visible = false;
            }
        }
        private void IconListPlus_Click(object sender, EventArgs e)
        {
            IconAddToList_Click();
        }

        private void iconPause_Click(object sender, EventArgs e)
        {
            player.Pause();
            Timer1.Stop();
            stopped = true;
            iconPlay.BringToFront();
        }

        private void iconPlay_Click(object sender, EventArgs e)
        {
            player.Play();
            Timer1.Start();
            stopped = false;
            iconPause.BringToFront();
        }

        private void IconFavRem_Click()
        {
            if (!remove_favourite)
            {
                IconFavRemove.ForeColor = Color.Red;
                remove_favourite = true;
            }
            else
            {
                IconFavRemove.ForeColor = Color.White;
                remove_favourite = false;
            }
        }
        private void IconFavRemove_Click(object sender, EventArgs e)
        {
            IconFavRem_Click();
        }
        private void IconFAV_Click()
        {
            if (!add_favourite)
            {
                iconFavouriteAdd.ForeColor = Color.Red;
                add_favourite = true;
            }
            else
            {
                iconFavouriteAdd.ForeColor = Color.White;
                add_favourite = false;
            }
        }
        private void iconFavourite_Click(object sender, EventArgs e)
        {
            IconFAV_Click();
        }

        private void Backward()
        {
            if (lstMusicList.SelectedIndex < lstMusicList.Items.Count - 1)
            {
                lstMusicList.SelectedIndex += 1;
            }
            else if (lstMusicList.SelectedIndex == lstMusicList.Items.Count - 1)
            {
                lstMusicList.SelectedIndex = 0;
            }
        }
        private void Forward()
        {
            if (lstMusicList.SelectedIndex > 0)
            {
                lstMusicList.SelectedIndex -= 1;
            }
            else if (lstMusicList.SelectedIndex == 0)
            {
                lstMusicList.SelectedIndex = lstMusicList.Items.Count - 1;
            }
        }
        private void IconFor_Click(object sender, EventArgs e)
        {
            Backward();
        }

        private void iconBack_Click(object sender, EventArgs e)
        {
            Forward();
        }

        public void SetToolTip()
        {
            ToolTip tooltip = new ToolTip();
            tooltip.AutoPopDelay = 5000;
            tooltip.InitialDelay = 1000;
            tooltip.ReshowDelay = 500;
            tooltip.ShowAlways = true;
            tooltip.BackColor = Color.FromArgb(30, 30, 90);
            tooltip.ForeColor = Color.White;

            tooltip.SetToolTip(this.iconPause, "Szünet");
            tooltip.SetToolTip(this.iconPlay, "Lejátszás");
            tooltip.SetToolTip(this.IconRepeat, "Ismétlés");
            tooltip.SetToolTip(this.IconFor, "Következő");
            tooltip.SetToolTip(this.iconBack, "Előző");
            tooltip.SetToolTip(this.iconPlay, "Lejátszás");
            tooltip.SetToolTip(this.iconFavouriteAdd, "Kedvenc hozzáadása");
            tooltip.SetToolTip(this.IconFavRemove, "Kedvenc eltávolítása");
            tooltip.SetToolTip(this.IconListMinus, "Eltávolítás a lejátszási listából");
            tooltip.SetToolTip(this.IconADDToList, "Hozzáadás a lejátszási listához");

        }
        private void FormResponsiveMain_Load(object sender, EventArgs e)
        {
            try
            {
                SetToolTip();
                Musics.Clear();
                Folders.Clear();
                ListNumber.Visible = false;
                String ln;
                StreamReader sr = new StreamReader("folders.txt");
                while ((ln = sr.ReadLine()) != null)
                {
                    Folders.Add(ln);
                }
                foreach (var item in Folders)
                {
                    foreach (var it in Directory.GetFiles(item, "*.mp3"))
                    {
                        if (Musics.Count(x => x.title == Path.GetFileName(it).ToString()) == 0)
                        {
                            Music n = new Music();
                            n.path = it;
                            n.title = Path.GetFileName(it).Replace(".mp3", "");
                            Musics.Add(n);
                        }
                    }
                }
                sr.Close();
                string ln2;
                StreamReader sr2 = new StreamReader("favourite.txt");
                while ((ln2 = sr2.ReadLine()) != null)
                {
                    int c = Musics.Count(x => x.title == ln2);
                    if (c > 0)
                    {
                        Fav.Add(ln2);
                    }
                }
                sr2.Close();
                StreamReader sr3 = new StreamReader("one.txt");
                while ((ln2 = sr3.ReadLine()) != null)
                {
                    one.Add(ln2);
                }
                sr3.Close();
                StreamReader sr4 = new StreamReader("two.txt");
                while ((ln2 = sr4.ReadLine()) != null)
                {
                    two.Add(ln2);
                }
                sr4.Close();
                StreamReader sr5 = new StreamReader("three.txt");
                while ((ln2 = sr5.ReadLine()) != null)
                {
                    three.Add(ln2);
                }
                sr5.Close();
                StreamReader sr6 = new StreamReader("four.txt");
                while ((ln2 = sr6.ReadLine()) != null)
                {
                    four.Add(ln2);
                }
                sr6.Close();
                StreamReader sr7 = new StreamReader("five.txt");
                while ((ln2 = sr7.ReadLine()) != null)
                {
                    five.Add(ln2);
                }
                sr7.Close();
                btnMusics.PerformClick();
                Timer1.Start();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            CreateButtonDelegate(5);
            btnMusics.PerformClick();
        }

        private void PanelMove_MouseUp(object sender, MouseEventArgs e)
        {
            moved = false;
        }

        private void PanelMove_DoubleClick(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Maximized)
            {
                WindowState = FormWindowState.Normal;
            }
            else
            {
                WindowState = WindowState = FormWindowState.Maximized;
            }
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            player.Volume = Convert.ToDouble(trackBar1.Value) / 100;
            lblVolume.Text = trackBar1.Value.ToString();
        }
    }
}
