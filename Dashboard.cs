using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;



namespace System
{
    public partial class Dashboard : Form
    {

        private  Guna2Panel[] rooms;

        public Dashboard()
        {
            InitializeComponent();
            activeTab();
            configureRooms();
            hideRoomInformation();

        }
        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void ExitBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void activeTab()
        {
            lblAvailableUnit.ForeColor = Color.White;
            lblAvailableUnit.BackColor = Color.FromArgb(76, 205, 153);
            lblCheckIcon.BackColor = Color.FromArgb(76, 205, 153);
            pnlAvailUnit.Visible = true;
            pnlOccUnit.Visible = false;
        }

        private void configureRooms()
        {
            rooms = new Guna2Panel[] {room1, room2, room3 , room4 ,
                room5, room6, room7, room8, room9, room10 };

            foreach (var room in rooms)
            {
                room.Click += Room_Click;
                room.MouseLeave += Room_MouseLeave;
            }

        }

        private void hideRoomInformation()
        {
            roomInformation.Hide();
            roomNumber.Hide();
            roomNumberPanel.Hide();
            roomImage.Hide();
        }

        private void showRoomInformation()
        {
            roomInformation.Show();
            roomNumber.Show();
            roomNumberPanel.Show();
            roomImage.Show();
        }


        private void Room_Click(object sender, EventArgs e)
        {
            Guna2Panel clickedPanel = (Guna2Panel)sender;
            Image backgroundImage = clickedPanel.BackgroundImage;
            int roomIndex = Array.IndexOf(rooms, clickedPanel) + 1;

            //update image dipende sa iamge nung room 

       /*     if (backgroundImage != null)
            {
                roomImage.SizeMode = PictureBoxSizeMode.StretchImage;
                roomImage.Image = backgroundImage;
            }
            else { 
                roomImage.Image = null; 
                MessageBox.Show("The clicked panel does not have a background image.");
            }
*/
            roomNumber.Text = "Room" + " " + roomIndex.ToString();

            showRoomInformation();

        }

        private void Room_MouseLeave(object sender, EventArgs e)
        {
            hideRoomInformation();
        }


        private void lblAvailableUnit_Click(object sender, EventArgs e)
        {
            lblAvailableUnit.ForeColor = Color.White;
            lblAvailableUnit.BackColor = Color.FromArgb(76, 205, 153);
            lblCheckIcon.BackColor = Color.FromArgb(76, 205, 153);
            pnlAvailUnit.Visible = true;
            pnlOccUnit.Visible = false;
        }

   
        private void lblCheckIcon_Click(object sender, EventArgs e)
        {
            lblAvailableUnit.BackColor = Color.FromArgb(76, 205, 153);
            lblCheckIcon.BackColor = Color.FromArgb(76, 205, 153);
            pnlAvailUnit.Visible = true;
            pnlOccUnit.Visible = false;
        }


        private void pnlAvailUnit_Paint(object sender, PaintEventArgs e)
        {

        }

        private void roomInformation_Paint(object sender, PaintEventArgs e)
        {

        }

        private void roomNumberPanel_Paint(object sender, PaintEventArgs e)
        {

        }

    
    }
}
