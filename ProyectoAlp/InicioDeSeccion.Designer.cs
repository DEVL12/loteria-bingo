/*
 * Creado por SharpDevelop.
 * Usuario: Gustavo
 * Fecha: 17/01/2021
 * Hora: 09:57 p.m.
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
namespace ProyectoAlp
{
	partial class InicioDeSeccion
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
			this.lblTituloContrasenia = new System.Windows.Forms.Label();
			this.txtbContraseña = new System.Windows.Forms.TextBox();
			this.btnContraseña = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// lblTituloContrasenia
			// 
			this.lblTituloContrasenia.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblTituloContrasenia.Location = new System.Drawing.Point(28, 9);
			this.lblTituloContrasenia.Name = "lblTituloContrasenia";
			this.lblTituloContrasenia.Size = new System.Drawing.Size(234, 19);
			this.lblTituloContrasenia.TabIndex = 0;
			this.lblTituloContrasenia.Text = "INGRESE LA CONTRASEÑA";
			// 
			// txtbContraseña
			// 
			this.txtbContraseña.Location = new System.Drawing.Point(28, 31);
			this.txtbContraseña.Name = "txtbContraseña";
			this.txtbContraseña.Size = new System.Drawing.Size(224, 20);
			this.txtbContraseña.TabIndex = 1;
			this.txtbContraseña.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// btnContraseña
			// 
			this.btnContraseña.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnContraseña.Location = new System.Drawing.Point(83, 57);
			this.btnContraseña.Name = "btnContraseña";
			this.btnContraseña.Size = new System.Drawing.Size(109, 33);
			this.btnContraseña.TabIndex = 2;
			this.btnContraseña.Text = "ACEPTAR";
			this.btnContraseña.UseVisualStyleBackColor = true;
			this.btnContraseña.Click += new System.EventHandler(this.BtnContraseñaClick);
			// 
			// InicioDeSeccion
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(284, 101);
			this.Controls.Add(this.btnContraseña);
			this.Controls.Add(this.txtbContraseña);
			this.Controls.Add(this.lblTituloContrasenia);
			this.MaximumSize = new System.Drawing.Size(300, 140);
			this.MinimumSize = new System.Drawing.Size(300, 140);
			this.Name = "InicioDeSeccion";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Iniciar sección";
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.Button btnContraseña;
		private System.Windows.Forms.TextBox txtbContraseña;
		private System.Windows.Forms.Label lblTituloContrasenia;
	}
}
