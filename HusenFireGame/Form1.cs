using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HusenFireGame
{
    public partial class Form1 : Form
    {
        //global variable 
        int x = 0,y=0;
        int z = 2,cunt=0;

        //object of another class using the concept of polymorphism
        GenreateFire obj = new GenreateFire();
        Image Imageobj = new Image();

        public Form1()
        {
            InitializeComponent();
        }

        private void btnSpin_Click(object sender, EventArgs e)
        {
            //working of spin image verify the counter
            if (x > 0)
            {
                pbGun.ImageLocation = "pic/8th.jpg";
            }
            else {
                MessageBox.Show("Firstly Load the Gun");

            }
        }

        private void btnShot_Click(object sender, EventArgs e)
        {
            int n = 0;
            if (x > 0) {
                
                y++;
                // default the gun image will be display 
                pbGun.ImageLocation = Imageobj.Shot();
                //check the chances of shoot and then trigger
                if (y == z && cunt<2)
                {
                   cunt++;
                    //generate the sound effect to generate the bullet sound
                   System.Media.SoundPlayer player = new System.Media.SoundPlayer("pic/sund.wav");
                   player.Play();
                    // calling the method from the class to fire
                    z = obj.fire();

                }
                else
                {
                    n++;
                }

                if (n==6)
                {
                    MessageBox.Show("you lose the game");
                }

                if (cunt == 2)
                {
                    // finishing the chance the error message will be display 
                    MessageBox.Show("Bullets are finished ");
                    MessageBox.Show("you win the game and you score is "+cunt);
                    btnShot.Enabled = false;
                }
            }
            

        }

        private void btnPlayAgain_Click(object sender, EventArgs e)
        {
            y = 0;
            x = 0;
            cunt = 0;
            // enable  the button after clicking on the play again button
            btnShot.Enabled = true;
            // reset the image of picture box
            pbGun.ImageLocation =Imageobj.plyAgain(); 

        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            // load the gun while clicking on the load button 
            x = x + 1;
            if (x == 1)
            {
                pbGun.ImageLocation =Imageobj.loadImage();
            }
        }


    }
}
