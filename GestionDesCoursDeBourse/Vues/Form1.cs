using GestionDesCoursDeBourse.Modeles;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestionDesCoursDeBourse
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string[] lignes = System.IO.File.ReadAllLines(@"C:\Users\Thierry\participer.txt");
            
            foreach (string line in lignes)
            {
                bool res = false;
                foreach (Entreprise uneEntreprise in Entreprise.CollClasseEntreprise)
                {
                    if (line.Split('-')[0].Equals(uneEntreprise.Nom))
                    {
                        res = true;
                        uneEntreprise.LesCours.Add(new Cours(Convert.ToInt32(line.Split('-')[1])));

                    }
                     
                }
                if (res.Equals(false))
                {
                    new Entreprise(line.Split('-')[0], new Cours(Convert.ToInt32(line.Split('-')[1])));
                }
                
            }

                
        }
       
    }
}
