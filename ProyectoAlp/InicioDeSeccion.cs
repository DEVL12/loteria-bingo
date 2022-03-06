using System;
using System.Drawing;
using System.Windows.Forms;

namespace ProyectoAlp
{
	
	public partial class InicioDeSeccion : Form
	{
		bool InicioSeccion = false;
		
		public bool _InicioSeccion {get { return InicioSeccion; } set { InicioSeccion = value; } }
		
		public InicioDeSeccion()
		{
			InitializeComponent();

		}
		void BtnContraseñaClick(object sender, EventArgs e)
		{
			string Contrasenia = "HOLA", Dato = "";
			
			Dato = txtbContraseña.Text.ToUpper();
			
			if (Dato == Contrasenia){
				MessageBox.Show("¡CONTRASEÑA CORRECTA, SEA BIENVENIDO!","Logueo",MessageBoxButtons.OK,MessageBoxIcon.Information);
				InicioSeccion = true;
				this.Close();
			}
			else{
				MessageBox.Show("CONTRASEÑA INCORRECTA","Logueo",MessageBoxButtons.OK,MessageBoxIcon.Error);
				txtbContraseña.Text = "";
			}
		}
	}
}