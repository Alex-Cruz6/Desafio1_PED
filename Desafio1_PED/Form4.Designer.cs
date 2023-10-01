
namespace Desafio1_PED
{
    partial class Form4
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dgvTotalPacientes = new System.Windows.Forms.DataGridView();
            this.cmbPresion = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.BtnBuscar = new System.Windows.Forms.Button();
            this.cmbTipoSangre = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.lblMostrarEnfermedad = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbGenero = new System.Windows.Forms.ComboBox();
            this.lblInstruccion = new System.Windows.Forms.Label();
            this.chkbPresion = new System.Windows.Forms.CheckBox();
            this.chkbTipoSangre = new System.Windows.Forms.CheckBox();
            this.chkbTipoGenero = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTotalPacientes)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.MintCream;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(492, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(260, 42);
            this.label1.TabIndex = 8;
            this.label1.Text = "Ver pacientes";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.MintCream;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(12, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 42);
            this.label2.TabIndex = 9;
            this.label2.Text = "←";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // dgvTotalPacientes
            // 
            this.dgvTotalPacientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTotalPacientes.Location = new System.Drawing.Point(12, 210);
            this.dgvTotalPacientes.Name = "dgvTotalPacientes";
            this.dgvTotalPacientes.Size = new System.Drawing.Size(1017, 265);
            this.dgvTotalPacientes.TabIndex = 11;
            this.dgvTotalPacientes.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvTotalPacientes_CellContentClick);
            // 
            // cmbPresion
            // 
            this.cmbPresion.FormattingEnabled = true;
            this.cmbPresion.Items.AddRange(new object[] {
            "Alta",
            "Media",
            "Baja"});
            this.cmbPresion.Location = new System.Drawing.Point(314, 130);
            this.cmbPresion.Name = "cmbPresion";
            this.cmbPresion.Size = new System.Drawing.Size(121, 21);
            this.cmbPresion.TabIndex = 12;
            this.cmbPresion.Text = "Selecciona Presión";
            this.cmbPresion.SelectedIndexChanged += new System.EventHandler(this.cmbPresion_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.MintCream;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(311, 92);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 18);
            this.label4.TabIndex = 14;
            this.label4.Text = "Presion";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // BtnBuscar
            // 
            this.BtnBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnBuscar.Location = new System.Drawing.Point(701, 112);
            this.BtnBuscar.Name = "BtnBuscar";
            this.BtnBuscar.Size = new System.Drawing.Size(175, 51);
            this.BtnBuscar.TabIndex = 15;
            this.BtnBuscar.Text = "Buscar paciente";
            this.BtnBuscar.UseVisualStyleBackColor = true;
            this.BtnBuscar.Click += new System.EventHandler(this.BtnBuscar_Click);
            // 
            // cmbTipoSangre
            // 
            this.cmbTipoSangre.FormattingEnabled = true;
            this.cmbTipoSangre.Items.AddRange(new object[] {
            "A+",
            "O+",
            "O-",
            "B-",
            "A--",
            "B+",
            "AB+"});
            this.cmbTipoSangre.Location = new System.Drawing.Point(85, 130);
            this.cmbTipoSangre.Name = "cmbTipoSangre";
            this.cmbTipoSangre.Size = new System.Drawing.Size(171, 21);
            this.cmbTipoSangre.TabIndex = 16;
            this.cmbTipoSangre.Text = "Seleccionar un tipo de sangre";
            this.cmbTipoSangre.SelectedIndexChanged += new System.EventHandler(this.cmbTipoSangre_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.MintCream;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(82, 92);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(108, 18);
            this.label5.TabIndex = 17;
            this.label5.Text = "Tipo de Sangre";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // lblMostrarEnfermedad
            // 
            this.lblMostrarEnfermedad.AutoSize = true;
            this.lblMostrarEnfermedad.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMostrarEnfermedad.ForeColor = System.Drawing.Color.Black;
            this.lblMostrarEnfermedad.Location = new System.Drawing.Point(16, 487);
            this.lblMostrarEnfermedad.Name = "lblMostrarEnfermedad";
            this.lblMostrarEnfermedad.Size = new System.Drawing.Size(0, 25);
            this.lblMostrarEnfermedad.TabIndex = 18;
            this.lblMostrarEnfermedad.Click += new System.EventHandler(this.lblMostrarEnfermedad_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.MintCream;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(480, 92);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 18);
            this.label3.TabIndex = 20;
            this.label3.Text = "Genero";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // cmbGenero
            // 
            this.cmbGenero.FormattingEnabled = true;
            this.cmbGenero.Items.AddRange(new object[] {
            "Masculino",
            "Femenino"});
            this.cmbGenero.Location = new System.Drawing.Point(483, 130);
            this.cmbGenero.Name = "cmbGenero";
            this.cmbGenero.Size = new System.Drawing.Size(171, 21);
            this.cmbGenero.TabIndex = 19;
            this.cmbGenero.Text = "Selecciona un genero";
            this.cmbGenero.SelectedIndexChanged += new System.EventHandler(this.cmbGenero_SelectedIndexChanged);
            // 
            // lblInstruccion
            // 
            this.lblInstruccion.AutoSize = true;
            this.lblInstruccion.BackColor = System.Drawing.Color.MintCream;
            this.lblInstruccion.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInstruccion.ForeColor = System.Drawing.Color.Black;
            this.lblInstruccion.Location = new System.Drawing.Point(180, 46);
            this.lblInstruccion.Name = "lblInstruccion";
            this.lblInstruccion.Size = new System.Drawing.Size(190, 24);
            this.lblInstruccion.TabIndex = 21;
            this.lblInstruccion.Text = "Elige un tipo de filtro: ";
            this.lblInstruccion.Click += new System.EventHandler(this.lblInstruccion_Click);
            // 
            // chkbPresion
            // 
            this.chkbPresion.AutoSize = true;
            this.chkbPresion.Location = new System.Drawing.Point(314, 166);
            this.chkbPresion.Name = "chkbPresion";
            this.chkbPresion.Size = new System.Drawing.Size(84, 17);
            this.chkbPresion.TabIndex = 22;
            this.chkbPresion.Text = "Activar Filtro";
            this.chkbPresion.UseVisualStyleBackColor = true;
            this.chkbPresion.CheckedChanged += new System.EventHandler(this.chkbPresion_CheckedChanged);
            // 
            // chkbTipoSangre
            // 
            this.chkbTipoSangre.AutoSize = true;
            this.chkbTipoSangre.Location = new System.Drawing.Point(85, 166);
            this.chkbTipoSangre.Name = "chkbTipoSangre";
            this.chkbTipoSangre.Size = new System.Drawing.Size(84, 17);
            this.chkbTipoSangre.TabIndex = 23;
            this.chkbTipoSangre.Text = "Activar Filtro";
            this.chkbTipoSangre.UseVisualStyleBackColor = true;
            this.chkbTipoSangre.CheckedChanged += new System.EventHandler(this.chkbTipoSangre_CheckedChanged);
            // 
            // chkbTipoGenero
            // 
            this.chkbTipoGenero.AutoSize = true;
            this.chkbTipoGenero.Location = new System.Drawing.Point(483, 166);
            this.chkbTipoGenero.Name = "chkbTipoGenero";
            this.chkbTipoGenero.Size = new System.Drawing.Size(84, 17);
            this.chkbTipoGenero.TabIndex = 24;
            this.chkbTipoGenero.Text = "Activar Filtro";
            this.chkbTipoGenero.UseVisualStyleBackColor = true;
            this.chkbTipoGenero.CheckedChanged += new System.EventHandler(this.chkbTipoGenero_CheckedChanged);
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MintCream;
            this.ClientSize = new System.Drawing.Size(1041, 552);
            this.Controls.Add(this.chkbTipoGenero);
            this.Controls.Add(this.chkbTipoSangre);
            this.Controls.Add(this.chkbPresion);
            this.Controls.Add(this.lblInstruccion);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cmbGenero);
            this.Controls.Add(this.lblMostrarEnfermedad);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cmbTipoSangre);
            this.Controls.Add(this.BtnBuscar);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cmbPresion);
            this.Controls.Add(this.dgvTotalPacientes);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form4";
            this.Text = "Ver pacientes";
            this.Load += new System.EventHandler(this.Form4_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTotalPacientes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgvTotalPacientes;
        private System.Windows.Forms.ComboBox cmbPresion;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button BtnBuscar;
        private System.Windows.Forms.ComboBox cmbTipoSangre;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblMostrarEnfermedad;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbGenero;
        private System.Windows.Forms.Label lblInstruccion;
        private System.Windows.Forms.CheckBox chkbPresion;
        private System.Windows.Forms.CheckBox chkbTipoSangre;
        private System.Windows.Forms.CheckBox chkbTipoGenero;
    }
}