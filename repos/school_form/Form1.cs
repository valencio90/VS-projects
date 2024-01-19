using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace school_form
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int totalMarksObtained = 0,totalMarks = 0,percentage = 0;
        string grade;

        private void exitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void resetButton_Click(object sender, EventArgs e)
        {
            Subject1Name.Text = " ";
            Subject2Name.Text = " ";
            Subject3Name.Text = " ";
            Subject4Name.Text = " ";
            Subject5Name.Text = " ";

            Subject1Marks.Text = " ";
            Subject2Marks.Text = " ";
            Subject3Marks.Text = " ";
            Subject4Marks.Text = " ";
            Subject5Marks.Text = " ";

            Subject1MarksObtained.Text = " ";
            Subject2MarksObtained.Text = " ";
            Subject3MarksObtained.Text = " ";
            Subject4MarksObtained.Text = " ";
            Subject5MarksObtained.Text = " ";

        }



        private void calculateButton_Click(object sender, EventArgs e)
        {
            totalMarksObtained += int.Parse(Subject1MarksObtained.Text);
            totalMarksObtained += int.Parse(Subject2MarksObtained.Text);
            totalMarksObtained += int.Parse(Subject3MarksObtained.Text);
            totalMarksObtained += int.Parse(Subject4MarksObtained.Text);
            totalMarksObtained += int.Parse(Subject5MarksObtained.Text);
            
            totalTextBox.Text = totalMarksObtained.ToString();

            totalMarks += int.Parse(Subject1Marks.Text);
            totalMarks += int.Parse(Subject2Marks.Text);
            totalMarks += int.Parse(Subject3Marks.Text);
            totalMarks += int.Parse(Subject4Marks.Text);
            totalMarks += int.Parse(Subject5Marks.Text);

            percentage = (int)Math.Round(((double)totalMarksObtained / totalMarks) * 100);

            percentageTextBox.Text = percentage.ToString();

            if (percentage >= 35 && percentage < 45)
            {
                grade = "E";
            }
            else if (percentage >= 45 && percentage < 55)
            {
                grade = "D";
            }
            else if (percentage >= 55 && percentage < 65)
            {
                grade = "C";
            }
            else if (percentage >= 65 && percentage < 75)
            {
                grade = "B";
            }
            else if (percentage >= 75)
            {
                grade = "A";
            }
            else
            {
                grade = "Fail";
            }

            gradeTextBox.Text = grade;
        }
    }
}
