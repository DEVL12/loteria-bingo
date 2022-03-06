using System;
using System.Drawing;
using System.Windows.Forms;
using System.Collections.Generic;

namespace ProyectoAlp
{
	public partial class Loteria : Form
	{
		private Int32 L_NumerosDeCartones = 0,L_Veces = 0,L_CambiarEntreCarton = 0;
		public Int32 _L_NumerosDeCartones {get { return L_NumerosDeCartones; }set { L_NumerosDeCartones = value; }}
		
		private Int32 J = 0, a = 0;
		private Int32[] L_Repetidos = new Int32[6];
		private Int32[] L_CartonGanador = new Int32[6];
		private Int32[] L_CartonesConAciertos;
		
		private bool L_ValidacionNumeros = false, L_AplicacionCierre = false, RepartirDinero = false , IniciarSorteo = false;
		
		public bool _IniciarSorteo {get { return IniciarSorteo; }set { IniciarSorteo = value; }}
		public bool _L_AplicacionCierre {get { return L_AplicacionCierre; }set { L_AplicacionCierre = value; }}
		
		List <Int32> L_Cartones = new List<Int32>();
		
		public Loteria()
		{
			InitializeComponent();
		}
		
		// FORMULARIO
		void LoteriaLoad(object sender, EventArgs e)
		{
			L_NumerosDeCartones++;
			lblNumeroDeCarton.Text = Convert.ToString(L_NumerosDeCartones);
			
			ValoresIniciales();
		}
		
		void LoteriaFormClosing(object sender, FormClosingEventArgs e)
		{
			DialogResult Cierre = DialogResult.None;
			
			if(L_AplicacionCierre == false && IniciarSorteo == false){
				Cierre = MessageBox.Show("¿Desea cerrar?, si cierra la ventana no se guardarán los cambios","ADVERTENCIA",MessageBoxButtons.YesNo,MessageBoxIcon.Exclamation);
				
				if(Cierre == DialogResult.No){
					e.Cancel = true;
				}
				else{
					L_NumerosDeCartones--;
				}
			}
			if (IniciarSorteo == true) {
				L_NumerosDeCartones = 0;
				L_Cartones.Clear();
				IniciarSorteo = false;
			}
		}
		
		//BOTONES
		private void BtnIngresarNumeroClick(object sender, EventArgs e){
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
					L_Repetidos[L_Veces] = Numero;
					L_ValidacionNumeros = ValidarNumerosRepetidos(L_Repetidos,L_Veces);
				
					if(L_ValidacionNumeros){
					
						txtbIngresarNumero.Text = "0";
						L_Veces++;
				
						switch (L_Veces) {
						
							case 1:lblNumero1.Text = Convert.ToString(Numero);break;
							case 2:lblNumero2.Text = Convert.ToString(Numero);break;
							case 3:lblNumero3.Text = Convert.ToString(Numero);break;
							case 4:lblNumero4.Text = Convert.ToString(Numero);break;
							case 5:lblNumero5.Text = Convert.ToString(Numero);break;
							case 6:lblNumero6.Text = Convert.ToString(Numero);break;
						}	
					}
					else{
						MessageBox.Show("No se aceptan numeros repetidos","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
					}
				}
			}
			
			if(L_Veces == 6){
				btnIngresarNumero.Enabled = false;
				btnGuardarCarton.Enabled = true;
			}
		}
		
