/*
 * Creado por SharpDevelop.
 * Usuario: Propietario
 * Fecha: 07/12/2019
 * Hora: 09:34 a. m.
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace SEMINARIO
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
		public MainForm()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		void TextBox3TextChanged(object sender, EventArgs e)
		{
	
		}
		void MainFormLoad(object sender, EventArgs e)
		{
	
		}
		void BtnNumerosParesClick(object sender, EventArgs e)
		{
			txtResultado.Text = "";
			int limiteInferior, limiteSuperior;
			int.TryParse(txtLimiteInferior.Text, out limiteInferior);
			int.TryParse(txtLimeteSuperior.Text, out limiteSuperior);
			
			for(int i=limiteInferior; i<=limiteSuperior; i= i+1)
			{
				if ((i % 2) == 0)
				{
					txtResultado.Text = txtResultado.Text + i.ToString() + "\r\n";
				}
				
			}
		}
		
		void BtnNumerosNonesClick(object sender, EventArgs e)
		{
			txtResultado.Text = "";
			int limiteInferior, limiteSuperior;
			int.TryParse(txtLimiteInferior.Text, out limiteInferior);
			int.TryParse(txtLimeteSuperior.Text, out limiteSuperior);
			
			for(int i=limiteInferior; i<=limiteSuperior; i= i+1)
			{
				if ((i % 2) != 0)
				{
					txtResultado.Text = txtResultado.Text + i.ToString() + "\r\n";
				}
				
			}
		}
		
		void BtnMultiplosde4Click(object sender, EventArgs e)
		{
			txtResultado.Text = "";
			int limiteInferior, limiteSuperior;
			int.TryParse(txtLimiteInferior.Text, out limiteInferior);
			int.TryParse(txtLimeteSuperior.Text, out limiteSuperior);
			
			for(int i=limiteInferior; i<=limiteSuperior; i= i+1)
			{
				if ((i % 4) == 0)
				{
					txtResultado.Text = txtResultado.Text + i.ToString() + "\r\n";
				}
				
			}
		}
		
		void BtnNumerosPrimosClick(object sender, EventArgs e)
		{
			txtResultado.Text = "";
			int limiteInferior, limiteSuperior;
			int.TryParse(txtLimiteInferior.Text, out limiteInferior);
			int.TryParse(txtLimeteSuperior.Text, out limiteSuperior);
			
			for(int i=3; i<=limiteSuperior; i= i+1)
			{
				bool esPrimo = true;
				for(int j=2; j<i; j=j+1)
				{
					if ((i % j) == 0)
					{
						esPrimo=false;
						break;
					}
				}
				if (esPrimo==true)
				   txtResultado.Text = txtResultado.Text + i.ToString() + "\r\n";
			}
		}
	}
}
