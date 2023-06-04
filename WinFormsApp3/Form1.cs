using AltoHttp;
using OfficeOpenXml.FormulaParsing.LexicalAnalysis;
using System.Diagnostics;
using System.Windows.Forms;
using System.Xml.Serialization;


namespace WinFormsApp3
{
    public partial class Form1 : Form
    {

        // Deklarerar de olika variablarna som anv�nds i koden
        float f�rstaNum;
        float andraNum;
        float totalNum;
        string op;

        public Form1()
        {
            InitializeComponent();
        }

        //l�gger in alla knappar f�r nummer
        private void button10_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "0";

        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "1";

        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "2";

        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "3";

        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "4";

        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "5";

        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "6";

        }

        private void button7_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "7";

        }

        private void button8_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "8";

        }

        private void button9_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "9";

        }

        //l�gger in alla knappar f�r funktioner
        private void buttonPlus_Click(object sender, EventArgs e)
        {
            op = "+";
            f�rstaNum = float.Parse(textBox1.Text);
            textBox1.Text = "";
        }

        private void buttonMinus_Click(object sender, EventArgs e)
        {
            op = "-";
            f�rstaNum = float.Parse(textBox1.Text);
            textBox1.Text = "";
        }

        private void buttonMultiplikation_Click(object sender, EventArgs e)
        {
            op = "*";
            f�rstaNum = float.Parse(textBox1.Text);
            textBox1.Text = "";
        }

        private void buttonDelat_Click(object sender, EventArgs e)
        {
            op = "/";
            f�rstaNum = float.Parse(textBox1.Text);
            textBox1.Text = "";
        }

        private void buttonAns_Click(object sender, EventArgs e)
        {
            andraNum = float.Parse(textBox1.Text);

            if (op == "+") totalNum = f�rstaNum + andraNum;
            if (op == "-") totalNum = f�rstaNum - andraNum;
            if (op == "*") totalNum = f�rstaNum * andraNum;
            if (op == "/") totalNum = f�rstaNum / andraNum;

            textBox1.Text = totalNum.ToString();
        }

        // funktion f�r komma
        private void buttonKomma_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + ",";
        }
        // f�r att deleta sista numret
        private void buttonDel_Click(object sender, EventArgs e)
        {
            string s = "0";
            string value = "0";
            if (textBox1.Text.Length > 1)
            {
                s = textBox1.Text;
                value = s.Substring(0, s.Length - 1);
            }
            textBox1.Text = value;
        }
        // vandlar om fr�n + till - eller - till +

        private void buttonomvandling_Click(object sender, EventArgs e)
        {
            op = "+/-";
            f�rstaNum = float.Parse(textBox1.Text);

            if (op == "+/-") totalNum = f�rstaNum * -1;
            textBox1.Text = totalNum.ToString();

        }

        private const string filNamn = "G:\\My Drive\\programeirng\\sparanaknemo";
        private void buttonSave_Click(object sender, EventArgs e)
        {
            // Kollar om det finns n�got nummer i textbox1 och sedan sparar den det numret.
            string data = textBox1.Text;

            try
            {
                // Sparar det nya talet och om det finns ett tal i filen s� skrivs det �ver
                using (StreamWriter writer = new StreamWriter(filNamn))
                {
                    writer.WriteLine(data);
                }

                MessageBox.Show("Talet sparades!");
            }
            catch (Exception)
            {
                MessageBox.Show("Ett fel uppstod");
            }
        }

        // B�rjar spela en video p� youtube om man skriver 420 eller 69

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

            if (textBox1.Text == "420")
            {
                // �ppna youtube och b�rja video
                string url = "https://www.youtube.com/watch?v=C6Le7luzv2Y";
                Process.Start(new ProcessStartInfo
                {
                    FileName = url,
                    UseShellExecute = true
                });
            }

            if (textBox1.Text == "69")
            {
                // �ppna youtube och b�rja video
                string url = "https://www.youtube.com/watch?v=4-BgweAN8hI";
                Process.Start(new ProcessStartInfo
                {
                    FileName = url,
                    UseShellExecute = true
                });
            }
        }

        private void button11_Click(object sender, EventArgs e)
        {
            try
            {
                // Kollar om datafilen existerar
                if (File.Exists(filNamn))
                {
                    // L�ser datan fr�n filen
                    using (StreamReader reader = new StreamReader(filNamn))
                    {
                        string data = reader.ReadLine();
                        if (data != null)
                        {
                            // splittar upp datan fr�n textbox 1 och 2
                            string[] values = data.Split(',');
                            textBox1.Text = values[0];
                            textBox2.Text = values[1];
                        }
                    }

                    MessageBox.Show("Talet laddades!");
                }
                else
                {
                    MessageBox.Show("Ingen data hittades");
                }
            }
            catch (Exception)
            {

            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        // r�knar ut upph�jt 
        private void button16_Click(object sender, EventArgs e)
        {
            op = "rotenUpph�jt";
            f�rstaNum = float.Parse(textBox1.Text);

            if (op == "rotenUpph�jt") totalNum = f�rstaNum * f�rstaNum;
            textBox1.Text = totalNum.ToString();
        }

        // clearar allt i rutan
        private void buttonClear_Click(object sender, EventArgs e)
        {
            textBox1.Text = String.Empty;
        }

        // r�knar ut roten ur
        private void buttonRoten_Click(object sender, EventArgs e)
        {
            op = "rotenRotenur";
            f�rstaNum = float.Parse(textBox1.Text);

            if (op == "rotenRotenur")
                totalNum = (float)Math.Sqrt(f�rstaNum);
            textBox1.Text = totalNum.ToString();


        }

        // r�knar ut sin
        private void buttonSin_Click(object sender, EventArgs e)
        {
            op = "sin";
            f�rstaNum = float.Parse(textBox1.Text);

            if (op == "sin") ;
            totalNum = (float)Math.Sin(f�rstaNum);
            textBox1.Text = totalNum.ToString();
        }

        // r�knar ut cos
        private void buttonCos_Click(object sender, EventArgs e)
        {
            op = "cos";
            f�rstaNum = float.Parse(textBox1.Text);

            if (op == "cos") ;
            totalNum = (float)Math.Cos(f�rstaNum);
            textBox1.Text = totalNum.ToString();
        }

        // r�knar ut tan
        private void buttonTan_Click(object sender, EventArgs e)
        {
            op = "tan";
            f�rstaNum = float.Parse(textBox1.Text);

            if (op == "tan") ;
            totalNum = (float)Math.Tan(f�rstaNum);
            textBox1.Text = totalNum.ToString();
        }

        // l�gger in Pi
        private void buttonPi_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + Math.PI;
        }

        // l�gger in e
        private void buttonE_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + Math.E;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}