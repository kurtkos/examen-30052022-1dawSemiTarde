using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JoseSanchezTomas24
{
    internal class QuestionModel
    {
        string question;
        string[] answers;
        int value;

        public void questionModel(string ques, string[] answ, int val)
        {
           
        }
        public string getQuestion()
        {
            return this.question;
        }
        public string getAnswer()
        {
            return this.answers[0];
        }
        public int getValue()
        {
            return this.value;
        }
    }
}
