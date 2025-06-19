using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HNI_TPmoyennes
{
    // Classes fournies par HNI Institut
    class Note
    {
        public int matiere { get; private set; }
        public float note { get; private set; }
        public Note(int m, float n)
        {
            matiere = m;
            note = n;
        }
    }

    class Classe
    {
        public string? nomClasse { get; private set; }
        public List<Eleve> eleves { get; private set; }
        public List<Matieres> matieres { get; private set; }

        
        public Classe(string? nomdeclasse)

        {
            nomClasse = nomdeclasse;
            eleves = new List<Eleve>();
            matieres = new List<Matieres>();
        }

        public void ajouterEleve(string prenom, string nom)
        {
            eleves.Add(new Eleve(prenom, nom));

        }

        public void ajouterMatiere(string nommatiere)
        {
            matieres.Add(new Matieres(nommatiere));
        }

        public double moyenneMatiere(int matiere)
        {
            double somme = 0;
            double moyenne = 0;
            int cpt = 0;

            foreach (Eleve eleve in eleves)
            {
                foreach (Note note in eleve.notes)
                {
                    if (note.matiere == matiere)
                    {
                        somme += note.note;
                        cpt++;
                    }
                }
            }

            moyenne = Math.Round(somme / cpt,2);
            
            return moyenne;
        }

        public double moyenneGeneral()
        {

            double somme = 0;
            double moyenne = 0;
            int cpt = 0;

            foreach (Eleve eleve in eleves)
            {
                foreach (Note note in eleve.notes)
                {
                    somme += note.note;
                    cpt++;
                }
            }
            moyenne = Math.Round(somme / cpt,2);
            return moyenne;


        }

    }

    class Eleve
    {
        public string nom { get; private set; }
        public string prenom { get; private set; }
        public List<Note> notes { get; private set; }

        public Eleve(string prenom_ ,string nom_)
        {
            nom = nom_;
            prenom = prenom_;
            notes = new List<Note>();
        }


        public void ajouterNote(Note note)
        {
            notes.Add(note);
        }

        public double moyenneMatiere(int matiere)
        {
            double somme = 0;
            double moyenne = 0;
            int cpt = 0;

            foreach(Note note in notes)
            {
                if (note.matiere == matiere)
                {
                    somme += note.note;

                    cpt++;
                }
            }


            moyenne = Math.Round(somme / cpt, 2);
            return moyenne;
        }

        public double moyenneGeneral()
        {
            
            double somme = 0;
            double moyenne = 0;
            int cpt = 0;

            foreach(Note note in notes)
            {
                somme += note.note;
                cpt++;
            }

            moyenne = Math.Round(somme / cpt, 2);
            return moyenne;


        }
    }

    class Matieres
    {
        public string NomMatiere { get; private set; }

        public Matieres(string nommatiere)
        {
            NomMatiere = nommatiere;
        }
    }
}
