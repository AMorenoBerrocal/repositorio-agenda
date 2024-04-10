namespace AgendaBeca
{
    partial class Form1
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
            groupBox1 = new GroupBox();
            label2 = new Label();
            id = new Label();
            label1 = new Label();
            label3 = new Label();
            label4 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            dateTimePicker1 = new DateTimePicker();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(dateTimePicker1);
            groupBox1.Controls.Add(textBox4);
            groupBox1.Controls.Add(textBox3);
            groupBox1.Controls.Add(textBox2);
            groupBox1.Controls.Add(textBox1);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(id);
            groupBox1.Location = new Point(90, 60);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(698, 316);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Contacto:";
            groupBox1.Enter += groupBox1_Enter;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(19, 64);
            label2.Name = "label2";
            label2.Size = new Size(82, 25);
            label2.TabIndex = 1;
            label2.Text = "Nombre:";
            label2.Click += label2_Click;
            // 
            // id
            // 
            id.AutoSize = true;
            id.Location = new Point(19, 32);
            id.Name = "id";
            id.Size = new Size(32, 25);
            id.TabIndex = 0;
            id.Text = "Id:";
            id.Click += label1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(19, 99);
            label1.Name = "label1";
            label1.Size = new Size(156, 25);
            label1.TabIndex = 2;
            label1.Text = "Fecha Nacimiento:";
            label1.Click += label1_Click_1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(19, 131);
            label3.Name = "label3";
            label3.Size = new Size(79, 25);
            label3.TabIndex = 3;
            label3.Text = "Teléfono";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(19, 167);
            label4.Name = "label4";
            label4.Size = new Size(132, 25);
            label4.TabIndex = 1;
            label4.Text = "Observaciones:";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(245, 26);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(150, 31);
            textBox1.TabIndex = 4;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(245, 64);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(150, 31);
            textBox2.TabIndex = 5;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(245, 136);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(150, 31);
            textBox3.TabIndex = 6;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(245, 178);
            textBox4.Multiline = true;
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(360, 113);
            textBox4.TabIndex = 7;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Format = DateTimePickerFormat.Short;
            dateTimePicker1.Location = new Point(244, 99);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(150, 31);
            dateTimePicker1.TabIndex = 8;
            dateTimePicker1.ValueChanged += dateTimePicker1_ValueChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(groupBox1);
            Name = "Form1";
            Text = "Form1";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Label label2;
        private Label id;
        private Label label1;
        private Label label4;
        private Label label3;
        private TextBox textBox1;
        private TextBox textBox3;
        private TextBox textBox2;
        private DateTimePicker dateTimePicker1;
        private TextBox textBox4;
    }
}
