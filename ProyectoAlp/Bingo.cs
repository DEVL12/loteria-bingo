using System;
using System.Drawing;
using System.Windows.Forms;
using System.Collections.Generic;

namespace ProyectoAlp
{
	public partial class Bingo : Form
	{
		Loteria UsarLoteria = new Loteria();
		
		private Int32 B_NumerosDeCartones = 0,B_Veces = 0, B_CambiarEntreCarton = 0, a = 0, J = 0, SiguienteNumero = 0, CantidadGanadores = 0;
		
		public int _B_NumerosDeCartones {get { return B_NumerosDeCartones; }set { B_NumerosDeCartones = value; }}
		
		private Int32[] B_Repetidos = new Int32[6];
		private Int32[] B_NumerosCantados = new Int32[21];
		
		private bool B_ValidacionNumeros = false, B_AplicacionCierre = false, B_IniciarJuego = false;
		
		public bool _B_IniciarJuego {get { return B_IniciarJuego; }set { B_IniciarJuego = value; }}

		public bool _B_AplicacionCierre {get { return B_AplicacionCierre; }set { B_AplicacionCierre = value; }}		
		
		List <Int32> B_Cartones = new List<int>();
		
		public Bingo()
		{
			InitializeComponent();
		}
		
		//FORMULARIO
		void BingoLoad(object sender, EventArgs e)
		{
			B_NumerosDeCartones++;
			lblBingoNumeroDelCarton.Text = Convert.ToString(B_NumerosDeCartones);
			ValoresIniciales();
		}
		
		void BingoFormClosing(object sender, FormClosingEventArgs e)
		{
			DialogResult Cierre = DialogResult.None;
			
			if(B_AplicacionCierre == false && B_IniciarJuego == false){
				Cierre = MessageBox.Show("¿Desea cerrar?, si cierra la ventana no se guardarán los cambios y puede perder su cartón","ADVERTENCIA",MessageBoxButtons.YesNo,MessageBoxIcon.Exclamation);
				
				if(Cierre == DialogResult.No){
					e.Cancel = true;
				}
				else{
					B_NumerosDeCartones--;
				}
			}
			if(B_IniciarJuego == true){
				B_NumerosDeCartones = 0;
				B_Cartones.Clear();
				B_IniciarJuego = false;
			}
		}
		
