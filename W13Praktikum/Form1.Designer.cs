
namespace W13Praktikum
{
    partial class Player
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
            this.buttonFirst = new System.Windows.Forms.Button();
            this.buttonPrevious = new System.Windows.Forms.Button();
            this.buttonLast = new System.Windows.Forms.Button();
            this.buttonNext = new System.Windows.Forms.Button();
            this.labelPlayerID = new System.Windows.Forms.Label();
            this.labelPlayerName = new System.Windows.Forms.Label();
            this.labelNationality = new System.Windows.Forms.Label();
            this.labelBirthdate = new System.Windows.Forms.Label();
            this.labelTeamNumber = new System.Windows.Forms.Label();
            this.labelTeam = new System.Windows.Forms.Label();
            this.buttonSave = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.comboBoxTeam = new System.Windows.Forms.ComboBox();
            this.textBoxPlayerID = new System.Windows.Forms.TextBox();
            this.dateTimePickerBirthDate = new System.Windows.Forms.DateTimePicker();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.labelStatus = new System.Windows.Forms.Label();
            this.comboBoxNationality = new System.Windows.Forms.ComboBox();
            this.numUpDownTeamNumber = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDownTeamNumber)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonFirst
            // 
            this.buttonFirst.Location = new System.Drawing.Point(129, 45);
            this.buttonFirst.Name = "buttonFirst";
            this.buttonFirst.Size = new System.Drawing.Size(81, 47);
            this.buttonFirst.TabIndex = 0;
            this.buttonFirst.Text = "<<";
            this.buttonFirst.UseVisualStyleBackColor = true;
            this.buttonFirst.Click += new System.EventHandler(this.buttonFirst_Click);
            // 
            // buttonPrevious
            // 
            this.buttonPrevious.Location = new System.Drawing.Point(228, 45);
            this.buttonPrevious.Name = "buttonPrevious";
            this.buttonPrevious.Size = new System.Drawing.Size(81, 47);
            this.buttonPrevious.TabIndex = 1;
            this.buttonPrevious.Text = "<";
            this.buttonPrevious.UseVisualStyleBackColor = true;
            this.buttonPrevious.Click += new System.EventHandler(this.buttonPrevious_Click);
            // 
            // buttonLast
            // 
            this.buttonLast.Location = new System.Drawing.Point(426, 45);
            this.buttonLast.Name = "buttonLast";
            this.buttonLast.Size = new System.Drawing.Size(81, 47);
            this.buttonLast.TabIndex = 3;
            this.buttonLast.Text = ">>";
            this.buttonLast.UseVisualStyleBackColor = true;
            this.buttonLast.Click += new System.EventHandler(this.buttonLast_Click);
            // 
            // buttonNext
            // 
            this.buttonNext.Location = new System.Drawing.Point(327, 45);
            this.buttonNext.Name = "buttonNext";
            this.buttonNext.Size = new System.Drawing.Size(81, 47);
            this.buttonNext.TabIndex = 2;
            this.buttonNext.Text = ">";
            this.buttonNext.UseVisualStyleBackColor = true;
            this.buttonNext.Click += new System.EventHandler(this.buttonNext_Click);
            // 
            // labelPlayerID
            // 
            this.labelPlayerID.AutoSize = true;
            this.labelPlayerID.Location = new System.Drawing.Point(126, 123);
            this.labelPlayerID.Name = "labelPlayerID";
            this.labelPlayerID.Size = new System.Drawing.Size(65, 17);
            this.labelPlayerID.TabIndex = 4;
            this.labelPlayerID.Text = "Player ID";
            // 
            // labelPlayerName
            // 
            this.labelPlayerName.AutoSize = true;
            this.labelPlayerName.Location = new System.Drawing.Point(126, 168);
            this.labelPlayerName.Name = "labelPlayerName";
            this.labelPlayerName.Size = new System.Drawing.Size(89, 17);
            this.labelPlayerName.TabIndex = 5;
            this.labelPlayerName.Text = "Player Name";
            // 
            // labelNationality
            // 
            this.labelNationality.AutoSize = true;
            this.labelNationality.Location = new System.Drawing.Point(126, 261);
            this.labelNationality.Name = "labelNationality";
            this.labelNationality.Size = new System.Drawing.Size(74, 17);
            this.labelNationality.TabIndex = 7;
            this.labelNationality.Text = "Nationality";
            // 
            // labelBirthdate
            // 
            this.labelBirthdate.AutoSize = true;
            this.labelBirthdate.Location = new System.Drawing.Point(126, 216);
            this.labelBirthdate.Name = "labelBirthdate";
            this.labelBirthdate.Size = new System.Drawing.Size(67, 17);
            this.labelBirthdate.TabIndex = 6;
            this.labelBirthdate.Text = "BirthDate";
            // 
            // labelTeamNumber
            // 
            this.labelTeamNumber.AutoSize = true;
            this.labelTeamNumber.Location = new System.Drawing.Point(126, 346);
            this.labelTeamNumber.Name = "labelTeamNumber";
            this.labelTeamNumber.Size = new System.Drawing.Size(98, 17);
            this.labelTeamNumber.TabIndex = 9;
            this.labelTeamNumber.Text = "Team Number";
            // 
            // labelTeam
            // 
            this.labelTeam.AutoSize = true;
            this.labelTeam.Location = new System.Drawing.Point(126, 301);
            this.labelTeam.Name = "labelTeam";
            this.labelTeam.Size = new System.Drawing.Size(44, 17);
            this.labelTeam.TabIndex = 8;
            this.labelTeam.Text = "Team";
            // 
            // buttonSave
            // 
            this.buttonSave.Location = new System.Drawing.Point(129, 396);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(180, 32);
            this.buttonSave.TabIndex = 10;
            this.buttonSave.Text = "Save";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.Location = new System.Drawing.Point(327, 396);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(180, 32);
            this.buttonCancel.TabIndex = 11;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // comboBoxTeam
            // 
            this.comboBoxTeam.FormattingEnabled = true;
            this.comboBoxTeam.Location = new System.Drawing.Point(228, 295);
            this.comboBoxTeam.Name = "comboBoxTeam";
            this.comboBoxTeam.Size = new System.Drawing.Size(222, 24);
            this.comboBoxTeam.TabIndex = 13;
            // 
            // textBoxPlayerID
            // 
            this.textBoxPlayerID.Enabled = false;
            this.textBoxPlayerID.Location = new System.Drawing.Point(228, 120);
            this.textBoxPlayerID.Name = "textBoxPlayerID";
            this.textBoxPlayerID.Size = new System.Drawing.Size(121, 22);
            this.textBoxPlayerID.TabIndex = 14;
            // 
            // dateTimePickerBirthDate
            // 
            this.dateTimePickerBirthDate.CustomFormat = "dddd,MMMM,dd  yyyy";
            this.dateTimePickerBirthDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerBirthDate.Location = new System.Drawing.Point(226, 213);
            this.dateTimePickerBirthDate.Name = "dateTimePickerBirthDate";
            this.dateTimePickerBirthDate.Size = new System.Drawing.Size(258, 22);
            this.dateTimePickerBirthDate.TabIndex = 15;
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(228, 165);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(222, 22);
            this.textBoxName.TabIndex = 16;
            // 
            // labelStatus
            // 
            this.labelStatus.AutoSize = true;
            this.labelStatus.Location = new System.Drawing.Point(375, 346);
            this.labelStatus.Name = "labelStatus";
            this.labelStatus.Size = new System.Drawing.Size(60, 17);
            this.labelStatus.TabIndex = 18;
            this.labelStatus.Text = ".............";
            // 
            // comboBoxNationality
            // 
            this.comboBoxNationality.FormattingEnabled = true;
            this.comboBoxNationality.Location = new System.Drawing.Point(228, 258);
            this.comboBoxNationality.Name = "comboBoxNationality";
            this.comboBoxNationality.Size = new System.Drawing.Size(222, 24);
            this.comboBoxNationality.TabIndex = 19;
            // 
            // numUpDownTeamNumber
            // 
            this.numUpDownTeamNumber.Location = new System.Drawing.Point(230, 341);
            this.numUpDownTeamNumber.Name = "numUpDownTeamNumber";
            this.numUpDownTeamNumber.Size = new System.Drawing.Size(120, 22);
            this.numUpDownTeamNumber.TabIndex = 20;
            this.numUpDownTeamNumber.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // Player
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 501);
            this.Controls.Add(this.numUpDownTeamNumber);
            this.Controls.Add(this.comboBoxNationality);
            this.Controls.Add(this.labelStatus);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.dateTimePickerBirthDate);
            this.Controls.Add(this.textBoxPlayerID);
            this.Controls.Add(this.comboBoxTeam);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.labelTeamNumber);
            this.Controls.Add(this.labelTeam);
            this.Controls.Add(this.labelNationality);
            this.Controls.Add(this.labelBirthdate);
            this.Controls.Add(this.labelPlayerName);
            this.Controls.Add(this.labelPlayerID);
            this.Controls.Add(this.buttonLast);
            this.Controls.Add(this.buttonNext);
            this.Controls.Add(this.buttonPrevious);
            this.Controls.Add(this.buttonFirst);
            this.Name = "Player";
            this.Text = "Player";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numUpDownTeamNumber)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonFirst;
        private System.Windows.Forms.Button buttonPrevious;
        private System.Windows.Forms.Button buttonLast;
        private System.Windows.Forms.Button buttonNext;
        private System.Windows.Forms.Label labelPlayerID;
        private System.Windows.Forms.Label labelPlayerName;
        private System.Windows.Forms.Label labelNationality;
        private System.Windows.Forms.Label labelBirthdate;
        private System.Windows.Forms.Label labelTeamNumber;
        private System.Windows.Forms.Label labelTeam;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.ComboBox comboBoxTeam;
        private System.Windows.Forms.TextBox textBoxPlayerID;
        private System.Windows.Forms.DateTimePicker dateTimePickerBirthDate;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.Label labelStatus;
        private System.Windows.Forms.ComboBox comboBoxNationality;
        private System.Windows.Forms.NumericUpDown numUpDownTeamNumber;
    }
}

