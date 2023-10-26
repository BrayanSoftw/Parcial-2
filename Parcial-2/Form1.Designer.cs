namespace Parcial_2
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.grbTipoEmpleado = new System.Windows.Forms.GroupBox();
            this.radGerente = new System.Windows.Forms.RadioButton();
            this.radAsistente = new System.Windows.Forms.RadioButton();
            this.grbDatosEmpleado = new System.Windows.Forms.GroupBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblEdad = new System.Windows.Forms.Label();
            this.lblSalario = new System.Windows.Forms.Label();
            this.lblDepartamento = new System.Windows.Forms.Label();
            this.lblHorasExtra = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtSalario = new System.Windows.Forms.TextBox();
            this.txtEdad = new System.Windows.Forms.TextBox();
            this.txtDepartamento = new System.Windows.Forms.TextBox();
            this.txtHorasExtra = new System.Windows.Forms.TextBox();
            this.btnAgregarEmpleado = new System.Windows.Forms.Button();
            this.dgvEmpleados = new System.Windows.Forms.DataGridView();
            this.btnMostrarEmpleado = new System.Windows.Forms.Button();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grbTipoEmpleado.SuspendLayout();
            this.grbDatosEmpleado.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmpleados)).BeginInit();
            this.SuspendLayout();
            // 
            // grbTipoEmpleado
            // 
            this.grbTipoEmpleado.Controls.Add(this.radAsistente);
            this.grbTipoEmpleado.Controls.Add(this.radGerente);
            this.grbTipoEmpleado.Location = new System.Drawing.Point(12, 73);
            this.grbTipoEmpleado.Name = "grbTipoEmpleado";
            this.grbTipoEmpleado.Size = new System.Drawing.Size(132, 118);
            this.grbTipoEmpleado.TabIndex = 0;
            this.grbTipoEmpleado.TabStop = false;
            this.grbTipoEmpleado.Text = "Tipo de Empleado";
            // 
            // radGerente
            // 
            this.radGerente.AutoSize = true;
            this.radGerente.Location = new System.Drawing.Point(18, 36);
            this.radGerente.Name = "radGerente";
            this.radGerente.Size = new System.Drawing.Size(63, 17);
            this.radGerente.TabIndex = 1;
            this.radGerente.TabStop = true;
            this.radGerente.Text = "Gerente";
            this.radGerente.UseVisualStyleBackColor = true;
            // 
            // radAsistente
            // 
            this.radAsistente.AutoSize = true;
            this.radAsistente.Location = new System.Drawing.Point(18, 90);
            this.radAsistente.Name = "radAsistente";
            this.radAsistente.Size = new System.Drawing.Size(68, 17);
            this.radAsistente.TabIndex = 2;
            this.radAsistente.TabStop = true;
            this.radAsistente.Text = "Asistente";
            this.radAsistente.UseVisualStyleBackColor = true;
            // 
            // grbDatosEmpleado
            // 
            this.grbDatosEmpleado.Controls.Add(this.txtHorasExtra);
            this.grbDatosEmpleado.Controls.Add(this.txtDepartamento);
            this.grbDatosEmpleado.Controls.Add(this.txtSalario);
            this.grbDatosEmpleado.Controls.Add(this.txtEdad);
            this.grbDatosEmpleado.Controls.Add(this.txtNombre);
            this.grbDatosEmpleado.Controls.Add(this.lblHorasExtra);
            this.grbDatosEmpleado.Controls.Add(this.lblNombre);
            this.grbDatosEmpleado.Controls.Add(this.lblDepartamento);
            this.grbDatosEmpleado.Controls.Add(this.lblEdad);
            this.grbDatosEmpleado.Controls.Add(this.lblSalario);
            this.grbDatosEmpleado.Location = new System.Drawing.Point(237, 73);
            this.grbDatosEmpleado.Name = "grbDatosEmpleado";
            this.grbDatosEmpleado.Size = new System.Drawing.Size(213, 178);
            this.grbDatosEmpleado.TabIndex = 1;
            this.grbDatosEmpleado.TabStop = false;
            this.grbDatosEmpleado.Text = "Datos del Empleado";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(6, 25);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(44, 13);
            this.lblNombre.TabIndex = 0;
            this.lblNombre.Text = "Nombre";
            // 
            // lblEdad
            // 
            this.lblEdad.AutoSize = true;
            this.lblEdad.Location = new System.Drawing.Point(6, 51);
            this.lblEdad.Name = "lblEdad";
            this.lblEdad.Size = new System.Drawing.Size(32, 13);
            this.lblEdad.TabIndex = 2;
            this.lblEdad.Text = "Edad";
            // 
            // lblSalario
            // 
            this.lblSalario.AutoSize = true;
            this.lblSalario.Location = new System.Drawing.Point(6, 79);
            this.lblSalario.Name = "lblSalario";
            this.lblSalario.Size = new System.Drawing.Size(39, 13);
            this.lblSalario.TabIndex = 3;
            this.lblSalario.Text = "Salario";
            // 
            // lblDepartamento
            // 
            this.lblDepartamento.AutoSize = true;
            this.lblDepartamento.Location = new System.Drawing.Point(6, 105);
            this.lblDepartamento.Name = "lblDepartamento";
            this.lblDepartamento.Size = new System.Drawing.Size(74, 13);
            this.lblDepartamento.TabIndex = 4;
            this.lblDepartamento.Text = "Departamento";
            // 
            // lblHorasExtra
            // 
            this.lblHorasExtra.AutoSize = true;
            this.lblHorasExtra.Location = new System.Drawing.Point(6, 138);
            this.lblHorasExtra.Name = "lblHorasExtra";
            this.lblHorasExtra.Size = new System.Drawing.Size(62, 13);
            this.lblHorasExtra.TabIndex = 5;
            this.lblHorasExtra.Text = "Horas Extra";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(87, 25);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(100, 20);
            this.txtNombre.TabIndex = 6;
            // 
            // txtSalario
            // 
            this.txtSalario.Location = new System.Drawing.Point(87, 79);
            this.txtSalario.Name = "txtSalario";
            this.txtSalario.Size = new System.Drawing.Size(100, 20);
            this.txtSalario.TabIndex = 6;
            // 
            // txtEdad
            // 
            this.txtEdad.Location = new System.Drawing.Point(87, 51);
            this.txtEdad.Name = "txtEdad";
            this.txtEdad.Size = new System.Drawing.Size(100, 20);
            this.txtEdad.TabIndex = 6;
            this.txtEdad.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // txtDepartamento
            // 
            this.txtDepartamento.Location = new System.Drawing.Point(87, 105);
            this.txtDepartamento.Name = "txtDepartamento";
            this.txtDepartamento.Size = new System.Drawing.Size(100, 20);
            this.txtDepartamento.TabIndex = 6;
            // 
            // txtHorasExtra
            // 
            this.txtHorasExtra.Location = new System.Drawing.Point(87, 131);
            this.txtHorasExtra.Name = "txtHorasExtra";
            this.txtHorasExtra.Size = new System.Drawing.Size(100, 20);
            this.txtHorasExtra.TabIndex = 7;
            // 
            // btnAgregarEmpleado
            // 
            this.btnAgregarEmpleado.Location = new System.Drawing.Point(612, 73);
            this.btnAgregarEmpleado.Name = "btnAgregarEmpleado";
            this.btnAgregarEmpleado.Size = new System.Drawing.Size(121, 57);
            this.btnAgregarEmpleado.TabIndex = 2;
            this.btnAgregarEmpleado.Text = "Agregar un nuevo Empleado";
            this.btnAgregarEmpleado.UseVisualStyleBackColor = true;
            this.btnAgregarEmpleado.Click += new System.EventHandler(this.btnAgregarEmpleado_Click);
            // 
            // dgvEmpleados
            // 
            this.dgvEmpleados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEmpleados.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5});
            this.dgvEmpleados.Location = new System.Drawing.Point(30, 287);
            this.dgvEmpleados.Name = "dgvEmpleados";
            this.dgvEmpleados.Size = new System.Drawing.Size(603, 170);
            this.dgvEmpleados.TabIndex = 3;
            this.dgvEmpleados.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvEmpleados_CellContentClick);
            // 
            // btnMostrarEmpleado
            // 
            this.btnMostrarEmpleado.Location = new System.Drawing.Point(609, 152);
            this.btnMostrarEmpleado.Name = "btnMostrarEmpleado";
            this.btnMostrarEmpleado.Size = new System.Drawing.Size(124, 57);
            this.btnMostrarEmpleado.TabIndex = 4;
            this.btnMostrarEmpleado.Text = "Mostrar Empleado en DGV";
            this.btnMostrarEmpleado.UseVisualStyleBackColor = true;
            this.btnMostrarEmpleado.Click += new System.EventHandler(this.btnMostrarEmpleado_Click);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Nombre";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Edad";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Salario";
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Departamento";
            this.Column4.Name = "Column4";
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Horas Extra";
            this.Column5.Name = "Column5";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(838, 487);
            this.Controls.Add(this.btnMostrarEmpleado);
            this.Controls.Add(this.dgvEmpleados);
            this.Controls.Add(this.btnAgregarEmpleado);
            this.Controls.Add(this.grbDatosEmpleado);
            this.Controls.Add(this.grbTipoEmpleado);
            this.Name = "Form1";
            this.Text = "Sistema de Gestion de Empleados";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.grbTipoEmpleado.ResumeLayout(false);
            this.grbTipoEmpleado.PerformLayout();
            this.grbDatosEmpleado.ResumeLayout(false);
            this.grbDatosEmpleado.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmpleados)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grbTipoEmpleado;
        private System.Windows.Forms.RadioButton radAsistente;
        private System.Windows.Forms.RadioButton radGerente;
        private System.Windows.Forms.GroupBox grbDatosEmpleado;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblDepartamento;
        private System.Windows.Forms.Label lblEdad;
        private System.Windows.Forms.Label lblSalario;
        private System.Windows.Forms.Label lblHorasExtra;
        private System.Windows.Forms.TextBox txtHorasExtra;
        private System.Windows.Forms.TextBox txtDepartamento;
        private System.Windows.Forms.TextBox txtSalario;
        private System.Windows.Forms.TextBox txtEdad;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Button btnAgregarEmpleado;
        private System.Windows.Forms.DataGridView dgvEmpleados;
        private System.Windows.Forms.Button btnMostrarEmpleado;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
    }
}

