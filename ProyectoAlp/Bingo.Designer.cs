/*
 * Creado por SharpDevelop.
 * Usuario: Gustavo
 * Fecha: 17/01/2021
 * Hora: 08:01 p.m.
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
namespace ProyectoAlp
{
	partial class Bingo
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Bingo));
			this.lblBingoTitulo = new System.Windows.Forms.Label();
			this.lblBingoCartonNumero = new System.Windows.Forms.Label();
			this.lblBingoNumeroDelCarton = new System.Windows.Forms.Label();
			this.txtbIngresarNumero = new System.Windows.Forms.TextBox();
			this.lblIngresaUnNumero = new System.Windows.Forms.Label();
			this.btnRegistrarNumero = new System.Windows.Forms.Button();
			this.lblBNumero1 = new System.Windows.Forms.Label();
			this.lblBNumero2 = new System.Windows.Forms.Label();
			this.lblBNumero3 = new System.Windows.Forms.Label();
			this.lblBNumero4 = new System.Windows.Forms.Label();
			this.lblBNumero5 = new System.Windows.Forms.Label();
			this.lblBNumero6 = new System.Windows.Forms.Label();
			this.btnGuardarNumero = new System.Windows.Forms.Button();
			this.btnSiguienteNumero = new System.Windows.Forms.Button();
			this.txtbCartones = new System.Windows.Forms.TextBox();
			this.btnB_SiguienteCartonEnJuego = new System.Windows.Forms.Button();
			this.btnB_AnterioCartonEnJuego = new System.Windows.Forms.Button();
			this.lblB_CartonNumeroEnJuego = new System.Windows.Forms.Label();
			this.lbl_BNumeroDeCartonEnJuego = new System.Windows.Forms.Label();
			this.btnB_Finalizar = new System.Windows.Forms.Button();
			this.lblB_NohayGanadores = new System.Windows.Forms.Label();
			this.txtbMostarGanadores = new System.Windows.Forms.TextBox();
			this.lblB_NumerosEnJuego = new System.Windows.Forms.Label();
			this.lblMostrarNumeroCantado = new System.Windows.Forms.Label();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.pictureBox2 = new System.Windows.Forms.PictureBox();
			this.lblB_PulsaSiguiente = new System.Windows.Forms.Label();
			this.lblB_Ganador = new System.Windows.Forms.Label();
			this.lblB_TituloInicioDelJuego = new System.Windows.Forms.Label();
			this.PictureBoxBingoPelotas1 = new System.Windows.Forms.PictureBox();
			this.PictureBoxBingoPelotas2 = new System.Windows.Forms.PictureBox();
			this.pictureBox3BolaDeBingoPNG = new System.Windows.Forms.PictureBox();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.PictureBoxBingoPelotas1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.PictureBoxBingoPelotas2)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox3BolaDeBingoPNG)).BeginInit();
			this.SuspendLayout();
			// 
			// lblBingoTitulo
			// 
			this.lblBingoTitulo.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold);
			this.lblBingoTitulo.Location = new System.Drawing.Point(71, -2);
			this.lblBingoTitulo.Name = "lblBingoTitulo";
			this.lblBingoTitulo.Size = new System.Drawing.Size(66, 23);
			this.lblBingoTitulo.TabIndex = 0;
			this.lblBingoTitulo.Text = "BINGO";
			// 
			// lblBingoCartonNumero
			// 
			this.lblBingoCartonNumero.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold);
			this.lblBingoCartonNumero.Location = new System.Drawing.Point(45, 15);
			this.lblBingoCartonNumero.Name = "lblBingoCartonNumero";
			this.lblBingoCartonNumero.Size = new System.Drawing.Size(104, 23);
			this.lblBingoCartonNumero.TabIndex = 1;
			this.lblBingoCartonNumero.Text = "CARTON N#";
			// 
			// lblBingoNumeroDelCarton
			// 
			this.lblBingoNumeroDelCarton.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold);
			this.lblBingoNumeroDelCarton.Location = new System.Drawing.Point(145, 15);
			this.lblBingoNumeroDelCarton.Name = "lblBingoNumeroDelCarton";
			this.lblBingoNumeroDelCarton.Size = new System.Drawing.Size(70, 23);
			this.lblBingoNumeroDelCarton.TabIndex = 2;
			this.lblBingoNumeroDelCarton.Text = "0";
			// 
			// txtbIngresarNumero
			// 
			this.txtbIngresarNumero.Location = new System.Drawing.Point(37, 53);
			this.txtbIngresarNumero.Name = "txtbIngresarNumero";
			this.txtbIngresarNumero.Size = new System.Drawing.Size(78, 20);
			this.txtbIngresarNumero.TabIndex = 3;
			this.txtbIngresarNumero.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.txtbIngresarNumero.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtbIngresarNumeroKeyPress);
			// 
			// lblIngresaUnNumero
			// 
			this.lblIngresaUnNumero.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold);
			this.lblIngresaUnNumero.Location = new System.Drawing.Point(37, 31);
			this.lblIngresaUnNumero.Name = "lblIngresaUnNumero";
			this.lblIngresaUnNumero.Size = new System.Drawing.Size(152, 24);
			this.lblIngresaUnNumero.TabIndex = 4;
			this.lblIngresaUnNumero.Text = "Ingrese un número:";
			// 
			// btnRegistrarNumero
			// 
			this.btnRegistrarNumero.Location = new System.Drawing.Point(129, 52);
			this.btnRegistrarNumero.Name = "btnRegistrarNumero";
			this.btnRegistrarNumero.Size = new System.Drawing.Size(60, 21);
			this.btnRegistrarNumero.TabIndex = 5;
			this.btnRegistrarNumero.Text = "Registrar";
			this.btnRegistrarNumero.UseVisualStyleBackColor = true;
			this.btnRegistrarNumero.Click += new System.EventHandler(this.BtnRegistrarNumeroClick);
			// 
			// lblBNumero1
			// 
			this.lblBNumero1.BackColor = System.Drawing.Color.White;
			this.lblBNumero1.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold);
			this.lblBNumero1.Location = new System.Drawing.Point(45, 134);
			this.lblBNumero1.Name = "lblBNumero1";
			this.lblBNumero1.Size = new System.Drawing.Size(26, 20);
			this.lblBNumero1.TabIndex = 6;
			this.lblBNumero1.Text = "42";
			this.lblBNumero1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// lblBNumero2
			// 
			this.lblBNumero2.BackColor = System.Drawing.Color.White;
			this.lblBNumero2.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold);
			this.lblBNumero2.Location = new System.Drawing.Point(144, 135);
			this.lblBNumero2.Name = "lblBNumero2";
			this.lblBNumero2.Size = new System.Drawing.Size(26, 16);
			this.lblBNumero2.TabIndex = 7;
			this.lblBNumero2.Text = "42";
			this.lblBNumero2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// lblBNumero3
			// 
			this.lblBNumero3.BackColor = System.Drawing.Color.White;
			this.lblBNumero3.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold);
			this.lblBNumero3.Location = new System.Drawing.Point(46, 188);
			this.lblBNumero3.Name = "lblBNumero3";
			this.lblBNumero3.Size = new System.Drawing.Size(26, 20);
			this.lblBNumero3.TabIndex = 8;
			this.lblBNumero3.Text = "42";
			this.lblBNumero3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// lblBNumero4
			// 
			this.lblBNumero4.BackColor = System.Drawing.Color.White;
			this.lblBNumero4.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold);
			this.lblBNumero4.Location = new System.Drawing.Point(141, 188);
			this.lblBNumero4.Name = "lblBNumero4";
			this.lblBNumero4.Size = new System.Drawing.Size(31, 20);
			this.lblBNumero4.TabIndex = 9;
			this.lblBNumero4.Text = "42";
			this.lblBNumero4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// lblBNumero5
			// 
			this.lblBNumero5.BackColor = System.Drawing.Color.White;
			this.lblBNumero5.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold);
			this.lblBNumero5.Location = new System.Drawing.Point(45, 239);
			this.lblBNumero5.Name = "lblBNumero5";
			this.lblBNumero5.Size = new System.Drawing.Size(27, 20);
			this.lblBNumero5.TabIndex = 10;
			this.lblBNumero5.Text = "42";
			this.lblBNumero5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// lblBNumero6
			// 
			this.lblBNumero6.BackColor = System.Drawing.Color.White;
			this.lblBNumero6.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold);
			this.lblBNumero6.Location = new System.Drawing.Point(145, 240);
			this.lblBNumero6.Name = "lblBNumero6";
			this.lblBNumero6.Size = new System.Drawing.Size(25, 20);
			this.lblBNumero6.TabIndex = 11;
			this.lblBNumero6.Text = "42";
			this.lblBNumero6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// btnGuardarNumero
			// 
			this.btnGuardarNumero.Location = new System.Drawing.Point(50, 272);
			this.btnGuardarNumero.Name = "btnGuardarNumero";
			this.btnGuardarNumero.Size = new System.Drawing.Size(110, 23);
			this.btnGuardarNumero.TabIndex = 12;
			this.btnGuardarNumero.Text = "Guardar Cartón";
			this.btnGuardarNumero.UseVisualStyleBackColor = true;
			this.btnGuardarNumero.Click += new System.EventHandler(this.BtnGuardarNumeroClick);
			// 
			// btnSiguienteNumero
			// 
			this.btnSiguienteNumero.Location = new System.Drawing.Point(288, 298);
			this.btnSiguienteNumero.Name = "btnSiguienteNumero";
			this.btnSiguienteNumero.Size = new System.Drawing.Size(144, 25);
			this.btnSiguienteNumero.TabIndex = 19;
			this.btnSiguienteNumero.Text = "Cantar siguiente número";
			this.btnSiguienteNumero.UseVisualStyleBackColor = true;
			this.btnSiguienteNumero.Click += new System.EventHandler(this.BtnSiguienteNumeroClick);
			// 
			// txtbCartones
			// 
			this.txtbCartones.Enabled = false;
			this.txtbCartones.Location = new System.Drawing.Point(235, 264);
			this.txtbCartones.Multiline = true;
			this.txtbCartones.Name = "txtbCartones";
			this.txtbCartones.Size = new System.Drawing.Size(259, 33);
			this.txtbCartones.TabIndex = 20;
			this.txtbCartones.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// btnB_SiguienteCartonEnJuego
			// 
			this.btnB_SiguienteCartonEnJuego.Location = new System.Drawing.Point(107, 296);
			this.btnB_SiguienteCartonEnJuego.Name = "btnB_SiguienteCartonEnJuego";
			this.btnB_SiguienteCartonEnJuego.Size = new System.Drawing.Size(60, 27);
			this.btnB_SiguienteCartonEnJuego.TabIndex = 21;
			this.btnB_SiguienteCartonEnJuego.Text = "Siguiente";
			this.btnB_SiguienteCartonEnJuego.UseVisualStyleBackColor = true;
			this.btnB_SiguienteCartonEnJuego.Click += new System.EventHandler(this.BtnB_SiguienteCartonEnJuegoClick);
			// 
			// btnB_AnterioCartonEnJuego
			// 
			this.btnB_AnterioCartonEnJuego.Location = new System.Drawing.Point(43, 295);
			this.btnB_AnterioCartonEnJuego.Name = "btnB_AnterioCartonEnJuego";
			this.btnB_AnterioCartonEnJuego.Size = new System.Drawing.Size(60, 27);
			this.btnB_AnterioCartonEnJuego.TabIndex = 22;
			this.btnB_AnterioCartonEnJuego.Text = "Anterior";
			this.btnB_AnterioCartonEnJuego.UseVisualStyleBackColor = true;
			this.btnB_AnterioCartonEnJuego.Click += new System.EventHandler(this.BtnB_AnterioCartonEnJuegoClick);
			// 
			// lblB_CartonNumeroEnJuego
			// 
			this.lblB_CartonNumeroEnJuego.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold);
			this.lblB_CartonNumeroEnJuego.Location = new System.Drawing.Point(48, 274);
			this.lblB_CartonNumeroEnJuego.Name = "lblB_CartonNumeroEnJuego";
			this.lblB_CartonNumeroEnJuego.Size = new System.Drawing.Size(100, 23);
			this.lblB_CartonNumeroEnJuego.TabIndex = 23;
			this.lblB_CartonNumeroEnJuego.Text = "Cartón N#:";
			// 
			// lbl_BNumeroDeCartonEnJuego
			// 
			this.lbl_BNumeroDeCartonEnJuego.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold);
			this.lbl_BNumeroDeCartonEnJuego.Location = new System.Drawing.Point(142, 274);
			this.lbl_BNumeroDeCartonEnJuego.Name = "lbl_BNumeroDeCartonEnJuego";
			this.lbl_BNumeroDeCartonEnJuego.Size = new System.Drawing.Size(87, 23);
			this.lbl_BNumeroDeCartonEnJuego.TabIndex = 24;
			this.lbl_BNumeroDeCartonEnJuego.Text = "0";
			// 
			// btnB_Finalizar
			// 
			this.btnB_Finalizar.Location = new System.Drawing.Point(538, 295);
			this.btnB_Finalizar.Name = "btnB_Finalizar";
			this.btnB_Finalizar.Size = new System.Drawing.Size(75, 23);
			this.btnB_Finalizar.TabIndex = 25;
			this.btnB_Finalizar.Text = "Finalizar";
			this.btnB_Finalizar.UseVisualStyleBackColor = true;
			this.btnB_Finalizar.Click += new System.EventHandler(this.BtnB_FinalizarClick);
			// 
			// lblB_NohayGanadores
			// 
			this.lblB_NohayGanadores.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold);
			this.lblB_NohayGanadores.Location = new System.Drawing.Point(275, 240);
			this.lblB_NohayGanadores.Name = "lblB_NohayGanadores";
			this.lblB_NohayGanadores.Size = new System.Drawing.Size(184, 23);
			this.lblB_NohayGanadores.TabIndex = 26;
			this.lblB_NohayGanadores.Text = "Aún no hay ganadores";
			this.lblB_NohayGanadores.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// txtbMostarGanadores
			// 
			this.txtbMostarGanadores.Location = new System.Drawing.Point(539, 84);
			this.txtbMostarGanadores.Multiline = true;
			this.txtbMostarGanadores.Name = "txtbMostarGanadores";
			this.txtbMostarGanadores.Size = new System.Drawing.Size(74, 187);
			this.txtbMostarGanadores.TabIndex = 27;
			// 
			// lblB_NumerosEnJuego
			// 
			this.lblB_NumerosEnJuego.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold);
			this.lblB_NumerosEnJuego.Location = new System.Drawing.Point(34, 55);
			this.lblB_NumerosEnJuego.Name = "lblB_NumerosEnJuego";
			this.lblB_NumerosEnJuego.Size = new System.Drawing.Size(147, 23);
			this.lblB_NumerosEnJuego.TabIndex = 28;
			this.lblB_NumerosEnJuego.Text = "Cartones en juego:";
			// 
			// lblMostrarNumeroCantado
			// 
			this.lblMostrarNumeroCantado.BackColor = System.Drawing.Color.Transparent;
			this.lblMostrarNumeroCantado.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblMostrarNumeroCantado.Location = new System.Drawing.Point(245, 214);
			this.lblMostrarNumeroCantado.Name = "lblMostrarNumeroCantado";
			this.lblMostrarNumeroCantado.Size = new System.Drawing.Size(26, 20);
			this.lblMostrarNumeroCantado.TabIndex = 29;
			this.lblMostrarNumeroCantado.Text = "42";
			// 
			// pictureBox1
			// 
			this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
			this.pictureBox1.Location = new System.Drawing.Point(18, 78);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(177, 193);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox1.TabIndex = 30;
			this.pictureBox1.TabStop = false;
			// 
			// pictureBox2
			// 
			this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
			this.pictureBox2.Location = new System.Drawing.Point(266, 82);
			this.pictureBox2.Name = "pictureBox2";
			this.pictureBox2.Size = new System.Drawing.Size(218, 156);
			this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox2.TabIndex = 31;
			this.pictureBox2.TabStop = false;
			// 
			// lblB_PulsaSiguiente
			// 
			this.lblB_PulsaSiguiente.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold);
			this.lblB_PulsaSiguiente.Location = new System.Drawing.Point(240, 54);
			this.lblB_PulsaSiguiente.Name = "lblB_PulsaSiguiente";
			this.lblB_PulsaSiguiente.Size = new System.Drawing.Size(262, 41);
			this.lblB_PulsaSiguiente.TabIndex = 32;
			this.lblB_PulsaSiguiente.Text = "Pulsa \"cantar siguiente número\" para conseguir un ganador";
			this.lblB_PulsaSiguiente.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// lblB_Ganador
			// 
			this.lblB_Ganador.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold);
			this.lblB_Ganador.Location = new System.Drawing.Point(512, 59);
			this.lblB_Ganador.Name = "lblB_Ganador";
			this.lblB_Ganador.Size = new System.Drawing.Size(125, 19);
			this.lblB_Ganador.TabIndex = 33;
			this.lblB_Ganador.Text = "Cartón ganador";
			// 
			// lblB_TituloInicioDelJuego
			// 
			this.lblB_TituloInicioDelJuego.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold);
			this.lblB_TituloInicioDelJuego.Location = new System.Drawing.Point(235, 3);
			this.lblB_TituloInicioDelJuego.Name = "lblB_TituloInicioDelJuego";
			this.lblB_TituloInicioDelJuego.Size = new System.Drawing.Size(249, 46);
			this.lblB_TituloInicioDelJuego.TabIndex = 34;
			this.lblB_TituloInicioDelJuego.Text = "¡BIENVENIDOS AL JUEGO DE BINGO!";
			this.lblB_TituloInicioDelJuego.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// PictureBoxBingoPelotas1
			// 
			this.PictureBoxBingoPelotas1.Image = ((System.Drawing.Image)(resources.GetObject("PictureBoxBingoPelotas1.Image")));
			this.PictureBoxBingoPelotas1.Location = new System.Drawing.Point(101, 7);
			this.PictureBoxBingoPelotas1.Name = "PictureBoxBingoPelotas1";
			this.PictureBoxBingoPelotas1.Size = new System.Drawing.Size(144, 48);
			this.PictureBoxBingoPelotas1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.PictureBoxBingoPelotas1.TabIndex = 35;
			this.PictureBoxBingoPelotas1.TabStop = false;
			// 
			// PictureBoxBingoPelotas2
			// 
			this.PictureBoxBingoPelotas2.Image = ((System.Drawing.Image)(resources.GetObject("PictureBoxBingoPelotas2.Image")));
			this.PictureBoxBingoPelotas2.Location = new System.Drawing.Point(478, 7);
			this.PictureBoxBingoPelotas2.Name = "PictureBoxBingoPelotas2";
			this.PictureBoxBingoPelotas2.Size = new System.Drawing.Size(144, 48);
			this.PictureBoxBingoPelotas2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.PictureBoxBingoPelotas2.TabIndex = 36;
			this.PictureBoxBingoPelotas2.TabStop = false;
			// 
			// pictureBox3BolaDeBingoPNG
			// 
			this.pictureBox3BolaDeBingoPNG.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3BolaDeBingoPNG.Image")));
			this.pictureBox3BolaDeBingoPNG.Location = new System.Drawing.Point(238, 201);
			this.pictureBox3BolaDeBingoPNG.Name = "pictureBox3BolaDeBingoPNG";
			this.pictureBox3BolaDeBingoPNG.Size = new System.Drawing.Size(43, 42);
			this.pictureBox3BolaDeBingoPNG.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox3BolaDeBingoPNG.TabIndex = 37;
			this.pictureBox3BolaDeBingoPNG.TabStop = false;
			// 
			// Bingo
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(670, 332);
			this.Controls.Add(this.PictureBoxBingoPelotas2);
			this.Controls.Add(this.lblB_TituloInicioDelJuego);
			this.Controls.Add(this.lblB_Ganador);
			this.Controls.Add(this.lblB_PulsaSiguiente);
			this.Controls.Add(this.lblMostrarNumeroCantado);
			this.Controls.Add(this.txtbMostarGanadores);
			this.Controls.Add(this.lblB_NohayGanadores);
			this.Controls.Add(this.btnB_Finalizar);
			this.Controls.Add(this.btnB_AnterioCartonEnJuego);
			this.Controls.Add(this.btnB_SiguienteCartonEnJuego);
			this.Controls.Add(this.txtbCartones);
			this.Controls.Add(this.btnSiguienteNumero);
			this.Controls.Add(this.btnGuardarNumero);
			this.Controls.Add(this.lblBNumero6);
			this.Controls.Add(this.lblBNumero5);
			this.Controls.Add(this.lblBNumero4);
			this.Controls.Add(this.lblBNumero3);
			this.Controls.Add(this.lblBNumero2);
			this.Controls.Add(this.lblBNumero1);
			this.Controls.Add(this.btnRegistrarNumero);
			this.Controls.Add(this.lblIngresaUnNumero);
			this.Controls.Add(this.txtbIngresarNumero);
			this.Controls.Add(this.lblBingoNumeroDelCarton);
			this.Controls.Add(this.lblBingoCartonNumero);
			this.Controls.Add(this.lblBingoTitulo);
			this.Controls.Add(this.pictureBox1);
			this.Controls.Add(this.PictureBoxBingoPelotas1);
			this.Controls.Add(this.pictureBox3BolaDeBingoPNG);
			this.Controls.Add(this.pictureBox2);
			this.Controls.Add(this.lbl_BNumeroDeCartonEnJuego);
			this.Controls.Add(this.lblB_CartonNumeroEnJuego);
			this.Controls.Add(this.lblB_NumerosEnJuego);
			this.Name = "Bingo";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Bingo";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.BingoFormClosing);
			this.Load += new System.EventHandler(this.BingoLoad);
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.PictureBoxBingoPelotas1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.PictureBoxBingoPelotas2)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox3BolaDeBingoPNG)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.PictureBox pictureBox3BolaDeBingoPNG;
		private System.Windows.Forms.PictureBox PictureBoxBingoPelotas2;
		private System.Windows.Forms.PictureBox PictureBoxBingoPelotas1;
		private System.Windows.Forms.Label lblB_TituloInicioDelJuego;
		private System.Windows.Forms.Label lblB_Ganador;
		private System.Windows.Forms.Label lblB_PulsaSiguiente;
		private System.Windows.Forms.PictureBox pictureBox2;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.Label lblMostrarNumeroCantado;
		private System.Windows.Forms.Label lblB_NumerosEnJuego;
		private System.Windows.Forms.TextBox txtbMostarGanadores;
		private System.Windows.Forms.Label lblB_NohayGanadores;
		private System.Windows.Forms.Button btnB_Finalizar;
		private System.Windows.Forms.Label lbl_BNumeroDeCartonEnJuego;
		private System.Windows.Forms.Label lblB_CartonNumeroEnJuego;
		private System.Windows.Forms.Button btnB_AnterioCartonEnJuego;
		private System.Windows.Forms.Button btnB_SiguienteCartonEnJuego;
		private System.Windows.Forms.TextBox txtbCartones;
		private System.Windows.Forms.Button btnSiguienteNumero;
		private System.Windows.Forms.Button btnGuardarNumero;
		private System.Windows.Forms.Label lblBNumero6;
		private System.Windows.Forms.Label lblBNumero5;
		private System.Windows.Forms.Label lblBNumero4;
		private System.Windows.Forms.Label lblBNumero3;
		private System.Windows.Forms.Label lblBNumero2;
		private System.Windows.Forms.Label lblBNumero1;
		private System.Windows.Forms.Button btnRegistrarNumero;
		private System.Windows.Forms.Label lblIngresaUnNumero;
		private System.Windows.Forms.TextBox txtbIngresarNumero;
		private System.Windows.Forms.Label lblBingoNumeroDelCarton;
		private System.Windows.Forms.Label lblBingoCartonNumero;
		private System.Windows.Forms.Label lblBingoTitulo;
	}
}
