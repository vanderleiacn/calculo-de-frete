using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalcularFrete
{
    public partial class FrmPrincipal : Form
    {
        //variavel gobal
        float kmRodada = 0;
        //float kmAutonomia = 0;
        float qtdCombustivel = 0;
        double  custoCombustivel; //valorCombustivel,
        public FrmPrincipal()
        {
            InitializeComponent();
        }

        private void txtVeiculo_Leave(object sender, EventArgs e) // acontece quando sai fora dele
        {
            if (txtVeiculo.Text == "carro")
            {
                ImgVeiculo.Image = CalcularFrete.Properties.Resources.carro;
            }
            else if (txtVeiculo.Text == "moto")
            {
                ImgVeiculo.Image = CalcularFrete.Properties.Resources.moto;
            }
            else if (txtVeiculo.Text == "caminhao")
            {
                ImgVeiculo.Image = CalcularFrete.Properties.Resources.caminhao;
            }
            else
            {
                MessageBox.Show("Invalido!");
                txtVeiculo.Text = "";// VAI LIMPAR O CAMPO 
                txtVeiculo.Focus(); // FAZ O CURSOR VOLTAR E FICAR PISCANDO
            }


        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            kmRodada = float.Parse(txtDistanciaKm.Text);

            float KmDobrado = 0;
            if (checkBoxIdaVolta.Checked == false)
            {
                KmDobrado = kmRodada * 1; // calcula só a ida
            }
            else if (checkBoxIdaVolta.Checked)
            {
                KmDobrado = kmRodada * 2; //calcula ida e volta
            }

            // consumo do combustivel 
            qtdCombustivel = KmDobrado / float.Parse(txtAutonomiaCombustivel.Text);

            // custo do combustivel // gastei de combustivel 
            custoCombustivel = double.Parse(txtValorCombustivel.Text) * qtdCombustivel;

            txtDespesaCombustivel.Text = custoCombustivel.ToString();

            txtTotal.Text = Convert.ToString(custoCombustivel * int.Parse(comboBoxTabela.Text));

            txtConsumoCombustivel.Text = custoCombustivel.ToString();
            txtKmRodado.Text = KmDobrado.ToString();

            txtCustoPorKm.Text = Convert.ToString(float.Parse(txtTotal.Text) / KmDobrado);       }
    }
}
