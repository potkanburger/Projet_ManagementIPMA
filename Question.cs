using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projet_Management
{
    class Question
    {
        private string _question;
        private string[] _answers;
        private int _correctAnswer;
        private int _userAnswer;

        public Question()
        {
            _question = "";
            _answers = new string[4];
            for(int i=0;i<4;i++){
                _answers[i] = "";
            }
            _correctAnswer = 0;
            _userAnswer = -1;
        }

        public Question(string q, string[] a, int r)
        {
            _question = q;
            _answers = a;
            _correctAnswer = r;
            _userAnswer = -1;
        }

        public string getQuestion(){
            return _question;
        }

        public string[] getAnswers()
        {
            return _answers;
        }

        public int getCorrectAnswer()
        {
            return _correctAnswer;
        }

        public int getUserAnswer()
        {
            return _userAnswer;
        }

        public void setUserAnswer(int userA)
        {
            _userAnswer = userA;
        }
    }
}
