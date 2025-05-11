namespace ApplicantRegistrationSystem.Forms
{
    partial class AddAbiturientForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            labelBenefitType = new Label();
            comboBoxBenefitType = new ComboBox();
            labelBenefitDocument = new Label();
            textBoxBenefitDocument = new TextBox();
            labelBenefitIssuedBy = new Label();
            textBoxBenefitIssuedBy = new TextBox();
            dateTimePickerBenefitDate = new DateTimePicker();
            labelBenefitDate = new Label();
            labelRegNumber = new Label();
            textBoxRegNumber = new TextBox();
            labelLastName = new Label();
            textBoxLastName = new TextBox();
            labelFirstName = new Label();
            textBoxFirstName = new TextBox();
            labelPatronymic = new Label();
            textBoxPatronymic = new TextBox();
            labelBirthDate = new Label();
            dateTimePickerBirthDate = new DateTimePicker();
            labelSchoolName = new Label();
            textBoxSchoolName = new TextBox();
            labelSchoolNumber = new Label();
            textBoxSchoolNumber = new TextBox();
            labelSchoolCity = new Label();
            textBoxSchoolCity = new TextBox();
            labelGraduationDate = new Label();
            dateTimePickerGraduationDate = new DateTimePicker();
            checkBoxRedDiploma = new CheckBox();
            checkBoxMedal = new CheckBox();
            labelCity = new Label();
            textBoxCity = new TextBox();
            labelStreet = new Label();
            textBoxStreet = new TextBox();
            labelHouseNumber = new Label();
            textBoxHouseNumber = new TextBox();
            labelPhone = new Label();
            textBoxPhone = new TextBox();
            labelSpeciality = new Label();
            comboBoxSpecialities = new ComboBox();
            buttonSave = new Button();
            dataGridViewSubjects = new DataGridView();
            buttonAddGrade = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridViewSubjects).BeginInit();
            SuspendLayout();
            // 
            // labelBenefitType
            // 
            labelBenefitType.AutoSize = true;
            labelBenefitType.Location = new Point(12, 659);
            labelBenefitType.Name = "labelBenefitType";
            labelBenefitType.Size = new Size(56, 20);
            labelBenefitType.TabIndex = 33;
            labelBenefitType.Text = "Льгота";
            // 
            // comboBoxBenefitType
            // 
            comboBoxBenefitType.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxBenefitType.FormattingEnabled = true;
            comboBoxBenefitType.Location = new Point(200, 659);
            comboBoxBenefitType.Name = "comboBoxBenefitType";
            comboBoxBenefitType.Size = new Size(300, 28);
            comboBoxBenefitType.TabIndex = 34;
            // 
            // labelBenefitDocument
            // 
            labelBenefitDocument.AutoSize = true;
            labelBenefitDocument.Location = new Point(12, 711);
            labelBenefitDocument.Name = "labelBenefitDocument";
            labelBenefitDocument.Size = new Size(138, 20);
            labelBenefitDocument.TabIndex = 35;
            labelBenefitDocument.Text = "Документ о льготе";
            // 
            // textBoxBenefitDocument
            // 
            textBoxBenefitDocument.Location = new Point(200, 711);
            textBoxBenefitDocument.Name = "textBoxBenefitDocument";
            textBoxBenefitDocument.Size = new Size(300, 27);
            textBoxBenefitDocument.TabIndex = 36;
            // 
            // labelBenefitIssuedBy
            // 
            labelBenefitIssuedBy.AutoSize = true;
            labelBenefitIssuedBy.Location = new Point(12, 805);
            labelBenefitIssuedBy.Name = "labelBenefitIssuedBy";
            labelBenefitIssuedBy.Size = new Size(85, 20);
            labelBenefitIssuedBy.TabIndex = 39;
            labelBenefitIssuedBy.Text = "Кем выдан";
            // 
            // textBoxBenefitIssuedBy
            // 
            textBoxBenefitIssuedBy.Location = new Point(200, 802);
            textBoxBenefitIssuedBy.Name = "textBoxBenefitIssuedBy";
            textBoxBenefitIssuedBy.Size = new Size(300, 27);
            textBoxBenefitIssuedBy.TabIndex = 40;
            // 
            // dateTimePickerBenefitDate
            // 
            dateTimePickerBenefitDate.Location = new Point(200, 762);
            dateTimePickerBenefitDate.Name = "dateTimePickerBenefitDate";
            dateTimePickerBenefitDate.Size = new Size(300, 27);
            dateTimePickerBenefitDate.TabIndex = 38;
            // 
            // labelBenefitDate
            // 
            labelBenefitDate.AutoSize = true;
            labelBenefitDate.Location = new Point(12, 762);
            labelBenefitDate.Name = "labelBenefitDate";
            labelBenefitDate.Size = new Size(118, 20);
            labelBenefitDate.TabIndex = 37;
            labelBenefitDate.Text = "Дата документа";
            // 
            // labelRegNumber
            // 
            labelRegNumber.AutoSize = true;
            labelRegNumber.Location = new Point(12, 15);
            labelRegNumber.Name = "labelRegNumber";
            labelRegNumber.Size = new Size(185, 20);
            labelRegNumber.TabIndex = 0;
            labelRegNumber.Text = "Регистрационный номер";
            // 
            // textBoxRegNumber
            // 
            textBoxRegNumber.Location = new Point(200, 12);
            textBoxRegNumber.Name = "textBoxRegNumber";
            textBoxRegNumber.Size = new Size(300, 27);
            textBoxRegNumber.TabIndex = 1;
            // 
            // labelLastName
            // 
            labelLastName.AutoSize = true;
            labelLastName.Location = new Point(12, 55);
            labelLastName.Name = "labelLastName";
            labelLastName.Size = new Size(73, 20);
            labelLastName.TabIndex = 2;
            labelLastName.Text = "Фамилия";
            // 
            // textBoxLastName
            // 
            textBoxLastName.Location = new Point(200, 52);
            textBoxLastName.Name = "textBoxLastName";
            textBoxLastName.Size = new Size(300, 27);
            textBoxLastName.TabIndex = 3;
            textBoxLastName.TextChanged += textBoxLastName_TextChanged;
            // 
            // labelFirstName
            // 
            labelFirstName.AutoSize = true;
            labelFirstName.Location = new Point(12, 95);
            labelFirstName.Name = "labelFirstName";
            labelFirstName.Size = new Size(39, 20);
            labelFirstName.TabIndex = 4;
            labelFirstName.Text = "Имя";
            // 
            // textBoxFirstName
            // 
            textBoxFirstName.Location = new Point(200, 92);
            textBoxFirstName.Name = "textBoxFirstName";
            textBoxFirstName.Size = new Size(300, 27);
            textBoxFirstName.TabIndex = 5;
            // 
            // labelPatronymic
            // 
            labelPatronymic.AutoSize = true;
            labelPatronymic.Location = new Point(12, 135);
            labelPatronymic.Name = "labelPatronymic";
            labelPatronymic.Size = new Size(72, 20);
            labelPatronymic.TabIndex = 6;
            labelPatronymic.Text = "Отчество";
            // 
            // textBoxPatronymic
            // 
            textBoxPatronymic.Location = new Point(200, 132);
            textBoxPatronymic.Name = "textBoxPatronymic";
            textBoxPatronymic.Size = new Size(300, 27);
            textBoxPatronymic.TabIndex = 7;
            // 
            // labelBirthDate
            // 
            labelBirthDate.AutoSize = true;
            labelBirthDate.Location = new Point(12, 175);
            labelBirthDate.Name = "labelBirthDate";
            labelBirthDate.Size = new Size(116, 20);
            labelBirthDate.TabIndex = 8;
            labelBirthDate.Text = "Дата рождения";
            // 
            // dateTimePickerBirthDate
            // 
            dateTimePickerBirthDate.Location = new Point(242, 168);
            dateTimePickerBirthDate.Name = "dateTimePickerBirthDate";
            dateTimePickerBirthDate.Size = new Size(300, 27);
            dateTimePickerBirthDate.TabIndex = 9;
            // 
            // labelSchoolName
            // 
            labelSchoolName.AutoSize = true;
            labelSchoolName.Location = new Point(12, 215);
            labelSchoolName.Name = "labelSchoolName";
            labelSchoolName.Size = new Size(223, 20);
            labelSchoolName.TabIndex = 10;
            labelSchoolName.Text = "Название учебного заведения";
            // 
            // textBoxSchoolName
            // 
            textBoxSchoolName.Location = new Point(241, 212);
            textBoxSchoolName.Name = "textBoxSchoolName";
            textBoxSchoolName.Size = new Size(300, 27);
            textBoxSchoolName.TabIndex = 11;
            // 
            // labelSchoolNumber
            // 
            labelSchoolNumber.AutoSize = true;
            labelSchoolNumber.Location = new Point(12, 255);
            labelSchoolNumber.Name = "labelSchoolNumber";
            labelSchoolNumber.Size = new Size(203, 20);
            labelSchoolNumber.TabIndex = 12;
            labelSchoolNumber.Text = "Номер учебного заведения";
            // 
            // textBoxSchoolNumber
            // 
            textBoxSchoolNumber.Location = new Point(242, 252);
            textBoxSchoolNumber.Name = "textBoxSchoolNumber";
            textBoxSchoolNumber.Size = new Size(300, 27);
            textBoxSchoolNumber.TabIndex = 13;
            // 
            // labelSchoolCity
            // 
            labelSchoolCity.AutoSize = true;
            labelSchoolCity.Location = new Point(12, 295);
            labelSchoolCity.Name = "labelSchoolCity";
            labelSchoolCity.Size = new Size(197, 20);
            labelSchoolCity.TabIndex = 14;
            labelSchoolCity.Text = "Город учебного заведения";
            // 
            // textBoxSchoolCity
            // 
            textBoxSchoolCity.Location = new Point(241, 292);
            textBoxSchoolCity.Name = "textBoxSchoolCity";
            textBoxSchoolCity.Size = new Size(300, 27);
            textBoxSchoolCity.TabIndex = 15;
            // 
            // labelGraduationDate
            // 
            labelGraduationDate.AutoSize = true;
            labelGraduationDate.Location = new Point(12, 335);
            labelGraduationDate.Name = "labelGraduationDate";
            labelGraduationDate.Size = new Size(172, 20);
            labelGraduationDate.TabIndex = 16;
            labelGraduationDate.Text = "Дата окончания школы";
            // 
            // dateTimePickerGraduationDate
            // 
            dateTimePickerGraduationDate.Location = new Point(200, 332);
            dateTimePickerGraduationDate.Name = "dateTimePickerGraduationDate";
            dateTimePickerGraduationDate.Size = new Size(300, 27);
            dateTimePickerGraduationDate.TabIndex = 17;
            // 
            // checkBoxRedDiploma
            // 
            checkBoxRedDiploma.AutoSize = true;
            checkBoxRedDiploma.Location = new Point(12, 375);
            checkBoxRedDiploma.Name = "checkBoxRedDiploma";
            checkBoxRedDiploma.Size = new Size(151, 24);
            checkBoxRedDiploma.TabIndex = 18;
            checkBoxRedDiploma.Text = "Красный диплом";
            checkBoxRedDiploma.UseVisualStyleBackColor = true;
            // 
            // checkBoxMedal
            // 
            checkBoxMedal.AutoSize = true;
            checkBoxMedal.Location = new Point(12, 405);
            checkBoxMedal.Name = "checkBoxMedal";
            checkBoxMedal.Size = new Size(233, 24);
            checkBoxMedal.TabIndex = 19;
            checkBoxMedal.Text = "Золотая/Серебряная медаль";
            checkBoxMedal.UseVisualStyleBackColor = true;
            // 
            // labelCity
            // 
            labelCity.AutoSize = true;
            labelCity.Location = new Point(12, 445);
            labelCity.Name = "labelCity";
            labelCity.Size = new Size(144, 20);
            labelCity.TabIndex = 20;
            labelCity.Text = "Город проживания";
            // 
            // textBoxCity
            // 
            textBoxCity.Location = new Point(200, 442);
            textBoxCity.Name = "textBoxCity";
            textBoxCity.Size = new Size(300, 27);
            textBoxCity.TabIndex = 21;
            // 
            // labelStreet
            // 
            labelStreet.AutoSize = true;
            labelStreet.Location = new Point(12, 485);
            labelStreet.Name = "labelStreet";
            labelStreet.Size = new Size(52, 20);
            labelStreet.TabIndex = 22;
            labelStreet.Text = "Улица";
            // 
            // textBoxStreet
            // 
            textBoxStreet.Location = new Point(200, 482);
            textBoxStreet.Name = "textBoxStreet";
            textBoxStreet.Size = new Size(300, 27);
            textBoxStreet.TabIndex = 23;
            // 
            // labelHouseNumber
            // 
            labelHouseNumber.AutoSize = true;
            labelHouseNumber.Location = new Point(12, 525);
            labelHouseNumber.Name = "labelHouseNumber";
            labelHouseNumber.Size = new Size(97, 20);
            labelHouseNumber.TabIndex = 24;
            labelHouseNumber.Text = "Номер дома";
            // 
            // textBoxHouseNumber
            // 
            textBoxHouseNumber.Location = new Point(200, 522);
            textBoxHouseNumber.Name = "textBoxHouseNumber";
            textBoxHouseNumber.Size = new Size(300, 27);
            textBoxHouseNumber.TabIndex = 25;
            // 
            // labelPhone
            // 
            labelPhone.AutoSize = true;
            labelPhone.Location = new Point(12, 565);
            labelPhone.Name = "labelPhone";
            labelPhone.Size = new Size(127, 20);
            labelPhone.TabIndex = 26;
            labelPhone.Text = "Номер телефона";
            // 
            // textBoxPhone
            // 
            textBoxPhone.Location = new Point(200, 562);
            textBoxPhone.Name = "textBoxPhone";
            textBoxPhone.Size = new Size(300, 27);
            textBoxPhone.TabIndex = 27;
            // 
            // labelSpeciality
            // 
            labelSpeciality.AutoSize = true;
            labelSpeciality.Location = new Point(12, 605);
            labelSpeciality.Name = "labelSpeciality";
            labelSpeciality.Size = new Size(116, 20);
            labelSpeciality.TabIndex = 28;
            labelSpeciality.Text = "Специальность";
            // 
            // comboBoxSpecialities
            // 
            comboBoxSpecialities.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxSpecialities.FormattingEnabled = true;
            comboBoxSpecialities.Location = new Point(200, 602);
            comboBoxSpecialities.Name = "comboBoxSpecialities";
            comboBoxSpecialities.Size = new Size(300, 28);
            comboBoxSpecialities.TabIndex = 29;
            // 
            // buttonSave
            // 
            buttonSave.Location = new Point(105, 1061);
            buttonSave.Name = "buttonSave";
            buttonSave.Size = new Size(300, 40);
            buttonSave.TabIndex = 30;
            buttonSave.Text = "Сохранить";
            buttonSave.UseVisualStyleBackColor = true;
            buttonSave.Click += buttonSave_Click;
            // 
            // dataGridViewSubjects
            // 
            dataGridViewSubjects.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewSubjects.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewSubjects.Location = new Point(12, 850);
            dataGridViewSubjects.Name = "dataGridViewSubjects";
            dataGridViewSubjects.RowHeadersWidth = 51;
            dataGridViewSubjects.Size = new Size(488, 150);
            dataGridViewSubjects.TabIndex = 31;
            // 
            // buttonAddGrade
            // 
            buttonAddGrade.Location = new Point(349, 1006);
            buttonAddGrade.Name = "buttonAddGrade";
            buttonAddGrade.Size = new Size(151, 40);
            buttonAddGrade.TabIndex = 32;
            buttonAddGrade.Text = "Добавить оценку";
            buttonAddGrade.UseVisualStyleBackColor = true;
            buttonAddGrade.Click += buttonAddGrade_Click;
            // 
            // AddAbiturientForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            AutoScrollMinSize = new Size(600, 1170);
            ClientSize = new Size(554, 1050);
            Controls.Add(textBoxBenefitIssuedBy);
            Controls.Add(labelBenefitIssuedBy);
            Controls.Add(dateTimePickerBenefitDate);
            Controls.Add(labelBenefitDate);
            Controls.Add(textBoxBenefitDocument);
            Controls.Add(labelBenefitDocument);
            Controls.Add(comboBoxBenefitType);
            Controls.Add(labelBenefitType);
            Controls.Add(buttonAddGrade);
            Controls.Add(dataGridViewSubjects);
            Controls.Add(buttonSave);
            Controls.Add(comboBoxSpecialities);
            Controls.Add(labelSpeciality);
            Controls.Add(textBoxPhone);
            Controls.Add(labelPhone);
            Controls.Add(textBoxHouseNumber);
            Controls.Add(labelHouseNumber);
            Controls.Add(textBoxStreet);
            Controls.Add(labelStreet);
            Controls.Add(textBoxCity);
            Controls.Add(labelCity);
            Controls.Add(checkBoxMedal);
            Controls.Add(checkBoxRedDiploma);
            Controls.Add(dateTimePickerGraduationDate);
            Controls.Add(labelGraduationDate);
            Controls.Add(textBoxSchoolCity);
            Controls.Add(labelSchoolCity);
            Controls.Add(textBoxSchoolNumber);
            Controls.Add(labelSchoolNumber);
            Controls.Add(textBoxSchoolName);
            Controls.Add(labelSchoolName);
            Controls.Add(dateTimePickerBirthDate);
            Controls.Add(labelBirthDate);
            Controls.Add(textBoxPatronymic);
            Controls.Add(labelPatronymic);
            Controls.Add(textBoxFirstName);
            Controls.Add(labelFirstName);
            Controls.Add(textBoxLastName);
            Controls.Add(labelLastName);
            Controls.Add(textBoxRegNumber);
            Controls.Add(labelRegNumber);
            Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 204);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "AddAbiturientForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Добавить абитуриента";
            Load += AddAbiturientForm_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridViewSubjects).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label labelRegNumber;
        private System.Windows.Forms.TextBox textBoxRegNumber;
        private System.Windows.Forms.Label labelLastName;
        private System.Windows.Forms.TextBox textBoxLastName;
        private System.Windows.Forms.Label labelFirstName;
        private System.Windows.Forms.TextBox textBoxFirstName;
        private System.Windows.Forms.Label labelPatronymic;
        private System.Windows.Forms.TextBox textBoxPatronymic;
        private System.Windows.Forms.Label labelBirthDate;
        private System.Windows.Forms.DateTimePicker dateTimePickerBirthDate;
        private System.Windows.Forms.Label labelSchoolName;
        private System.Windows.Forms.TextBox textBoxSchoolName;
        private System.Windows.Forms.Label labelSchoolNumber;
        private System.Windows.Forms.TextBox textBoxSchoolNumber;
        private System.Windows.Forms.Label labelSchoolCity;
        private System.Windows.Forms.TextBox textBoxSchoolCity;
        private System.Windows.Forms.Label labelGraduationDate;
        private System.Windows.Forms.DateTimePicker dateTimePickerGraduationDate;
        private System.Windows.Forms.CheckBox checkBoxRedDiploma;
        private System.Windows.Forms.CheckBox checkBoxMedal;
        private System.Windows.Forms.Label labelCity;
        private System.Windows.Forms.TextBox textBoxCity;
        private System.Windows.Forms.Label labelStreet;
        private System.Windows.Forms.TextBox textBoxStreet;
        private System.Windows.Forms.Label labelHouseNumber;
        private System.Windows.Forms.TextBox textBoxHouseNumber;
        private System.Windows.Forms.Label labelPhone;
        private System.Windows.Forms.TextBox textBoxPhone;
        private System.Windows.Forms.Label labelSpeciality;
        private System.Windows.Forms.ComboBox comboBoxSpecialities;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.DataGridView dataGridViewSubjects;
        private System.Windows.Forms.Button buttonAddGrade;
        private Label labelBenefitType;
        private ComboBox comboBoxBenefitType;
        private Label labelBenefitDocument;
        private TextBox textBoxBenefitDocument;
        private Label labelBenefitIssuedBy;
        private TextBox textBoxBenefitIssuedBy;
        private DateTimePicker dateTimePickerBenefitDate;
        private Label labelBenefitDate;
    }
}