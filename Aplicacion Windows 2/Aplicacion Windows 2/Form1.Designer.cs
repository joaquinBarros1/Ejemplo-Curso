namespace Aplicación_Windows_2
{
    partial class formDatosPersonales
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
            this.btnAceptar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.tboxApellido = new System.Windows.Forms.TextBox();
            this.tboxNombre = new System.Windows.Forms.TextBox();
            this.tboxEdad = new System.Windows.Forms.TextBox();
            this.tboxDireccion = new System.Windows.Forms.TextBox();
            this.tboxResultado = new System.Windows.Forms.TextBox();
            this.lbApellido = new System.Windows.Forms.Label();
            this.lbNombre = new System.Windows.Forms.Label();
            this.lbEdad = new System.Windows.Forms.Label();
            this.lbDireccion = new System.Windows.Forms.Label();
            this.lbResultado = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnAceptar
            // 
            this.btnAceptar.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnAceptar.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.btnAceptar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAceptar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnAceptar.Location = new System.Drawing.Point(73, 316);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(77, 26);
            this.btnAceptar.TabIndex = 0;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = false;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnCancelar.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.btnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnCancelar.Location = new System.Drawing.Point(303, 316);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(77, 26);
            this.btnCancelar.TabIndex = 1;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // tboxApellido
            // 
            this.tboxApellido.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tboxApellido.BackColor = System.Drawing.Color.White;
            this.tboxApellido.Location = new System.Drawing.Point(110, 32);
            this.tboxApellido.MaxLength = 15;
            this.tboxApellido.Name = "tboxApellido";
            this.tboxApellido.Size = new System.Drawing.Size(291, 20);
            this.tboxApellido.TabIndex = 2;
            // 
            // tboxNombre
            // 
            this.tboxNombre.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tboxNombre.Location = new System.Drawing.Point(110, 68);
            this.tboxNombre.MaxLength = 15;
            this.tboxNombre.Name = "tboxNombre";
            this.tboxNombre.Size = new System.Drawing.Size(291, 20);
            this.tboxNombre.TabIndex = 3;
            // 
            // tboxEdad
            // 
            this.tboxEdad.Location = new System.Drawing.Point(110, 105);
            this.tboxEdad.MaxLength = 3;
            this.tboxEdad.Name = "tboxEdad";
            this.tboxEdad.Size = new System.Drawing.Size(52, 20);
            this.tboxEdad.TabIndex = 4;
            this.tboxEdad.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tboxEdad_KeyPress);
            // 
            // tboxDireccion
            // 
            this.tboxDireccion.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tboxDireccion.Location = new System.Drawing.Point(110, 142);
            this.tboxDireccion.MaxLength = 50;
            this.tboxDireccion.Name = "tboxDireccion";
            this.tboxDireccion.Size = new System.Drawing.Size(291, 20);
            this.tboxDireccion.TabIndex = 5;
            // 
            // tboxResultado
            // 
            this.tboxResultado.Location = new System.Drawing.Point(54, 198);
            this.tboxResultado.Multiline = true;
            this.tboxResultado.Name = "tboxResultado";
            this.tboxResultado.Size = new System.Drawing.Size(347, 112);
            this.tboxResultado.TabIndex = 6;
            // 
            // lbApellido
            // 
            this.lbApellido.AutoSize = true;
            this.lbApellido.Font = new System.Drawing.Font("Bahnschrift SemiBold Condensed", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbApellido.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbApellido.Location = new System.Drawing.Point(51, 34);
            this.lbApellido.Name = "lbApellido";
            this.lbApellido.Size = new System.Drawing.Size(56, 18);
            this.lbApellido.TabIndex = 7;
            this.lbApellido.Text = "APELLIDO";
            // 
            // lbNombre
            // 
            this.lbNombre.AutoSize = true;
            this.lbNombre.Font = new System.Drawing.Font("Bahnschrift SemiBold Condensed", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNombre.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbNombre.Location = new System.Drawing.Point(51, 70);
            this.lbNombre.Name = "lbNombre";
            this.lbNombre.Size = new System.Drawing.Size(49, 18);
            this.lbNombre.TabIndex = 8;
            this.lbNombre.Text = "NOMBRE";
            // 
            // lbEdad
            // 
            this.lbEdad.AutoSize = true;
            this.lbEdad.Font = new System.Drawing.Font("Bahnschrift SemiBold Condensed", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbEdad.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbEdad.Location = new System.Drawing.Point(51, 107);
            this.lbEdad.Name = "lbEdad";
            this.lbEdad.Size = new System.Drawing.Size(33, 18);
            this.lbEdad.TabIndex = 9;
            this.lbEdad.Text = "EDAD";
            // 
            // lbDireccion
            // 
            this.lbDireccion.AutoSize = true;
            this.lbDireccion.Font = new System.Drawing.Font("Bahnschrift SemiBold Condensed", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDireccion.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbDireccion.Location = new System.Drawing.Point(51, 144);
            this.lbDireccion.Name = "lbDireccion";
            this.lbDireccion.Size = new System.Drawing.Size(59, 18);
            this.lbDireccion.TabIndex = 10;
            this.lbDireccion.Text = "DIRECCIÓN";
            // 
            // lbResultado
            // 
            this.lbResultado.AutoSize = true;
            this.lbResultado.Font = new System.Drawing.Font("Bahnschrift SemiBold Condensed", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbResultado.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbResultado.Location = new System.Drawing.Point(51, 177);
            this.lbResultado.Name = "lbResultado";
            this.lbResultado.Size = new System.Drawing.Size(64, 18);
            this.lbResultado.TabIndex = 11;
            this.lbResultado.Text = "RESULTADO";
            // 
            // formDatosPersonales
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightBlue;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(448, 354);
            this.Controls.Add(this.lbResultado);
            this.Controls.Add(this.lbDireccion);
            this.Controls.Add(this.lbEdad);
            this.Controls.Add(this.lbNombre);
            this.Controls.Add(this.lbApellido);
            this.Controls.Add(this.tboxResultado);
            this.Controls.Add(this.tboxDireccion);
            this.Controls.Add(this.tboxEdad);
            this.Controls.Add(this.tboxNombre);
            this.Controls.Add(this.tboxApellido);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnAceptar);
            this.ForeColor = System.Drawing.Color.OliveDrab;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximumSize = new System.Drawing.Size(468, 397);
            this.MinimumSize = new System.Drawing.Size(468, 397);
            this.Name = "formDatosPersonales";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Datos Personales";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.TextBox tboxApellido;
        private System.Windows.Forms.TextBox tboxNombre;
        private System.Windows.Forms.TextBox tboxEdad;
        private System.Windows.Forms.TextBox tboxDireccion;
        private System.Windows.Forms.TextBox tboxResultado;
        private System.Windows.Forms.Label lbApellido;
        private System.Windows.Forms.Label lbNombre;
        private System.Windows.Forms.Label lbEdad;
        private System.Windows.Forms.Label lbDireccion;
        private System.Windows.Forms.Label lbResultado;
    }
}

