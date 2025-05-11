namespace ApplicantRegistrationSystem.Forms
{
    partial class AddSpecialityForm
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
            labelName = new Label();
            textBoxName = new TextBox();
            buttonSave = new Button();
            SuspendLayout();
            // 
            // labelName
            // 
            labelName.AutoSize = true;
            labelName.Location = new Point(12, 15);
            labelName.Name = "labelName";
            labelName.Size = new Size(122, 20);
            labelName.TabIndex = 0;
            labelName.Text = "Название специальности";
            // 
            // textBoxName
            // 
            textBoxName.Location = new Point(200, 12);
            textBoxName.Name = "textBoxName";
            textBoxName.Size = new Size(300, 27);
            textBoxName.TabIndex = 1;
            // 
            // buttonSave
            // 
            buttonSave.Location = new Point(200, 50);
            buttonSave.Name = "buttonSave";
            buttonSave.Size = new Size(300, 40);
            buttonSave.TabIndex = 2;
            buttonSave.Text = "Сохранить";
            buttonSave.UseVisualStyleBackColor = true;
            buttonSave.Click += buttonSave_Click;
            // 
            // AddSpecialityForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(512, 100);
            Controls.Add(buttonSave);
            Controls.Add(textBoxName);
            Controls.Add(labelName);
            Name = "AddSpecialityForm";
            Text = "Добавить специальность";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelName;
        private TextBox textBoxName;
        private Button buttonSave;
    }
}