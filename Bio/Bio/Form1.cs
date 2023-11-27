using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bio
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
        int nr = 0;
        private void button1_Click(object sender, EventArgs e)
        {
            if (PavUr.Text.ToLower()=="pavilionul urechii")
            {
                PavUr.BackColor = Color.Green;
                nr++;
                PavUr.ReadOnly = true;
            }
            else { PavUr.BackColor = Color.Red;
                PavUr.ReadOnly= true;

                 }
            if(Ciocan.Text.ToLower() == "ciocan")
            {
                Ciocan.BackColor = Color.Green;
                nr++;
                Ciocan.ReadOnly = true;
            }
            else {Ciocan.BackColor = Color.Red;
            Ciocan.ReadOnly= true;
            }
            if(CanAudExt.Text.ToLower() == "canalul auditiv extern")
            {
                CanAudExt.BackColor = Color.Green; nr++;
                CanAudExt.ReadOnly = true;
            }
            else
            { CanAudExt.BackColor = Color.Red;
            CanAudExt.ReadOnly= true;
            }
            if(Nicov.Text.ToLower()== "nicovala")
            {
                Nicov.BackColor = Color.Green; nr++;
                Nicov.ReadOnly = true;
            }
            else
            { Nicov.BackColor = Color.Red;
            Nicov.ReadOnly= true;
            }
            if(Scarita.Text.ToLower()== "scarita")
            {
                Scarita.BackColor = Color.Green;
                Scarita.ReadOnly= true;
                nr++;
            }
            else
            { Scarita.BackColor = Color.Red;
            Scarita.ReadOnly= true;
            }
            if(Vestibul.Text.ToLower()=="vestibul")
            {
                Vestibul.BackColor = Color.Green; nr++;
                Vestibul.ReadOnly = true;
            }
            else
            { Vestibul.BackColor= Color.Red;
            Vestibul.ReadOnly= true;
            }
            if(NervVest.Text.ToLower()== "nervul vestibular")
            {
                NervVest.BackColor = Color.Green; nr++;
                NervVest.ReadOnly= true;
            }
            else
            { NervVest.BackColor= Color.Red;
            NervVest.ReadOnly= true;
            }
            if(NervCoh.Text.ToLower() == "nervul cohlear")
            {
                NervCoh.BackColor = Color.Green; nr++;
                NervCoh.ReadOnly= true;
            }
            else
            { NervCoh.BackColor= Color.Red;
            NervCoh.ReadOnly= true;
            }
            if(FerRot.Text.ToLower()== "fereastra rotunda")
            {
                FerRot.BackColor = Color.Green;
                nr++;
                FerRot.ReadOnly= true;
            }
            else
            { FerRot.BackColor= Color.Red;
            FerRot.ReadOnly= true;
            }
            if(Coh.Text.ToLower()== "cohlea")
            {
                Coh.BackColor = Color.Green;
                nr++;
                Coh.ReadOnly= true;
            }
            else { Coh.BackColor= Color.Red; Coh.ReadOnly= true; }
            if(tromEust.Text == "trompa lui Eustachio")
            {
                tromEust.BackColor= Color.Green;
                nr++;
                tromEust.ReadOnly= true;
            }
            else
            { tromEust.BackColor=Color.Red;
            tromEust.ReadOnly= true;
            }
            if(CavTim.Text.ToLower()== "cavitatea timpanica")
            {
                CavTim.BackColor= Color.Green; nr++; 
                    CavTim.ReadOnly= true;
            }
            else
            { CavTim.ReadOnly = true;
                CavTim.BackColor = Color.Red;
            }
            if (Timpan.Text.ToLower() == "timpan")
            {
                Timpan.BackColor = Color.Green; nr++;
                Timpan.ReadOnly = true;
            }
            else
            {
                Timpan.BackColor = Color.Red;
                Timpan.ReadOnly = true;
            }
            if(UrExt.Text.ToLower()== "urechea externa")
            {
                UrExt.BackColor= Color.Green;nr++;
                UrExt.ReadOnly= true;
            }
            else
            { UrExt.BackColor= Color.Red;
            UrExt.ReadOnly= true;}
            if(UrMed.Text.ToLower() == "urechea medie")
            {
                UrMed.BackColor= Color.Green;
                nr++;
                UrMed.ReadOnly= true;
            }
            else
            { UrMed.BackColor= Color.Red;
                UrMed.ReadOnly= true;
            }
            if(UrInt.Text.ToLower()== "urechea interna")
            {
                UrInt.BackColor= Color.Green;
                nr++; UrInt.ReadOnly= true;
            }
            else
            { UrInt.BackColor= Color.Red;
                UrInt.ReadOnly= true;
            }    

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (nr > 6)
                MessageBox.Show("Felicitari ai obtinut " + nr + " din 16 puncte", "Afisare Punctaj!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else MessageBox.Show("Din pacate ai picat acest test cu "+nr+" punct(e)","Esec",MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }
    }
}
