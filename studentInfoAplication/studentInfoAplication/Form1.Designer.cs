namespace studentInfoAplication
{
    partial class FrmStudentInfo
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            labelFName = new Label();
            labelFirstName = new Label();
            labelLastName = new Label();
            textBoxStudID = new TextBox();
            textBoxFName = new TextBox();
            textBoxLName = new TextBox();
            buttonSubmit = new Button();
            labelStudIDList = new Label();
            labelFNameList = new Label();
            labelLName = new Label();
            listBoxStudID = new ListBox();
            listBoxFirstNames = new ListBox();
            listBoxLName = new ListBox();
            SuspendLayout();
            // 
            // labelFName
            // 
            labelFName.AutoSize = true;
            labelFName.Location = new Point(39, 57);
            labelFName.Name = "labelFName";
            labelFName.Size = new Size(127, 32);
            labelFName.TabIndex = 0;
            labelFName.Text = "Student ID";
            labelFName.UseWaitCursor = true;
            // 
            // labelFirstName
            // 
            labelFirstName.AutoSize = true;
            labelFirstName.Location = new Point(416, 57);
            labelFirstName.Name = "labelFirstName";
            labelFirstName.Size = new Size(129, 32);
            labelFirstName.TabIndex = 1;
            labelFirstName.Text = "First Name";
            // 
            // labelLastName
            // 
            labelLastName.AutoSize = true;
            labelLastName.Location = new Point(814, 57);
            labelLastName.Name = "labelLastName";
            labelLastName.Size = new Size(126, 32);
            labelLastName.TabIndex = 2;
            labelLastName.Text = "Last Name";
            // 
            // textBoxStudID
            // 
            textBoxStudID.Location = new Point(42, 99);
            textBoxStudID.Name = "textBoxStudID";
            textBoxStudID.Size = new Size(338, 39);
            textBoxStudID.TabIndex = 3;
            // 
            // textBoxFName
            // 
            textBoxFName.Location = new Point(420, 99);
            textBoxFName.Name = "textBoxFName";
            textBoxFName.Size = new Size(360, 39);
            textBoxFName.TabIndex = 4;
            // 
            // textBoxLName
            // 
            textBoxLName.Location = new Point(817, 100);
            textBoxLName.Name = "textBoxLName";
            textBoxLName.Size = new Size(290, 39);
            textBoxLName.TabIndex = 5;
            // 
            // buttonSubmit
            // 
            buttonSubmit.Location = new Point(957, 157);
            buttonSubmit.Name = "buttonSubmit";
            buttonSubmit.Size = new Size(150, 40);
            buttonSubmit.TabIndex = 6;
            buttonSubmit.Text = "Submit";
            buttonSubmit.UseVisualStyleBackColor = true;
            buttonSubmit.Click += buttonSubmit_Click;
            // 
            // labelStudIDList
            // 
            labelStudIDList.AutoSize = true;
            labelStudIDList.Location = new Point(51, 271);
            labelStudIDList.Name = "labelStudIDList";
            labelStudIDList.Size = new Size(169, 32);
            labelStudIDList.TabIndex = 7;
            labelStudIDList.Text = "Student ID List";
            // 
            // labelFNameList
            // 
            labelFNameList.AutoSize = true;
            labelFNameList.Location = new Point(425, 273);
            labelFNameList.Name = "labelFNameList";
            labelFNameList.Size = new Size(181, 32);
            labelFNameList.TabIndex = 8;
            labelFNameList.Text = "First Names List";
            // 
            // labelLName
            // 
            labelLName.AutoSize = true;
            labelLName.Location = new Point(823, 277);
            labelLName.Name = "labelLName";
            labelLName.Size = new Size(178, 32);
            labelLName.TabIndex = 9;
            labelLName.Text = "Last Names List";
            // 
            // listBoxStudID
            // 
            listBoxStudID.FormattingEnabled = true;
            listBoxStudID.Location = new Point(42, 322);
            listBoxStudID.Name = "listBoxStudID";
            listBoxStudID.Size = new Size(348, 196);
            listBoxStudID.TabIndex = 10;
            // 
            // listBoxFirstNames
            // 
            listBoxFirstNames.FormattingEnabled = true;
            listBoxFirstNames.Location = new Point(433, 324);
            listBoxFirstNames.Name = "listBoxFirstNames";
            listBoxFirstNames.Size = new Size(358, 196);
            listBoxFirstNames.TabIndex = 11;
            // 
            // listBoxLName
            // 
            listBoxLName.FormattingEnabled = true;
            listBoxLName.Location = new Point(829, 324);
            listBoxLName.Name = "listBoxLName";
            listBoxLName.Size = new Size(278, 196);
            listBoxLName.TabIndex = 12;
            // 
            // FrmStudentInfo
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1155, 590);
            Controls.Add(listBoxLName);
            Controls.Add(listBoxFirstNames);
            Controls.Add(listBoxStudID);
            Controls.Add(labelLName);
            Controls.Add(labelFNameList);
            Controls.Add(labelStudIDList);
            Controls.Add(buttonSubmit);
            Controls.Add(textBoxLName);
            Controls.Add(textBoxFName);
            Controls.Add(textBoxStudID);
            Controls.Add(labelLastName);
            Controls.Add(labelFirstName);
            Controls.Add(labelFName);
            Name = "FrmStudentInfo";
            Text = "Student Info";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelFName;
        private Label labelFirstName;
        private Label labelLastName;
        private TextBox textBoxStudID;
        private TextBox textBoxFName;
        private TextBox textBoxLName;
        private Button buttonSubmit;
        private Label labelStudIDList;
        private Label labelFNameList;
        private Label labelLName;
        private ListBox listBoxStudID;
        private ListBox listBoxFirstNames;
        private ListBox listBoxLName;
    }
}
