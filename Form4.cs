using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace Week3LabAct2
{
    public partial class Form4 : Form
    {
        private SurveyResponse responses;
        public Form4(SurveyResponse responses)
        {
            InitializeComponent();
            this.responses = responses;
        }
        private void Form4_Load(object sender, EventArgs e)
        {
            rb1q1.Checked = responses.Form4Question1 == rb1q1.Text;
            rb2q1.Checked = responses.Form4Question1 == rb2q1.Text;
            rb3q1.Checked = responses.Form4Question1 == rb3q1.Text;
            rb4q1.Checked = responses.Form4Question1 == rb4q1.Text;
            rb5q1.Checked = responses.Form4Question1 == rb5q1.Text;

            cb1q2.Checked = responses.Form4Question2CheckboxChoices.Contains(cb1q2.Text);
            cb2q2.Checked = responses.Form4Question2CheckboxChoices.Contains(cb2q2.Text);
            cb3q2.Checked = responses.Form4Question2CheckboxChoices.Contains(cb3q2.Text);
            cb4q2.Checked = responses.Form4Question2CheckboxChoices.Contains(cb4q2.Text);
            cb5q2.Checked = responses.Form4Question2CheckboxChoices.Contains(cb5q2.Text);
            cb6q2.Checked = responses.Form4Question2CheckboxChoices.Contains(cb6q2.Text);

            cb1q3.Checked = responses.Form4Question3CheckboxChoices.Contains(cb1q3.Text);
            cb2q3.Checked = responses.Form4Question3CheckboxChoices.Contains(cb2q3.Text);
            cb3q3.Checked = responses.Form4Question3CheckboxChoices.Contains(cb3q3.Text);
            cb4q3.Checked = responses.Form4Question3CheckboxChoices.Contains(cb4q3.Text);
            cb5q3.Checked = responses.Form4Question3CheckboxChoices.Contains(cb5q3.Text);

        }
        private void button2_Click(object sender, EventArgs e)
        {
            responses.Form4Question1 = rb1q1.Checked ? rb1q1.Text :
                                     rb2q1.Checked ? rb2q1.Text :
                                     rb3q1.Checked ? rb3q1.Text :
                                     rb4q1.Checked ? rb4q1.Text :
                                     rb5q1.Checked ? rb5q1.Text : null;

            responses.Form4Question2CheckboxChoices.Clear();
            if (cb1q2.Checked) responses.Form4Question2CheckboxChoices.Add(cb1q2.Text);
            if (cb2q2.Checked) responses.Form4Question2CheckboxChoices.Add(cb2q2.Text);
            if (cb3q2.Checked) responses.Form4Question2CheckboxChoices.Add(cb3q2.Text);
            if (cb4q2.Checked) responses.Form4Question2CheckboxChoices.Add(cb4q2.Text);
            if (cb5q2.Checked) responses.Form4Question2CheckboxChoices.Add(cb5q2.Text);
            if (cb6q2.Checked) responses.Form4Question2CheckboxChoices.Add(cb6q2.Text);

            responses.Form4Question3CheckboxChoices.Clear();
            if (cb1q3.Checked) responses.Form4Question3CheckboxChoices.Add(cb1q3.Text);
            if (cb2q3.Checked) responses.Form4Question3CheckboxChoices.Add(cb2q3.Text);
            if (cb3q3.Checked) responses.Form4Question3CheckboxChoices.Add(cb3q3.Text);
            if (cb4q3.Checked) responses.Form4Question3CheckboxChoices.Add(cb4q3.Text);
            if (cb5q3.Checked) responses.Form4Question3CheckboxChoices.Add(cb5q3.Text);

            this.Hide();
            Form3 form = new Form3(responses);
            form.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            responses.Form4Question1 = rb1q1.Checked ? rb1q1.Text :
                                     rb2q1.Checked ? rb2q1.Text :
                                     rb3q1.Checked ? rb3q1.Text :
                                     rb4q1.Checked ? rb4q1.Text :
                                     rb5q1.Checked ? rb5q1.Text : null;

            responses.Form4Question2CheckboxChoices.Clear();
            if (cb1q2.Checked) responses.Form4Question2CheckboxChoices.Add(cb1q2.Text);
            if (cb2q2.Checked) responses.Form4Question2CheckboxChoices.Add(cb2q2.Text);
            if (cb3q2.Checked) responses.Form4Question2CheckboxChoices.Add(cb3q2.Text);
            if (cb4q2.Checked) responses.Form4Question2CheckboxChoices.Add(cb4q2.Text);
            if (cb5q2.Checked) responses.Form4Question2CheckboxChoices.Add(cb5q2.Text);
            if (cb6q2.Checked) responses.Form4Question2CheckboxChoices.Add(cb6q2.Text);

            responses.Form4Question3CheckboxChoices.Clear();
            if (cb1q3.Checked) responses.Form4Question3CheckboxChoices.Add(cb1q3.Text);
            if (cb2q3.Checked) responses.Form4Question3CheckboxChoices.Add(cb2q3.Text);
            if (cb3q3.Checked) responses.Form4Question3CheckboxChoices.Add(cb3q3.Text);
            if (cb4q3.Checked) responses.Form4Question3CheckboxChoices.Add(cb4q3.Text);
            if (cb5q3.Checked) responses.Form4Question3CheckboxChoices.Add(cb5q3.Text);
            


            this.Hide();
            Form5 form = new Form5(responses);
            form.Show();
        }

        
    }
}