		void BtnGuardarCartonClick(object sender, EventArgs e)
		{
			bool ValidarCartonRepetido = false;
			DialogResult Resultado = DialogResult.None;
			
			Resultado = MessageBox.Show("¿Desea Guardar los numeros?","Registrar",MessageBoxButtons.YesNo,MessageBoxIcon.Information);
			
			if(Resultado == DialogResult.No){
				ValoresIniciales();
			}
			else{
				
				ValidarCartonRepetido = CartonesRepetidos(L_Cartones,L_Repetidos);
				
				if(ValidarCartonRepetido){
					L_AplicacionCierre = true;
				
					for (Int32 i = 0; i < L_Repetidos.Length; i++) {
						L_Cartones.Add(L_Repetidos[i]);
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
		
		void BtnGenerarNumeroGanadorClick(object sender, EventArgs e)
		{
			btnGenerarNumeroGanador.Enabled = false;
			btnFinDelSorteo.Enabled = true;
			
			Random Aleatorio = new Random();
			
			bool EncontrarRepetido = true;
			
			for (Int32 i = 0; i < 6; i++) {

				L_CartonGanador[i] = Convert.ToInt32(Aleatorio.Next(1,42));
				EncontrarRepetido = ValidarNumerosRepetidos(L_CartonGanador,i);
				
				switch (i) {
						case 0: lblNumeroGanador1.Text = Convert.ToString(L_CartonGanador[0]);break;
						case 1: lblNumeroGanador2.Text = Convert.ToString(L_CartonGanador[1]);break;
						case 2: lblNumeroGanador3.Text = Convert.ToString(L_CartonGanador[2]);break;
						case 3: lblNumeroGanador4.Text = Convert.ToString(L_CartonGanador[3]);break;
						case 4: lblNumeroGanador5.Text = Convert.ToString(L_CartonGanador[4]);break;
						case 5: lblNumeroGanador6.Text = Convert.ToString(L_CartonGanador[5]);break;
				}
				
				if (EncontrarRepetido == false) {
					i--;
				}
			}
			MostrarCartonesConAciertos();
		}
		
		void BtnAnteriorCrtnEnJuegoClick(object sender, EventArgs e)
		{
			L_CambiarEntreCarton--;
			CambiarEntreCartonesEnJuego();
		}
		
		void BtnSiguienteCrtnEnJuegoClick(object sender, EventArgs e)
		{
			L_CambiarEntreCarton++;
			CambiarEntreCartonesEnJuego();
		}
		
		void BtnFinDelSorteoClick(object sender, EventArgs e)
		{
			this.Close();
		}
		
		//CAJA DE TEXTO
		private void TxtbIngresarNumeroKeyPress(object sender, KeyPressEventArgs e)
		{
			if(Char.IsLetter(e.KeyChar) || e.KeyChar == ',' || e.KeyChar == '.'){
				e.Handled =true;
				MessageBox.Show("Solamente se admiten numeros, intente de nuevo","ERROR",MessageBoxButtons.OK,MessageBoxIcon.Error);
			}
		}
		
		//----METODOS Y FUNCIONES-----//
		public bool CartonesRepetidos(List<Int32> HOLA,Int32[] ArregloAComparar){
		
		Int32 j = 0, P = HOLA.Count,Coincidecias = 0;
		bool Iguales = true;
		
		for (Int32 i = 0; i < P; i++) {
			Coincidecias = 0;
			for (Int32 a = 0; a < 6; a++) {
				for (Int32 b = j; b < j+6; b++) {
					if(b < P){
						if(ArregloAComparar[a] == HOLA[b]){
							Coincidecias++;
							if(Coincidecias > 5 && Iguales == true){
								Iguales = false;
							}
						}
					}
				}
			}
			j = j + 6;
		}
			return Iguales;
		}
			
		public bool ValidarNumerosRepetidos(Int32[] Arreglo, Int32 x){
		
			for (Int32 i = 0; i <= x; i++) {
				for (Int32 a = 0; a <= x ; a++) {
					if((i != a) && (Arreglo[i] == Arreglo[a])){
						return false;
					}
				}
			}
			return true;
		}
		
		private void ValoresIniciales(){
			if(IniciarSorteo == true){
				
				CambiarEntreCartonesEnJuego();
				MinimumSize = new Size(707, 357); MaximumSize = new Size (707, 357);
				btnGuardarCarton.Visible = false; txtbIngresarNumero.Visible = false;
				btnIngresarNumero.Visible = false; lblIngreseNumero.Visible = false;
				lblRegistroDeCarton.Visible = false; lblNumeroDeCarton.Visible = false;
				lblTituloLoteria.Visible = false; btnAnteriorCrtnEnJuego.Visible = true;
				btnSiguienteCrtnEnJuego.Visible = true; lblCartonEnJuegoNumero.Visible = true;
				lblNumeroCartonEnJuego.Visible = true; lblCartonesEnJuego.Visible = true;
				btnFinDelSorteo.Enabled = false; txtbMostrarCartonesGanadores.Text = "";
				PictureBoxPelotasDeLoteria1.Visible = true; PictureBoxPelotasDeLoteria2.Visible = true;
				L_AplicacionCierre = true;
			}
			else{
				MinimumSize = new Size(263, 337); MaximumSize = new Size (263, 337);
				btnGuardarCarton.Visible = true; txtbIngresarNumero.Visible = true;
				btnIngresarNumero.Visible = true; lblIngreseNumero.Visible = true;
				lblRegistroDeCarton.Visible = true; lblNumeroDeCarton.Visible = true;
				lblTituloLoteria.Visible = true; btnAnteriorCrtnEnJuego.Visible = false;
				btnSiguienteCrtnEnJuego.Visible = false; lblCartonEnJuegoNumero.Visible = false;
				lblNumeroCartonEnJuego.Visible = false; lblCartonesEnJuego.Visible = false;
				PictureBoxPelotasDeLoteria1.Visible = false; PictureBoxPelotasDeLoteria2.Visible = false;

				L_Veces = 0;
			
				txtbIngresarNumero.Text = "0";
			
				lblNumero1.Text = "*"; lblNumeroGanador1.Text = "*";
				lblNumero2.Text = "*"; lblNumeroGanador2.Text = "*";
				lblNumero3.Text = "*"; lblNumeroGanador3.Text = "*";
				lblNumero4.Text = "*"; lblNumeroGanador4.Text = "*";
				lblNumero5.Text = "*"; lblNumeroGanador5.Text = "*";
				lblNumero6.Text = "*"; lblNumeroGanador6.Text = "*";
			
				for (Int32 i = 0; i < 6; i++) {
					L_Repetidos[i] = 0;
				}
			
				btnIngresarNumero.Enabled = true; btnGuardarCarton.Enabled = false;
				btnGenerarNumeroGanador.Enabled = true; L_AplicacionCierre = false;
				RepartirDinero = false; L_CambiarEntreCarton = 0;				
			}
		}
		
		private void CambiarEntreCartonesEnJuego(){
			if(L_Cartones.Count != 0){
				lblNumeroCartonEnJuego.Text = Convert.ToString(L_CambiarEntreCarton+1);
				J = L_CambiarEntreCarton * 6;
				Int32 w = 0;
					for ( a = J; a < J+6 ; a++) {
				
						switch (w) {
							case 0 :lblNumero1.Text = Convert.ToString(L_Cartones[a]);break;
							case 1 :lblNumero2.Text = Convert.ToString(L_Cartones[a]);break;
							case 2 :lblNumero3.Text = Convert.ToString(L_Cartones[a]);break;
							case 3 :lblNumero4.Text = Convert.ToString(L_Cartones[a]);break;
							case 4 :lblNumero5.Text = Convert.ToString(L_Cartones[a]);break;
							case 5 :lblNumero6.Text = Convert.ToString(L_Cartones[a]);break;
						}
					w++;
					}
			
					if(a + 6 > L_Cartones.Count){
						btnSiguienteCrtnEnJuego.Enabled = false;
					}
					else{
						btnSiguienteCrtnEnJuego.Enabled  = true;
					}
			
					if(a - 6 <= 0){
						btnAnteriorCrtnEnJuego.Enabled = false;
					}
					else{
						btnAnteriorCrtnEnJuego.Enabled = true;
					}
			}
		}
		
		private void MostrarCartonesConAciertos(){
			Coincidencias(L_Cartones,L_CartonGanador);
		
			for (Int32 i  = 0; i < L_NumerosDeCartones-1; i ++) {
				if(L_CartonesConAciertos[i] > 2){
					RepartirDinero = true;
					txtbMostrarCartonesGanadores.Text += Convert.ToString("Cartón N#  " + (i +1) + " || Acierto " + L_CartonesConAciertos[i] + "   ");
				}
			}
		}

		private void Coincidencias(List<Int32> Cartonsito, Int32[] Comparacion){
			
		Int32 X = 0, P = Cartonsito.Count, Iguales = 0;
		L_CartonesConAciertos = new Int32 [L_NumerosDeCartones-1];
		
		for (Int32 i = 0; i < L_NumerosDeCartones-1; i++) {
			Iguales = 0;
			for (Int32 a = 0; a < 6; a++) {
				for (Int32 b = X; b < X+6; b++) {
					if(b < P){
						if(Comparacion[a] == Cartonsito[b]){
							Iguales++;
						}
					}
				}
			}
			L_CartonesConAciertos[i] = Iguales;
			X = X + 6;
		}
		}
		
		public Int32 RepartirDineroDeLosGanadores(Int32 DineroPote){
			Int32 Aciertos3 = 0, Aciertos4 = 0, Aciertos5 = 0, Aciertos6 = 0, Porcentajes = 0;
			
			if(RepartirDinero){
				for(Int32 CONTADOR = 0; CONTADOR < L_CartonesConAciertos.Length; CONTADOR++){
					if(L_CartonesConAciertos[CONTADOR] == 3){
						Aciertos3++;
					}
					else if(L_CartonesConAciertos[CONTADOR] == 4){
						Aciertos4++;
					}
					else if(L_CartonesConAciertos[CONTADOR] == 5){
						Aciertos5++;
					}
					else if(L_CartonesConAciertos[CONTADOR] == 6){
						Aciertos6++;
					}
				}
				
				if(Aciertos6 != 0){
					Porcentajes = Convert.ToInt32(DineroPote*0.25);
					MessageBox.Show("Se ha encontrado un cartón con un total de 6 aciertos y se ha ganado " + Porcentajes + "$","Ganador",MessageBoxButtons.OK,MessageBoxIcon.Information);
					DineroPote -= Porcentajes;
				}
				if(Aciertos5 != 0){
					Porcentajes = Convert.ToInt32(DineroPote*0.20);
					if(Aciertos5 == 1){
						MessageBox.Show("Se ha encontrado un cartón con un total de 5 aciertos y se ha ganado " + Porcentajes + "$","Ganador",MessageBoxButtons.OK,MessageBoxIcon.Information);	
					}
					else{
						MessageBox.Show("Se ha encontrado un total de " + Aciertos5 + " cartones con 5 aciertos y cada ganador recibe " + (Porcentajes/Aciertos5) + "$","Ganador",MessageBoxButtons.OK,MessageBoxIcon.Information);
					}
					DineroPote -=Porcentajes;
				}
				if(Aciertos4 != 0){
					Porcentajes = Convert.ToInt32(DineroPote*0.20);
					if(Aciertos4 == 1){
						MessageBox.Show("Se ha encontrado un cartón con un total de 4 aciertos y se ha ganado " + Porcentajes + "$","Ganador",MessageBoxButtons.OK,MessageBoxIcon.Information);	
					}
					else{
						MessageBox.Show("Se ha encontrado un total de " + Aciertos4 + " cartones con 4 aciertos y cada ganador recibe " + (Porcentajes/Aciertos4) + "$","Ganador",MessageBoxButtons.OK,MessageBoxIcon.Information);
					}
					DineroPote -=Porcentajes;
				}
				if(Aciertos3 != 0){
					Porcentajes = Convert.ToInt32(DineroPote*0.25);
					if(Aciertos3 == 1){
						MessageBox.Show("Se ha encontrado un cartón con un total de 3 aciertos y se ha ganado " + Porcentajes + "$","Ganador",MessageBoxButtons.OK,MessageBoxIcon.Information);	
					}
					else{
						MessageBox.Show("Se ha encontrado un total de " + Aciertos3 + " cartones con 4 aciertos y cada ganador recibe " + (Porcentajes/Aciertos3) + "$","Ganador",MessageBoxButtons.OK,MessageBoxIcon.Information);
					}
					DineroPote -=Porcentajes;
				}	
			}
			
			MessageBox.Show("Quedó un total de: "+ DineroPote +" $","Dinero restante",MessageBoxButtons.OK,MessageBoxIcon.Information);
			MessageBox.Show("Ganando el club de loteria un total de "+ (DineroPote/2) +" $ y lo restante para el siguiente juego","Dinero restante",MessageBoxButtons.OK,MessageBoxIcon.Information);
	
			return DineroPote;
		}
	}
}