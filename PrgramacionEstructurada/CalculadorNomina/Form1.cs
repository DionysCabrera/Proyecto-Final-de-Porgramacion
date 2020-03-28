using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CalculadorNomina
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            tabControl1.Appearance = TabAppearance.FlatButtons;
            tabControl1.ItemSize = new Size(0, 1);
            tabControl1.SizeMode = TabSizeMode.Fixed;
            //tabControl1.Visible = false;
        }

        public bool validar()
        {
            if (TxNombre.Text == "")
            {
                MessageBox.Show("Debe llenar el campo con el Nombre", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }

            if (TxSalario.Text == "")
            {
                MessageBox.Show("Debe llenar el campo con el Salario", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }

            if (TxHoras.Text == "")
            {
                MessageBox.Show("Debe llenar el campo con las Horas", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }

            return true;
        }

        private void BtnCalcular_Click(object sender, EventArgs e)
        {
            if (validar())
            {
                bool _bandera = true;

                #region ValidacionDeTipo
                try
                {
                    Convert.ToInt32(TxHoras.Text);
                }
                catch (Exception)
                {
                    _bandera = false;
                    MessageBox.Show("Invalido", "Las horas No Tienen un Formato Valido", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                try
                {
                    Convert.ToDouble(TxSalario.Text);
                }
                catch (Exception)
                {
                    _bandera = false;
                    MessageBox.Show("Invalido", "El salario No Tienen un Formato Valido", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                #endregion

                if (_bandera)
                {
                    CalcularSalario(Convert.ToDouble(TxSalario.Text), Convert.ToInt32(TxHoras.Text), TxNombre.Text);
                    tabControl1.SelectedTab = tabPage2;
                }

            }
        }
            

        private void CalcularSalario(double pSalario, int pHoras, string pNombre)
        {
            LNombre.Text = pNombre;
            LHorasTotal.Text = Convert.ToString(pHoras);

            int _HorasNormal = 0, _HorasDoble = 0, _HorasTriple = 0;

            //Calcular Horas Trabajadas
            if (pHoras > 40)
            {
                _HorasNormal = 40;
                _HorasDoble = pHoras - 40;

                if (_HorasDoble > 10)
                {
                    _HorasTriple = _HorasDoble - 10;
                    _HorasDoble = 10;
                }
            }
            else { _HorasNormal = pHoras; }

            //Colocando Horas obtenidas
            LHoras.Text = Convert.ToString(_HorasNormal);
            LHorasDoble.Text = Convert.ToString(_HorasDoble);
            LHorasTriples.Text = Convert.ToString(_HorasTriple);

            //Calculando y colocando Montos obtenidos
            LMontoNormal.Text = string.Format("{0:C2}", (_HorasNormal * pSalario));
            LMontoDoble.Text = string.Format("{0:C2}", _HorasDoble * (pSalario*2));
            LMontoTriple.Text = string.Format("{0:C2}", _HorasTriple * (pSalario*3));

            double _TotalMonto = 0;
            _TotalMonto = (_HorasNormal * pSalario) + (_HorasDoble * (pSalario * 2)) + _HorasTriple * (pSalario * 3);
            LMontoTotal.Text = string.Format("{0:C2}", _TotalMonto);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Limpiar();
            tabControl1.SelectedTab = tabPage1;
        }

        public void Limpiar()
        {
            // Limpiando texboxs
            TxHoras.Text = "";
            TxSalario.Text = "";
            TxNombre.Text = "";

            // Limpiando Horas
            LHoras.Text = "";
            LHorasDoble.Text = "";
            LHorasTriples.Text = "";
            LHorasTotal.Text = "";

            // Limpiando Montos
            LMontoNormal.Text = "";
            LMontoDoble.Text = "";
            LMontoTriple.Text = "";
            LMontoTotal.Text = "";
           
        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }
    }

}
