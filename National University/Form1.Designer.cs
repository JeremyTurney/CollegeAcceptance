namespace National_University
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
            this.Welcome = new System.Windows.Forms.Label();
            this.ProgramChoice = new System.Windows.Forms.ComboBox();
            this.Choose = new System.Windows.Forms.Label();
            this.ThankYou = new System.Windows.Forms.Label();
            this.EducationBox = new System.Windows.Forms.GroupBox();
            this.None = new System.Windows.Forms.RadioButton();
            this.HighSchool = new System.Windows.Forms.RadioButton();
            this.GED = new System.Windows.Forms.RadioButton();
            this.CollegeEducation = new System.Windows.Forms.GroupBox();
            this.Doctorate = new System.Windows.Forms.RadioButton();
            this.Master = new System.Windows.Forms.RadioButton();
            this.Bachelor = new System.Windows.Forms.RadioButton();
            this.AttendedCollege = new System.Windows.Forms.RadioButton();
            this.AdditionalExperience = new System.Windows.Forms.GroupBox();
            this.LabratoryResearch = new System.Windows.Forms.RadioButton();
            this.FamilyBusiness = new System.Windows.Forms.RadioButton();
            this.WorkExperience = new System.Windows.Forms.RadioButton();
            this.Tests = new System.Windows.Forms.GroupBox();
            this.ACTScore = new System.Windows.Forms.TextBox();
            this.SATScore = new System.Windows.Forms.TextBox();
            this.ACT = new System.Windows.Forms.CheckBox();
            this.Score2 = new System.Windows.Forms.Label();
            this.Score1 = new System.Windows.Forms.Label();
            this.SAT = new System.Windows.Forms.CheckBox();
            this.Process = new System.Windows.Forms.Button();
            this.Clear = new System.Windows.Forms.Button();
            this.Exit = new System.Windows.Forms.Button();
            this.EducationBox.SuspendLayout();
            this.CollegeEducation.SuspendLayout();
            this.AdditionalExperience.SuspendLayout();
            this.Tests.SuspendLayout();
            this.SuspendLayout();
            // 
            // Welcome
            // 
            this.Welcome.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Welcome.Location = new System.Drawing.Point(55, 15);
            this.Welcome.Name = "Welcome";
            this.Welcome.Size = new System.Drawing.Size(526, 49);
            this.Welcome.TabIndex = 0;
            this.Welcome.Text = "Welcome to the Nation University program admission requirements calander. Please " +
    "selcet the program which interests you";
            // 
            // ProgramChoice
            // 
            this.ProgramChoice.FormattingEnabled = true;
            this.ProgramChoice.Items.AddRange(new object[] {
            "Accounting",
            "Applied Engineering",
            "Arts and Humanities",
            "Community Health",
            "Computer Science",
            "Education",
            "Educational Administration",
            "English",
            "Finance and Economics",
            "Health Sciences",
            "Journalism",
            "Leadership",
            "Management and Marketing",
            "Mathmatics",
            "Nursing",
            "Professional Studies",
            "Psychology",
            "Social Sciences",
            "Special Education",
            "Teacher Education"});
            this.ProgramChoice.Location = new System.Drawing.Point(235, 71);
            this.ProgramChoice.Name = "ProgramChoice";
            this.ProgramChoice.Size = new System.Drawing.Size(218, 26);
            this.ProgramChoice.TabIndex = 1;
            this.ProgramChoice.Text = "Computer Science";
            // 
            // Choose
            // 
            this.Choose.AutoSize = true;
            this.Choose.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Choose.Location = new System.Drawing.Point(55, 75);
            this.Choose.Name = "Choose";
            this.Choose.Size = new System.Drawing.Size(152, 19);
            this.Choose.TabIndex = 2;
            this.Choose.Text = "Choose a Program";
            // 
            // ThankYou
            // 
            this.ThankYou.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ThankYou.Location = new System.Drawing.Point(55, 112);
            this.ThankYou.Name = "ThankYou";
            this.ThankYou.Size = new System.Drawing.Size(494, 61);
            this.ThankYou.TabIndex = 3;
            this.ThankYou.Text = "Thank you. Now please indicate your qualifications by selecting  the appropriate " +
    "boxes and a recommendation based on your particular experience will be made.";
            // 
            // EducationBox
            // 
            this.EducationBox.Controls.Add(this.None);
            this.EducationBox.Controls.Add(this.HighSchool);
            this.EducationBox.Controls.Add(this.GED);
            this.EducationBox.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EducationBox.Location = new System.Drawing.Point(59, 185);
            this.EducationBox.Name = "EducationBox";
            this.EducationBox.Size = new System.Drawing.Size(339, 122);
            this.EducationBox.TabIndex = 4;
            this.EducationBox.TabStop = false;
            this.EducationBox.Text = "Education [Highest Completed]";
            // 
            // None
            // 
            this.None.AutoSize = true;
            this.None.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.None.Location = new System.Drawing.Point(19, 85);
            this.None.Name = "None";
            this.None.Size = new System.Drawing.Size(159, 22);
            this.None.TabIndex = 2;
            this.None.TabStop = true;
            this.None.Text = "None of the above";
            this.None.UseVisualStyleBackColor = true;
            // 
            // HighSchool
            // 
            this.HighSchool.AutoSize = true;
            this.HighSchool.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HighSchool.Location = new System.Drawing.Point(19, 58);
            this.HighSchool.Name = "HighSchool";
            this.HighSchool.Size = new System.Drawing.Size(186, 22);
            this.HighSchool.TabIndex = 1;
            this.HighSchool.TabStop = true;
            this.HighSchool.Text = "High School Graduate";
            this.HighSchool.UseVisualStyleBackColor = true;
            // 
            // GED
            // 
            this.GED.AutoSize = true;
            this.GED.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GED.Location = new System.Drawing.Point(19, 32);
            this.GED.Name = "GED";
            this.GED.Size = new System.Drawing.Size(68, 22);
            this.GED.TabIndex = 0;
            this.GED.TabStop = true;
            this.GED.Text = "GED";
            this.GED.UseVisualStyleBackColor = true;
            // 
            // CollegeEducation
            // 
            this.CollegeEducation.Controls.Add(this.Doctorate);
            this.CollegeEducation.Controls.Add(this.Master);
            this.CollegeEducation.Controls.Add(this.Bachelor);
            this.CollegeEducation.Controls.Add(this.AttendedCollege);
            this.CollegeEducation.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CollegeEducation.Location = new System.Drawing.Point(60, 313);
            this.CollegeEducation.Name = "CollegeEducation";
            this.CollegeEducation.Size = new System.Drawing.Size(339, 158);
            this.CollegeEducation.TabIndex = 5;
            this.CollegeEducation.TabStop = false;
            this.CollegeEducation.Text = "Colleg Education [Highest Completed]";
            // 
            // Doctorate
            // 
            this.Doctorate.AutoSize = true;
            this.Doctorate.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Doctorate.Location = new System.Drawing.Point(19, 121);
            this.Doctorate.Name = "Doctorate";
            this.Doctorate.Size = new System.Drawing.Size(170, 22);
            this.Doctorate.TabIndex = 3;
            this.Doctorate.TabStop = true;
            this.Doctorate.Text = "Doctorate\'s Degree";
            this.Doctorate.UseVisualStyleBackColor = true;
            // 
            // Master
            // 
            this.Master.AutoSize = true;
            this.Master.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Master.Location = new System.Drawing.Point(19, 92);
            this.Master.Name = "Master";
            this.Master.Size = new System.Drawing.Size(149, 22);
            this.Master.TabIndex = 2;
            this.Master.TabStop = true;
            this.Master.Text = "Master\'s Degree";
            this.Master.UseVisualStyleBackColor = true;
            // 
            // Bachelor
            // 
            this.Bachelor.AutoSize = true;
            this.Bachelor.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Bachelor.Location = new System.Drawing.Point(19, 63);
            this.Bachelor.Name = "Bachelor";
            this.Bachelor.Size = new System.Drawing.Size(163, 22);
            this.Bachelor.TabIndex = 1;
            this.Bachelor.TabStop = true;
            this.Bachelor.Text = "Bachelor\'s Degree";
            this.Bachelor.UseVisualStyleBackColor = true;
            // 
            // AttendedCollege
            // 
            this.AttendedCollege.AutoSize = true;
            this.AttendedCollege.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AttendedCollege.Location = new System.Drawing.Point(19, 34);
            this.AttendedCollege.Name = "AttendedCollege";
            this.AttendedCollege.Size = new System.Drawing.Size(292, 22);
            this.AttendedCollege.TabIndex = 0;
            this.AttendedCollege.TabStop = true;
            this.AttendedCollege.Text = "Attended College (degree unfinished)";
            this.AttendedCollege.UseVisualStyleBackColor = true;
            // 
            // AdditionalExperience
            // 
            this.AdditionalExperience.Controls.Add(this.LabratoryResearch);
            this.AdditionalExperience.Controls.Add(this.FamilyBusiness);
            this.AdditionalExperience.Controls.Add(this.WorkExperience);
            this.AdditionalExperience.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AdditionalExperience.Location = new System.Drawing.Point(61, 477);
            this.AdditionalExperience.Name = "AdditionalExperience";
            this.AdditionalExperience.Size = new System.Drawing.Size(338, 134);
            this.AdditionalExperience.TabIndex = 6;
            this.AdditionalExperience.TabStop = false;
            this.AdditionalExperience.Text = "Additional Experience";
            // 
            // LabratoryResearch
            // 
            this.LabratoryResearch.AutoSize = true;
            this.LabratoryResearch.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabratoryResearch.Location = new System.Drawing.Point(13, 94);
            this.LabratoryResearch.Name = "LabratoryResearch";
            this.LabratoryResearch.Size = new System.Drawing.Size(170, 22);
            this.LabratoryResearch.TabIndex = 2;
            this.LabratoryResearch.TabStop = true;
            this.LabratoryResearch.Text = "Labratory Research";
            this.LabratoryResearch.UseVisualStyleBackColor = true;
            // 
            // FamilyBusiness
            // 
            this.FamilyBusiness.AutoSize = true;
            this.FamilyBusiness.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FamilyBusiness.Location = new System.Drawing.Point(13, 65);
            this.FamilyBusiness.Name = "FamilyBusiness";
            this.FamilyBusiness.Size = new System.Drawing.Size(147, 22);
            this.FamilyBusiness.TabIndex = 1;
            this.FamilyBusiness.TabStop = true;
            this.FamilyBusiness.Text = "Family Business";
            this.FamilyBusiness.UseVisualStyleBackColor = true;
            // 
            // WorkExperience
            // 
            this.WorkExperience.AutoSize = true;
            this.WorkExperience.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WorkExperience.Location = new System.Drawing.Point(13, 34);
            this.WorkExperience.Name = "WorkExperience";
            this.WorkExperience.Size = new System.Drawing.Size(225, 22);
            this.WorkExperience.TabIndex = 0;
            this.WorkExperience.TabStop = true;
            this.WorkExperience.Text = "Work Experience in Industry";
            this.WorkExperience.UseVisualStyleBackColor = true;
            // 
            // Tests
            // 
            this.Tests.Controls.Add(this.ACTScore);
            this.Tests.Controls.Add(this.SATScore);
            this.Tests.Controls.Add(this.ACT);
            this.Tests.Controls.Add(this.Score2);
            this.Tests.Controls.Add(this.Score1);
            this.Tests.Controls.Add(this.SAT);
            this.Tests.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Tests.Location = new System.Drawing.Point(414, 185);
            this.Tests.Name = "Tests";
            this.Tests.Size = new System.Drawing.Size(177, 243);
            this.Tests.TabIndex = 7;
            this.Tests.TabStop = false;
            this.Tests.Text = "Tests";
            // 
            // ACTScore
            // 
            this.ACTScore.Location = new System.Drawing.Point(92, 161);
            this.ACTScore.Name = "ACTScore";
            this.ACTScore.Size = new System.Drawing.Size(64, 26);
            this.ACTScore.TabIndex = 5;
            this.ACTScore.TextChanged += new System.EventHandler(this.ACTScore_TextChanged);
            this.ACTScore.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ACTScore_KeyPress);
            // 
            // SATScore
            // 
            this.SATScore.Location = new System.Drawing.Point(92, 72);
            this.SATScore.Name = "SATScore";
            this.SATScore.Size = new System.Drawing.Size(64, 26);
            this.SATScore.TabIndex = 4;
            this.SATScore.TextChanged += new System.EventHandler(this.SATScore_TextChanged);
            this.SATScore.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.SATScore_KeyPress);
            // 
            // ACT
            // 
            this.ACT.AutoSize = true;
            this.ACT.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ACT.Location = new System.Drawing.Point(20, 127);
            this.ACT.Name = "ACT";
            this.ACT.Size = new System.Drawing.Size(66, 22);
            this.ACT.TabIndex = 3;
            this.ACT.Text = "ACT";
            this.ACT.UseVisualStyleBackColor = true;
            // 
            // Score2
            // 
            this.Score2.AutoSize = true;
            this.Score2.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Score2.Location = new System.Drawing.Point(36, 166);
            this.Score2.Name = "Score2";
            this.Score2.Size = new System.Drawing.Size(50, 18);
            this.Score2.TabIndex = 2;
            this.Score2.Text = "Score";
            // 
            // Score1
            // 
            this.Score1.AutoSize = true;
            this.Score1.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Score1.Location = new System.Drawing.Point(36, 75);
            this.Score1.Name = "Score1";
            this.Score1.Size = new System.Drawing.Size(50, 18);
            this.Score1.TabIndex = 1;
            this.Score1.Text = "Score";
            // 
            // SAT
            // 
            this.SAT.AutoSize = true;
            this.SAT.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SAT.Location = new System.Drawing.Point(20, 33);
            this.SAT.Name = "SAT";
            this.SAT.Size = new System.Drawing.Size(64, 22);
            this.SAT.TabIndex = 0;
            this.SAT.Text = "SAT";
            this.SAT.UseVisualStyleBackColor = true;
            // 
            // Process
            // 
            this.Process.Location = new System.Drawing.Point(434, 494);
            this.Process.Name = "Process";
            this.Process.Size = new System.Drawing.Size(113, 35);
            this.Process.TabIndex = 8;
            this.Process.Text = "Process";
            this.Process.UseVisualStyleBackColor = true;
            this.Process.Click += new System.EventHandler(this.Process_Click);
            // 
            // Clear
            // 
            this.Clear.Location = new System.Drawing.Point(434, 536);
            this.Clear.Name = "Clear";
            this.Clear.Size = new System.Drawing.Size(113, 35);
            this.Clear.TabIndex = 9;
            this.Clear.Text = "Clear";
            this.Clear.UseVisualStyleBackColor = true;
            this.Clear.Click += new System.EventHandler(this.Clear_Click);
            // 
            // Exit
            // 
            this.Exit.Location = new System.Drawing.Point(434, 576);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(113, 35);
            this.Exit.TabIndex = 10;
            this.Exit.Text = "Exit";
            this.Exit.UseVisualStyleBackColor = true;
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(603, 637);
            this.Controls.Add(this.Exit);
            this.Controls.Add(this.Clear);
            this.Controls.Add(this.Process);
            this.Controls.Add(this.Tests);
            this.Controls.Add(this.AdditionalExperience);
            this.Controls.Add(this.CollegeEducation);
            this.Controls.Add(this.EducationBox);
            this.Controls.Add(this.ThankYou);
            this.Controls.Add(this.Choose);
            this.Controls.Add(this.ProgramChoice);
            this.Controls.Add(this.Welcome);
            this.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.Text = "Admissions Form";
            this.EducationBox.ResumeLayout(false);
            this.EducationBox.PerformLayout();
            this.CollegeEducation.ResumeLayout(false);
            this.CollegeEducation.PerformLayout();
            this.AdditionalExperience.ResumeLayout(false);
            this.AdditionalExperience.PerformLayout();
            this.Tests.ResumeLayout(false);
            this.Tests.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Welcome;
        private System.Windows.Forms.ComboBox ProgramChoice;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label Choose;
        private System.Windows.Forms.Label ThankYou;
        private System.Windows.Forms.GroupBox EducationBox;
        private System.Windows.Forms.GroupBox CollegeEducation;
        private System.Windows.Forms.RadioButton GED;
        private System.Windows.Forms.RadioButton HighSchool;
        private System.Windows.Forms.RadioButton None;
        private System.Windows.Forms.RadioButton AttendedCollege;
        private System.Windows.Forms.RadioButton Bachelor;
        private System.Windows.Forms.RadioButton Master;
        private System.Windows.Forms.RadioButton Doctorate;
        private System.Windows.Forms.GroupBox AdditionalExperience;
        private System.Windows.Forms.RadioButton WorkExperience;
        private System.Windows.Forms.RadioButton FamilyBusiness;
        private System.Windows.Forms.RadioButton LabratoryResearch;
        private System.Windows.Forms.GroupBox Tests;
        private System.Windows.Forms.CheckBox SAT;
        private System.Windows.Forms.Label Score1;
        private System.Windows.Forms.Label Score2;
        private System.Windows.Forms.CheckBox ACT;
        private System.Windows.Forms.TextBox SATScore;
        private System.Windows.Forms.TextBox ACTScore;
        private System.Windows.Forms.Button Process;
        private System.Windows.Forms.Button Clear;
        private System.Windows.Forms.Button Exit;
    }
}

