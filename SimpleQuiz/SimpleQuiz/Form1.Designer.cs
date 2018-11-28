namespace SimpleQuiz
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.buttonReplace = new System.Windows.Forms.Button();
            this.buttonInsert = new System.Windows.Forms.Button();
            this.buttonShowGrade = new System.Windows.Forms.Button();
            this.buttonExit = new System.Windows.Forms.Button();
            this.labAllTypes = new System.Windows.Forms.Label();
            this.labTime = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnDelAll = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.gpQuestion = new System.Windows.Forms.GroupBox();
            this.chkC = new System.Windows.Forms.CheckBox();
            this.chkB = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.chkA = new System.Windows.Forms.CheckBox();
            this.cboQtype = new System.Windows.Forms.ComboBox();
            this.radA = new System.Windows.Forms.RadioButton();
            this.radC = new System.Windows.Forms.RadioButton();
            this.radB = new System.Windows.Forms.RadioButton();
            this.lstMyAnswer = new System.Windows.Forms.ListBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.labelGrade = new System.Windows.Forms.Label();
            this.CorrectAnswer = new System.Windows.Forms.ListBox();
            this.MyAnswer = new System.Windows.Forms.ListBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.gpQuestion.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(12, 22);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1374, 698);
            this.tabControl1.TabIndex = 20;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.buttonReplace);
            this.tabPage1.Controls.Add(this.buttonInsert);
            this.tabPage1.Controls.Add(this.buttonShowGrade);
            this.tabPage1.Controls.Add(this.buttonExit);
            this.tabPage1.Controls.Add(this.labAllTypes);
            this.tabPage1.Controls.Add(this.labTime);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.btnDelAll);
            this.tabPage1.Controls.Add(this.btnDelete);
            this.tabPage1.Controls.Add(this.btnSubmit);
            this.tabPage1.Controls.Add(this.gpQuestion);
            this.tabPage1.Controls.Add(this.lstMyAnswer);
            this.tabPage1.Location = new System.Drawing.Point(8, 39);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1358, 651);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Quiz";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // buttonReplace
            // 
            this.buttonReplace.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonReplace.Location = new System.Drawing.Point(531, 105);
            this.buttonReplace.Margin = new System.Windows.Forms.Padding(6);
            this.buttonReplace.Name = "buttonReplace";
            this.buttonReplace.Size = new System.Drawing.Size(184, 43);
            this.buttonReplace.TabIndex = 30;
            this.buttonReplace.Text = "Replace";
            this.buttonReplace.UseVisualStyleBackColor = true;
            this.buttonReplace.Click += new System.EventHandler(this.buttonReplace_Click);
            // 
            // buttonInsert
            // 
            this.buttonInsert.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonInsert.Location = new System.Drawing.Point(531, 174);
            this.buttonInsert.Margin = new System.Windows.Forms.Padding(6);
            this.buttonInsert.Name = "buttonInsert";
            this.buttonInsert.Size = new System.Drawing.Size(184, 43);
            this.buttonInsert.TabIndex = 29;
            this.buttonInsert.Text = "Insert";
            this.buttonInsert.UseVisualStyleBackColor = true;
            this.buttonInsert.Click += new System.EventHandler(this.buttonInsert_Click);
            // 
            // buttonShowGrade
            // 
            this.buttonShowGrade.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonShowGrade.Location = new System.Drawing.Point(531, 538);
            this.buttonShowGrade.Margin = new System.Windows.Forms.Padding(6);
            this.buttonShowGrade.Name = "buttonShowGrade";
            this.buttonShowGrade.Size = new System.Drawing.Size(184, 43);
            this.buttonShowGrade.TabIndex = 28;
            this.buttonShowGrade.Text = "Show Grade";
            this.buttonShowGrade.UseVisualStyleBackColor = true;
            this.buttonShowGrade.Click += new System.EventHandler(this.buttonShowGrade_Click);
            // 
            // buttonExit
            // 
            this.buttonExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonExit.Location = new System.Drawing.Point(531, 239);
            this.buttonExit.Margin = new System.Windows.Forms.Padding(6);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(184, 43);
            this.buttonExit.TabIndex = 27;
            this.buttonExit.Text = "Exit";
            this.buttonExit.UseVisualStyleBackColor = true;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // labAllTypes
            // 
            this.labAllTypes.AutoSize = true;
            this.labAllTypes.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labAllTypes.Location = new System.Drawing.Point(61, 44);
            this.labAllTypes.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.labAllTypes.Name = "labAllTypes";
            this.labAllTypes.Size = new System.Drawing.Size(485, 37);
            this.labAllTypes.TabIndex = 26;
            this.labAllTypes.Text = "(...show six question type here...)";
            // 
            // labTime
            // 
            this.labTime.AutoSize = true;
            this.labTime.BackColor = System.Drawing.Color.White;
            this.labTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labTime.ForeColor = System.Drawing.Color.Blue;
            this.labTime.Location = new System.Drawing.Point(921, 10);
            this.labTime.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.labTime.Name = "labTime";
            this.labTime.Size = new System.Drawing.Size(172, 120);
            this.labTime.TabIndex = 25;
            this.labTime.Text = "15";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(761, 10);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(148, 37);
            this.label1.TabIndex = 24;
            this.label1.Text = "Time left:";
            // 
            // btnDelAll
            // 
            this.btnDelAll.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelAll.Location = new System.Drawing.Point(531, 461);
            this.btnDelAll.Margin = new System.Windows.Forms.Padding(6);
            this.btnDelAll.Name = "btnDelAll";
            this.btnDelAll.Size = new System.Drawing.Size(184, 43);
            this.btnDelAll.TabIndex = 23;
            this.btnDelAll.Text = "Delete All";
            this.btnDelAll.UseVisualStyleBackColor = true;
            this.btnDelAll.Click += new System.EventHandler(this.btnDelAll_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Location = new System.Drawing.Point(531, 391);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(6);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(184, 43);
            this.btnDelete.TabIndex = 22;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnSubmit
            // 
            this.btnSubmit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubmit.Location = new System.Drawing.Point(531, 321);
            this.btnSubmit.Margin = new System.Windows.Forms.Padding(6);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(184, 43);
            this.btnSubmit.TabIndex = 21;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // gpQuestion
            // 
            this.gpQuestion.Controls.Add(this.chkC);
            this.gpQuestion.Controls.Add(this.chkB);
            this.gpQuestion.Controls.Add(this.label2);
            this.gpQuestion.Controls.Add(this.chkA);
            this.gpQuestion.Controls.Add(this.cboQtype);
            this.gpQuestion.Controls.Add(this.radA);
            this.gpQuestion.Controls.Add(this.radC);
            this.gpQuestion.Controls.Add(this.radB);
            this.gpQuestion.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.gpQuestion.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpQuestion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.gpQuestion.Location = new System.Drawing.Point(42, 105);
            this.gpQuestion.Margin = new System.Windows.Forms.Padding(6);
            this.gpQuestion.Name = "gpQuestion";
            this.gpQuestion.Padding = new System.Windows.Forms.Padding(6);
            this.gpQuestion.Size = new System.Drawing.Size(402, 438);
            this.gpQuestion.TabIndex = 20;
            this.gpQuestion.TabStop = false;
            this.gpQuestion.Text = "Question";
            // 
            // chkC
            // 
            this.chkC.AutoSize = true;
            this.chkC.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkC.Location = new System.Drawing.Point(228, 344);
            this.chkC.Margin = new System.Windows.Forms.Padding(6);
            this.chkC.Name = "chkC";
            this.chkC.Size = new System.Drawing.Size(86, 55);
            this.chkC.TabIndex = 10;
            this.chkC.Text = "C";
            this.chkC.UseVisualStyleBackColor = true;
            // 
            // chkB
            // 
            this.chkB.AutoSize = true;
            this.chkB.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkB.Location = new System.Drawing.Point(228, 277);
            this.chkB.Margin = new System.Windows.Forms.Padding(6);
            this.chkB.Name = "chkB";
            this.chkB.Size = new System.Drawing.Size(84, 55);
            this.chkB.TabIndex = 9;
            this.chkB.Text = "B";
            this.chkB.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(20, 75);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(303, 37);
            this.label2.TabIndex = 14;
            this.label2.Text = "This is a question of";
            // 
            // chkA
            // 
            this.chkA.AutoSize = true;
            this.chkA.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkA.Location = new System.Drawing.Point(228, 206);
            this.chkA.Margin = new System.Windows.Forms.Padding(6);
            this.chkA.Name = "chkA";
            this.chkA.Size = new System.Drawing.Size(84, 55);
            this.chkA.TabIndex = 8;
            this.chkA.Text = "A";
            this.chkA.UseVisualStyleBackColor = true;
            // 
            // cboQtype
            // 
            this.cboQtype.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cboQtype.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboQtype.ForeColor = System.Drawing.Color.White;
            this.cboQtype.FormattingEnabled = true;
            this.cboQtype.Items.AddRange(new object[] {
            "Multiple Choice",
            "Multiple Answers"});
            this.cboQtype.Location = new System.Drawing.Point(26, 117);
            this.cboQtype.Margin = new System.Windows.Forms.Padding(6);
            this.cboQtype.Name = "cboQtype";
            this.cboQtype.Size = new System.Drawing.Size(346, 45);
            this.cboQtype.TabIndex = 13;
            this.cboQtype.SelectedIndexChanged += new System.EventHandler(this.cboQtype_SelectedIndexChanged);
            // 
            // radA
            // 
            this.radA.AutoSize = true;
            this.radA.Enabled = false;
            this.radA.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radA.Location = new System.Drawing.Point(76, 206);
            this.radA.Margin = new System.Windows.Forms.Padding(6);
            this.radA.Name = "radA";
            this.radA.Size = new System.Drawing.Size(83, 55);
            this.radA.TabIndex = 4;
            this.radA.TabStop = true;
            this.radA.Text = "A";
            this.radA.UseVisualStyleBackColor = true;
            // 
            // radC
            // 
            this.radC.AutoSize = true;
            this.radC.Enabled = false;
            this.radC.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radC.Location = new System.Drawing.Point(76, 344);
            this.radC.Margin = new System.Windows.Forms.Padding(6);
            this.radC.Name = "radC";
            this.radC.Size = new System.Drawing.Size(85, 55);
            this.radC.TabIndex = 6;
            this.radC.TabStop = true;
            this.radC.Text = "C";
            this.radC.UseVisualStyleBackColor = true;
            // 
            // radB
            // 
            this.radB.AutoSize = true;
            this.radB.Enabled = false;
            this.radB.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radB.Location = new System.Drawing.Point(76, 275);
            this.radB.Margin = new System.Windows.Forms.Padding(6);
            this.radB.Name = "radB";
            this.radB.Size = new System.Drawing.Size(83, 55);
            this.radB.TabIndex = 5;
            this.radB.TabStop = true;
            this.radB.Text = "B";
            this.radB.UseVisualStyleBackColor = true;
            // 
            // lstMyAnswer
            // 
            this.lstMyAnswer.BackColor = System.Drawing.Color.Navy;
            this.lstMyAnswer.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstMyAnswer.ForeColor = System.Drawing.Color.Aqua;
            this.lstMyAnswer.FormattingEnabled = true;
            this.lstMyAnswer.ItemHeight = 51;
            this.lstMyAnswer.Location = new System.Drawing.Point(912, 222);
            this.lstMyAnswer.Margin = new System.Windows.Forms.Padding(6);
            this.lstMyAnswer.Name = "lstMyAnswer";
            this.lstMyAnswer.Size = new System.Drawing.Size(322, 361);
            this.lstMyAnswer.TabIndex = 19;
            this.lstMyAnswer.SelectedIndexChanged += new System.EventHandler(this.AnswerSelected);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.labelGrade);
            this.tabPage2.Controls.Add(this.CorrectAnswer);
            this.tabPage2.Controls.Add(this.MyAnswer);
            this.tabPage2.Location = new System.Drawing.Point(8, 39);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1358, 651);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Grade";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(748, 181);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(252, 37);
            this.label4.TabIndex = 28;
            this.label4.Text = "Correct Answer";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(65, 181);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(183, 37);
            this.label3.TabIndex = 27;
            this.label3.Text = "My Answer";
            // 
            // labelGrade
            // 
            this.labelGrade.AutoSize = true;
            this.labelGrade.BackColor = System.Drawing.Color.White;
            this.labelGrade.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelGrade.ForeColor = System.Drawing.Color.Red;
            this.labelGrade.Location = new System.Drawing.Point(905, 35);
            this.labelGrade.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.labelGrade.Name = "labelGrade";
            this.labelGrade.Size = new System.Drawing.Size(111, 120);
            this.labelGrade.TabIndex = 26;
            this.labelGrade.Text = "0";
            // 
            // CorrectAnswer
            // 
            this.CorrectAnswer.BackColor = System.Drawing.Color.Navy;
            this.CorrectAnswer.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CorrectAnswer.ForeColor = System.Drawing.Color.Aqua;
            this.CorrectAnswer.FormattingEnabled = true;
            this.CorrectAnswer.ItemHeight = 51;
            this.CorrectAnswer.Location = new System.Drawing.Point(746, 243);
            this.CorrectAnswer.Margin = new System.Windows.Forms.Padding(6);
            this.CorrectAnswer.Name = "CorrectAnswer";
            this.CorrectAnswer.Size = new System.Drawing.Size(322, 361);
            this.CorrectAnswer.TabIndex = 21;
            // 
            // MyAnswer
            // 
            this.MyAnswer.BackColor = System.Drawing.Color.Navy;
            this.MyAnswer.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MyAnswer.ForeColor = System.Drawing.Color.Aqua;
            this.MyAnswer.FormattingEnabled = true;
            this.MyAnswer.ItemHeight = 51;
            this.MyAnswer.Location = new System.Drawing.Point(72, 243);
            this.MyAnswer.Margin = new System.Windows.Forms.Padding(6);
            this.MyAnswer.Name = "MyAnswer";
            this.MyAnswer.Size = new System.Drawing.Size(322, 361);
            this.MyAnswer.TabIndex = 20;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1398, 732);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.gpQuestion.ResumeLayout(false);
            this.gpQuestion.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button buttonReplace;
        private System.Windows.Forms.Button buttonInsert;
        private System.Windows.Forms.Button buttonShowGrade;
        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.Label labAllTypes;
        private System.Windows.Forms.Label labTime;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnDelAll;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.GroupBox gpQuestion;
        private System.Windows.Forms.CheckBox chkC;
        private System.Windows.Forms.CheckBox chkB;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox chkA;
        private System.Windows.Forms.ComboBox cboQtype;
        private System.Windows.Forms.RadioButton radA;
        private System.Windows.Forms.RadioButton radC;
        private System.Windows.Forms.RadioButton radB;
        private System.Windows.Forms.ListBox lstMyAnswer;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label labelGrade;
        private System.Windows.Forms.ListBox CorrectAnswer;
        private System.Windows.Forms.ListBox MyAnswer;
        private System.Windows.Forms.Timer timer1;
    }
}

