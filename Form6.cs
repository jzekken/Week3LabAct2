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
    public partial class Form6 : Form
    {
        private SurveyResponse responses;
        public Form6(SurveyResponse responses)
        {
            InitializeComponent();
            this.responses = responses;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            responses.Form6Ratings[0] = rb11.Checked ? "1" :
                                        rb12.Checked ? "2" :
                                        rb13.Checked ? "3" :
                                        rb14.Checked ? "4" :
                                        rb15.Checked ? "5" : null;
            responses.Form6Ratings[1] = rb21.Checked ? "1" :
                                        rb22.Checked ? "2" :
                                        rb23.Checked ? "3" :
                                        rb24.Checked ? "4" :
                                        rb25.Checked ? "5" : null;
            responses.Form6Ratings[2] = rb31.Checked ? "1" :
                                        rb32.Checked ? "2" :
                                        rb33.Checked ? "3" :
                                        rb34.Checked ? "4" :
                                        rb35.Checked ? "5" : null;
            responses.Form6Ratings[3] = rb41.Checked ? "1" :
                                        rb42.Checked ? "2" :
                                        rb43.Checked ? "3" :
                                        rb44.Checked ? "4" :
                                        rb45.Checked ? "5" : null;
            responses.Form6Ratings[4] = rb51.Checked ? "1" :
                                        rb52.Checked ? "2" :
                                        rb53.Checked ? "3" :
                                        rb54.Checked ? "4" :
                                        rb55.Checked ? "5" : null;
            responses.Form6Ratings[5] = rb61.Checked ? "1" :
                                        rb62.Checked ? "2" :
                                        rb63.Checked ? "3" :
                                        rb64.Checked ? "4" :
                                        rb65.Checked ? "5" : null;
            responses.Form6Ratings[6] = rb71.Checked ? "1" :
                                        rb72.Checked ? "2" :
                                        rb73.Checked ? "3" :
                                        rb74.Checked ? "4" :
                                        rb75.Checked ? "5" : null;

            responses.Email = textBox1.Text;

            this.Hide();
            Form5 form = new Form5(responses);
            form.Show();
        }

        private void Form6_Load(object sender, EventArgs e)
        {
            LoadRating();
            textBox1.Text = responses.Email;
        }
        private void LoadRating()
        {
            rb11.Checked = responses.Form6Ratings[0] == "1";
            rb12.Checked = responses.Form6Ratings[0] == "2";
            rb13.Checked = responses.Form6Ratings[0] == "3";
            rb14.Checked = responses.Form6Ratings[0] == "4";
            rb15.Checked = responses.Form6Ratings[0] == "5";

            rb21.Checked = responses.Form6Ratings[1] == "1";
            rb22.Checked = responses.Form6Ratings[1] == "2";
            rb23.Checked = responses.Form6Ratings[1] == "3";
            rb24.Checked = responses.Form6Ratings[1] == "4";
            rb25.Checked = responses.Form6Ratings[1] == "5";

            rb31.Checked = responses.Form6Ratings[2] == "1";
            rb32.Checked = responses.Form6Ratings[2] == "2";
            rb33.Checked = responses.Form6Ratings[2] == "3";
            rb34.Checked = responses.Form6Ratings[2] == "4";
            rb35.Checked = responses.Form6Ratings[2] == "5";

            rb41.Checked = responses.Form6Ratings[3] == "1";
            rb42.Checked = responses.Form6Ratings[3] == "2";
            rb43.Checked = responses.Form6Ratings[3] == "3";
            rb44.Checked = responses.Form6Ratings[3] == "4";
            rb45.Checked = responses.Form6Ratings[3] == "5";

            rb51.Checked = responses.Form6Ratings[4] == "1";
            rb52.Checked = responses.Form6Ratings[4] == "2";
            rb53.Checked = responses.Form6Ratings[4] == "3";
            rb54.Checked = responses.Form6Ratings[4] == "4";
            rb55.Checked = responses.Form6Ratings[4] == "5";

            rb61.Checked = responses.Form6Ratings[5] == "1";
            rb62.Checked = responses.Form6Ratings[5] == "2";
            rb63.Checked = responses.Form6Ratings[5] == "3";
            rb64.Checked = responses.Form6Ratings[5] == "4";
            rb65.Checked = responses.Form6Ratings[5] == "5";

            rb71.Checked = responses.Form6Ratings[6] == "1";
            rb72.Checked = responses.Form6Ratings[6] == "2";
            rb73.Checked = responses.Form6Ratings[6] == "3";
            rb74.Checked = responses.Form6Ratings[6] == "4";
            rb75.Checked = responses.Form6Ratings[6] == "5";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            responses.Form6Ratings[0] = rb11.Checked ? "1" :
                                        rb12.Checked ? "2" :
                                        rb13.Checked ? "3" :
                                        rb14.Checked ? "4" :
                                        rb15.Checked ? "5" : null;
            responses.Form6Ratings[1] = rb21.Checked ? "1" :
                                        rb22.Checked ? "2" :
                                        rb23.Checked ? "3" :
                                        rb24.Checked ? "4" :
                                        rb25.Checked ? "5" : null;
            responses.Form6Ratings[2] = rb31.Checked ? "1" :
                                        rb32.Checked ? "2" :
                                        rb33.Checked ? "3" :
                                        rb34.Checked ? "4" :
                                        rb35.Checked ? "5" : null;
            responses.Form6Ratings[3] = rb41.Checked ? "1" :
                                        rb42.Checked ? "2" :
                                        rb43.Checked ? "3" :
                                        rb44.Checked ? "4" :
                                        rb45.Checked ? "5" : null;
            responses.Form6Ratings[4] = rb51.Checked ? "1" :
                                        rb52.Checked ? "2" :
                                        rb53.Checked ? "3" :
                                        rb54.Checked ? "4" :
                                        rb55.Checked ? "5" : null;
            responses.Form6Ratings[5] = rb61.Checked ? "1" :
                                        rb62.Checked ? "2" :
                                        rb63.Checked ? "3" :
                                        rb64.Checked ? "4" :
                                        rb65.Checked ? "5" : null;
            responses.Form6Ratings[6] = rb71.Checked ? "1" :
                                        rb72.Checked ? "2" :
                                        rb73.Checked ? "3" :
                                        rb74.Checked ? "4" :
                                        rb75.Checked ? "5" : null;

            responses.Email = textBox1.Text;
            

            string message = $"Email: {responses.Email}\n\n" +
                             $"Gender: {responses.Form1Question1}\n" +
                             $"Age: {responses.Form1Question2}\n" +
                             $"Marital Status: {responses.Form1Question3}\n" +
                             $"Annual Income: {responses.Form2Question1}\n" +
                             $"Employment Status: {responses.Form2Question2}\n" +
                             $"Highest level of education: {responses.Form3Question1}\n" +
                             $"Exercise Frequency: {responses.Form3Question2}\n" +
                             $"Sportswear Usage Frequency: {responses.Form3Question3}\n" +
                             $"Last buy: {responses.Form4Question1}\n" +
                             $"Purpose of buying: {string.Join(", ", responses.Form4Question2CheckboxChoices)}\n" +
                             $"Sportswear Purchase Location: {string.Join(", ", responses.Form4Question3CheckboxChoices)}\n" +
                             $"Preference: {string.Join(", ", responses.Form5Question1CheckboxChoices)}\n" +
                             $"Influence in buying: {string.Join(", ", responses.Form5Question2CheckboxChoices)}\n" +
                             $"Water Resistance: {responses.Form6Ratings[0]}\n" +
                             $"Cooling: {responses.Form6Ratings[1]}\n" +
                             $"Anti Bacteria: {responses.Form6Ratings[2]}\n" +
                             $"Anti Odour: {responses.Form6Ratings[3]}\n" +
                             $"Soft and Smooth Material: {responses.Form6Ratings[4]}\n" +
                             $"Elasticity: {responses.Form6Ratings[5]}\n" +
                             $"Endurance: {responses.Form6Ratings[6]}\n";

            MessageBox.Show(message, "Survey Responses");

        }
    }
}

