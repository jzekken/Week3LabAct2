using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week3LabAct2
{
    public class SurveyResponse
    {
        // Form 1
        public string Form1Question1 { get; set; }
        public string Form1Question2 { get; set; }
        public string Form1Question3 { get; set; }

        // Form 2
        public string Form2Question1 { get; set; }
        public string Form2Question2 { get; set; }

        // Form 3
        public string Form3Question1 { get; set; }
        public string Form3Question2 { get; set; }
        public string Form3Question3 { get; set; }

        // Form 4
        public string Form4Question1 { get; set; }
        public List<string> Form4Question2CheckboxChoices { get; set; } = new List<string>(); 
        public List<string> Form4Question3CheckboxChoices { get; set; } = new List<string>();

        // Form 5
        public List<string> Form5Question1CheckboxChoices { get; set; } = new List<string>();
        public List<string> Form5Question2CheckboxChoices { get; set; } = new List<string>();

        // Form 6
        public string[] Form6Ratings { get; set; } = new string[7]; // 7 categories
        public string Email { get; set; }
    }
}
