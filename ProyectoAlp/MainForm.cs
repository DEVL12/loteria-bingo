using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace ProyectoAlp
{
	public partial class MainForm : Form
	{
		InicioDeSeccion Logueo = new InicioDeSeccion();
		Bingo UsarBingo = new Bingo();
		Loteria UsarLoteria = new Loteria();
		
		private Int32 LoteriaPote = 0, BingoPote = 0, DineroRepartidoGanadores = 0, DineroGanadoBingo = 0, DineroGanadoLoteria = 0;
		
		List <Int32> LoteriaHistorial = new List<Int32>();
		List <Int32> BingoHistorial = new List<Int32>();
	
		
		public MainForm()
		{
			InitializeComponent();
		}
		
		// Mostrar los otros formularios
		void MainFormLoad(object sender, EventArgs e)
		{
			Logueo.ShowDialog();
			
			if(Logueo._InicioSeccion == false){
				this.Close();
			}
		}
		
		// BOTONES
		void BtnComprarCartonLoteriaClick(object sender, EventArgs e)
		{	
			SumarDineroLoteria();
			UsarLoteria.ShowDialog();
			if(UsarLoteria._L_AplicacionCierre == false){
				LoteriaPote -=100;
				lblDineroPoteLoteria.Text = Convert.ToString(LoteriaPote);
			}
		}
		
		void BtnSortearLoteriaClick(object sender, EventArgs e)
		{
			if(UsarLoteria._L_NumerosDeCartones > 0){
				UsarLoteria._IniciarSorteo = true;
				UsarLoteria.ShowDialog();
				DineroRepartidoGanadores = UsarLoteria.RepartirDineroDeLosGanadores(LoteriaPote);
				DineroRepartidoGanadores = LoteriaPote - DineroRepartidoGanadores;
				LoteriaPote = LoteriaPote - DineroRepartidoGanadores;
				LoteriaPote /= 2;
				DineroGanadoLoteria += LoteriaPote;
				lblDineroPoteLoteria.Text = Convert.ToString(LoteriaPote);
				LoteriaHistorial.Add(DineroRepartidoGanadores);
				LoteriaHistorial.Add(LoteriaPote);
			}
			else{
				MessageBox.Show("Debe haber almenos un cartón para sortear","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
			}
		}
		
		void BtnB_ComprarCartonClick(object sender, EventArgs e)
		{
			SumarDineroBingo();
			UsarBingo.ShowDialog();
			if(UsarBingo._B_AplicacionCierre == false){
				BingoPote -= 100;
				lblDineroPoteBingo.Text = Convert.ToString(BingoPote);
			}
			
		}
		
		void BtnB_EmpezarJuegoClick(object sender, EventArgs e)
		{
			if(UsarBingo._B_NumerosDeCartones > 0){
				UsarBingo._B_IniciarJuego = true;
				UsarBingo.ShowDialog();
				DineroRepartidoGanadores = UsarBingo.RepartirDinero(BingoPote);
				DineroRepartidoGanadores = BingoPote - DineroRepartidoGanadores;
				BingoPote = BingoPote - DineroRepartidoGanadores;
				BingoPote /= 2;
				DineroGanadoBingo += BingoPote;
				lblDineroPoteBingo.Text = Convert.ToString(BingoPote);
				BingoHistorial.Add(DineroRepartidoGanadores);
				BingoHistorial.Add(BingoPote);
			}
			else{
				MessageBox.Show("Debe haber almenos un cartón para sortear","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);		
			}
		}
		
		//MenuStrip
		void HistorialDelBingoToolStripMenuItemClick(object sender, EventArgs e)
		{
			if(BingoHistorial.Count == 0){
				MessageBox.Show("Aún no se ha hecho ningún sorteo intente mas tarde.","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
			}
			else{
				Int32 Numerito = 1;
				for (Int32 a = 0;  a < BingoHistorial.Count ;  a+=2) {
					MessageBox.Show("Sorteo N# "+(Numerito)+".\nSe repartió entre los ganadores "+BingoHistorial[a]+"$ y el club ganó "+BingoHistorial[a+1] +"$","Historial bingo",MessageBoxButtons.OK,MessageBoxIcon.Information);
					Numerito++;
				}
			}
		}
		
		void HistorialDeLaLoteriaToolStripMenuItemClick(object sender, EventArgs e)
		{
			if(LoteriaHistorial.Count == 0){
				MessageBox.Show("Aún no se ha hecho ningún sorteo intente mas tarde.","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
			}
			else{
				Int32 Numerito = 1;
				for (Int32 a = 0;  a < LoteriaHistorial.Count ;  a+=2) {
					MessageBox.Show("Sorteo N# "+(Numerito)+".\nSe repartió entre los ganadores "+LoteriaHistorial[a]+"$ y el club ganó "+LoteriaHistorial[a+1]+"$","Historial loteria",MessageBoxButtons.OK,MessageBoxIcon.Information);
					Numerito++;
				}	
			}
		}
		
		void OpcionesToolStripMenuItemClick(object sender, EventArgs e)
		{
			MessageBox.Show("Henrry Alvares\nJose Diaz\nOriana Pacheco\nRichellys Castillo\nRafzymar Escobar","Integrantes",MessageBoxButtons.OK,MessageBoxIcon.Information);
		}
		
		void DineroDelClubDeBingoToolStripMenuItemClick(object sender, EventArgs e)
		{
			MessageBox.Show("El club de bingo ha ganado un total de: "+ DineroGanadoBingo +" $","Dinero del club",MessageBoxButtons.OK,MessageBoxIcon.Information);
		}
		
		void DineroDelClubDeLoteríaToolStripMenuItemClick(object sender, EventArgs e)
		{
			MessageBox.Show("El club de lotería ha ganado un total de: "+ DineroGanadoLoteria +" $","Dinero del club",MessageBoxButtons.OK,MessageBoxIcon.Information);	
		}
		
		void TotalRecaudadoToolStripMenuItemClick(object sender, EventArgs e)
		{
			MessageBox.Show("Entre el club de bingo y lotería se ha recaudado un total de: "+ (DineroGanadoBingo+DineroGanadoLoteria) +" $","Dinero del club",MessageBoxButtons.OK,MessageBoxIcon.Information);
		}
		
		// FUNCIONES
		private void SumarDineroLoteria(){
			LoteriaPote += 100;
			lblDineroPoteLoteria.Text = Convert.ToString(LoteriaPote);
		}
		
		private void SumarDineroBingo(){
			BingoPote += 100;
			lblDineroPoteBingo.Text = Convert.ToString(BingoPote);
		}
	}
}