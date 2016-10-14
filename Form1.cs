using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projet_Management
{
    public partial class Form1 : Form
    {
        private List<Question> listeQuestion;
        private Question curQuestion;
        private int qN;

        public Form1()
        {
            InitializeComponent();
            listeQuestion = new List<Question>();
            qN = 0;
            string[] a = new string[4];
            string q = "Parmi les techniques suivantes, laquelle est liée au financement d'un projet ?";
            a[0] = "a) ligne budgétaire";
            a[1] = "b) Courbe en S";
            a[2] = "c) liste de prix";
            a[3] = "d) valeur actuelle nette";

            listeQuestion.Add(new Question(q, a, 3));

            a = new string[4];

            q = "Jean doit livrer une récolte de fruits évaluée a 10,000€. La probabilité de perdre la moitié des fruits à cause du mauvais temps est de 20%. Pour pallier cette perte possible, Jean décide de prendre une assurance. Parmi les prix proposés, quel est celui que Jean ne doit pas dépasser:";
            a[0] = "a) 500";
            a[1] = "b) 1000";
            a[2] = "c) 1500";
            a[3] = "d) 2000";
            listeQuestion.Add(new Question(q, a, 1));

            a = new string[4];
            q = "Parmi les instruments de mesures suivants, lequel n'est pas identifié comme un instrument de contrôle des coûts ?";

            a[0] = "a) Liste de prix";
            a[1] = "b) Retour sur investissement";
            a[2] = "c) Ligne budgétaire";
            a[3] = "d) Courbe en S";
            listeQuestion.Add(new Question(q, a, 1));

            a = new string[4];
            q = "Pour motiver son équipe le Chef de projet doit dans le cadre de la communication :";

            a[0] = "a) Faire part de tous les événements intervenants sur le projet";
            a[1] = "b) Souligner uniquement les points qui vont mal afin de les améliorer";
            a[2] = "c) Sélectionner les éléments significatifs favorables ou non";
            a[3] = "d) Ne communiquer qu'aux parties concernées uniquement";
            listeQuestion.Add(new Question(q, a, 2));


            a = new string[4];
            q = "Les motivations des membres d'une équipe est un facteur clé du succès d’un projet. Le chef de projet doit :";

            a[0] = "a) Former son équipe en fonction de la motivation des membres";
            a[1] = "b) S'assurer des raisons des motivation des membres";
            a[2] = "c) La motivation personelles des parties prenantes ne doit pas interférer dans le projet";
            a[3] = "d) Peut déleguer la responsabilité de motivation de son équipe ";
            listeQuestion.Add(new Question(q, a, 1));


            a = new string[4];
            q = "Dans un projet très stressant, Olivier s'est emporté pour une broutille. Face à cette situation, que conseiller au chef de projet ?";

            a[0] = "a) Il devrait organiser une séance d'information et de travail sur le stress au travail et la capacité à gérer son stress";
            a[1] = "b) Mettre Olivier à pied pour montrer l'exemple";
            a[2] = "c) Demander à Olivier de donner des excuses publique";
            a[3] = "d) Passer la situation sous silence ";
            listeQuestion.Add(new Question(q, a, 0));

            a = new string[4];
            q = "Pour renforcer les liens avec son équipe, le chef de projet devrait :";

            a[0] = "a) Organiser une session de \"team building\" au début du projet";
            a[1] = "b) Manger régulierement avec les différents membres de l'équipe";
            a[2] = "c) Etablir formellement son autorité";
            a[3] = "d) Assurer la transparence des rôles et responsabilités";
            listeQuestion.Add(new Question(q, a, 1));


            a = new string[4];
            q = "Le responsable de projet ne doit pas prendre en compte :";

            a[0] = "a) La quantité de CO² et autre gaz a effet de serre émis";
            a[1] = "b) La recyclabilité des matériaux";
            a[2] = "c) Le cout en eau des chasses d'eau";
            a[3] = "d) Les quantités d'énergie utilisées";
            listeQuestion.Add(new Question(q, a, 2));


            a = new string[4];
            q = "Le responsable de projet doit :";

            a[0] = "a) Imposer un plan de projet a l'équipe";
            a[1] = "b) Encourager les membres à travailler seul";
            a[2] = "c) Accueillir les critiques comme une forme d'engagement";
            a[3] = "d) Conserver toute la responsabilité du projet et donc tout le mérite en cas de réussite";
            listeQuestion.Add(new Question(q, a, 2));


            a = new string[4];
            q = "Le cash flow est :";

            a[0] = "a) Une rivière du Guatémala où naissent les poissons-billet";
            a[1] = "b) Un indicateur mesurant le flux de trésorie dont dispose une entreprise";
            a[2] = "c) La somme bénéfique net des charges non décaissées";
            a[3] = "d) La différence entre le coût des matières premières et le bénéfice à la vente";
            listeQuestion.Add(new Question(q, a, 1));



            loadNextQuestion();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            int strLength = labelTime.Text.Length - 5;
            int min = int.Parse(labelTime.Text.Substring(strLength,2));
            int sec = int.Parse(labelTime.Text.Substring(strLength+3,2));
            if (sec >= 59)
            {
                sec = 0;
                if (min < 59)
                {
                    min += 1;
                }
                else
                {
                    min = 0;
                } 
            }
            else
            {
                sec += 1;
            }
            string minutes = min.ToString();
            string secondes = sec.ToString();

            if (minutes.Length == 1)
            {
                minutes = "0" + minutes;
            }
            
            if(secondes.Length == 1)
            {
                secondes = "0" + secondes;
            }

            labelTime.Text = "Time: " + minutes + ":" + secondes;
        }

        private void loadNextQuestion()
        {
            if (listeQuestion.Count > qN)
            {
                curQuestion = listeQuestion.ElementAt(qN);
                textBox.Text = curQuestion.getQuestion();
                buttonA.Text = curQuestion.getAnswers()[0];
                buttonB.Text = curQuestion.getAnswers()[1];
                buttonC.Text = curQuestion.getAnswers()[2];
                buttonD.Text = curQuestion.getAnswers()[3];
            }
        }


        private void answer_Click(object sender, EventArgs e)
        {
           

            if (progressBar.Value <= 100)
            {
               Button s = (Button) sender;
               int r;
                switch (s.Name)
                {
                    case "buttonA":
                        r = 0;
                        break;

                    case "buttonB":
                        r = 1;
                        break;

                    case "buttonC":
                        r = 2;
                        break;

                    case "buttonD":
                        r = 3;
                        break;

                    default:
                        r = -1;
                        break;
                }
                curQuestion.setUserAnswer(r);
                listeQuestion.RemoveAt(qN);
                listeQuestion.Insert(qN, curQuestion);
                if (listeQuestion.Count > qN+1)
                {
                    qN += 1;
                    progressBar.Increment(10);
                    loadNextQuestion();
                }
                else
                {
                    afficheResultat();
                }
            }
        }

        private void afficheResultat()
        {
            timer1.Stop();
            List<Question> errors = new List<Question>();
            for (int i = 0; i < listeQuestion.Count; i++)
            {
                if(!listeQuestion.ElementAt(i).getUserAnswer().Equals(listeQuestion.ElementAt(i).getCorrectAnswer())){
                    errors.Add(listeQuestion.ElementAt(i));
                }
            }

            buttonA.Visible = false;
            buttonB.Visible = false;
            buttonC.Visible = false;
            buttonD.Visible = false;
            textBox.Visible = false;
            int score = listeQuestion.Count - errors.Count;
            int strLength = labelTime.Text.Length - 5;
            int min = int.Parse(labelTime.Text.Substring(strLength,2));
            int sec = int.Parse(labelTime.Text.Substring(strLength+3,2));

            string minute = " minute";
            string seconde = " seconde";
            if(min>1)
                minute+="s";
            if(sec>1)
                seconde+="s";
            string res = "Vous avez obtenu un score de " + score +"/"+listeQuestion.Count.ToString()+" en " + min + minute + " et " + sec + seconde;
            res += Environment.NewLine;
            res += "Vos erreurs:" + Environment.NewLine;
            foreach(Question error in errors){
                res += Environment.NewLine;
                res += error.getQuestion();
                res += Environment.NewLine;
                res += "Votre Réponse: " + error.getAnswers()[error.getUserAnswer()];
                res += Environment.NewLine;
                res += "Bonne Réponse: " + error.getAnswers()[error.getCorrectAnswer()];
                res += Environment.NewLine;
            }

            textBoxResult.Visible = true;
            textBoxResult.Text = res;
        }

        private void buttonRestart_Click(object sender, EventArgs e)
        {
            buttonA.Visible = true;
            buttonB.Visible = true;
            buttonC.Visible = true;
            buttonD.Visible = true;
            textBox.Visible = true;

            textBoxResult.Visible = false;

            foreach (Question q in listeQuestion)
            {
                q.setUserAnswer(-1);
            }
            qN = 0;
            progressBar.Value = 10;
            labelTime.Text = "Time: 00:00";
            loadNextQuestion();
            timer1.Start();
        }

    }
}
