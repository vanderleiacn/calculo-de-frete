namespace CalcularFrete
{
    partial class FrmPrincipal
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblValorLitro = new System.Windows.Forms.Label();
            this.txtValorCombustivel = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblTabela = new System.Windows.Forms.Label();
            this.lblAutonomiaCombustivel = new System.Windows.Forms.Label();
            this.lblDistanciaKm = new System.Windows.Forms.Label();
            this.lblLocalidade = new System.Windows.Forms.Label();
            this.checkBoxIdaVolta = new System.Windows.Forms.CheckBox();
            this.lblVeiculo = new System.Windows.Forms.Label();
            this.comboBoxTabela = new System.Windows.Forms.ComboBox();
            this.txtAutonomiaCombustivel = new System.Windows.Forms.TextBox();
            this.txtDistanciaKm = new System.Windows.Forms.TextBox();
            this.txtLocalidade = new System.Windows.Forms.TextBox();
            this.txtVeiculo = new System.Windows.Forms.TextBox();
            this.lblKmRodado = new System.Windows.Forms.Label();
            this.lblCustoPorKm = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.txtKmRodado = new System.Windows.Forms.TextBox();
            this.txtCustoPorKm = new System.Windows.Forms.TextBox();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.btnConfirmar = new System.Windows.Forms.Button();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.ImgVeiculo = new System.Windows.Forms.PictureBox();
            this.txtConsumoCombustivel = new System.Windows.Forms.TextBox();
            this.lblConsumoCombustivel = new System.Windows.Forms.Label();
            this.txtDespesaCombustivel = new System.Windows.Forms.TextBox();
            this.lblDespesaCombustivel = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ImgVeiculo)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Highlight;
            this.panel1.Controls.Add(this.lblValorLitro);
            this.panel1.Controls.Add(this.txtValorCombustivel);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.lblTabela);
            this.panel1.Controls.Add(this.lblAutonomiaCombustivel);
            this.panel1.Controls.Add(this.lblDistanciaKm);
            this.panel1.Controls.Add(this.lblLocalidade);
            this.panel1.Controls.Add(this.checkBoxIdaVolta);
            this.panel1.Controls.Add(this.lblVeiculo);
            this.panel1.Controls.Add(this.comboBoxTabela);
            this.panel1.Controls.Add(this.txtAutonomiaCombustivel);
            this.panel1.Controls.Add(this.txtDistanciaKm);
            this.panel1.Controls.Add(this.txtLocalidade);
            this.panel1.Controls.Add(this.txtVeiculo);
            this.panel1.Location = new System.Drawing.Point(12, 84);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1296, 230);
            this.panel1.TabIndex = 0;
            // 
            // lblValorLitro
            // 
            this.lblValorLitro.AutoSize = true;
            this.lblValorLitro.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValorLitro.Location = new System.Drawing.Point(23, 145);
            this.lblValorLitro.Name = "lblValorLitro";
            this.lblValorLitro.Size = new System.Drawing.Size(163, 29);
            this.lblValorLitro.TabIndex = 13;
            this.lblValorLitro.Text = "Valor por litro:";
            // 
            // txtValorCombustivel
            // 
            this.txtValorCombustivel.BackColor = System.Drawing.SystemColors.ControlLight;
            this.txtValorCombustivel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtValorCombustivel.Location = new System.Drawing.Point(17, 185);
            this.txtValorCombustivel.Name = "txtValorCombustivel";
            this.txtValorCombustivel.Size = new System.Drawing.Size(255, 35);
            this.txtValorCombustivel.TabIndex = 4;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::CalcularFrete.Properties.Resources.veiculos;
            this.pictureBox1.Location = new System.Drawing.Point(924, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(369, 217);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // lblTabela
            // 
            this.lblTabela.AutoSize = true;
            this.lblTabela.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTabela.Location = new System.Drawing.Point(297, 145);
            this.lblTabela.Name = "lblTabela";
            this.lblTabela.Size = new System.Drawing.Size(95, 29);
            this.lblTabela.TabIndex = 10;
            this.lblTabela.Text = "Tabela:";
            // 
            // lblAutonomiaCombustivel
            // 
            this.lblAutonomiaCombustivel.AutoSize = true;
            this.lblAutonomiaCombustivel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAutonomiaCombustivel.Location = new System.Drawing.Point(552, 145);
            this.lblAutonomiaCombustivel.Name = "lblAutonomiaCombustivel";
            this.lblAutonomiaCombustivel.Size = new System.Drawing.Size(272, 29);
            this.lblAutonomiaCombustivel.TabIndex = 9;
            this.lblAutonomiaCombustivel.Text = "Autonomia Combustivel:";
            // 
            // lblDistanciaKm
            // 
            this.lblDistanciaKm.AutoSize = true;
            this.lblDistanciaKm.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDistanciaKm.Location = new System.Drawing.Point(561, 31);
            this.lblDistanciaKm.Name = "lblDistanciaKm";
            this.lblDistanciaKm.Size = new System.Drawing.Size(159, 29);
            this.lblDistanciaKm.TabIndex = 8;
            this.lblDistanciaKm.Text = "Distância Km:";
            // 
            // lblLocalidade
            // 
            this.lblLocalidade.AutoSize = true;
            this.lblLocalidade.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLocalidade.Location = new System.Drawing.Point(297, 31);
            this.lblLocalidade.Name = "lblLocalidade";
            this.lblLocalidade.Size = new System.Drawing.Size(138, 29);
            this.lblLocalidade.TabIndex = 7;
            this.lblLocalidade.Text = "Localidade:";
            // 
            // checkBoxIdaVolta
            // 
            this.checkBoxIdaVolta.AutoSize = true;
            this.checkBoxIdaVolta.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxIdaVolta.Location = new System.Drawing.Point(820, 190);
            this.checkBoxIdaVolta.Name = "checkBoxIdaVolta";
            this.checkBoxIdaVolta.Size = new System.Drawing.Size(99, 24);
            this.checkBoxIdaVolta.TabIndex = 7;
            this.checkBoxIdaVolta.Text = "Ida/Volta";
            this.checkBoxIdaVolta.UseVisualStyleBackColor = true;
            // 
            // lblVeiculo
            // 
            this.lblVeiculo.AutoSize = true;
            this.lblVeiculo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVeiculo.Location = new System.Drawing.Point(23, 31);
            this.lblVeiculo.Name = "lblVeiculo";
            this.lblVeiculo.Size = new System.Drawing.Size(99, 29);
            this.lblVeiculo.TabIndex = 6;
            this.lblVeiculo.Text = "Veículo:";
            // 
            // comboBoxTabela
            // 
            this.comboBoxTabela.BackColor = System.Drawing.SystemColors.ControlLight;
            this.comboBoxTabela.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxTabela.FormattingEnabled = true;
            this.comboBoxTabela.Items.AddRange(new object[] {
            "1",
            "2",
            "3"});
            this.comboBoxTabela.Location = new System.Drawing.Point(281, 186);
            this.comboBoxTabela.Name = "comboBoxTabela";
            this.comboBoxTabela.Size = new System.Drawing.Size(251, 34);
            this.comboBoxTabela.TabIndex = 5;
            // 
            // txtAutonomiaCombustivel
            // 
            this.txtAutonomiaCombustivel.BackColor = System.Drawing.SystemColors.ControlLight;
            this.txtAutonomiaCombustivel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAutonomiaCombustivel.Location = new System.Drawing.Point(557, 185);
            this.txtAutonomiaCombustivel.Name = "txtAutonomiaCombustivel";
            this.txtAutonomiaCombustivel.Size = new System.Drawing.Size(257, 35);
            this.txtAutonomiaCombustivel.TabIndex = 6;
            // 
            // txtDistanciaKm
            // 
            this.txtDistanciaKm.BackColor = System.Drawing.SystemColors.ControlLight;
            this.txtDistanciaKm.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDistanciaKm.Location = new System.Drawing.Point(557, 65);
            this.txtDistanciaKm.Name = "txtDistanciaKm";
            this.txtDistanciaKm.Size = new System.Drawing.Size(257, 35);
            this.txtDistanciaKm.TabIndex = 3;
            // 
            // txtLocalidade
            // 
            this.txtLocalidade.BackColor = System.Drawing.SystemColors.ControlLight;
            this.txtLocalidade.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLocalidade.Location = new System.Drawing.Point(281, 65);
            this.txtLocalidade.Name = "txtLocalidade";
            this.txtLocalidade.Size = new System.Drawing.Size(251, 35);
            this.txtLocalidade.TabIndex = 2;
            // 
            // txtVeiculo
            // 
            this.txtVeiculo.BackColor = System.Drawing.SystemColors.ControlLight;
            this.txtVeiculo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtVeiculo.Location = new System.Drawing.Point(17, 65);
            this.txtVeiculo.Name = "txtVeiculo";
            this.txtVeiculo.Size = new System.Drawing.Size(255, 35);
            this.txtVeiculo.TabIndex = 1;
            this.txtVeiculo.Leave += new System.EventHandler(this.txtVeiculo_Leave);
            // 
            // lblKmRodado
            // 
            this.lblKmRodado.AutoSize = true;
            this.lblKmRodado.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKmRodado.Location = new System.Drawing.Point(35, 587);
            this.lblKmRodado.Name = "lblKmRodado";
            this.lblKmRodado.Size = new System.Drawing.Size(141, 29);
            this.lblKmRodado.TabIndex = 9;
            this.lblKmRodado.Text = "Km Rodado";
            // 
            // lblCustoPorKm
            // 
            this.lblCustoPorKm.AutoSize = true;
            this.lblCustoPorKm.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCustoPorKm.Location = new System.Drawing.Point(257, 587);
            this.lblCustoPorKm.Name = "lblCustoPorKm";
            this.lblCustoPorKm.Size = new System.Drawing.Size(159, 29);
            this.lblCustoPorKm.TabIndex = 10;
            this.lblCustoPorKm.Text = "Custo por Km";
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.Location = new System.Drawing.Point(487, 587);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(68, 29);
            this.lblTotal.TabIndex = 11;
            this.lblTotal.Text = "Total";
            // 
            // txtKmRodado
            // 
            this.txtKmRodado.BackColor = System.Drawing.SystemColors.ControlLight;
            this.txtKmRodado.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtKmRodado.Location = new System.Drawing.Point(29, 619);
            this.txtKmRodado.Name = "txtKmRodado";
            this.txtKmRodado.Size = new System.Drawing.Size(199, 35);
            this.txtKmRodado.TabIndex = 11;
            // 
            // txtCustoPorKm
            // 
            this.txtCustoPorKm.BackColor = System.Drawing.SystemColors.ControlLight;
            this.txtCustoPorKm.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCustoPorKm.Location = new System.Drawing.Point(258, 619);
            this.txtCustoPorKm.Name = "txtCustoPorKm";
            this.txtCustoPorKm.Size = new System.Drawing.Size(211, 35);
            this.txtCustoPorKm.TabIndex = 12;
            // 
            // txtTotal
            // 
            this.txtTotal.BackColor = System.Drawing.SystemColors.ControlLight;
            this.txtTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotal.Location = new System.Drawing.Point(482, 619);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Size = new System.Drawing.Size(220, 35);
            this.txtTotal.TabIndex = 13;
            // 
            // btnConfirmar
            // 
            this.btnConfirmar.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.btnConfirmar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConfirmar.Location = new System.Drawing.Point(29, 346);
            this.btnConfirmar.Name = "btnConfirmar";
            this.btnConfirmar.Size = new System.Drawing.Size(199, 58);
            this.btnConfirmar.TabIndex = 8;
            this.btnConfirmar.Text = "CONFIRMAR";
            this.btnConfirmar.UseVisualStyleBackColor = false;
            this.btnConfirmar.Click += new System.EventHandler(this.btnConfirmar_Click);
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(498, 24);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(308, 32);
            this.lblTitulo.TabIndex = 19;
            this.lblTitulo.Text = "CALCULO DE FRETE";
            // 
            // ImgVeiculo
            // 
            this.ImgVeiculo.Location = new System.Drawing.Point(946, 389);
            this.ImgVeiculo.Name = "ImgVeiculo";
            this.ImgVeiculo.Size = new System.Drawing.Size(337, 252);
            this.ImgVeiculo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ImgVeiculo.TabIndex = 17;
            this.ImgVeiculo.TabStop = false;
            // 
            // txtConsumoCombustivel
            // 
            this.txtConsumoCombustivel.BackColor = System.Drawing.SystemColors.ControlLight;
            this.txtConsumoCombustivel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtConsumoCombustivel.Location = new System.Drawing.Point(249, 466);
            this.txtConsumoCombustivel.Name = "txtConsumoCombustivel";
            this.txtConsumoCombustivel.Size = new System.Drawing.Size(220, 35);
            this.txtConsumoCombustivel.TabIndex = 9;
            // 
            // lblConsumoCombustivel
            // 
            this.lblConsumoCombustivel.AutoSize = true;
            this.lblConsumoCombustivel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConsumoCombustivel.Location = new System.Drawing.Point(24, 472);
            this.lblConsumoCombustivel.Name = "lblConsumoCombustivel";
            this.lblConsumoCombustivel.Size = new System.Drawing.Size(210, 25);
            this.lblConsumoCombustivel.TabIndex = 7;
            this.lblConsumoCombustivel.Text = "Consumo Combustivel";
            // 
            // txtDespesaCombustivel
            // 
            this.txtDespesaCombustivel.BackColor = System.Drawing.SystemColors.ControlLight;
            this.txtDespesaCombustivel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDespesaCombustivel.Location = new System.Drawing.Point(720, 464);
            this.txtDespesaCombustivel.Name = "txtDespesaCombustivel";
            this.txtDespesaCombustivel.Size = new System.Drawing.Size(211, 35);
            this.txtDespesaCombustivel.TabIndex = 10;
            // 
            // lblDespesaCombustivel
            // 
            this.lblDespesaCombustivel.AutoSize = true;
            this.lblDespesaCombustivel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDespesaCombustivel.Location = new System.Drawing.Point(499, 470);
            this.lblDespesaCombustivel.Name = "lblDespesaCombustivel";
            this.lblDespesaCombustivel.Size = new System.Drawing.Size(203, 25);
            this.lblDespesaCombustivel.TabIndex = 8;
            this.lblDespesaCombustivel.Text = "Despesa Combustivel";
            // 
            // FrmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(1312, 675);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.btnConfirmar);
            this.Controls.Add(this.ImgVeiculo);
            this.Controls.Add(this.txtTotal);
            this.Controls.Add(this.txtCustoPorKm);
            this.Controls.Add(this.txtKmRodado);
            this.Controls.Add(this.txtDespesaCombustivel);
            this.Controls.Add(this.txtConsumoCombustivel);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.lblCustoPorKm);
            this.Controls.Add(this.lblKmRodado);
            this.Controls.Add(this.lblDespesaCombustivel);
            this.Controls.Add(this.lblConsumoCombustivel);
            this.Controls.Add(this.panel1);
            this.Name = "FrmPrincipal";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ImgVeiculo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblTabela;
        private System.Windows.Forms.Label lblAutonomiaCombustivel;
        private System.Windows.Forms.Label lblDistanciaKm;
        private System.Windows.Forms.Label lblLocalidade;
        private System.Windows.Forms.Label lblVeiculo;
        private System.Windows.Forms.CheckBox checkBoxIdaVolta;
        private System.Windows.Forms.ComboBox comboBoxTabela;
        private System.Windows.Forms.TextBox txtAutonomiaCombustivel;
        private System.Windows.Forms.TextBox txtDistanciaKm;
        private System.Windows.Forms.TextBox txtLocalidade;
        private System.Windows.Forms.TextBox txtVeiculo;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblKmRodado;
        private System.Windows.Forms.Label lblCustoPorKm;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.TextBox txtKmRodado;
        private System.Windows.Forms.TextBox txtCustoPorKm;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.PictureBox ImgVeiculo;
        private System.Windows.Forms.Button btnConfirmar;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.TextBox txtValorCombustivel;
        private System.Windows.Forms.Label lblValorLitro;
        private System.Windows.Forms.TextBox txtConsumoCombustivel;
        private System.Windows.Forms.Label lblConsumoCombustivel;
        private System.Windows.Forms.TextBox txtDespesaCombustivel;
        private System.Windows.Forms.Label lblDespesaCombustivel;
    }
}

