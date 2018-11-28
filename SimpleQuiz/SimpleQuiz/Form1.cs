using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimpleQuiz
{
    public partial class Form1 : Form
    {
        public int count = 15;
        private int Qnum { get; set; }
        private int QuestionTotal { get; set; }

        public static Random random = new Random();

        //public String labText;
        public int a = 1;
        int grade = 0;
        int k = 0;
        int indexSelected = 0;

        public Form1()
        {
            InitializeComponent();
            this.Qnum = 1;
            QuestionTotal = 6;
            buttonShowGrade.Enabled = false;
            buttonReplace.Enabled = false;
            buttonInsert.Enabled = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            tabPage2.Enabled = false;
            timer1.Enabled = true;

            gpQuestion.Text = "Question " + this.Qnum.ToString() +
                              " of " + this.QuestionTotal.ToString();
            cboQtype.SelectedIndex = 0;
            labAllTypes.Text = RandomString().ToString();
            if (labAllTypes.Text[0].ToString() == "A")
            {
                cboQtype.SelectedIndex = 1;
            }
            else if (labAllTypes.Text[0].ToString() == "C")
            {
                cboQtype.SelectedIndex = 0;
            }

            foreach (var item in labAllTypes.Text.ToList())
            {
                if (item.ToString().Equals("C"))
                {
                    String randomLetter = CreateString(new Random().Next(1, 2));
                    CorrectAnswer.Items.Add(randomLetter);
                }
                else if (item.ToString().Equals("A"))
                {
                    String randomLetter = CreateString(new Random().Next(1, 4));
                    CorrectAnswer.Items.Add(randomLetter);
                }
            }
        }

        public static string CreateString(int stringLength)
        {
            const string allowedChars = "ABC";
            List<char> chars = new List<char>(stringLength);

            for (int i = 0; i < stringLength; i++)
            {
                var ans = allowedChars[random.Next(0, allowedChars.Length)];
                if (!chars.Contains(ans))
                {
                    chars.Add(ans);
                }

            }

            return String.Concat(chars.OrderBy(A => A));
        }

        public static string RandomString()
        {
            const string chars = "AC";
            return new string(Enumerable.Repeat(chars, 6)
                .Select(s => s[random.Next(s.Length)]).ToArray());
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            count--;
            labTime.Text = count.ToString();
            if (count == 0)
            {
                timer1.Stop();
                btnSubmit.Enabled = false;
                btnDelAll.Enabled = false;
                btnDelete.Enabled = false;
                buttonShowGrade.Enabled = true;
                ((Control) this.tabPage2).Enabled = true;

                buttonReplace.Enabled = true;
                MessageBox.Show("Time out. Check your grade.");
                //buttonShowGrade.Enabled = true;
            }
        }
        private void ChangeQuestionType()
        {
            /*chkA.Enabled = !chkA.Enabled;
            chkB.Enabled = !chkB.Enabled;
            chkC.Enabled = !chkC.Enabled;
            radA.Enabled = !radA.Enabled;
            radB.Enabled = !radB.Enabled;
            radC.Enabled = !radC.Enabled;*/
            if (cboQtype.SelectedIndex == 0)
            {
                SetMultipleChoice(true);
                SetMultipleAnswer(false);
            }
            else
            {
                SetMultipleChoice(false);
                SetMultipleAnswer(true);
            }

            ResetAnswerSelection();
        }

        private void SetMultipleChoice(bool on_off)
        {
            radA.Enabled = on_off;
            radB.Enabled = on_off;
            radC.Enabled = on_off;
        }

        private void SetMultipleAnswer(bool on_off)
        {
            chkA.Enabled = on_off;
            chkB.Enabled = on_off;
            chkC.Enabled = on_off;
        }

        private void ResetAnswerSelection()
        {
            chkA.Checked = false;
            chkB.Checked = false;
            chkC.Checked = false;
            radA.Checked = false;
            radB.Checked = false;
            radC.Checked = false;
        }

        private string WhichAnswerIsSelected()
        {
            string myAns = "";

            if (radA.Checked)
                myAns = "A";
            else if (radB.Checked)
                myAns = "B";
            else if (radC.Checked)
                myAns = "C";

            if (chkA.Checked)
                myAns += "A";
            if (chkB.Checked)
                myAns += "B";
            if (chkC.Checked)
                myAns += "C";

            return myAns;
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (Qnum <= 6)
            {
                if (WhichAnswerIsSelected() == "")
                {
                    MessageBox.Show("You must select an answer to submit!", "CANNOT SUBIT");
                }
                else
                {
                    lstMyAnswer.Items.Add(WhichAnswerIsSelected());
                    MyAnswer.Items.Add(WhichAnswerIsSelected());
                    buttonReplace.Enabled = true;
                    buttonInsert.Enabled = true;
                    /*
                    CorrectAnswer.Items.Add(CreateString(3));
                    */
                    if (a < 6)
                    {
                        if (labAllTypes.Text[a].ToString() == "A")
                        {
                            cboQtype.SelectedIndex = 1;
                        }
                        else if (labAllTypes.Text[a].ToString() == "C")
                        {
                            cboQtype.SelectedIndex = 0;

                        }

                    }
                    a++;

                    Qnum++;

                    if (Qnum <= 6)
                        gpQuestion.Text = "Question " + Qnum.ToString() +
                                          " of " + this.QuestionTotal.ToString();
                    else // Quiz ends
                    {
                        timer1.Enabled = false;
                        ResetAnswerSelection();
                        cboQtype.SelectedIndex = 0; //reset question type to Multiple Choice
                        SetMultipleChoice(false);
                        SetMultipleAnswer(false);
                        btnSubmit.Enabled = false;
                        cboQtype.Enabled = false;
                        MessageBox.Show("You have answered and submitted all questions.", "Quiz Completed");
                        buttonShowGrade.Enabled = true;
                        buttonInsert.Enabled = true;
                    }
                }

                // MyAnswer.Items.Add(lstMyAnswer.SelectedValue);
            }

        }
        private void calculateGrade()
        {


            for (int k = 0; k < CorrectAnswer.Items.Count; k++)
            {
                if (MyAnswer.Items.Count >= k + 1 && CorrectAnswer.Items[k].ToString().Equals(MyAnswer.Items[k].ToString()))
                {
                    grade += 10;
                    labelGrade.Text = grade.ToString();
                }
            }



            /*ListBox.SelectedObjectCollection sourceItems = source.SelectedItems;
           foreach (var item in sourceItems)
            {
                destination.Items.Add(item);
            }
            while (source.SelectedItems.Count > 0)
            {
                source.Items.Remove(source.SelectedItems[0]);
            }
            */
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (lstMyAnswer.SelectedIndex != -1)
            {
                MyAnswer.Items.RemoveAt(lstMyAnswer.SelectedIndex);
                lstMyAnswer.Items.Remove(lstMyAnswer.SelectedItem);

                lstMyAnswer.SelectedIndex = -1;
                gpQuestion.Text = "Question " + (--Qnum).ToString() +
                                  " of " + this.QuestionTotal.ToString();
                btnSubmit.Enabled = true;
                cboQtype.Enabled = true;
                timer1.Enabled = true;

                if (Qnum == 6)
                {

                    if (cboQtype.SelectedIndex == 0)
                    {
                        SetMultipleChoice(true);
                        SetMultipleAnswer(false);
                    }
                    else
                    {
                        SetMultipleChoice(false);
                        SetMultipleAnswer(true);
                    }
                }
            }
            else
            {
                MessageBox.Show("You must select an answer to delete!", "CANNOT DELETE");
            }
        }

        private void btnDelAll_Click(object sender, EventArgs e)
        {
            lstMyAnswer.Items.Clear();
            MyAnswer.Items.Clear();
            Qnum = 1;
            gpQuestion.Text = "Question " + (Qnum).ToString() +
                              " of " + this.QuestionTotal.ToString();
            ResetAnswerSelection();
            btnSubmit.Enabled = true;
            cboQtype.Enabled = true;
            timer1.Enabled = true;

            cboQtype.SelectedIndex = 0; //reset question type to Multiple Choice
            SetMultipleChoice(true);
            SetMultipleAnswer(false);
        }

        private void cboQtype_SelectedIndexChanged(object sender, EventArgs e)
        {
            ChangeQuestionType();
        }

        private void buttonShowGrade_Click(object sender, EventArgs e)
        {
            btnDelAll.Enabled = false;
            btnDelete.Enabled = false;
            btnSubmit.Enabled = false;
            buttonReplace.Enabled = false;
            buttonInsert.Enabled = false;
            lstMyAnswer.Enabled = false;
            tabPage2.Enabled = true;
            //tabControl1.SelectedTab = tabPage2;
            tabControl1.SelectTab(1);
            // tabControl1.SelectedIndex = 1;
            ((Control)this.tabPage2).Enabled = true;
            calculateGrade();

        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void buttonReplace_Click(object sender, EventArgs e)
        {
            indexSelected = lstMyAnswer.SelectedIndex;

            try
            {
                if (lstMyAnswer.Items.Count > 0)
                {
                    lstMyAnswer.Items.RemoveAt(indexSelected);
                    lstMyAnswer.SelectedIndex = -1;
                    MyAnswer.Items.RemoveAt(indexSelected);
                    var answerEntered = WhichAnswerIsSelected();
                    lstMyAnswer.Items.Insert(indexSelected, answerEntered);
                    MyAnswer.Items.Insert(indexSelected, answerEntered);
                    ResetAnswerSelection();
                }

            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        private void buttonInsert_Click(object sender, EventArgs e)
        {
            indexSelected = lstMyAnswer.SelectedIndex;
            try
            {
                if (lstMyAnswer.Items.Count > 0)
                {
                    // lstMyAnswer.Items.RemoveAt(m);
                    // MyAnswer.Items.RemoveAt(m);
                    lstMyAnswer.Items.Insert(indexSelected, WhichAnswerIsSelected());
                    MyAnswer.Items.Insert(indexSelected, WhichAnswerIsSelected());
                    if (lstMyAnswer.Items.Count == 7)
                    {
                        lstMyAnswer.Items.RemoveAt(6);
                        MyAnswer.Items.RemoveAt(6);
                    }


                }

            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
        private void AnswerSelected(object sender, EventArgs e)
        {
            if (lstMyAnswer.SelectedIndex > -1)
            {
                var answerIndex = lstMyAnswer.SelectedIndex;
                var questionType = labAllTypes.Text[answerIndex].ToString();

                if (questionType.Equals("A"))
                {
                    cboQtype.SelectedIndex = 1;
                }
                else if (questionType.Equals("C"))
                {
                    cboQtype.SelectedIndex = 0;

                }
            }

        }

        private void lstMyAnswer_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
