namespace _04_Single_Responsability
{
    partial class System
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private global::System.ComponentModel.IContainer components = null;

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
            listBoxEmployees = new ListBox();
            panel1 = new Panel();
            tbName = new TextBox();
            lblName = new Label();
            tbEmail = new TextBox();
            lblEmail = new Label();
            tbPosition = new TextBox();
            lblPosition = new Label();
            btnSaveEmployee = new Button();
            iptHourSalary = new NumericUpDown();
            label1 = new Label();
            btnCalculate = new Button();
            iptHoursWorked = new NumericUpDown();
            lblHoursWorked = new Label();
            pnlEmail = new Panel();
            lblBody = new Label();
            tbBody = new TextBox();
            lblSubject = new Label();
            tbSubject = new TextBox();
            btnMail = new Button();
            panel1.SuspendLayout();
            ((global::System.ComponentModel.ISupportInitialize)iptHourSalary).BeginInit();
            ((global::System.ComponentModel.ISupportInitialize)iptHoursWorked).BeginInit();
            pnlEmail.SuspendLayout();
            SuspendLayout();
            // 
            // listBoxEmployees
            // 
            listBoxEmployees.FormattingEnabled = true;
            listBoxEmployees.Location = new Point(12, 12);
            listBoxEmployees.Name = "listBoxEmployees";
            listBoxEmployees.Size = new Size(392, 164);
            listBoxEmployees.TabIndex = 0;
            listBoxEmployees.SelectedIndexChanged += listBoxEmployees_SelectedIndexChanged;
            // 
            // panel1
            // 
            panel1.Controls.Add(tbName);
            panel1.Controls.Add(lblName);
            panel1.Controls.Add(tbEmail);
            panel1.Controls.Add(lblEmail);
            panel1.Controls.Add(tbPosition);
            panel1.Controls.Add(lblPosition);
            panel1.Controls.Add(btnSaveEmployee);
            panel1.Controls.Add(iptHourSalary);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(btnCalculate);
            panel1.Controls.Add(iptHoursWorked);
            panel1.Controls.Add(lblHoursWorked);
            panel1.Location = new Point(12, 182);
            panel1.Name = "panel1";
            panel1.Size = new Size(392, 197);
            panel1.TabIndex = 8;
            // 
            // tbName
            // 
            tbName.Location = new Point(128, 14);
            tbName.Name = "tbName";
            tbName.Size = new Size(258, 27);
            tbName.TabIndex = 19;
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Location = new Point(3, 21);
            lblName.Name = "lblName";
            lblName.Size = new Size(64, 20);
            lblName.TabIndex = 20;
            lblName.Text = "Nombre";
            // 
            // tbEmail
            // 
            tbEmail.Location = new Point(128, 47);
            tbEmail.Name = "tbEmail";
            tbEmail.Size = new Size(258, 27);
            tbEmail.TabIndex = 17;
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Location = new Point(3, 54);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(46, 20);
            lblEmail.TabIndex = 18;
            lblEmail.Text = "Email";
            // 
            // tbPosition
            // 
            tbPosition.Location = new Point(128, 82);
            tbPosition.Name = "tbPosition";
            tbPosition.Size = new Size(258, 27);
            tbPosition.TabIndex = 15;
            // 
            // lblPosition
            // 
            lblPosition.AutoSize = true;
            lblPosition.Location = new Point(4, 89);
            lblPosition.Name = "lblPosition";
            lblPosition.Size = new Size(63, 20);
            lblPosition.TabIndex = 14;
            lblPosition.Text = "Posición";
            // 
            // btnSaveEmployee
            // 
            btnSaveEmployee.Location = new Point(284, 125);
            btnSaveEmployee.Name = "btnSaveEmployee";
            btnSaveEmployee.Size = new Size(102, 27);
            btnSaveEmployee.TabIndex = 13;
            btnSaveEmployee.Text = "Cargar";
            btnSaveEmployee.UseVisualStyleBackColor = true;
            btnSaveEmployee.Click += btnSaveEmployee_Click;
            // 
            // iptHourSalary
            // 
            iptHourSalary.DecimalPlaces = 2;
            iptHourSalary.ImeMode = ImeMode.Off;
            iptHourSalary.Increment = new decimal(new int[] { 100, 0, 0, 0 });
            iptHourSalary.Location = new Point(128, 125);
            iptHourSalary.Maximum = new decimal(new int[] { 1000000, 0, 0, 0 });
            iptHourSalary.Minimum = new decimal(new int[] { 100, 0, 0, 0 });
            iptHourSalary.Name = "iptHourSalary";
            iptHourSalary.Size = new Size(150, 27);
            iptHourSalary.TabIndex = 12;
            iptHourSalary.TextAlign = HorizontalAlignment.Right;
            iptHourSalary.ThousandsSeparator = true;
            iptHourSalary.Value = new decimal(new int[] { 100, 0, 0, 0 });
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(3, 125);
            label1.Name = "label1";
            label1.Size = new Size(116, 20);
            label1.TabIndex = 11;
            label1.Text = "Salario por hora";
            // 
            // btnCalculate
            // 
            btnCalculate.Location = new Point(284, 162);
            btnCalculate.Name = "btnCalculate";
            btnCalculate.Size = new Size(102, 27);
            btnCalculate.TabIndex = 9;
            btnCalculate.Text = "Cargar";
            btnCalculate.UseVisualStyleBackColor = true;
            btnCalculate.Click += btnCalculate_Click;
            // 
            // iptHoursWorked
            // 
            iptHoursWorked.Location = new Point(128, 162);
            iptHoursWorked.Maximum = new decimal(new int[] { 10000, 0, 0, 0 });
            iptHoursWorked.Name = "iptHoursWorked";
            iptHoursWorked.Size = new Size(150, 27);
            iptHoursWorked.TabIndex = 10;
            iptHoursWorked.TextAlign = HorizontalAlignment.Right;
            // 
            // lblHoursWorked
            // 
            lblHoursWorked.AutoSize = true;
            lblHoursWorked.Location = new Point(3, 165);
            lblHoursWorked.Name = "lblHoursWorked";
            lblHoursWorked.Size = new Size(122, 20);
            lblHoursWorked.TabIndex = 9;
            lblHoursWorked.Text = "Horas trabajadas";
            // 
            // pnlEmail
            // 
            pnlEmail.Controls.Add(lblBody);
            pnlEmail.Controls.Add(tbBody);
            pnlEmail.Controls.Add(lblSubject);
            pnlEmail.Controls.Add(tbSubject);
            pnlEmail.Controls.Add(btnMail);
            pnlEmail.Location = new Point(12, 385);
            pnlEmail.Name = "pnlEmail";
            pnlEmail.Size = new Size(392, 217);
            pnlEmail.TabIndex = 7;
            // 
            // lblBody
            // 
            lblBody.AutoSize = true;
            lblBody.Location = new Point(3, 48);
            lblBody.Name = "lblBody";
            lblBody.Size = new Size(67, 20);
            lblBody.TabIndex = 8;
            lblBody.Text = "Mensaje:";
            // 
            // tbBody
            // 
            tbBody.Location = new Point(4, 71);
            tbBody.Multiline = true;
            tbBody.Name = "tbBody";
            tbBody.Size = new Size(382, 108);
            tbBody.TabIndex = 7;
            // 
            // lblSubject
            // 
            lblSubject.AutoSize = true;
            lblSubject.Location = new Point(3, 21);
            lblSubject.Name = "lblSubject";
            lblSubject.Size = new Size(58, 20);
            lblSubject.TabIndex = 6;
            lblSubject.Text = "Asunto:";
            // 
            // tbSubject
            // 
            tbSubject.Location = new Point(67, 18);
            tbSubject.Name = "tbSubject";
            tbSubject.Size = new Size(261, 27);
            tbSubject.TabIndex = 5;
            // 
            // btnMail
            // 
            btnMail.Location = new Point(255, 185);
            btnMail.Name = "btnMail";
            btnMail.Size = new Size(137, 29);
            btnMail.TabIndex = 4;
            btnMail.Text = "Enviar email";
            btnMail.UseVisualStyleBackColor = true;
            btnMail.Click += btnMail_Click;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(415, 615);
            Controls.Add(panel1);
            Controls.Add(pnlEmail);
            Controls.Add(listBoxEmployees);
            Name = "Form2";
            Text = "Form2";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((global::System.ComponentModel.ISupportInitialize)iptHourSalary).EndInit();
            ((global::System.ComponentModel.ISupportInitialize)iptHoursWorked).EndInit();
            pnlEmail.ResumeLayout(false);
            pnlEmail.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private ListBox listBoxEmployees;
        private Panel panel1;
        private TextBox tbName;
        private Label lblName;
        private TextBox tbEmail;
        private Label lblEmail;
        private TextBox tbPosition;
        private Label lblPosition;
        private Button btnSaveEmployee;
        private NumericUpDown iptHourSalary;
        private Label label1;
        private Button btnCalculate;
        private NumericUpDown iptHoursWorked;
        private Label lblHoursWorked;
        private Panel pnlEmail;
        private Label lblBody;
        private TextBox tbBody;
        private Label lblSubject;
        private TextBox tbSubject;
        private Button btnMail;
    }
}