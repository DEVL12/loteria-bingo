namespace ProyectoAlp
{
	partial class MainForm
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
			this.pictboxBingo = new System.Windows.Forms.PictureBox();
			this.pictboxLoteria = new System.Windows.Forms.PictureBox();
			this.lbPoteBingo = new System.Windows.Forms.Label();
			this.lblDineroPoteBingo = new System.Windows.Forms.Label();
			this.btnL_ComprarCartonLoteria = new System.Windows.Forms.Button();
			this.btnSortearLoteria = new System.Windows.Forms.Button();
			this.menuStrip1 = new System.Windows.Forms.MenuStrip();
			this.opcionesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.dineroClubToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.dineroDelClubDeBingoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.dineroDelClubDeLoteríaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.totalRecaudadoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.informacionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.historialDelBingoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.historialDeLaLoteriaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.btnB_ComprarCarton = new System.Windows.Forms.Button();
			this.btnB_EmpezarJuego = new System.Windows.Forms.Button();
			this.pictureBox1DineroBingo = new System.Windows.Forms.PictureBox();
			this.pictureBox2DineroLoteria = new System.Windows.Forms.PictureBox();
			this.lbPoteLoteria = new System.Windows.Forms.Label();
			this.lblDineroPoteLoteria = new System.Windows.Forms.Label();
			this.lblM_Bienvenidos = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.pictboxBingo)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictboxLoteria)).BeginInit();
			this.menuStrip1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1DineroBingo)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox2DineroLoteria)).BeginInit();
			this.SuspendLayout();
			// 
			// pictboxBingo
			// 
			this.pictboxBingo.Cursor = System.Windows.Forms.Cursors.Hand;
			this.pictboxBingo.Enabled = false;
			this.pictboxBingo.Image = ((System.Drawing.Image)(resources.GetObject("pictboxBingo.Image")));
			this.pictboxBingo.Location = new System.Drawing.Point(25, 69);
			this.pictboxBingo.Name = "pictboxBingo";
			this.pictboxBingo.Size = new System.Drawing.Size(149, 131);
			this.pictboxBingo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictboxBingo.TabIndex = 0;
			this.pictboxBingo.TabStop = false;
			// 
			// pictboxLoteria
			// 
			this.pictboxLoteria.Cursor = System.Windows.Forms.Cursors.Hand;
			this.pictboxLoteria.Enabled = false;
			this.pictboxLoteria.Image = ((System.Drawing.Image)(resources.GetObject("pictboxLoteria.Image")));
			this.pictboxLoteria.Location = new System.Drawing.Point(293, 69);
			this.pictboxLoteria.Name = "pictboxLoteria";
			this.pictboxLoteria.Size = new System.Drawing.Size(149, 131);
			this.pictboxLoteria.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictboxLoteria.TabIndex = 1;
			this.pictboxLoteria.TabStop = false;
			// 
			// lbPoteBingo
			// 
			this.lbPoteBingo.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold);
			this.lbPoteBingo.Location = new System.Drawing.Point(36, 232);
			this.lbPoteBingo.Name = "lbPoteBingo";
			this.lbPoteBingo.Size = new System.Drawing.Size(147, 23);
			this.lbPoteBingo.TabIndex = 7;
			this.lbPoteBingo.Text = "Dinero a sortear :";
			// 
			// lblDineroPoteBingo
			// 
			this.lblDineroPoteBingo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
			this.lblDineroPoteBingo.Location = new System.Drawing.Point(107, 276);
			this.lblDineroPoteBingo.Name = "lblDineroPoteBingo";
			this.lblDineroPoteBingo.Size = new System.Drawing.Size(95, 23);
			this.lblDineroPoteBingo.TabIndex = 8;
			this.lblDineroPoteBingo.Text = "0";
			// 
			// btnL_ComprarCartonLoteria
			// 
			this.btnL_ComprarCartonLoteria.Location = new System.Drawing.Point(255, 206);
			this.btnL_ComprarCartonLoteria.Name = "btnL_ComprarCartonLoteria";
			this.btnL_ComprarCartonLoteria.Size = new System.Drawing.Size(99, 23);
			this.btnL_ComprarCartonLoteria.TabIndex = 10;
			this.btnL_ComprarCartonLoteria.Text = "Comprar cartón";
			this.btnL_ComprarCartonLoteria.UseVisualStyleBackColor = true;
			this.btnL_ComprarCartonLoteria.Click += new System.EventHandler(this.BtnComprarCartonLoteriaClick);
			// 
			// btnSortearLoteria
			// 
			this.btnSortearLoteria.Location = new System.Drawing.Point(364, 206);
			this.btnSortearLoteria.Name = "btnSortearLoteria";
			this.btnSortearLoteria.Size = new System.Drawing.Size(97, 23);
			this.btnSortearLoteria.TabIndex = 11;
			this.btnSortearLoteria.Text = "Empezar sorteo";
			this.btnSortearLoteria.UseVisualStyleBackColor = true;
			this.btnSortearLoteria.Click += new System.EventHandler(this.BtnSortearLoteriaClick);
			// 
			// menuStrip1
			// 
			this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
									this.opcionesToolStripMenuItem,
									this.dineroClubToolStripMenuItem,
									this.informacionToolStripMenuItem});
			this.menuStrip1.Location = new System.Drawing.Point(0, 0);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Size = new System.Drawing.Size(470, 24);
			this.menuStrip1.TabIndex = 12;
			this.menuStrip1.Text = "menuStrip1";
			// 
			// opcionesToolStripMenuItem
			// 
			this.opcionesToolStripMenuItem.Name = "opcionesToolStripMenuItem";
			this.opcionesToolStripMenuItem.Size = new System.Drawing.Size(80, 20);
			this.opcionesToolStripMenuItem.Text = "Acerca de...";
			this.opcionesToolStripMenuItem.Click += new System.EventHandler(this.OpcionesToolStripMenuItemClick);
			// 
			// dineroClubToolStripMenuItem
			// 
			this.dineroClubToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
									this.dineroDelClubDeBingoToolStripMenuItem,
									this.dineroDelClubDeLoteríaToolStripMenuItem,
									this.totalRecaudadoToolStripMenuItem});
			this.dineroClubToolStripMenuItem.Name = "dineroClubToolStripMenuItem";
			this.dineroClubToolStripMenuItem.Size = new System.Drawing.Size(99, 20);
			this.dineroClubToolStripMenuItem.Text = "Dinero del club";
			// 
			// dineroDelClubDeBingoToolStripMenuItem
			// 
			this.dineroDelClubDeBingoToolStripMenuItem.Name = "dineroDelClubDeBingoToolStripMenuItem";
			this.dineroDelClubDeBingoToolStripMenuItem.Size = new System.Drawing.Size(206, 22);
			this.dineroDelClubDeBingoToolStripMenuItem.Text = "Dinero del club de bingo";
			this.dineroDelClubDeBingoToolStripMenuItem.Click += new System.EventHandler(this.DineroDelClubDeBingoToolStripMenuItemClick);
			// 
			// dineroDelClubDeLoteríaToolStripMenuItem
			// 
			this.dineroDelClubDeLoteríaToolStripMenuItem.Name = "dineroDelClubDeLoteríaToolStripMenuItem";
			this.dineroDelClubDeLoteríaToolStripMenuItem.Size = new System.Drawing.Size(206, 22);
			this.dineroDelClubDeLoteríaToolStripMenuItem.Text = "Dinero del club de lotería";
			this.dineroDelClubDeLoteríaToolStripMenuItem.Click += new System.EventHandler(this.DineroDelClubDeLoteríaToolStripMenuItemClick);
			// 
			// totalRecaudadoToolStripMenuItem
			// 
			this.totalRecaudadoToolStripMenuItem.Name = "totalRecaudadoToolStripMenuItem";
			this.totalRecaudadoToolStripMenuItem.Size = new System.Drawing.Size(206, 22);
			this.totalRecaudadoToolStripMenuItem.Text = "Recaudaciones en total";
			this.totalRecaudadoToolStripMenuItem.Click += new System.EventHandler(this.TotalRecaudadoToolStripMenuItemClick);
			// 
			// informacionToolStripMenuItem
			// 
			this.informacionToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
									this.historialDelBingoToolStripMenuItem,
									this.historialDeLaLoteriaToolStripMenuItem});
			this.informacionToolStripMenuItem.Name = "informacionToolStripMenuItem";
			this.informacionToolStripMenuItem.Size = new System.Drawing.Size(84, 20);
			this.informacionToolStripMenuItem.Text = "Informacion";
			// 
			// historialDelBingoToolStripMenuItem
			// 
			this.historialDelBingoToolStripMenuItem.Name = "historialDelBingoToolStripMenuItem";
			this.historialDelBingoToolStripMenuItem.Size = new System.Drawing.Size(182, 22);
			this.historialDelBingoToolStripMenuItem.Text = "Historial del bingo";
			this.historialDelBingoToolStripMenuItem.Click += new System.EventHandler(this.HistorialDelBingoToolStripMenuItemClick);
			// 
			// historialDeLaLoteriaToolStripMenuItem
			// 
			this.historialDeLaLoteriaToolStripMenuItem.Name = "historialDeLaLoteriaToolStripMenuItem";
			this.historialDeLaLoteriaToolStripMenuItem.Size = new System.Drawing.Size(182, 22);
			this.historialDeLaLoteriaToolStripMenuItem.Text = "Historial de la lotería";
			this.historialDeLaLoteriaToolStripMenuItem.Click += new System.EventHandler(this.HistorialDeLaLoteriaToolStripMenuItemClick);
			// 
			// btnB_ComprarCarton
			// 
			this.btnB_ComprarCarton.Location = new System.Drawing.Point(7, 206);
			this.btnB_ComprarCarton.Name = "btnB_ComprarCarton";
			this.btnB_ComprarCarton.Size = new System.Drawing.Size(91, 23);
			this.btnB_ComprarCarton.TabIndex = 13;
			this.btnB_ComprarCarton.Text = "Comprar cartón";
			this.btnB_ComprarCarton.UseVisualStyleBackColor = true;
			this.btnB_ComprarCarton.Click += new System.EventHandler(this.BtnB_ComprarCartonClick);
			// 
			// btnB_EmpezarJuego
			// 
			this.btnB_EmpezarJuego.Location = new System.Drawing.Point(107, 206);
			this.btnB_EmpezarJuego.Name = "btnB_EmpezarJuego";
			this.btnB_EmpezarJuego.Size = new System.Drawing.Size(90, 23);
			this.btnB_EmpezarJuego.TabIndex = 14;
			this.btnB_EmpezarJuego.Text = "Empezar Juego";
			this.btnB_EmpezarJuego.UseVisualStyleBackColor = true;
			this.btnB_EmpezarJuego.Click += new System.EventHandler(this.BtnB_EmpezarJuegoClick);
			// 
			// pictureBox1DineroBingo
			// 
			this.pictureBox1DineroBingo.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1DineroBingo.Image")));
			this.pictureBox1DineroBingo.Location = new System.Drawing.Point(36, 255);
			this.pictureBox1DineroBingo.Name = "pictureBox1DineroBingo";
			this.pictureBox1DineroBingo.Size = new System.Drawing.Size(81, 58);
			this.pictureBox1DineroBingo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox1DineroBingo.TabIndex = 15;
			this.pictureBox1DineroBingo.TabStop = false;
			// 
			// pictureBox2DineroLoteria
			// 
			this.pictureBox2DineroLoteria.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2DineroLoteria.Image")));
			this.pictureBox2DineroLoteria.Location = new System.Drawing.Point(285, 255);
			this.pictureBox2DineroLoteria.Name = "pictureBox2DineroLoteria";
			this.pictureBox2DineroLoteria.Size = new System.Drawing.Size(81, 58);
			this.pictureBox2DineroLoteria.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox2DineroLoteria.TabIndex = 16;
			this.pictureBox2DineroLoteria.TabStop = false;
			// 
			// lbPoteLoteria
			// 
			this.lbPoteLoteria.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold);
			this.lbPoteLoteria.Location = new System.Drawing.Point(285, 232);
			this.lbPoteLoteria.Name = "lbPoteLoteria";
			this.lbPoteLoteria.Size = new System.Drawing.Size(149, 23);
			this.lbPoteLoteria.TabIndex = 17;
			this.lbPoteLoteria.Text = "Dinero a sortear :";
			// 
			// lblDineroPoteLoteria
			// 
			this.lblDineroPoteLoteria.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
			this.lblDineroPoteLoteria.Location = new System.Drawing.Point(352, 276);
			this.lblDineroPoteLoteria.Name = "lblDineroPoteLoteria";
			this.lblDineroPoteLoteria.Size = new System.Drawing.Size(106, 23);
			this.lblDineroPoteLoteria.TabIndex = 18;
			this.lblDineroPoteLoteria.Text = "0";
			// 
			// lblM_Bienvenidos
			// 
			this.lblM_Bienvenidos.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold);
			this.lblM_Bienvenidos.Location = new System.Drawing.Point(85, 27);
			this.lblM_Bienvenidos.Name = "lblM_Bienvenidos";
			this.lblM_Bienvenidos.Size = new System.Drawing.Size(293, 36);
			this.lblM_Bienvenidos.TabIndex = 19;
			this.lblM_Bienvenidos.Text = "¡BIENVENIDOS AL CLUB DE \r\nBINGO Y LOTERIA!\r\n!";
			this.lblM_Bienvenidos.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(470, 319);
			this.Controls.Add(this.lblDineroPoteLoteria);
			this.Controls.Add(this.lbPoteLoteria);
			this.Controls.Add(this.btnB_EmpezarJuego);
			this.Controls.Add(this.btnB_ComprarCarton);
			this.Controls.Add(this.btnSortearLoteria);
			this.Controls.Add(this.btnL_ComprarCartonLoteria);
			this.Controls.Add(this.lblDineroPoteBingo);
			this.Controls.Add(this.lbPoteBingo);
			this.Controls.Add(this.pictboxLoteria);
			this.Controls.Add(this.pictboxBingo);
			this.Controls.Add(this.menuStrip1);
			this.Controls.Add(this.pictureBox1DineroBingo);
			this.Controls.Add(this.pictureBox2DineroLoteria);
			this.Controls.Add(this.lblM_Bienvenidos);
			this.MainMenuStrip = this.menuStrip1;
			this.MaximumSize = new System.Drawing.Size(486, 358);
			this.MinimumSize = new System.Drawing.Size(486, 358);
			this.Name = "MainForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Juego de loto";
			this.Load += new System.EventHandler(this.MainFormLoad);
			((System.ComponentModel.ISupportInitialize)(this.pictboxBingo)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictboxLoteria)).EndInit();
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1DineroBingo)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox2DineroLoteria)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.ToolStripMenuItem totalRecaudadoToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem dineroDelClubDeLoteríaToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem dineroDelClubDeBingoToolStripMenuItem;
		private System.Windows.Forms.Label lblM_Bienvenidos;
		private System.Windows.Forms.Label lblDineroPoteLoteria;
		private System.Windows.Forms.Label lbPoteLoteria;
		private System.Windows.Forms.PictureBox pictureBox2DineroLoteria;
		private System.Windows.Forms.PictureBox pictureBox1DineroBingo;
		private System.Windows.Forms.ToolStripMenuItem historialDeLaLoteriaToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem historialDelBingoToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem informacionToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem dineroClubToolStripMenuItem;
		private System.Windows.Forms.Button btnB_EmpezarJuego;
		private System.Windows.Forms.Button btnB_ComprarCarton;
		private System.Windows.Forms.ToolStripMenuItem opcionesToolStripMenuItem;
		private System.Windows.Forms.MenuStrip menuStrip1;
		private System.Windows.Forms.Button btnSortearLoteria;
		private System.Windows.Forms.Button btnL_ComprarCartonLoteria;
		private System.Windows.Forms.Label lblDineroPoteBingo;
		private System.Windows.Forms.Label lbPoteBingo;
		private System.Windows.Forms.PictureBox pictboxLoteria;
		private System.Windows.Forms.PictureBox pictboxBingo;
	}
}
