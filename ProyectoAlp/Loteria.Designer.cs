/*
 * Creado por SharpDevelop.
 * Usuario: Gustavo
 * Fecha: 17/01/2021
 * Hora: 09:52 p.m.
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
namespace ProyectoAlp
{
	partial class Loteria
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Loteria));
			this.lblTituloLoteria = new System.Windows.Forms.Label();
			this.lblRegistroDeCarton = new System.Windows.Forms.Label();
			this.lblNumeroDeCarton = new System.Windows.Forms.Label();
			this.txtbIngresarNumero = new System.Windows.Forms.TextBox();
			this.lblIngreseNumero = new System.Windows.Forms.Label();
			this.btnIngresarNumero = new System.Windows.Forms.Button();
			this.lblNumero1 = new System.Windows.Forms.Label();
			this.lblNumero2 = new System.Windows.Forms.Label();
			this.lblNumero3 = new System.Windows.Forms.Label();
			this.lblNumero4 = new System.Windows.Forms.Label();
			this.lblNumero5 = new System.Windows.Forms.Label();
			this.lblNumero6 = new System.Windows.Forms.Label();
			this.btnGuardarCarton = new System.Windows.Forms.Button();
			this.lblNumeroGanador1 = new System.Windows.Forms.Label();
			this.lblNumeroGanador2 = new System.Windows.Forms.Label();
			this.lblNumeroGanador3 = new System.Windows.Forms.Label();
			this.lblNumeroGanador4 = new System.Windows.Forms.Label();
			this.lblNumeroGanador5 = new System.Windows.Forms.Label();
			this.lblNumeroGanador6 = new System.Windows.Forms.Label();
			this.btnGenerarNumeroGanador = new System.Windows.Forms.Button();
			this.lblTituloCartonGanador = new System.Windows.Forms.Label();
			this.lblCartonesConAciertos = new System.Windows.Forms.Label();
			this.btnAnteriorCrtnEnJuego = new System.Windows.Forms.Button();
			this.btnSiguienteCrtnEnJuego = new System.Windows.Forms.Button();
			this.txtbMostrarCartonesGanadores = new System.Windows.Forms.TextBox();
			this.btnFinDelSorteo = new System.Windows.Forms.Button();
			this.lblCartonesEnJuego = new System.Windows.Forms.Label();
			this.lblCartonEnJuegoNumero = new System.Windows.Forms.Label();
			this.lblNumeroCartonEnJuego = new System.Windows.Forms.Label();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.pictureBox2 = new System.Windows.Forms.PictureBox();
			this.lblL_TituloInicioDeSorteo = new System.Windows.Forms.Label();
			this.PictureBoxPelotasDeLoteria1 = new System.Windows.Forms.PictureBox();
			this.PictureBoxPelotasDeLoteria2 = new System.Windows.Forms.PictureBox();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.PictureBoxPelotasDeLoteria1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.PictureBoxPelotasDeLoteria2)).BeginInit();
			this.SuspendLayout();
			// 
			// lblTituloLoteria
			// 
			this.lblTituloLoteria.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold);
			this.lblTituloLoteria.Location = new System.Drawing.Point(73, -2);
			this.lblTituloLoteria.Name = "lblTituloLoteria";
			this.lblTituloLoteria.Size = new System.Drawing.Size(90, 26);
			this.lblTituloLoteria.TabIndex = 0;
			this.lblTituloLoteria.Text = "LOTERIA";
			// 
			// lblRegistroDeCarton
			// 
			this.lblRegistroDeCarton.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold);
			this.lblRegistroDeCarton.Location = new System.Drawing.Point(57, 15);
			this.lblRegistroDeCarton.Name = "lblRegistroDeCarton";
			this.lblRegistroDeCarton.Size = new System.Drawing.Size(91, 23);
			this.lblRegistroDeCarton.TabIndex = 1;
			this.lblRegistroDeCarton.Text = "Carton N#:";
			// 
			// lblNumeroDeCarton
			// 
			this.lblNumeroDeCarton.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold);
			this.lblNumeroDeCarton.Location = new System.Drawing.Point(148, 15);
			this.lblNumeroDeCarton.Name = "lblNumeroDeCarton";
			this.lblNumeroDeCarton.Size = new System.Drawing.Size(72, 23);
			this.lblNumeroDeCarton.TabIndex = 2;
			this.lblNumeroDeCarton.Text = "0";
			// 
			// txtbIngresarNumero
			// 
			this.txtbIngresarNumero.Location = new System.Drawing.Point(49, 53);
			this.txtbIngresarNumero.Name = "txtbIngresarNumero";
			this.txtbIngresarNumero.Size = new System.Drawing.Size(94, 20);
			this.txtbIngresarNumero.TabIndex = 3;
			this.txtbIngresarNumero.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.txtbIngresarNumero.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtbIngresarNumeroKeyPress);
			// 
			// lblIngreseNumero
			// 
			this.lblIngreseNumero.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold);
			this.lblIngreseNumero.Location = new System.Drawing.Point(49, 32);
			this.lblIngreseNumero.Name = "lblIngreseNumero";
			this.lblIngreseNumero.Size = new System.Drawing.Size(152, 18);
			this.lblIngreseNumero.TabIndex = 4;
			this.lblIngreseNumero.Text = "Ingrese un numero:";
			// 
			// btnIngresarNumero
			// 
			this.btnIngresarNumero.Location = new System.Drawing.Point(151, 50);
			this.btnIngresarNumero.Name = "btnIngresarNumero";
			this.btnIngresarNumero.Size = new System.Drawing.Size(60, 21);
			this.btnIngresarNumero.TabIndex = 5;
			this.btnIngresarNumero.Text = "Registrar";
			this.btnIngresarNumero.UseVisualStyleBackColor = true;
			this.btnIngresarNumero.Click += new System.EventHandler(this.BtnIngresarNumeroClick);
			// 
			// lblNumero1
			// 
			this.lblNumero1.BackColor = System.Drawing.Color.White;
			this.lblNumero1.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold);
			this.lblNumero1.Location = new System.Drawing.Point(60, 129);
			this.lblNumero1.Name = "lblNumero1";
			this.lblNumero1.Size = new System.Drawing.Size(29, 20);
			this.lblNumero1.TabIndex = 6;
			this.lblNumero1.Text = "42";
			this.lblNumero1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// lblNumero2
			// 
			this.lblNumero2.BackColor = System.Drawing.Color.White;
			this.lblNumero2.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold);
			this.lblNumero2.Location = new System.Drawing.Point(158, 130);
			this.lblNumero2.Name = "lblNumero2";
			this.lblNumero2.Size = new System.Drawing.Size(29, 20);
			this.lblNumero2.TabIndex = 7;
			this.lblNumero2.Text = "42";
			this.lblNumero2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// lblNumero3
			// 
			this.lblNumero3.BackColor = System.Drawing.Color.White;
			this.lblNumero3.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold);
			this.lblNumero3.Location = new System.Drawing.Point(60, 183);
			this.lblNumero3.Name = "lblNumero3";
			this.lblNumero3.Size = new System.Drawing.Size(29, 20);
			this.lblNumero3.TabIndex = 8;
			this.lblNumero3.Text = "42";
			this.lblNumero3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// lblNumero4
			// 
			this.lblNumero4.BackColor = System.Drawing.Color.White;
			this.lblNumero4.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold);
			this.lblNumero4.Location = new System.Drawing.Point(158, 183);
			this.lblNumero4.Name = "lblNumero4";
			this.lblNumero4.Size = new System.Drawing.Size(29, 20);
			this.lblNumero4.TabIndex = 9;
			this.lblNumero4.Text = "42";
			this.lblNumero4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// lblNumero5
			// 
			this.lblNumero5.BackColor = System.Drawing.Color.White;
			this.lblNumero5.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold);
			this.lblNumero5.Location = new System.Drawing.Point(60, 235);
			this.lblNumero5.Name = "lblNumero5";
			this.lblNumero5.Size = new System.Drawing.Size(29, 20);
			this.lblNumero5.TabIndex = 10;
			this.lblNumero5.Text = "42";
			this.lblNumero5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// lblNumero6
			// 
			this.lblNumero6.BackColor = System.Drawing.Color.White;
			this.lblNumero6.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold);
			this.lblNumero6.Location = new System.Drawing.Point(158, 235);
			this.lblNumero6.Name = "lblNumero6";
			this.lblNumero6.Size = new System.Drawing.Size(29, 20);
			this.lblNumero6.TabIndex = 11;
			this.lblNumero6.Text = "42";
			this.lblNumero6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// btnGuardarCarton
			// 
			this.btnGuardarCarton.Enabled = false;
			this.btnGuardarCarton.Location = new System.Drawing.Point(85, 273);
			this.btnGuardarCarton.Name = "btnGuardarCarton";
			this.btnGuardarCarton.Size = new System.Drawing.Size(75, 23);
			this.btnGuardarCarton.TabIndex = 12;
			this.btnGuardarCarton.Text = "Guardar";
			this.btnGuardarCarton.UseVisualStyleBackColor = true;
			this.btnGuardarCarton.Click += new System.EventHandler(this.BtnGuardarCartonClick);
			// 
			// lblNumeroGanador1
			// 
			this.lblNumeroGanador1.BackColor = System.Drawing.Color.White;
			this.lblNumeroGanador1.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold);
			this.lblNumeroGanador1.Location = new System.Drawing.Point(308, 128);
			this.lblNumeroGanador1.Name = "lblNumeroGanador1";
			this.lblNumeroGanador1.Size = new System.Drawing.Size(24, 23);
			this.lblNumeroGanador1.TabIndex = 13;
			this.lblNumeroGanador1.Text = "42";
			this.lblNumeroGanador1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// lblNumeroGanador2
			// 
			this.lblNumeroGanador2.BackColor = System.Drawing.Color.White;
			this.lblNumeroGanador2.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold);
			this.lblNumeroGanador2.Location = new System.Drawing.Point(406, 129);
			this.lblNumeroGanador2.Name = "lblNumeroGanador2";
			this.lblNumeroGanador2.Size = new System.Drawing.Size(24, 23);
			this.lblNumeroGanador2.TabIndex = 14;
			this.lblNumeroGanador2.Text = "42";
			this.lblNumeroGanador2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// lblNumeroGanador3
			// 
			this.lblNumeroGanador3.BackColor = System.Drawing.Color.White;
			this.lblNumeroGanador3.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold);
			this.lblNumeroGanador3.Location = new System.Drawing.Point(307, 181);
			this.lblNumeroGanador3.Name = "lblNumeroGanador3";
			this.lblNumeroGanador3.Size = new System.Drawing.Size(24, 23);
			this.lblNumeroGanador3.TabIndex = 15;
			this.lblNumeroGanador3.Text = "42";
			this.lblNumeroGanador3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// lblNumeroGanador4
			// 
			this.lblNumeroGanador4.BackColor = System.Drawing.Color.White;
			this.lblNumeroGanador4.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold);
			this.lblNumeroGanador4.Location = new System.Drawing.Point(406, 181);
			this.lblNumeroGanador4.Name = "lblNumeroGanador4";
			this.lblNumeroGanador4.Size = new System.Drawing.Size(24, 23);
			this.lblNumeroGanador4.TabIndex = 16;
			this.lblNumeroGanador4.Text = "42";
			this.lblNumeroGanador4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// lblNumeroGanador5
			// 
			this.lblNumeroGanador5.BackColor = System.Drawing.Color.White;
			this.lblNumeroGanador5.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold);
			this.lblNumeroGanador5.Location = new System.Drawing.Point(307, 236);
			this.lblNumeroGanador5.Name = "lblNumeroGanador5";
			this.lblNumeroGanador5.Size = new System.Drawing.Size(24, 16);
			this.lblNumeroGanador5.TabIndex = 17;
			this.lblNumeroGanador5.Text = "42";
			this.lblNumeroGanador5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// lblNumeroGanador6
			// 
			this.lblNumeroGanador6.BackColor = System.Drawing.Color.White;
			this.lblNumeroGanador6.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold);
			this.lblNumeroGanador6.Location = new System.Drawing.Point(406, 236);
			this.lblNumeroGanador6.Name = "lblNumeroGanador6";
			this.lblNumeroGanador6.Size = new System.Drawing.Size(24, 16);
			this.lblNumeroGanador6.TabIndex = 18;
			this.lblNumeroGanador6.Text = "42";
			this.lblNumeroGanador6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// btnGenerarNumeroGanador
			// 
			this.btnGenerarNumeroGanador.Location = new System.Drawing.Point(286, 290);
			this.btnGenerarNumeroGanador.Name = "btnGenerarNumeroGanador";
			this.btnGenerarNumeroGanador.Size = new System.Drawing.Size(163, 23);
			this.btnGenerarNumeroGanador.TabIndex = 19;
			this.btnGenerarNumeroGanador.Text = "CREAR CARTÓN GANADOR";
			this.btnGenerarNumeroGanador.UseVisualStyleBackColor = true;
			this.btnGenerarNumeroGanador.Click += new System.EventHandler(this.BtnGenerarNumeroGanadorClick);
			// 
			// lblTituloCartonGanador
			// 
			this.lblTituloCartonGanador.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold);
			this.lblTituloCartonGanador.Location = new System.Drawing.Point(307, 49);
			this.lblTituloCartonGanador.Name = "lblTituloCartonGanador";
			this.lblTituloCartonGanador.Size = new System.Drawing.Size(130, 23);
			this.lblTituloCartonGanador.TabIndex = 20;
			this.lblTituloCartonGanador.Text = "Cartón Ganador";
			this.lblTituloCartonGanador.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// lblCartonesConAciertos
			// 
			this.lblCartonesConAciertos.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold);
			this.lblCartonesConAciertos.Location = new System.Drawing.Point(509, 45);
			this.lblCartonesConAciertos.Name = "lblCartonesConAciertos";
			this.lblCartonesConAciertos.Size = new System.Drawing.Size(165, 27);
			this.lblCartonesConAciertos.TabIndex = 21;
			this.lblCartonesConAciertos.Text = "Cartones con aciertos";
			this.lblCartonesConAciertos.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// btnAnteriorCrtnEnJuego
			// 
			this.btnAnteriorCrtnEnJuego.Location = new System.Drawing.Point(60, 286);
			this.btnAnteriorCrtnEnJuego.Name = "btnAnteriorCrtnEnJuego";
			this.btnAnteriorCrtnEnJuego.Size = new System.Drawing.Size(60, 27);
			this.btnAnteriorCrtnEnJuego.TabIndex = 30;
			this.btnAnteriorCrtnEnJuego.Text = "Anterior";
			this.btnAnteriorCrtnEnJuego.UseVisualStyleBackColor = true;
			this.btnAnteriorCrtnEnJuego.Click += new System.EventHandler(this.BtnAnteriorCrtnEnJuegoClick);
			// 
			// btnSiguienteCrtnEnJuego
			// 
			this.btnSiguienteCrtnEnJuego.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
			this.btnSiguienteCrtnEnJuego.Location = new System.Drawing.Point(127, 286);
			this.btnSiguienteCrtnEnJuego.Name = "btnSiguienteCrtnEnJuego";
			this.btnSiguienteCrtnEnJuego.Size = new System.Drawing.Size(60, 27);
			this.btnSiguienteCrtnEnJuego.TabIndex = 31;
			this.btnSiguienteCrtnEnJuego.Text = "Siguiente";
			this.btnSiguienteCrtnEnJuego.UseVisualStyleBackColor = true;
			this.btnSiguienteCrtnEnJuego.Click += new System.EventHandler(this.BtnSiguienteCrtnEnJuegoClick);
			// 
			// txtbMostrarCartonesGanadores
			// 
			this.txtbMostrarCartonesGanadores.Location = new System.Drawing.Point(524, 75);
			this.txtbMostrarCartonesGanadores.Multiline = true;
			this.txtbMostrarCartonesGanadores.Name = "txtbMostrarCartonesGanadores";
			this.txtbMostrarCartonesGanadores.Size = new System.Drawing.Size(128, 193);
			this.txtbMostrarCartonesGanadores.TabIndex = 32;
			// 
			// btnFinDelSorteo
			// 
			this.btnFinDelSorteo.Location = new System.Drawing.Point(550, 290);
			this.btnFinDelSorteo.Name = "btnFinDelSorteo";
			this.btnFinDelSorteo.Size = new System.Drawing.Size(75, 23);
			this.btnFinDelSorteo.TabIndex = 33;
			this.btnFinDelSorteo.Text = "Finalizar";
			this.btnFinDelSorteo.UseVisualStyleBackColor = true;
			this.btnFinDelSorteo.Click += new System.EventHandler(this.BtnFinDelSorteoClick);
			// 
			// lblCartonesEnJuego
			// 
			this.lblCartonesEnJuego.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold);
			this.lblCartonesEnJuego.Location = new System.Drawing.Point(49, 49);
			this.lblCartonesEnJuego.Name = "lblCartonesEnJuego";
			this.lblCartonesEnJuego.Size = new System.Drawing.Size(142, 22);
			this.lblCartonesEnJuego.TabIndex = 34;
			this.lblCartonesEnJuego.Text = "Cartones en juego";
			// 
			// lblCartonEnJuegoNumero
			// 
			this.lblCartonEnJuegoNumero.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold);
			this.lblCartonEnJuegoNumero.Location = new System.Drawing.Point(69, 269);
			this.lblCartonEnJuegoNumero.Name = "lblCartonEnJuegoNumero";
			this.lblCartonEnJuegoNumero.Size = new System.Drawing.Size(92, 23);
			this.lblCartonEnJuegoNumero.TabIndex = 35;
			this.lblCartonEnJuegoNumero.Text = "Cartón N#:";
			// 
			// lblNumeroCartonEnJuego
			// 
			this.lblNumeroCartonEnJuego.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold);
			this.lblNumeroCartonEnJuego.Location = new System.Drawing.Point(158, 269);
			this.lblNumeroCartonEnJuego.Name = "lblNumeroCartonEnJuego";
			this.lblNumeroCartonEnJuego.Size = new System.Drawing.Size(85, 23);
			this.lblNumeroCartonEnJuego.TabIndex = 36;
			this.lblNumeroCartonEnJuego.Text = "0";
			// 
			// pictureBox1
			// 
			this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
			this.pictureBox1.Location = new System.Drawing.Point(34, 75);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(177, 193);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox1.TabIndex = 37;
			this.pictureBox1.TabStop = false;
			// 
			// pictureBox2
			// 
			this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
			this.pictureBox2.Location = new System.Drawing.Point(280, 75);
			this.pictureBox2.Name = "pictureBox2";
			this.pictureBox2.Size = new System.Drawing.Size(177, 193);
			this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox2.TabIndex = 38;
			this.pictureBox2.TabStop = false;
			// 
			// lblL_TituloInicioDeSorteo
			// 
			this.lblL_TituloInicioDeSorteo.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold);
			this.lblL_TituloInicioDeSorteo.Location = new System.Drawing.Point(249, 2);
			this.lblL_TituloInicioDeSorteo.Name = "lblL_TituloInicioDeSorteo";
			this.lblL_TituloInicioDeSorteo.Size = new System.Drawing.Size(251, 45);
			this.lblL_TituloInicioDeSorteo.TabIndex = 39;
			this.lblL_TituloInicioDeSorteo.Text = "¡BIENVENIDO AL SORTEO DE LOTERIA¡\r\n";
			this.lblL_TituloInicioDeSorteo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// PictureBoxPelotasDeLoteria1
			// 
			this.PictureBoxPelotasDeLoteria1.Image = ((System.Drawing.Image)(resources.GetObject("PictureBoxPelotasDeLoteria1.Image")));
			this.PictureBoxPelotasDeLoteria1.Location = new System.Drawing.Point(19, 2);
			this.PictureBoxPelotasDeLoteria1.Name = "PictureBoxPelotasDeLoteria1";
			this.PictureBoxPelotasDeLoteria1.Size = new System.Drawing.Size(144, 48);
			this.PictureBoxPelotasDeLoteria1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.PictureBoxPelotasDeLoteria1.TabIndex = 40;
			this.PictureBoxPelotasDeLoteria1.TabStop = false;
			// 
			// PictureBoxPelotasDeLoteria2
			// 
			this.PictureBoxPelotasDeLoteria2.Image = ((System.Drawing.Image)(resources.GetObject("PictureBoxPelotasDeLoteria2.Image")));
			this.PictureBoxPelotasDeLoteria2.Location = new System.Drawing.Point(549, 2);
			this.PictureBoxPelotasDeLoteria2.Name = "PictureBoxPelotasDeLoteria2";
			this.PictureBoxPelotasDeLoteria2.Size = new System.Drawing.Size(144, 48);
			this.PictureBoxPelotasDeLoteria2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.PictureBoxPelotasDeLoteria2.TabIndex = 41;
			this.PictureBoxPelotasDeLoteria2.TabStop = false;
			// 
			// Loteria
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(705, 325);
			this.Controls.Add(this.PictureBoxPelotasDeLoteria2);
			this.Controls.Add(this.lblL_TituloInicioDeSorteo);
			this.Controls.Add(this.btnFinDelSorteo);
			this.Controls.Add(this.txtbMostrarCartonesGanadores);
			this.Controls.Add(this.btnSiguienteCrtnEnJuego);
			this.Controls.Add(this.btnAnteriorCrtnEnJuego);
			this.Controls.Add(this.lblCartonesConAciertos);
			this.Controls.Add(this.lblTituloCartonGanador);
			this.Controls.Add(this.btnGenerarNumeroGanador);
			this.Controls.Add(this.lblNumeroGanador6);
			this.Controls.Add(this.lblNumeroGanador5);
			this.Controls.Add(this.lblNumeroGanador4);
			this.Controls.Add(this.lblNumeroGanador3);
			this.Controls.Add(this.lblNumeroGanador2);
			this.Controls.Add(this.lblNumeroGanador1);
			this.Controls.Add(this.btnGuardarCarton);
			this.Controls.Add(this.lblNumero6);
			this.Controls.Add(this.lblNumero5);
			this.Controls.Add(this.lblNumero4);
			this.Controls.Add(this.lblNumero3);
			this.Controls.Add(this.lblNumero2);
			this.Controls.Add(this.lblNumero1);
			this.Controls.Add(this.btnIngresarNumero);
			this.Controls.Add(this.lblIngreseNumero);
			this.Controls.Add(this.lblNumeroDeCarton);
			this.Controls.Add(this.lblRegistroDeCarton);
			this.Controls.Add(this.lblTituloLoteria);
			this.Controls.Add(this.lblNumeroCartonEnJuego);
			this.Controls.Add(this.pictureBox2);
			this.Controls.Add(this.txtbIngresarNumero);
			this.Controls.Add(this.lblCartonEnJuegoNumero);
			this.Controls.Add(this.lblCartonesEnJuego);
			this.Controls.Add(this.pictureBox1);
			this.Controls.Add(this.PictureBoxPelotasDeLoteria1);
			this.Name = "Loteria";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Loteria";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.LoteriaFormClosing);
			this.Load += new System.EventHandler(this.LoteriaLoad);
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.PictureBoxPelotasDeLoteria1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.PictureBoxPelotasDeLoteria2)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.PictureBox PictureBoxPelotasDeLoteria2;
		private System.Windows.Forms.PictureBox PictureBoxPelotasDeLoteria1;
		private System.Windows.Forms.Label lblL_TituloInicioDeSorteo;
		private System.Windows.Forms.PictureBox pictureBox2;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.Label lblNumeroCartonEnJuego;
		private System.Windows.Forms.Label lblCartonEnJuegoNumero;
		private System.Windows.Forms.Label lblCartonesEnJuego;
		private System.Windows.Forms.Button btnFinDelSorteo;
		private System.Windows.Forms.TextBox txtbMostrarCartonesGanadores;
		private System.Windows.Forms.Button btnSiguienteCrtnEnJuego;
		private System.Windows.Forms.Button btnAnteriorCrtnEnJuego;
		private System.Windows.Forms.Label lblCartonesConAciertos;
		private System.Windows.Forms.Label lblTituloCartonGanador;
		private System.Windows.Forms.Button btnGenerarNumeroGanador;
		private System.Windows.Forms.Label lblNumeroGanador6;
		private System.Windows.Forms.Label lblNumeroGanador5;
		private System.Windows.Forms.Label lblNumeroGanador4;
		private System.Windows.Forms.Label lblNumeroGanador3;
		private System.Windows.Forms.Label lblNumeroGanador2;
		private System.Windows.Forms.Label lblNumeroGanador1;
		private System.Windows.Forms.Button btnGuardarCarton;
		private System.Windows.Forms.Label lblNumero6;
		private System.Windows.Forms.Label lblNumero5;
		private System.Windows.Forms.Label lblNumero4;
		private System.Windows.Forms.Label lblNumero3;
		private System.Windows.Forms.Label lblNumero2;
		private System.Windows.Forms.Label lblNumero1;
		private System.Windows.Forms.Button btnIngresarNumero;
		private System.Windows.Forms.Label lblIngreseNumero;
		private System.Windows.Forms.TextBox txtbIngresarNumero;
		private System.Windows.Forms.Label lblNumeroDeCarton;
		private System.Windows.Forms.Label lblRegistroDeCarton;
		private System.Windows.Forms.Label lblTituloLoteria;
	}
}
