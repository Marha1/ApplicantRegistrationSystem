namespace ApplicantRegistrationSystem
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPageAbiturients;
        private System.Windows.Forms.DataGridView dataGridViewAbiturients;
        private System.Windows.Forms.Button buttonAddAbiturient;
        private System.Windows.Forms.TabPage tabPageSpecialities;
        private System.Windows.Forms.DataGridView dataGridViewSpecialities;
        private System.Windows.Forms.Button buttonAddSpeciality;
        private System.Windows.Forms.TabPage tabPageSubjects;
        private System.Windows.Forms.DataGridView dataGridViewSubjects;
        private System.Windows.Forms.Button buttonAddSubject;
        private System.Windows.Forms.DataGridViewButtonColumn editButton;
        private System.Windows.Forms.DataGridViewButtonColumn viewButton;
        private System.Windows.Forms.DataGridViewButtonColumn deleteButton;
        private System.Windows.Forms.DataGridViewButtonColumn deleteButtons;
        private System.Windows.Forms.DataGridViewButtonColumn viewButtonColumn;
        private System.Windows.Forms.Panel panelHeader;
        private System.Windows.Forms.Label labelTitle;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panelHeader = new System.Windows.Forms.Panel();
            this.labelTitle = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPageAbiturients = new System.Windows.Forms.TabPage();
            this.dataGridViewAbiturients = new System.Windows.Forms.DataGridView();
            this.editButton = new System.Windows.Forms.DataGridViewButtonColumn();
            this.viewButton = new System.Windows.Forms.DataGridViewButtonColumn();
            this.deleteButton = new System.Windows.Forms.DataGridViewButtonColumn();
            this.buttonAddAbiturient = new System.Windows.Forms.Button();
            this.tabPageSpecialities = new System.Windows.Forms.TabPage();
            this.dataGridViewSpecialities = new System.Windows.Forms.DataGridView();
            this.deleteButtons = new System.Windows.Forms.DataGridViewButtonColumn();
            this.viewButtonColumn = new System.Windows.Forms.DataGridViewButtonColumn();
            this.buttonAddSpeciality = new System.Windows.Forms.Button();
            this.tabPageSubjects = new System.Windows.Forms.TabPage();
            this.dataGridViewSubjects = new System.Windows.Forms.DataGridView();
            this.buttonAddSubject = new System.Windows.Forms.Button();
            this.panelHeader.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPageAbiturients.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAbiturients)).BeginInit();
            this.tabPageSpecialities.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSpecialities)).BeginInit();
            this.tabPageSubjects.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSubjects)).BeginInit();
            this.SuspendLayout();

            // panelHeader
            this.panelHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.panelHeader.Controls.Add(this.labelTitle);
            this.panelHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHeader.Location = new System.Drawing.Point(0, 0);
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.Size = new System.Drawing.Size(1000, 60);
            this.panelHeader.TabIndex = 0;

            // labelTitle
            this.labelTitle.AutoSize = true;
            this.labelTitle.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, System.Drawing.FontStyle.Bold);
            this.labelTitle.ForeColor = System.Drawing.Color.White;
            this.labelTitle.Location = new System.Drawing.Point(20, 15);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(492, 38);
            this.labelTitle.TabIndex = 0;
            this.labelTitle.Text = "Информационная система для абитуриентов";

            // tabControl1
            this.tabControl1.Controls.Add(this.tabPageAbiturients);
            this.tabControl1.Controls.Add(this.tabPageSpecialities);
            this.tabControl1.Controls.Add(this.tabPageSubjects);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.tabControl1.ItemSize = new System.Drawing.Size(120, 30);
            this.tabControl1.Location = new System.Drawing.Point(0, 60);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1000, 540);
            this.tabControl1.TabIndex = 1;

            // tabPageAbiturients
            this.tabPageAbiturients.BackColor = System.Drawing.Color.White;
            this.tabPageAbiturients.Controls.Add(this.dataGridViewAbiturients);
            this.tabPageAbiturients.Controls.Add(this.buttonAddAbiturient);
            this.tabPageAbiturients.Location = new System.Drawing.Point(4, 34);
            this.tabPageAbiturients.Name = "tabPageAbiturients";
            this.tabPageAbiturients.Padding = new System.Windows.Forms.Padding(20, 10, 20, 10);
            this.tabPageAbiturients.Size = new System.Drawing.Size(992, 502);
            this.tabPageAbiturients.TabIndex = 0;
            this.tabPageAbiturients.Text = "Абитуриенты";

            // dataGridViewAbiturients
            this.dataGridViewAbiturients.AllowUserToAddRows = false;
            this.dataGridViewAbiturients.AllowUserToDeleteRows = false;
            this.dataGridViewAbiturients.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewAbiturients.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewAbiturients.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridViewAbiturients.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dataGridViewAbiturients.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(10);
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewAbiturients.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewAbiturients.ColumnHeadersHeight = 50;
            this.dataGridViewAbiturients.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.editButton,
            this.viewButton,
            this.deleteButton});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(5);
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewAbiturients.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewAbiturients.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewAbiturients.EnableHeadersVisualStyles = false;
            this.dataGridViewAbiturients.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.dataGridViewAbiturients.Location = new System.Drawing.Point(20, 10);
            this.dataGridViewAbiturients.MultiSelect = false;
            this.dataGridViewAbiturients.Name = "dataGridViewAbiturients";
            this.dataGridViewAbiturients.ReadOnly = true;
            this.dataGridViewAbiturients.RowHeadersVisible = false;
            this.dataGridViewAbiturients.RowHeadersWidth = 62;
            this.dataGridViewAbiturients.RowTemplate.Height = 40;
            this.dataGridViewAbiturients.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewAbiturients.Size = new System.Drawing.Size(952, 402);
            this.dataGridViewAbiturients.TabIndex = 0;
            this.dataGridViewAbiturients.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewAbiturients_CellClick);
            this.dataGridViewAbiturients.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewAbiturients_CellContentClick);

            // editButton
            this.editButton.HeaderText = "Изменить";
            this.editButton.Name = "editButton";
            this.editButton.ReadOnly = true;
            this.editButton.Text = "Изменить";
            this.editButton.UseColumnTextForButtonValue = true;
            this.editButton.DefaultCellStyle.BackColor = System.Drawing.Color.LightBlue;
            this.editButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;

            // viewButton
            this.viewButton.HeaderText = "Просмотр";
            this.viewButton.Name = "viewButton";
            this.viewButton.ReadOnly = true;
            this.viewButton.Text = "Просмотр";
            this.viewButton.UseColumnTextForButtonValue = true;
            this.viewButton.DefaultCellStyle.BackColor = System.Drawing.Color.LightGreen;
            this.viewButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;

            // deleteButton
            this.deleteButton.HeaderText = "Удалить";
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.ReadOnly = true;
            this.deleteButton.Text = "Удалить";
            this.deleteButton.UseColumnTextForButtonValue = true;
            this.deleteButton.DefaultCellStyle.BackColor = System.Drawing.Color.LightCoral;
            this.deleteButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;

            // buttonAddAbiturient
            this.buttonAddAbiturient.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.buttonAddAbiturient.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.buttonAddAbiturient.FlatAppearance.BorderSize = 0;
            this.buttonAddAbiturient.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAddAbiturient.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.buttonAddAbiturient.ForeColor = System.Drawing.Color.White;
            this.buttonAddAbiturient.Location = new System.Drawing.Point(20, 412);
            this.buttonAddAbiturient.Name = "buttonAddAbiturient";
            this.buttonAddAbiturient.Size = new System.Drawing.Size(952, 80);
            this.buttonAddAbiturient.TabIndex = 1;
            this.buttonAddAbiturient.Text = "Добавить абитуриента";
            this.buttonAddAbiturient.UseVisualStyleBackColor = false;
            this.buttonAddAbiturient.Click += new System.EventHandler(this.buttonAddAbiturient_Click);

            // tabPageSpecialities
            this.tabPageSpecialities.BackColor = System.Drawing.Color.White;
            this.tabPageSpecialities.Controls.Add(this.dataGridViewSpecialities);
            this.tabPageSpecialities.Controls.Add(this.buttonAddSpeciality);
            this.tabPageSpecialities.Location = new System.Drawing.Point(4, 34);
            this.tabPageSpecialities.Name = "tabPageSpecialities";
            this.tabPageSpecialities.Padding = new System.Windows.Forms.Padding(20, 10, 20, 10);
            this.tabPageSpecialities.Size = new System.Drawing.Size(992, 502);
            this.tabPageSpecialities.TabIndex = 1;
            this.tabPageSpecialities.Text = "Специальности";

            // dataGridViewSpecialities
            this.dataGridViewSpecialities.AllowUserToAddRows = false;
            this.dataGridViewSpecialities.AllowUserToDeleteRows = false;
            this.dataGridViewSpecialities.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewSpecialities.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewSpecialities.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridViewSpecialities.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dataGridViewSpecialities.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Padding = new System.Windows.Forms.Padding(10);
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewSpecialities.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridViewSpecialities.ColumnHeadersHeight = 50;
            this.dataGridViewSpecialities.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.deleteButtons,
            this.viewButtonColumn});
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 9F);
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.Padding = new System.Windows.Forms.Padding(5);
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewSpecialities.DefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridViewSpecialities.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewSpecialities.EnableHeadersVisualStyles = false;
            this.dataGridViewSpecialities.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.dataGridViewSpecialities.Location = new System.Drawing.Point(20, 10);
            this.dataGridViewSpecialities.MultiSelect = false;
            this.dataGridViewSpecialities.Name = "dataGridViewSpecialities";
            this.dataGridViewSpecialities.ReadOnly = true;
            this.dataGridViewSpecialities.RowHeadersVisible = false;
            this.dataGridViewSpecialities.RowHeadersWidth = 62;
            this.dataGridViewSpecialities.RowTemplate.Height = 40;
            this.dataGridViewSpecialities.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewSpecialities.Size = new System.Drawing.Size(952, 402);
            this.dataGridViewSpecialities.TabIndex = 0;
            this.dataGridViewSpecialities.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewSpecialities_CellClick);

            // deleteButtons
            this.deleteButtons.HeaderText = "Удалить";
            this.deleteButtons.Name = "deleteButtons";
            this.deleteButtons.ReadOnly = true;
            this.deleteButtons.Text = "Удалить";
            this.deleteButtons.UseColumnTextForButtonValue = true;
            this.deleteButtons.DefaultCellStyle.BackColor = System.Drawing.Color.LightCoral;
            this.deleteButtons.FlatStyle = System.Windows.Forms.FlatStyle.Flat;

            // viewButtonColumn
            this.viewButtonColumn.HeaderText = "Просмотр";
            this.viewButtonColumn.Name = "viewButtonColumn";
            this.viewButtonColumn.ReadOnly = true;
            this.viewButtonColumn.Text = "Просмотр";
            this.viewButtonColumn.UseColumnTextForButtonValue = true;
            this.viewButtonColumn.DefaultCellStyle.BackColor = System.Drawing.Color.LightGreen;
            this.viewButtonColumn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;

            // buttonAddSpeciality
            this.buttonAddSpeciality.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.buttonAddSpeciality.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.buttonAddSpeciality.FlatAppearance.BorderSize = 0;
            this.buttonAddSpeciality.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAddSpeciality.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.buttonAddSpeciality.ForeColor = System.Drawing.Color.White;
            this.buttonAddSpeciality.Location = new System.Drawing.Point(20, 412);
            this.buttonAddSpeciality.Name = "buttonAddSpeciality";
            this.buttonAddSpeciality.Size = new System.Drawing.Size(952, 80);
            this.buttonAddSpeciality.TabIndex = 1;
            this.buttonAddSpeciality.Text = "Добавить специальность";
            this.buttonAddSpeciality.UseVisualStyleBackColor = false;
            this.buttonAddSpeciality.Click += new System.EventHandler(this.buttonAddSpeciality_Click);

            // tabPageSubjects
            this.tabPageSubjects.BackColor = System.Drawing.Color.White;
            this.tabPageSubjects.Controls.Add(this.dataGridViewSubjects);
            this.tabPageSubjects.Controls.Add(this.buttonAddSubject);
            this.tabPageSubjects.Location = new System.Drawing.Point(4, 34);
            this.tabPageSubjects.Name = "tabPageSubjects";
            this.tabPageSubjects.Padding = new System.Windows.Forms.Padding(20, 10, 20, 10);
            this.tabPageSubjects.Size = new System.Drawing.Size(992, 502);
            this.tabPageSubjects.TabIndex = 2;
            this.tabPageSubjects.Text = "Предметы";

            // dataGridViewSubjects
            this.dataGridViewSubjects.AllowUserToAddRows = false;
            this.dataGridViewSubjects.AllowUserToDeleteRows = false;
            this.dataGridViewSubjects.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewSubjects.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewSubjects.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridViewSubjects.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dataGridViewSubjects.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.Padding = new System.Windows.Forms.Padding(10);
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewSubjects.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dataGridViewSubjects.ColumnHeadersHeight = 50;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 9F);
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle6.Padding = new System.Windows.Forms.Padding(5);
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewSubjects.DefaultCellStyle = dataGridViewCellStyle6;
            this.dataGridViewSubjects.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewSubjects.EnableHeadersVisualStyles = false;
            this.dataGridViewSubjects.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.dataGridViewSubjects.Location = new System.Drawing.Point(20, 10);
            this.dataGridViewSubjects.MultiSelect = false;
            this.dataGridViewSubjects.Name = "dataGridViewSubjects";
            this.dataGridViewSubjects.ReadOnly = true;
            this.dataGridViewSubjects.RowHeadersVisible = false;
            this.dataGridViewSubjects.RowHeadersWidth = 62;
            this.dataGridViewSubjects.RowTemplate.Height = 40;
            this.dataGridViewSubjects.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewSubjects.Size = new System.Drawing.Size(952, 402);
            this.dataGridViewSubjects.TabIndex = 0;
            this.dataGridViewSubjects.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewSubjects_CellContentClick);

            // buttonAddSubject
            this.buttonAddSubject.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.buttonAddSubject.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.buttonAddSubject.FlatAppearance.BorderSize = 0;
            this.buttonAddSubject.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAddSubject.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.buttonAddSubject.ForeColor = System.Drawing.Color.White;
            this.buttonAddSubject.Location = new System.Drawing.Point(20, 412);
            this.buttonAddSubject.Name = "buttonAddSubject";
            this.buttonAddSubject.Size = new System.Drawing.Size(952, 80);
            this.buttonAddSubject.TabIndex = 1;
            this.buttonAddSubject.Text = "Добавить предмет";
            this.buttonAddSubject.UseVisualStyleBackColor = false;
            this.buttonAddSubject.Click += new System.EventHandler(this.buttonAddSubject_Click);

            // Form1
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1000, 600);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.panelHeader);
            this.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.MinimumSize = new System.Drawing.Size(800, 500);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Информационная система для абитуриентов";
            this.panelHeader.ResumeLayout(false);
            this.panelHeader.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPageAbiturients.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAbiturients)).EndInit();
            this.tabPageSpecialities.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSpecialities)).EndInit();
            this.tabPageSubjects.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSubjects)).EndInit();
            this.ResumeLayout(false);
        }
    }
}