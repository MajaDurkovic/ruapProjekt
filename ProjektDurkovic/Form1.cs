using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.IO;
using System.Net.Http;
using System.Net.Http.Formatting;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjektDurkovic
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void checkedListBox5_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void groupBox7_Enter(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void checkedListBox7_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

private void checkBox7_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox10_CheckedChanged(object sender, EventArgs e)
        {

        }
private void groupBox8_Enter(object sender, EventArgs e)
        {

        }

        private void checkBox21_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox18_CheckedChanged(object sender, EventArgs e)
        {

        }



        string  Age, Gender, family_history, work_interfere, remote_work, tech_company, benefits, care_options, wellness_program, seek_help, leave, coworkers, supervisor, mental_vs_physical, obs_consequence;

        public class StringTable
        {
            public string[] ColumnNames { get; set; }
            public string[,] Values { get; set; }
        }


        private async void button1_Click(object sender, EventArgs e)
        {
            string Age = textBox1.Text.ToString();
          
            //Gender
            if (radioButton1.Checked) { Gender = "F"; }
            if (radioButton2.Checked) { Gender = "M"; }
            if (radioButton3.Checked) { Gender = "T"; }
            if (radioButton4.Checked) { Gender = "A"; }

            //familiy history
            if (radioButton5.Checked) { family_history = "1"; }
            if (radioButton6.Checked) { family_history = "0"; }

            //work_interfere
            if (radioButton7.Checked) { work_interfere = "0"; }
            if (radioButton8.Checked) { work_interfere = "1"; }
            if (radioButton9.Checked) { work_interfere = "2"; }
            if (radioButton10.Checked) { work_interfere = "3"; }
            if (radioButton11.Checked) { work_interfere = "4"; }

            //tech_company
            if (radioButton12.Checked) { tech_company = "1"; }
            if (radioButton13.Checked) { tech_company = "0"; }

            //remote_work
            if (radioButton15.Checked) { remote_work = "1"; }
            if (radioButton14.Checked) { remote_work = "0"; }

            //benefits
            if (radioButton16.Checked) { benefits = "1"; }
            if (radioButton17.Checked) { benefits = "0"; }
            if (radioButton18.Checked) { benefits = "4"; }

            //care_options
            if (radioButton21.Checked) { care_options = "1"; }
            if (radioButton20.Checked) { care_options = "0"; }
            if (radioButton19.Checked) { care_options = "4"; }

            //wellness_program
            if (radioButton24.Checked) { wellness_program = "1"; }
            if (radioButton23.Checked) { wellness_program = "0"; }
            if (radioButton22.Checked) { wellness_program = "4"; }

            //seek_help
            if (radioButton27.Checked) { seek_help = "1"; }
            if (radioButton26.Checked) { seek_help = "0"; }
            if (radioButton25.Checked) { seek_help = "4"; }

            //leave
            if (radioButton28.Checked) { leave = "0"; }
            if (radioButton29.Checked) { leave = "1"; }
            if (radioButton30.Checked) { leave = "2"; }
            if (radioButton31.Checked) { leave = "3"; }
            if (radioButton32.Checked) { leave = "4"; }

            //coworkers
            if (radioButton33.Checked) { coworkers = "1"; }
            if (radioButton34.Checked) { coworkers = "0"; }
            if (radioButton35.Checked) { coworkers = "2"; }

            //supervisor
            if (radioButton38.Checked) { supervisor = "1"; }
            if (radioButton37.Checked) { supervisor = "0"; }
            if (radioButton36.Checked) { supervisor = "2"; }

            //mental_vs_physical
            if (radioButton41.Checked) { mental_vs_physical = "1"; }
            if (radioButton40.Checked) { mental_vs_physical = "0"; }
            if (radioButton39.Checked) { mental_vs_physical = "4"; }

            //obs_consequence
            if (radioButton42.Checked) { obs_consequence = "1"; }
            if (radioButton42.Checked) { obs_consequence = "0"; }


                using (var client = new HttpClient())
                {
                    var scoreRequest = new
                    {

                        Inputs = new Dictionary<string, StringTable> () {
                        {
                            "input1",
                            new StringTable()
                            {
                                ColumnNames = new string[] { "Age", "Gender", "family_history", "treatment", "work_interfere", "remote_work", "tech_company", "benefits", "care_options", "wellness_program", "seek_help", "leave", "coworkers", "supervisor", "mental_vs_physical", "obs_consequence"},
                                Values = new string[,] { { Age, Gender, family_history, "", work_interfere, remote_work, tech_company, benefits, care_options, wellness_program, seek_help, leave, coworkers, supervisor, mental_vs_physical, obs_consequence } }
                                 
                            }
                        },
                    },
                        GlobalParameters = new Dictionary<string, string>()
                        {
                        }
                    };
                    const string apiKey = "Oq1894GdJ3gc6+14oajIpBdobLcFIn0sBSGdTghyrkZgV0zot3vCepLzMlVayd641fNhQ1ybVrdb2TN8xpyd3g=="; // Replace this with the API key for the web service
                    client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", apiKey);

                client.BaseAddress = new Uri("https://ussouthcentral.services.azureml.net/workspaces/a85f41c0ff9b4318a0cbaef66dcb1fa6/services/9609b7867c4d442b9cfc5c25c92b7256/execute?api-version=2.0&details=true");

                // WARNING: The 'await' statement below can result in a deadlock if you are calling this code from the UI thread of an ASP.Net application.
                // One way to address this would be to call ConfigureAwait(false) so that the execution does not attempt to resume on the original context.
                // For instance, replace code such as:
                //      result = await DoSomeTask()
                // with the following:
                //      result = await DoSomeTask().ConfigureAwait(false)


                HttpResponseMessage response = await client.PostAsJsonAsync("", scoreRequest);

                    if (response.IsSuccessStatusCode)
                    {
                    string[] resultArray;
                    string result = await response.Content.ReadAsStringAsync();
                   // MessageBox.Show("Result: {0}", result);
                    resultArray = result.Split(':');

                    resultArray[7] = resultArray[7].Replace("}", "");
                    resultArray[7] = resultArray[7].Replace("]", "");
                    resultArray[7] = resultArray[7].Replace("[", "");
                    resultArray[7] = resultArray[7].Replace("\"", "");

                     var outputString = string.Join(",", resultArray[7]);
                   

                    MessageBox.Show("Osoba ce potraziti strucnu pomoc: " + outputString , "Results", MessageBoxButtons.OK);
                    
                }
                    else
                    {
                    MessageBox.Show(string.Format("The request failed with status code: {0}", response.StatusCode));
                    
                    // Print the headers - they include the requert ID and the timestamp, which are useful for debugging the failure
                    MessageBox.Show(response.Headers.ToString());
                    

                    string responseContent = await response.Content.ReadAsStringAsync();
                    MessageBox.Show(responseContent);
                   
                }
                }
            }



        }
    }