		//BOTONES
		void BtnRegistrarNumeroClick(object sender, EventArgs e)
		{
			Int32 Numero = 0;
			
			if(txtbIngresarNumero.Text == ""){
				MessageBox.Show("No ha ingresado ningún numero, intente denuevo...","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
			}
			
			else{
				Numero = Convert.ToInt32(txtbIngresarNumero.Text);
				
				if(Numero < 1 || Numero > 42){
					MessageBox.Show("El número está fuera del rango entre 1 y 42","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
				}
				
				else {
					B_Repetidos[B_Veces] = Numero;
					B_ValidacionNumeros = UsarLoteria.ValidarNumerosRepetidos(B_Repetidos,B_Veces);
				
					if(B_ValidacionNumeros){
					
						txtbIngresarNumero.Text = "0";
						B_Veces++;
				
						switch (B_Veces) {
							case 1:lblBNumero1.Text = Convert.ToString(Numero);break;
							case 2:lblBNumero2.Text = Convert.ToString(Numero);break;
							case 3:lblBNumero3.Text = Convert.ToString(Numero);break;
							case 4:lblBNumero4.Text = Convert.ToString(Numero);break;
							case 5:lblBNumero5.Text = Convert.ToString(Numero);break;
							case 6:lblBNumero6.Text = Convert.ToString(Numero);break;
						}	
					}
					else{
						MessageBox.Show("No se aceptan numeros repetidos","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
					}
				}
			}
			
			if(B_Veces == 6){
				btnRegistrarNumero.Enabled = false;
				btnGuardarNumero.Enabled = true;
			}
		}
		
		void BtnSiguienteNumeroClick(object sender, EventArgs e)
		{
			SiguienteNumero++;
			lblMostrarNumeroCantado.Text = Convert.ToString(B_NumerosCantados[SiguienteNumero-1]);
			CantarLosNumeros();
			if (SiguienteNumero > 5) {
				EncontrarGanador();
			}
		}
		
		void BtnGuardarNumeroClick(object sender, EventArgs e)
		{
			bool ValidarCartonRepetido = false;
			DialogResult Resultado = DialogResult.None;
			
			Resultado = MessageBox.Show("¿Desea Guardar los numeros?","Registrar",MessageBoxButtons.YesNo,MessageBoxIcon.Information);
			
			if(Resultado == DialogResult.No){
				ValoresIniciales();
			}
			else{
				ValidarCartonRepetido = UsarLoteria.CartonesRepetidos(B_Cartones,B_Repetidos);
				if(ValidarCartonRepetido){
					B_AplicacionCierre = true;
				
					for (Int32 i = 0; i < B_Repetidos.Length; i++) {
						B_Cartones.Add(B_Repetidos[i]);
					}
					
					MessageBox.Show("¡El carton fue registrado exitosamente!","Registrar",MessageBoxButtons.OK,MessageBoxIcon.Information);
					this.Close();
				}
				else{
					MessageBox.Show("Ya existe un cartón con los mismos numeros. Intente denuevo","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
					ValoresIniciales();
				}
			}
		}
		
		void BtnB_SiguienteCartonEnJuegoClick(object sender, EventArgs e)
		{
			B_CambiarEntreCarton++;
			CambiarEntreCartonesBingo();
		}
		
		void BtnB_AnterioCartonEnJuegoClick(object sender, EventArgs e)
		{
			B_CambiarEntreCarton--;
			CambiarEntreCartonesBingo();
		}
		
		void BtnB_FinalizarClick(object sender, EventArgs e)
		{
			this.Close();
		}
		
		//CAJA DE TEXTO
		void TxtbIngresarNumeroKeyPress(object sender, KeyPressEventArgs e)
		{
			if(Char.IsLetter(e.KeyChar) || e.KeyChar == ',' || e.KeyChar == '.'){
				e.Handled =true;
				MessageBox.Show("Solamente se admiten numeros, intente de nuevo","ERROR",MessageBoxButtons.OK,MessageBoxIcon.Error);
			}
		}
		
		//METODOS Y FUNCIONES
		private void ValoresIniciales(){
			if(B_IniciarJuego == true){
				CambiarEntreCartonesBingo();
				CrearNumerosAleatorios();
				MaximumSize = new Size(686, 370);
				MinimumSize = new Size(686, 370);
				
				B_CambiarEntreCarton = 0; SiguienteNumero = 0;
				btnB_SiguienteCartonEnJuego.Visible = true; btnB_AnterioCartonEnJuego.Visible = true;
				lblB_CartonNumeroEnJuego.Visible = true; lbl_BNumeroDeCartonEnJuego.Visible = true;
				btnB_SiguienteCartonEnJuego.Visible = true; btnB_AnterioCartonEnJuego.Visible = true;
				txtbCartones.Text = ""; txtbMostarGanadores.Text = "";lblBingoTitulo.Visible = false;
				lblBingoCartonNumero.Visible = false; lblBingoNumeroDelCarton.Visible = false;
				txtbIngresarNumero.Visible = false; btnRegistrarNumero.Visible = false;
				lblIngresaUnNumero.Visible = false; btnGuardarNumero.Visible = false;
				lblB_NohayGanadores.Text = "Aún no hay ganadores"; btnB_Finalizar.Enabled = false;
				lblB_NumerosEnJuego.Visible = true; lblMostrarNumeroCantado.Text = "0";
				PictureBoxBingoPelotas1.Visible = true; PictureBoxBingoPelotas2.Visible = true;
				B_AplicacionCierre = true;
			}
			else{
				MaximumSize = new Size(231, 336);
				MinimumSize = new Size(231, 336);
				
				B_CambiarEntreCarton = 0; SiguienteNumero = 0;
				lblB_CartonNumeroEnJuego.Visible = false; lbl_BNumeroDeCartonEnJuego.Visible = false;
				btnB_SiguienteCartonEnJuego.Visible = false; btnB_AnterioCartonEnJuego.Visible = false;
				txtbCartones.Text = ""; lblBingoTitulo.Visible = true;
				lblBingoCartonNumero.Visible = true; lblBingoNumeroDelCarton.Visible = true;
				txtbIngresarNumero.Visible = true; btnRegistrarNumero.Visible = true;
				lblIngresaUnNumero.Visible = true; btnGuardarNumero.Visible = true;
				CantidadGanadores = 0; btnSiguienteNumero.Enabled = true;			
				lblB_NumerosEnJuego.Visible = false;
				PictureBoxBingoPelotas1.Visible = false; PictureBoxBingoPelotas2.Visible = false;
				
				B_Veces = 0;
			
				txtbIngresarNumero.Text = "0";
			
				lblBNumero1.Text = "*";	lblBNumero2.Text = "*";
				lblBNumero3.Text = "*"; lblBNumero4.Text = "*";
				lblBNumero5.Text = "*"; lblBNumero6.Text = "*";
			
				for (Int32 i = 0; i < 6; i++) {
					B_Repetidos[i] = 0;
				}
				
				btnRegistrarNumero.Enabled = true;
				btnGuardarNumero.Enabled = false;
				B_AplicacionCierre = false;
			}
		}
		
		private void CrearNumerosAleatorios(){
			Random Aleatorio = new Random();
			bool RepetidoEncontrado = false;
			
			for(Int32 a = 0; a < 21; a++){

				B_NumerosCantados[a] = Convert.ToInt32(Aleatorio.Next(1,42));
				
				RepetidoEncontrado = UsarLoteria.ValidarNumerosRepetidos(B_NumerosCantados,a);
				
				if(RepetidoEncontrado == false){
					a--;
				}
			}
		}
		
		private void CambiarEntreCartonesBingo(){
			if(B_Cartones.Count != 0){
				lbl_BNumeroDeCartonEnJuego.Text = Convert.ToString(B_CambiarEntreCarton+1);
				J = B_CambiarEntreCarton * 6;
				Int32 w = 0;
					for ( a = J; a < J+6 ; a++) {
				
						switch (w) {
							case 0 :lblBNumero1.Text = Convert.ToString(B_Cartones[a]);break;
							case 1 :lblBNumero2.Text = Convert.ToString(B_Cartones[a]);break;
							case 2 :lblBNumero3.Text = Convert.ToString(B_Cartones[a]);break;
							case 3 :lblBNumero4.Text = Convert.ToString(B_Cartones[a]);break;
							case 4 :lblBNumero5.Text = Convert.ToString(B_Cartones[a]);break;
							case 5 :lblBNumero6.Text = Convert.ToString(B_Cartones[a]);break;
						}
					w++;
					}
			
					if(a + 6 > B_Cartones.Count){
						btnB_SiguienteCartonEnJuego.Enabled = false;
					}
					else{
						btnB_SiguienteCartonEnJuego.Enabled  = true;
					}
			
					if(a - 6 <= 0){
						btnB_AnterioCartonEnJuego.Enabled = false;
					}
					else{
						btnB_AnterioCartonEnJuego.Enabled = true;
					}
			}
		}
		
		private void CantarLosNumeros(){
			
			txtbCartones.Text = "";
			
			for (Int32 a = 0; a < SiguienteNumero; a++) {
				txtbCartones.Text += Convert.ToString(B_NumerosCantados[a]+ " - ");
			}
			
			if (SiguienteNumero+1 > 21) {
				btnSiguienteNumero.Enabled = false;
			}
		}
		
		private void EncontrarGanador(){
			
		int j = 0, P = B_Cartones.Count,Coincidecias = 0, i = 0;
		
		while(i < B_NumerosDeCartones-1){
			Coincidecias = 0;
			for (Int32 a = 0; a < SiguienteNumero; a++) {
				for (Int32 b = j; b < j+6; b++) {
					if(b < P){
						if(B_NumerosCantados[a] == B_Cartones[b]){
							Coincidecias++;
							if(Coincidecias > 5){
								MessageBox.Show("¡BINGO! EL CARTÓN N#" + (i+1) +" HA GANADO!","¡GANADOR!",MessageBoxButtons.OK,MessageBoxIcon.Information);
								btnSiguienteNumero.Enabled = false; btnB_Finalizar.Enabled = true;
								CantidadGanadores++;
								txtbMostarGanadores.Text += Convert.ToString("Cartón N# "+ (i+1)+"   ");
							}
						}
					}
				}
			}
			j = j + 6; i++;
		}
		
			if(CantidadGanadores != 0){
				lblB_NohayGanadores.Text = "¡BINGO!";
			}
			if(btnSiguienteNumero.Enabled == false){
				btnB_Finalizar.Enabled = true;
			}
		}
		
		public Int32 RepartirDinero(Int32 DineroPote){
			
			Int32 Porcentaje = 0;
			
			if(CantidadGanadores != 0){              
				if(CantidadGanadores == 1){
					Porcentaje = Convert.ToInt32(DineroPote*0.70);
					MessageBox.Show("Hay un ganador en el juego de bingo y se lleva un total de "+Porcentaje+"$","Ganador",MessageBoxButtons.OK,MessageBoxIcon.Information);
				}
				else{
					Porcentaje = Convert.ToInt32(DineroPote*0.70);
					MessageBox.Show("Se ha encotrado un total de " + CantidadGanadores + " ganadores y cada uno recibe " +(Porcentaje/CantidadGanadores)+ "$","Ganadores",MessageBoxButtons.OK,MessageBoxIcon.Information);
				}
				DineroPote -= Porcentaje;
			}
			else{
				MessageBox.Show("No hubo ganadores en esta partida","Ganador",MessageBoxButtons.OK,MessageBoxIcon.Information);
			}
			
			MessageBox.Show("Quedó un total de "+DineroPote+"$","Dinero restante",MessageBoxButtons.OK,MessageBoxIcon.Information);
			MessageBox.Show("Ganando el club de bingo un total de "+ (DineroPote/2) +" $ y lo restante para el siguiente juego","Dinero restante",MessageBoxButtons.OK,MessageBoxIcon.Information);
			
			return DineroPote;
			
		}
	}
}