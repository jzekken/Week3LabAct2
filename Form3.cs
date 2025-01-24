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
    public partial class Form3 : Form
    {
        private SurveyResponse responses;
        public Form3(SurveyResponse responses)
        {
            InitializeComponent();
            this.responses = responses;
        }
        private void Form3_Load(object sender, EventArgs e)
        {
            rb1q1.Checked = responses.Form3Question1 == rb1q1.Text;
            rb2q1.Checked = responses.Form3Question1 == rb2q1.Text;
            rb3q1.Checked = responses.Form3Question1 == rb3q1.Text;
            rb4q1.Checked = responses.Form3Question1 == rb4q1.Text;
            rb5q1.Checked = responses.Form3Question1 == rb5q1.Text;
            rb6q1.Checked = responses.Form3Question1 == rb6q1.Text;
            rb7q1.Checked = responses.Form3Question1 == rb7q1.Text;
            rb8q1.Checked = responses.Form3Question1 == rb8q1.Text;
            rb9q1.Checked = responses.Form3Question1 == rb9q1.Text;

            rb1q2.Checked = responses.Form3Question2 == rb1q2.Text;
            rb2q2.Checked = responses.Form3Question2 == rb2q2.Text;
            rb3q2.Checked = responses.Form3Question2 == rb3q2.Text;
            rb4q2.Checked = responses.Form3Question2 == rb4q2.Text;
            rb5q2.Checked = responses.Form3Question2 == rb5q2.Text;
            rb6q2.Checked = responses.Form3Question2 == rb6q2.Text;
            rb7q2.Checked = responses.Form3Question2 == rb7q2.Text;
            rb8q2.Checked = responses.Form3Question2 == rb8q2.Text;
            rb9q2.Checked = responses.Form3Question2 == rb9q2.Text;
            rb10q2.Checked = responses.Form3Question2 == rb10q2.Text;

            rb1q3.Checked = responses.Form3Question3 == rb1q3.Text;
            rb2q3.Checked = responses.Form3Question3 == rb2q3.Text;
            rb3q3.Checked = responses.Form3Question3 == rb3q3.Text;
            rb4q3.Checked = responses.Form3Question3 == rb4q3.Text;
            rb5q3.Checked = responses.Form3Question3 == rb5q3.Text;
            rb6q3.Checked = responses.Form3Question3 == rb6q3.Text;
            rb7q3.Checked = responses.Form3Question3 == rb7q3.Text;
            rb8q3.Checked = responses.Form3Question3 == rb8q3.Text;
            rb9q3.Checked = responses.Form3Question3 == rb9q3.Text;
            rb10q3.Checked = responses.Form3Question3 == rb10q3.Text;
        }
        private void button2_Click(object sender, EventArgs e)
        {
            responses.Form3Question1 = rb1q1.Checked ? rb1q1.Text :
                                      rb2q1.Checked ? rb2q1.Text :
                                      rb3q1.Checked ? rb3q1.Text :
                                      rb4q1.Checked ? rb4q1.Text :
                                      rb5q1.Checked ? rb5q1.Text :
                                      rb6q1.Checked ? rb6q1.Text :
                                      rb7q1.Checked ? rb7q1.Text :
                                      rb8q1.Checked ? rb8q1.Text :
                                      rb9q1.Checked ? rb9q1.Text : null;

            responses.Form3Question2 = rb1q2.Checked ? rb1q2.Text :
                                      rb2q2.Checked ? rb2q2.Text :
                                      rb3q2.Checked ? rb3q2.Text :
                                      rb4q2.Checked ? rb4q2.Text :
                                      rb5q2.Checked ? rb5q2.Text :
                                      rb6q2.Checked ? rb6q2.Text :
                                      rb7q2.Checked ? rb7q2.Text :
                                      rb8q2.Checked ? rb8q2.Text :
                                      rb9q2.Checked ? rb9q2.Text :
                                      rb10q2.Checked ? rb10q2.Text : null;

            responses.Form3Question3 = rb1q3.Checked ? rb1q3.Text :
                                      rb2q3.Checked ? rb2q3.Text :
                                      rb3q3.Checked ? rb3q3.Text :
                                      rb4q3.Checked ? rb4q3.Text :
                                      rb5q3.Checked ? rb5q3.Text :
                                      rb6q3.Checked ? rb6q3.Text :
                                      rb7q3.Checked ? rb7q3.Text :
                                      rb8q3.Checked ? rb8q3.Text :
                                      rb9q3.Checked ? rb9q3.Text :
                                      rb10q3.Checked ? rb10q3.Text : null;

            this.Hide();
            Form2 form = new Form2(responses);
            form.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            responses.Form3Question1 = rb1q1.Checked ? rb1q1.Text :
                                      rb2q1.Checked ? rb2q1.Text :
                                      rb3q1.Checked ? rb3q1.Text :
                                      rb4q1.Checked ? rb4q1.Text :
                                      rb5q1.Checked ? rb5q1.Text :
                                      rb6q1.Checked ? rb6q1.Text :
                                      rb7q1.Checked ? rb7q1.Text :
                                      rb8q1.Checked ? rb8q1.Text :
                                      rb9q1.Checked ? rb9q1.Text : null;

            responses.Form3Question2 = rb1q2.Checked ? rb1q2.Text :
                                      rb2q2.Checked ? rb2q2.Text :
                                      rb3q2.Checked ? rb3q2.Text :
                                      rb4q2.Checked ? rb4q2.Text :
                                      rb5q2.Checked ? rb5q2.Text :
                                      rb6q2.Checked ? rb6q2.Text :
                                      rb7q2.Checked ? rb7q2.Text :
                                      rb8q2.Checked ? rb8q2.Text :
                                      rb9q2.Checked ? rb9q2.Text :
                                      rb10q2.Checked ? rb10q2.Text : null;

            responses.Form3Question3 = rb1q3.Checked ? rb1q3.Text :
                                      rb2q3.Checked ? rb2q3.Text :
                                      rb3q3.Checked ? rb3q3.Text :
                                      rb4q3.Checked ? rb4q3.Text :
                                      rb5q3.Checked ? rb5q3.Text :
                                      rb6q3.Checked ? rb6q3.Text :
                                      rb7q3.Checked ? rb7q3.Text :
                                      rb8q3.Checked ? rb8q3.Text :
                                      rb9q3.Checked ? rb9q3.Text :
                                      rb10q3.Checked ? rb10q3.Text : null;

            this.Hide();
            Form4 form = new Form4(responses);
            form.Show();
        }

       
    }
}
