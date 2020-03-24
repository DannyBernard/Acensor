using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Acensor
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		 private float llenara()
		{
			float[] PesoArray = new float[10];
			float[] ascensor = new float[10];
			TextBox[] aTextbox = { Peso1textBox, Peso2textBox, Peso3textBox, Peso4textBox, Peso5textBox, Peso6textBox, Peso7textBox, Peso8textBox, Peso9textBox, Peso10textBox };
			
		
		

			for (int i = 0; i < 10; i++)
			{
				
					PesoArray[i] = Convert.ToSingle(aTextbox[i].Text);
			
			}
			Random r = new Random();
			
			float nums = PesoArray.Sum();
			textBox10.Text = nums.ToString();
			
			if (nums >= 2000)
			{
				PesoStatustextBox.Text = "Max P";
				//PesoStatustextBox.BackColor = Color.Red;
				//PesoStatustextBox.ForeColor = Color.Blue;
			}
			else
			{
				PesoStatustextBox.Text = "Listo";
				//PesoStatustextBox.BackColor = Color.Green;
				//PesoStatustextBox.ForeColor = Color.Blue;
			}


			

			
			return 0;

		}
		 private int RandomD()
		{
			var giud = Guid.NewGuid();
			var justNumers = new String(giud.ToString().Where(Char.IsDigit).ToArray());
			var seed = int.Parse(justNumers.Substring(0, 4));

			var ramdom = new Random(seed);
			int value = ramdom.Next(1, 6);
			return value;
		}

		private void Llenar()
		{
			int[] Personas = new int [10];
			int num;
			int[] elejidos = new int[5];

			Personas[0] = Convert.ToInt32(Peso1textBox.Text);
			Personas[1] = Convert.ToInt32(Peso2textBox.Text);
			Personas[2] = Convert.ToInt32(Peso3textBox.Text);
			Personas[3] = Convert.ToInt32(Peso4textBox.Text);
			Personas[4] = Convert.ToInt32(Peso5textBox.Text);
			Personas[5] = Convert.ToInt32(Peso6textBox.Text);
			Personas[6] = Convert.ToInt32(Peso7textBox.Text);
			Personas[7] = Convert.ToInt32(Peso8textBox.Text);
			Personas[8] = Convert.ToInt32(Peso9textBox.Text);
			Personas[9] = Convert.ToInt32(Peso10textBox.Text);

			 for(int i =0; i < 5; i++)
			{
				
				num = RandomD();
				elejidos[i] = Personas[num];

			}

			textBox10.Text = elejidos[0].ToString();
			textBox11.Text = elejidos[1].ToString();
			textBox12.Text = elejidos[2].ToString();
			textBox13.Text = elejidos[3].ToString();
			textBox14.Text = elejidos[4].ToString();

		}

		public void SubirBajar()
		{
          
		}

		private void button1_Click(object sender, EventArgs e)
		{
			Llenar();
			//llenara();
		}

		
	}

	
}
