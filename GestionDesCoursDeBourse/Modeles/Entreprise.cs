using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionDesCoursDeBourse.Modeles
{
    class Entreprise
    {
        #region Attributs
        public static List<Entreprise> CollClasseEntreprise = new List<Entreprise>();        
        private int _id;
        private string _nom;
        private List<Cours> _lesCours;


        #endregion
        #region Constructeurs

        public Entreprise( string nom,Cours lecours)
        {
            _id = Entreprise.CollClasseEntreprise.Count + 1;
            _nom = nom;
            
            _lesCours = new List<Cours>();
            _lesCours.Add(lecours);
            Entreprise.CollClasseEntreprise.Add(this);
        }
        #endregion
        #region Getters Setters
        public int Id { get => _id; set => _id = value; }
        public string Nom { get => _nom; set => _nom = value; }
        public List<Cours> LesCours { get => _lesCours; set => _lesCours = value; }

        #endregion
        #region Methodes
        #endregion
    }
}
