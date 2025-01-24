using System.Runtime.CompilerServices;

namespace Week3LabAct2
{
    public partial class Form1 : Form
    {
        private SurveyResponse responses;
        public Form1(SurveyResponse responses)
        {
            InitializeComponent();
            this.responses = responses;
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            rb1Q1.Checked = responses.Form1Question1 == rb1Q1.Text;
            rb2Q1.Checked = responses.Form1Question1 == rb2Q1.Text;
            rb3Q1.Checked = responses.Form1Question1 == rb3Q1.Text;
            rb4Q1.Checked = responses.Form1Question1 == rb4Q1.Text;

            rb1q2.Checked = responses.Form1Question2 == rb1q2.Text;
            rb2q2.Checked = responses.Form1Question2 == rb2q2.Text;
            rb3q2.Checked = responses.Form1Question2 == rb3q2.Text;
            rb4q2.Checked = responses.Form1Question2 == rb4q2.Text;
            rb5q2.Checked = responses.Form1Question2 == rb5q2.Text;
            rb6q2.Checked = responses.Form1Question2 == rb6q2.Text;
            rb7q2.Checked = responses.Form1Question2 == rb7q2.Text;

            rb1q3.Checked = responses.Form1Question3 == rb1q3.Text;
            rb2q3.Checked = responses.Form1Question3 == rb2q3.Text;
            rb3q3.Checked = responses.Form1Question3 == rb3q3.Text;
            rb4q3.Checked = responses.Form1Question3 == rb4q3.Text;
            rb5q3.Checked = responses.Form1Question3 == rb5q3.Text;

        }
        private void Next(object sender, EventArgs e)
        {
            responses.Form1Question1 = rb1Q1.Checked ? rb1Q1.Text :
                                       rb2Q1.Checked ? rb2Q1.Text :
                                       rb3Q1.Checked ? rb3Q1.Text :
                                       rb4Q1.Checked ? rb4Q1.Text : null;

            responses.Form1Question2 = rb1q2.Checked ? rb1q2.Text :
                                       rb2q2.Checked ? rb2q2.Text :
                                       rb3q2.Checked ? rb3q2.Text :
                                       rb4q2.Checked ? rb4q2.Text :
                                       rb5q2.Checked ? rb5q2.Text :
                                       rb6q2.Checked ? rb6q2.Text :
                                       rb7q2.Checked ? rb7q2.Text : null;

            responses.Form1Question3 = rb1q3.Checked ? rb1q3.Text :
                                       rb2q3.Checked ? rb2q3.Text :
                                       rb3q3.Checked ? rb3q3.Text :
                                       rb4q3.Checked ? rb4q3.Text :
                                       rb5q3.Checked ? rb5q3.Text : null;


            this.Hide();
            Form2 form = new Form2(responses);
            form.Show();
        }
    }
}
