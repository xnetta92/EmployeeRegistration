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
            this.button_new = new System.Windows.Forms.Button();
            this.groupBox_employe = new System.Windows.Forms.GroupBox();
            this.numericUpDown_salary = new System.Windows.Forms.NumericUpDown();
            this.textBox_name = new System.Windows.Forms.TextBox();
            this.textBox_position = new System.Windows.Forms.TextBox();
            this.textBox_id = new System.Windows.Forms.TextBox();
            this.label_position = new System.Windows.Forms.Label();
            this.label_salary = new System.Windows.Forms.Label();
            this.label_name = new System.Windows.Forms.Label();
            this.label_id = new System.Windows.Forms.Label();
            this.button_read = new System.Windows.Forms.Button();
            this.button_edit = new System.Windows.Forms.Button();
            this.button_delete = new System.Windows.Forms.Button();
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
            this.listBox_employees.SelectedIndexChanged += new System.EventHandler(this.listBox_employees_SelectedIndexChanged);
            // 
            // button_new
            // 
            this.button_new.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button_new.Location = new System.Drawing.Point(350, 350);
            this.button_new.Name = "button_new";
            this.button_new.Size = new System.Drawing.Size(88, 30);
            this.button_new.TabIndex = 1;
            this.button_new.Text = "New";
            this.button_new.UseVisualStyleBackColor = true;
            this.button_new.Click += new System.EventHandler(this.button_new_Click);
            // 
            // groupBox_employe
            // 
            this.groupBox_employe.Controls.Add(this.numericUpDown_salary);
            this.groupBox_employe.Controls.Add(this.textBox_name);
            this.groupBox_employe.Controls.Add(this.textBox_position);
            this.groupBox_employe.Controls.Add(this.textBox_id);
            this.groupBox_employe.Controls.Add(this.label_position);
            this.groupBox_employe.Controls.Add(this.label_salary);
            this.groupBox_employe.Controls.Add(this.label_name);
            this.groupBox_employe.Controls.Add(this.label_id);
            this.groupBox_employe.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox_employe.Location = new System.Drawing.Point(344, 0);
            this.groupBox_employe.Name = "groupBox_employe";
            this.groupBox_employe.Size = new System.Drawing.Size(456, 295);
            this.groupBox_employe.TabIndex = 2;
            this.groupBox_employe.TabStop = false;
            this.groupBox_employe.Text = "groupBox1";
            // 
            // numericUpDown_salary
            // 
            this.numericUpDown_salary.Location = new System.Drawing.Point(123, 166);
            this.numericUpDown_salary.Maximum = new decimal(new int[] {
            20000,
            0,
            0,
            0});
            this.numericUpDown_salary.Name = "numericUpDown_salary";
            this.numericUpDown_salary.Size = new System.Drawing.Size(142, 20);
            this.numericUpDown_salary.TabIndex = 2;
            this.numericUpDown_salary.ThousandsSeparator = true;
            // 
            // textBox_name
            // 
            this.textBox_name.Location = new System.Drawing.Point(123, 108);
            this.textBox_name.Name = "textBox_name";
            this.textBox_name.Size = new System.Drawing.Size(251, 20);
            this.textBox_name.TabIndex = 1;
            // 
            // textBox_position
            // 
            this.textBox_position.Location = new System.Drawing.Point(123, 232);
            this.textBox_position.Name = "textBox_position";
            this.textBox_position.Size = new System.Drawing.Size(251, 20);
            this.textBox_position.TabIndex = 1;
            // 
            // textBox_id
            // 
            this.textBox_id.Location = new System.Drawing.Point(123, 49);
            this.textBox_id.Name = "textBox_id";
            this.textBox_id.Size = new System.Drawing.Size(142, 20);
            this.textBox_id.TabIndex = 1;
            // 
            // label_position
            // 
            this.label_position.AutoSize = true;
            this.label_position.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_position.Location = new System.Drawing.Point(31, 236);
            this.label_position.Name = "label_position";
            this.label_position.Size = new System.Drawing.Size(55, 16);
            this.label_position.TabIndex = 0;
            this.label_position.Text = "Position";
            // 
            // label_salary
            // 
            this.label_salary.AutoSize = true;
            this.label_salary.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_salary.Location = new System.Drawing.Point(40, 170);
            this.label_salary.Name = "label_salary";
            this.label_salary.Size = new System.Drawing.Size(46, 16);
            this.label_salary.TabIndex = 0;
            this.label_salary.Text = "Salary";
            this.label_salary.Click += new System.EventHandler(this.label2_Click);
            // 
            // label_name
            // 
            this.label_name.AutoSize = true;
            this.label_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_name.Location = new System.Drawing.Point(40, 112);
            this.label_name.Name = "label_name";
            this.label_name.Size = new System.Drawing.Size(44, 16);
            this.label_name.TabIndex = 0;
            this.label_name.Text = "Name";
            // 
            // label_id
            // 
            this.label_id.AutoSize = true;
            this.label_id.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_id.Location = new System.Drawing.Point(67, 51);
            this.label_id.Name = "label_id";
            this.label_id.Size = new System.Drawing.Size(19, 18);
            this.label_id.TabIndex = 0;
            this.label_id.Text = "Id";
            // 
            // button_read
            // 
            this.button_read.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button_read.Location = new System.Drawing.Point(467, 350);
            this.button_read.Name = "button_read";
            this.button_read.Size = new System.Drawing.Size(88, 30);
            this.button_read.TabIndex = 1;
            this.button_read.Text = "Read";
            this.button_read.UseVisualStyleBackColor = true;
            this.button_read.Click += new System.EventHandler(this.button_read_Click);
            // 
            // button_edit
            // 
            this.button_edit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button_edit.Location = new System.Drawing.Point(585, 350);
            this.button_edit.Name = "button_edit";
            this.button_edit.Size = new System.Drawing.Size(88, 30);
            this.button_edit.TabIndex = 1;
            this.button_edit.Text = "Save";
            this.button_edit.UseVisualStyleBackColor = true;
            this.button_edit.Click += new System.EventHandler(this.button_edit_Click);
            // 
            // button_delete
            // 
            this.button_delete.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button_delete.Location = new System.Drawing.Point(700, 350);
            this.button_delete.Name = "button_delete";
            this.button_delete.Size = new System.Drawing.Size(88, 30);
            this.button_delete.TabIndex = 1;
            this.button_delete.Text = "Delete";
            this.button_delete.UseVisualStyleBackColor = true;
            this.button_delete.Click += new System.EventHandler(this.button_delete_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox_employe);
            this.Controls.Add(this.button_delete);
            this.Controls.Add(this.button_edit);
            this.Controls.Add(this.button_read);
            this.Controls.Add(this.button_new);
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
        private System.Windows.Forms.Button button_new;
        private System.Windows.Forms.GroupBox groupBox_employe;
        private System.Windows.Forms.Label label_id;
        private System.Windows.Forms.TextBox textBox_id;
        private System.Windows.Forms.Label label_position;
        private System.Windows.Forms.Label label_salary;
        private System.Windows.Forms.Label label_name;
        private System.Windows.Forms.NumericUpDown numericUpDown_salary;
        private System.Windows.Forms.TextBox textBox_name;
        private System.Windows.Forms.TextBox textBox_position;
        private System.Windows.Forms.Button button_read;
        private System.Windows.Forms.Button button_edit;
        private System.Windows.Forms.Button button_delete;
    }
}

