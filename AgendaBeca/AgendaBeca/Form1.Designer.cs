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
            components = new System.ComponentModel.Container();
            groupBox1 = new GroupBox();
            imagen = new PictureBox();
            txtFechaNacimiento = new DateTimePicker();
            txtObservaciones = new TextBox();
            txtTelefono = new TextBox();
            txtNombre = new TextBox();
            txtId = new TextBox();
            label4 = new Label();
            label3 = new Label();
            label1 = new Label();
            label2 = new Label();
            id = new Label();
            aniadir = new Button();
            viewContactos = new DataGridView();
            Eliminar = new Button();
            Modificar = new Button();
            Guardar = new Button();
            Cancelar = new Button();
            contextMenuStrip1 = new ContextMenuStrip(components);
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)imagen).BeginInit();
            ((System.ComponentModel.ISupportInitialize)viewContactos).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(imagen);
            groupBox1.Controls.Add(txtFechaNacimiento);
            groupBox1.Controls.Add(txtObservaciones);
            groupBox1.Controls.Add(txtTelefono);
            groupBox1.Controls.Add(txtNombre);
            groupBox1.Controls.Add(txtId);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(id);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(843, 316);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Contacto:";
            groupBox1.Enter += groupBox1_Enter;
            // 
            // imagen
            // 
            imagen.Location = new Point(617, 30);
            imagen.Name = "imagen";
            imagen.Size = new Size(198, 267);
            imagen.SizeMode = PictureBoxSizeMode.Zoom;
            imagen.TabIndex = 9;
            imagen.TabStop = false;
            imagen.Click += imagen_Click;
            // 
            // txtFechaNacimiento
            // 
            txtFechaNacimiento.Format = DateTimePickerFormat.Short;
            txtFechaNacimiento.Location = new Point(244, 99);
            txtFechaNacimiento.Name = "txtFechaNacimiento";
            txtFechaNacimiento.Size = new Size(150, 31);
            txtFechaNacimiento.TabIndex = 8;
            txtFechaNacimiento.ValueChanged += dateTimePicker1_ValueChanged;
            // 
            // txtObservaciones
            // 
            txtObservaciones.Location = new Point(245, 184);
            txtObservaciones.Multiline = true;
            txtObservaciones.Name = "txtObservaciones";
            txtObservaciones.Size = new Size(336, 113);
            txtObservaciones.TabIndex = 7;
            txtObservaciones.TextChanged += txtObservaciones_TextChanged;
            // 
            // txtTelefono
            // 
            txtTelefono.Location = new Point(245, 136);
            txtTelefono.Name = "txtTelefono";
            txtTelefono.Size = new Size(150, 31);
            txtTelefono.TabIndex = 6;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(245, 64);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(150, 31);
            txtNombre.TabIndex = 5;
            // 
            // txtId
            // 
            txtId.Location = new Point(245, 26);
            txtId.Name = "txtId";
            txtId.Size = new Size(150, 31);
            txtId.TabIndex = 4;
            txtId.TextChanged += textBox1_TextChanged;
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
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(19, 131);
            label3.Name = "label3";
            label3.Size = new Size(79, 25);
            label3.TabIndex = 3;
            label3.Text = "Teléfono";
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
            // aniadir
            // 
            aniadir.Location = new Point(28, 351);
            aniadir.Name = "aniadir";
            aniadir.Size = new Size(112, 34);
            aniadir.TabIndex = 1;
            aniadir.Text = "Nuevo";
            aniadir.UseVisualStyleBackColor = true;
            aniadir.Click += aniadir_Click;
            // 
            // viewContactos
            // 
            viewContactos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            viewContactos.Location = new Point(28, 426);
            viewContactos.Name = "viewContactos";
            viewContactos.RowHeadersWidth = 62;
            viewContactos.RowTemplate.Height = 33;
            viewContactos.Size = new Size(1029, 273);
            viewContactos.TabIndex = 2;
            viewContactos.CellContentClick += dataGridView1_CellContentClick_1;
            // 
            // Eliminar
            // 
            Eliminar.Location = new Point(183, 351);
            Eliminar.Name = "Eliminar";
            Eliminar.Size = new Size(112, 34);
            Eliminar.TabIndex = 3;
            Eliminar.Text = "Eliminar";
            Eliminar.UseVisualStyleBackColor = true;
            Eliminar.Click += Eliminar_Click;
            // 
            // Modificar
            // 
            Modificar.Location = new Point(353, 351);
            Modificar.Name = "Modificar";
            Modificar.Size = new Size(112, 34);
            Modificar.TabIndex = 4;
            Modificar.Text = "Modificar";
            Modificar.UseVisualStyleBackColor = true;
            Modificar.Click += Modificar_Click;
            // 
            // Guardar
            // 
            Guardar.Location = new Point(612, 351);
            Guardar.Name = "Guardar";
            Guardar.Size = new Size(112, 34);
            Guardar.TabIndex = 5;
            Guardar.Text = "Guardar";
            Guardar.UseVisualStyleBackColor = true;
            Guardar.Click += Guardar_Click;
            // 
            // Cancelar
            // 
            Cancelar.Location = new Point(746, 351);
            Cancelar.Name = "Cancelar";
            Cancelar.Size = new Size(112, 34);
            Cancelar.TabIndex = 6;
            Cancelar.Text = "Cancelar";
            Cancelar.UseVisualStyleBackColor = true;
            Cancelar.Click += Cancelar_Click;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.ImageScalingSize = new Size(24, 24);
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(241, 37);
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1150, 734);
            Controls.Add(Cancelar);
            Controls.Add(Guardar);
            Controls.Add(Modificar);
            Controls.Add(Eliminar);
            Controls.Add(viewContactos);
            Controls.Add(aniadir);
            Controls.Add(groupBox1);
            Name = "Form1";
            Text = "Form1";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)imagen).EndInit();
            ((System.ComponentModel.ISupportInitialize)viewContactos).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Label label2;
        private Label id;
        private Label label1;
        private Label label4;
        private Label label3;
        private TextBox txtId;
        private TextBox txtTelefono;
        private TextBox txtNombre;
        private DateTimePicker txtFechaNacimiento;
        private TextBox txtObservaciones;
        private Button aniadir;
        private DataGridView viewContactos;
        private Button Eliminar;
        private Button Modificar;
        private Button Guardar;
        private Button Cancelar;
        private PictureBox imagen;
        private ContextMenuStrip contextMenuStrip1;
    }
}
