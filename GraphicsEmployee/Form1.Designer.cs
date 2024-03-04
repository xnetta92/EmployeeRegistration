namespace GraphicsEmployee
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
            this.listBox_employees = new System.Windows.Forms.ListBox();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox_employe = new System.Windows.Forms.GroupBox();
            this.label_id = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label_name = new System.Windows.Forms.Label();
            this.label_salary = new System.Windows.Forms.Label();
            this.label_position = new System.Windows.Forms.Label();
            this.textBox_position = new System.Windows.Forms.TextBox();
            this.textBox_name = new System.Windows.Forms.TextBox();
            this.numericUpDown_salary = new System.Windows.Forms.NumericUpDown();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.groupBox_employe.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_salary)).BeginInit();
            this.SuspendLayout();
            // 
            // listBox_employees
            // 
            this.listBox_employees.Dock = System.Windows.Forms.DockStyle.Left;
            this.listBox_employees.FormattingEnabled = true;
            this.listBox_employees.Location = new System.Drawing.Point(0, 0);
            this.listBox_employees.Name = "listBox_employees";
            this.listBox_employees.Size = new System.Drawing.Size(344, 450);
            this.listBox_employees.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(355, 303);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(88, 30);
            this.button1.TabIndex = 1;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // groupBox_employe
            // 
            this.groupBox_employe.Controls.Add(this.numericUpDown_salary);
            this.groupBox_employe.Controls.Add(this.textBox_name);
            this.groupBox_employe.Controls.Add(this.textBox_position);
            this.groupBox_employe.Controls.Add(this.textBox1);
            this.groupBox_employe.Controls.Add(this.label_position);
            this.groupBox_employe.Controls.Add(this.label_salary);
            this.groupBox_employe.Controls.Add(this.label_name);
            this.groupBox_employe.Controls.Add(this.label_id);
            this.groupBox_employe.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox_employe.Location = new System.Drawing.Point(344, 0);
            this.groupBox_employe.Name = "groupBox_employe";
            this.groupBox_employe.Size = new System.Drawing.Size(456, 229);
            this.groupBox_employe.TabIndex = 2;
            this.groupBox_employe.TabStop = false;
            this.groupBox_employe.Text = "groupBox1";
            // 
            // label_id
            // 
            this.label_id.AutoSize = true;
            this.label_id.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_id.Location = new System.Drawing.Point(31, 30);
            this.label_id.Name = "label_id";
            this.label_id.Size = new System.Drawing.Size(19, 18);
            this.label_id.TabIndex = 0;
            this.label_id.Text = "Id";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(69, 28);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(169, 20);
            this.textBox1.TabIndex = 1;
            // 
            // label_name
            // 
            this.label_name.AutoSize = true;
            this.label_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_name.Location = new System.Drawing.Point(8, 66);
            this.label_name.Name = "label_name";
            this.label_name.Size = new System.Drawing.Size(44, 16);
            this.label_name.TabIndex = 0;
            this.label_name.Text = "Name";
            // 
            // label_salary
            // 
            this.label_salary.AutoSize = true;
            this.label_salary.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_salary.Location = new System.Drawing.Point(8, 100);
            this.label_salary.Name = "label_salary";
            this.label_salary.Size = new System.Drawing.Size(46, 16);
            this.label_salary.TabIndex = 0;
            this.label_salary.Text = "Salary";
            this.label_salary.Click += new System.EventHandler(this.label2_Click);
            // 
            // label_position
            // 
            this.label_position.AutoSize = true;
            this.label_position.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_position.Location = new System.Drawing.Point(8, 132);
            this.label_position.Name = "label_position";
            this.label_position.Size = new System.Drawing.Size(55, 16);
            this.label_position.TabIndex = 0;
            this.label_position.Text = "Position";
            // 
            // textBox_position
            // 
            this.textBox_position.Location = new System.Drawing.Point(69, 128);
            this.textBox_position.Name = "textBox_position";
            this.textBox_position.Size = new System.Drawing.Size(169, 20);
            this.textBox_position.TabIndex = 1;
            // 
            // textBox_name
            // 
            this.textBox_name.Location = new System.Drawing.Point(69, 66);
            this.textBox_name.Name = "textBox_name";
            this.textBox_name.Size = new System.Drawing.Size(169, 20);
            this.textBox_name.TabIndex = 1;
            // 
            // numericUpDown_salary
            // 
            this.numericUpDown_salary.Location = new System.Drawing.Point(69, 100);
            this.numericUpDown_salary.Maximum = new decimal(new int[] {
            20000,
            0,
            0,
            0});
            this.numericUpDown_salary.Name = "numericUpDown_salary";
            this.numericUpDown_salary.Size = new System.Drawing.Size(169, 20);
            this.numericUpDown_salary.TabIndex = 2;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(462, 303);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(88, 30);
            this.button2.TabIndex = 1;
            this.button2.Text = "button1";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(576, 303);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(88, 30);
            this.button3.TabIndex = 1;
            this.button3.Text = "button1";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(684, 303);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(88, 30);
            this.button4.TabIndex = 1;
            this.button4.Text = "button1";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox_employe);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.listBox_employees);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox_employe.ResumeLayout(false);
            this.groupBox_employe.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_salary)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listBox_employees;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox_employe;
        private System.Windows.Forms.Label label_id;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label_position;
        private System.Windows.Forms.Label label_salary;
        private System.Windows.Forms.Label label_name;
        private System.Windows.Forms.NumericUpDown numericUpDown_salary;
        private System.Windows.Forms.TextBox textBox_name;
        private System.Windows.Forms.TextBox textBox_position;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
    }
}

