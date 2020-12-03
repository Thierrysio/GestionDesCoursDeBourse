using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionDesCoursDeBourse.Modeles
{
    class Cours
    {
        #region Attributs
        public static List<Cours> CollClasseCours = new List<Cours>();
        private int _id;
        private int _bCours;

        #endregion
        #region Constructeurs
        public Cours( int bCours)
        {
            _id =  Cours.CollClasseCours.Count + 1; 
            _bCours = bCours;
            Cours.CollClasseCours.Add(this);
        }
        #endregion
        #region Getters Setters
        public int Id { get => _id; set => _id = value; }
        public int BCours { get => _bCours; set => _bCours = value; }

        #endregion
        #region Methodes
        #endregion
    }
}
