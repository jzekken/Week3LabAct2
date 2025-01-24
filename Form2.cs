using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Week3LabAct2
{
    public partial class Form2 : Form
    {
        private SurveyResponse responses;
        public Form2(SurveyResponse responses)
        {
            InitializeComponent();
            this.responses = responses;
        }
        private void Form2_Load(object sender, EventArgs e)
        {
            rb1q1.Checked = responses.Form2Question1 == rb1q1.Text;
            rb2q1.Checked = responses.Form2Question1 == rb2q1.Text;
            rb3q1.Checked = responses.Form2Question1 == rb3q1.Text;
            rb4q1.Checked = responses.Form2Question1 == rb4q1.Text;
            rb5q1.Checked = responses.Form2Question1 == rb5q1.Text;
            rb6q1.Checked = responses.Form2Question1 == rb6q1.Text;
            rb7q1.Checked = responses.Form2Question1 == rb7q1.Text;

            rb1q2.Checked = responses.Form2Question2 == rb1q2.Text;
            rb2q2.Checked = responses.Form2Question2 == rb2q2.Text;
            rb3q2.Checked = responses.Form2Question2 == rb3q2.Text;
            rb4q2.Checked = responses.Form2Question2 == rb4q2.Text;
            rb5q2.Checked = responses.Form2Question2 == rb5q2.Text;
            rb6q2.Checked = responses.Form2Question2 == rb6q2.Text;
            rb7q2.Checked = responses.Form2Question2 == rb7q2.Text;
            rb8q2.Checked = responses.Form2Question2 == rb8q2.Text;
        }
        private void button2_Click(object sender, EventArgs e)
        {
            responses.Form2Question1 = rb1q1.Checked ? rb1q1.Text :
                                       rb2q1.Checked ? rb2q1.Text :
                                       rb3q1.Checked ? rb3q1.Text :
                                       rb4q1.Checked ? rb4q1.Text :
                                       rb5q1.Checked ? rb5q1.Text :
                                       rb6q1.Checked ? rb6q1.Text :
                                       rb7q1.Checked ? rb7q1.Text : null;


            responses.Form2Question2 = rb1q2.Checked ? rb1q2.Text :
                                       rb2q2.Checked ? rb2q2.Text :
                                       rb3q2.Checked ? rb3q2.Text :
                                       rb4q2.Checked ? rb4q2.Text :
                                       rb5q2.Checked ? rb5q2.Text :
                                       rb6q2.Checked ? rb6q2.Text :
                                       rb7q2.Checked ? rb7q2.Text :
                                       rb8q2.Checked ? rb8q2.Text : null;

            this.Hide();
            Form1 form = new Form1(responses);
            form.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            responses.Form2Question1 = rb1q1.Checked ? rb1q1.Text :
                                       rb2q1.Checked ? rb2q1.Text :
                                       rb3q1.Checked ? rb3q1.Text :
                                       rb4q1.Checked ? rb4q1.Text :
                                       rb5q1.Checked ? rb5q1.Text :
                                       rb6q1.Checked ? rb6q1.Text :
                                       rb7q1.Checked ? rb7q1.Text : null;


            responses.Form2Question2 = rb1q2.Checked ? rb1q2.Text :
                                       rb2q2.Checked ? rb2q2.Text :
                                       rb3q2.Checked ? rb3q2.Text :
                                       rb4q2.Checked ? rb4q2.Text :
                                       rb5q2.Checked ? rb5q2.Text :
                                       rb6q2.Checked ? rb6q2.Text :
                                       rb7q2.Checked ? rb7q2.Text :
                                       rb8q2.Checked ? rb8q2.Text : null;
            this.Hide();
            Form3 form = new Form3(responses);
            form.Show();
        }
         
        
    }
}
