using System.Text.RegularExpressions;
using System.IO;
using System.Reflection;

namespace MinecraftNoResetTracker
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            if(runTimeTextBox.Text != "")
            {
                if(Regex.IsMatch(runTimeTextBox.Text, @"([0-1][0-9]:[0-5][0-9]:[0-5][0-9])"))
                {
                    if(runTimeTextBox.Text.Length == 8)
                    {
                        runsListBox.Items.Add(runTimeTextBox.Text);
                        runTimeTextBox.Text = "";
                        UpdateRuns();
                        WriteFile();
                    }
                }
            }
        }

        private void removeButton_Click(object sender, EventArgs e)
        {
            runsListBox.Items.Remove(runsListBox.SelectedItem);
            runTimeTextBox.Text = "";

            if (runsListBox.Items.Count == 0)
            {
                runsTotalOutputLabel.Text = "0";
                averageTimeOutputLabel.Text = "00:00:00";
                WriteFile();
            }
            else
            {
                UpdateRuns();
                WriteFile();
            }
        }

        private void UpdateRuns()
        {
            runsTotalOutputLabel.Text = runsListBox.Items.Count.ToString();
            averageTimeOutputLabel.Text = AverageTime();
        }

        private string AverageTime()
        {
            TimeSpan totalTime = TimeSpan.Parse("00:00:00");

            for (int i = 0; i < runsListBox.Items.Count; i++)
            {
                totalTime += TimeSpan.Parse(runsListBox.Items[i].ToString());
            }

            return (totalTime / runsListBox.Items.Count).ToString().Substring(0,8);
        }

        private void WriteFile()
        {
            StreamWriter streamWriter = new StreamWriter("Runs.txt");
            streamWriter.WriteLine("Runs Completed: " + runsTotalOutputLabel.Text);
            streamWriter.WriteLine("Average Time: " + AverageTime());
            streamWriter.Flush();
            streamWriter.Close();
        }
    }
}