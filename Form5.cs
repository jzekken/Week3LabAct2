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
    public partial class Form5 : Form
    {
        private SurveyResponse responses;
        public Form5(SurveyResponse responses)
        {
            InitializeComponent();
            this.responses = responses;
        }
        private void Form5_Load(object sender, EventArgs e)
        {
            cb1q1.Checked = responses.Form5Question1CheckboxChoices.Contains(cb1q1.Text);
            cb2q1.Checked = responses.Form5Question1CheckboxChoices.Contains(cb2q1.Text);
            cb3q1.Checked = responses.Form5Question1CheckboxChoices.Contains(cb3q1.Text);
            cb4q1.Checked = responses.Form5Question1CheckboxChoices.Contains(cb4q1.Text);

            cb1q2.Checked = responses.Form5Question2CheckboxChoices.Contains(cb1q2.Text);
            cb2q2.Checked = responses.Form5Question2CheckboxChoices.Contains(cb2q2.Text);
            cb3q2.Checked = responses.Form5Question2CheckboxChoices.Contains(cb3q2.Text);
            cb4q2.Checked = responses.Form5Question2CheckboxChoices.Contains(cb4q2.Text);
            cb5q2.Checked = responses.Form5Question2CheckboxChoices.Contains(cb5q2.Text);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            responses.Form5Question1CheckboxChoices.Clear();
            if (cb1q1.Checked) responses.Form5Question1CheckboxChoices.Add(cb1q1.Text);
            if (cb2q1.Checked) responses.Form5Question1CheckboxChoices.Add(cb2q1.Text);
            if (cb3q1.Checked) responses.Form5Question1CheckboxChoices.Add(cb3q1.Text);
            if (cb4q1.Checked) responses.Form5Question1CheckboxChoices.Add(cb4q1.Text);

            responses.Form5Question2CheckboxChoices.Clear();
            if (cb1q2.Checked) responses.Form5Question2CheckboxChoices.Add(cb1q2.Text);
            if (cb2q2.Checked) responses.Form5Question2CheckboxChoices.Add(cb2q2.Text);
            if (cb3q2.Checked) responses.Form5Question2CheckboxChoices.Add(cb3q2.Text);
            if (cb4q2.Checked) responses.Form5Question2CheckboxChoices.Add(cb4q2.Text);
            if (cb5q2.Checked) responses.Form5Question2CheckboxChoices.Add(cb5q2.Text);

            this.Hide();
            Form4 form = new Form4(responses);
            form.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            responses.Form5Question1CheckboxChoices.Clear();
            if (cb1q1.Checked) responses.Form5Question1CheckboxChoices.Add(cb1q1.Text);
            if (cb2q1.Checked) responses.Form5Question1CheckboxChoices.Add(cb2q1.Text);
            if (cb3q1.Checked) responses.Form5Question1CheckboxChoices.Add(cb3q1.Text);
            if (cb4q1.Checked) responses.Form5Question1CheckboxChoices.Add(cb4q1.Text);

            responses.Form5Question2CheckboxChoices.Clear();
            if (cb1q2.Checked) responses.Form5Question2CheckboxChoices.Add(cb1q2.Text);
            if (cb2q2.Checked) responses.Form5Question2CheckboxChoices.Add(cb2q2.Text);
            if (cb3q2.Checked) responses.Form5Question2CheckboxChoices.Add(cb3q2.Text);
            if (cb4q2.Checked) responses.Form5Question2CheckboxChoices.Add(cb4q2.Text);
            if (cb5q2.Checked) responses.Form5Question2CheckboxChoices.Add(cb5q2.Text);
            

            this.Hide();
            Form6 form = new Form6(responses);
            form.Show();
        }

        
    }
}
