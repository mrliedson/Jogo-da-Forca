/*
 * Created by SharpDevelop.
 * User: aliss
 * Date: 03/10/2024
 * Time: 12:00
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Jogo_da_Forca
{

	public partial class MainForm : Form
	{
		int tentativas = 6;
		string palavra = "__";
		bool button4 = false;
		Button[] botoesColoridos = {};
		
		public MainForm()
		{
		
			InitializeComponent();
			
		}
	
		void dar(bool neutro){
			button_A.Enabled = neutro;
			button_B.Enabled = neutro;
			button_C.Enabled = neutro;
			button_D.Enabled = neutro;
			button_E.Enabled = neutro;
			button_F.Enabled = neutro;
			button_G.Enabled = neutro;
			button_H.Enabled = neutro;
			button_I.Enabled = neutro;
			button_J.Enabled = neutro;
			button_K.Enabled = neutro;
			button_L.Enabled = neutro;
			button_M.Enabled = neutro;
			button_N.Enabled = neutro;
			button_O.Enabled = neutro;
			button_P.Enabled = neutro;
			button_Q.Enabled = neutro;
			button_R.Enabled = neutro;
			button_S.Enabled = neutro;
			button_T.Enabled = neutro;
			button_U.Enabled = neutro;
			button_V.Enabled = neutro;
			button_W.Enabled = neutro;
			button_X.Enabled = neutro;
			button_Y.Enabled = neutro;
			button_Z.Enabled = neutro;
		}
		
		void show (bool visivel){
			button_A.Visible = visivel;
			button_B.Visible = visivel;
			button_C.Visible = visivel;
			button_D.Visible = visivel;
			button_E.Visible = visivel;
			button_F.Visible = visivel;
			button_G.Visible = visivel;
			button_H.Visible = visivel;
			button_I.Visible = visivel;
			button_J.Visible = visivel;
			button_K.Visible = visivel;
			button_L.Visible = visivel;
			button_M.Visible = visivel;
			button_N.Visible = visivel;
			button_O.Visible = visivel;
			button_P.Visible = visivel;
			button_Q.Visible = visivel;
			button_R.Visible = visivel;
			button_S.Visible = visivel;
			button_T.Visible = visivel;
			button_U.Visible = visivel;
			button_V.Visible = visivel;
			button_W.Visible = visivel;
			button_X.Visible = visivel;
			button_Y.Visible = visivel;
			button_Z.Visible = visivel;
		}	
		
		void letra (char letra, Button botao){
			
			bool cont = false;
			botao.Enabled = false;
			for(int i=0; i<palavra.Length; i++){
				if(palavra[i] == letra){
					cont = true;
					botao.BackColor = Color.Green;
					if (i == 0){
						char[] A = label2.Text.ToCharArray();
						A[i] = letra;
						label2.Text = new string(A);
					} else {
						char[] A = label2.Text.ToCharArray();
						A[i+i] = letra;
						label2.Text = new string(A);
					}
					
				}
			}
			if(!label2.Text.Contains("_")){
				label3.Text = "Parabéns! A palavra era " + palavra;
				button3.Enabled = false;
				textBox1.Enabled = false;
				dar(false);
			}
			if (cont == false){
				botao.BackColor = Color.Red;
				listBox2.Items.Add(letra+",");
				tentativas = tentativas - 1;
				label6.Text = tentativas.ToString();
			}
			if (tentativas == 0) {
				dar(false);
			}
		}
		
		void Button1Click(object sender, EventArgs e)
		{
			label1.Visible = true;
			textBox1.Visible = true;
			button3.Visible = true;
			button1.Visible = false;
			button3.Text = "CONFIRMAR";
			button3.Enabled = true;
			textBox1.Enabled = true;
			for(int i =0; i<botoesColoridos.Length; i++){
				botoesColoridos[i].BackColor = Color.Gainsboro;
				Array.Clear(botoesColoridos,0, botoesColoridos.Length);
			}
			
			
			
		}
		
		void Button2Click(object sender, EventArgs e)
		{
			label1.Visible = false;
			label2.Visible = false;
			label3.Visible = false;
			label4.Visible = false;
			label5.Visible = false;
			label6.Visible = false;
			label7.Visible = false;
			label1.Text = "Digite uma palavra:";
			
			panel2.Visible = false;
			listBox2.Visible = false;
			textBox1.Visible = false;
			panel1.Visible = false;
			textBox1.MaxLength = 3000;
			
			button3.Visible = false;
			button2.Visible = false;
			
			listBox2.Items.Clear();
			
			dar(true);
			tentativas = 6;
			
			
			button1.Visible = true;
			show(false);
			
			button4 = false;
				
		}
		
		void Button3Click(object sender, EventArgs e)
		{
			
			if(button4 == false){
				palavra = textBox1.Text.ToUpper();
				label2.Text = (new string('_', palavra.Length)).Replace("_","_ ");
				label2.Visible = true;
				label3.Text = "A Palavra tem " + textBox1.Text.Length + " letras";
				label1.Text = "palpite:";
				label4.Visible = true;
				label5.Visible = true;
				panel2.Visible = true;
				listBox2.Visible = true;
				label3.Visible = true;
				show(true);
			
				textBox1.Text = "";
				textBox1.MaxLength = palavra.Length;
				button2.Visible = true;
				panel1.Visible = true;
				label6.Visible = true;
				label7.Visible = true;
				
				button3.Text = "CHUTAR";
				button4 = true;
				
			} else {
				if (textBox1.Text.ToUpper() == palavra){
					label3.Text = "Parabéns! A palavra era " + palavra;
					
					
				} else {
					label3.Text = "Errou! A palavra era " + palavra;
					
				}
				button3.Enabled = false;
				textBox1.Enabled = false;
				dar(false);
				label2.Text = palavra;
			}
			
		
			
		}
		
		
		// Alphabet order

		void Button_AClick(object sender, EventArgs e)
		{
			letra('A', sender as Button);
		}
		
		void Button_BClick(object sender, EventArgs e)
		{
			letra('B', sender as Button);
		}
		
		void Button_CClick(object sender, EventArgs e)
		{
			letra('C',  sender as Button);
		}
		
		void Button_DClick(object sender, EventArgs e)
		{
			letra('D',  sender as Button);
		}
		
		void Button_EClick(object sender, EventArgs e)
		{
			letra('E',  sender as Button);
		}
		
		void Button_FClick(object sender, EventArgs e)
		{
			letra('F',  sender as Button);
		}
		
		void Button_GClick(object sender, EventArgs e)
		{
			letra('G',  sender as Button);
		}
		
		void Button_HClick(object sender, EventArgs e)
		{
			letra('H',  sender as Button);
		}
		
		void Button_IClick(object sender, EventArgs e)
		{
			letra('I',  sender as Button);
		}
		
		void Button_JClick(object sender, EventArgs e)
		{
			letra('K',  sender as Button);
		}
		
		void Button_LClick(object sender, EventArgs e)
		{
			letra('L',  sender as Button);
		}
		
		void Button_MClick(object sender, EventArgs e)
		{
			letra('M',  sender as Button);
		}
		
		void Button_NClick(object sender, EventArgs e)
		{
			letra('N',  sender as Button);
		}
		
		void Button_OClick(object sender, EventArgs e)
		{
			letra('O',  sender as Button);
		}
		
		void Button_PClick(object sender, EventArgs e)
		{
			letra('P',  sender as Button);
		}
		
		void Button_QClick(object sender, EventArgs e)
		{
			letra('Q',  sender as Button);
		}
		
		void Button_RClick(object sender, EventArgs e)
		{
			letra('R',  sender as Button);
		}
		
		void Button_SClick(object sender, EventArgs e)
		{
			letra('S',  sender as Button);
		}
		
		void Button_TClick(object sender, EventArgs e)
		{
			letra('T',  sender as Button);
		}
		
		void Button_UClick(object sender, EventArgs e)
		{
			letra('U',  sender as Button);
		}
		
		void Button_VClick(object sender, EventArgs e)
		{
			letra('V',  sender as Button);
		}
		
		void Button_WClick(object sender, EventArgs e)
		{
			letra('W',  sender as Button);
		}
		
		void Button_XClick(object sender, EventArgs e)
		{
			letra('X',  sender as Button);
		}
		
		void Button_YClick(object sender, EventArgs e)
		{
			letra('Y',  sender as Button);
		}
		
		void Button_ZClick(object sender, EventArgs e)
		{
			letra('Z',  sender as Button);
		}
	}
}
