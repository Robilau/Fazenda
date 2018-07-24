namespace Fazenda.Apresentacao.Features.Despesas
{
    partial class CadastroDespesaForm
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
            this.btnCancelar = new System.Windows.Forms.Button();
            this.txtValorTotal = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioEstrutura = new System.Windows.Forms.RadioButton();
            this.radioPlantacao = new System.Windows.Forms.RadioButton();
            this.radioCriacao = new System.Windows.Forms.RadioButton();
            this.label9 = new System.Windows.Forms.Label();
            this.cmbItens = new System.Windows.Forms.ComboBox();
            this.numQuantidade = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtUnidade = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cmbFornecedor = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.datePicker = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbAnimal = new System.Windows.Forms.ComboBox();
            this.lblAnimal = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.numValorUnitario = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.groupBox3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numQuantidade)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numValorUnitario)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCancelar
            // 
            this.btnCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancelar.Location = new System.Drawing.Point(434, 315);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(90, 53);
            this.btnCancelar.TabIndex = 12;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            // 
            // txtValorTotal
            // 
            this.txtValorTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtValorTotal.Location = new System.Drawing.Point(71, 31);
            this.txtValorTotal.Name = "txtValorTotal";
            this.txtValorTotal.ReadOnly = true;
            this.txtValorTotal.Size = new System.Drawing.Size(179, 26);
            this.txtValorTotal.TabIndex = 23;
            this.txtValorTotal.Text = "0,00";
            this.txtValorTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(4, 34);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(61, 13);
            this.label8.TabIndex = 22;
            this.label8.Text = "Valor Total:";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txtValorTotal);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Location = new System.Drawing.Point(12, 302);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(256, 67);
            this.groupBox3.TabIndex = 15;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Dados da Compra";
            // 
            // btnSalvar
            // 
            this.btnSalvar.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnSalvar.Location = new System.Drawing.Point(305, 315);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(123, 53);
            this.btnSalvar.TabIndex = 11;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.numValorUnitario);
            this.groupBox1.Controls.Add(this.radioEstrutura);
            this.groupBox1.Controls.Add(this.radioPlantacao);
            this.groupBox1.Controls.Add(this.radioCriacao);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.cmbItens);
            this.groupBox1.Controls.Add(this.numQuantidade);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txtUnidade);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.cmbFornecedor);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.datePicker);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.cmbAnimal);
            this.groupBox1.Controls.Add(this.lblAnimal);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(512, 231);
            this.groupBox1.TabIndex = 18;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Selecionar Produto";
            // 
            // radioEstrutura
            // 
            this.radioEstrutura.AutoSize = true;
            this.radioEstrutura.Location = new System.Drawing.Point(194, 35);
            this.radioEstrutura.Name = "radioEstrutura";
            this.radioEstrutura.Size = new System.Drawing.Size(67, 17);
            this.radioEstrutura.TabIndex = 3;
            this.radioEstrutura.TabStop = true;
            this.radioEstrutura.Text = "Estrutura";
            this.radioEstrutura.UseVisualStyleBackColor = true;
            // 
            // radioPlantacao
            // 
            this.radioPlantacao.AutoSize = true;
            this.radioPlantacao.Location = new System.Drawing.Point(115, 35);
            this.radioPlantacao.Name = "radioPlantacao";
            this.radioPlantacao.Size = new System.Drawing.Size(73, 17);
            this.radioPlantacao.TabIndex = 2;
            this.radioPlantacao.Text = "Plantação";
            this.radioPlantacao.UseVisualStyleBackColor = true;
            // 
            // radioCriacao
            // 
            this.radioCriacao.AutoSize = true;
            this.radioCriacao.Checked = true;
            this.radioCriacao.Location = new System.Drawing.Point(48, 35);
            this.radioCriacao.Name = "radioCriacao";
            this.radioCriacao.Size = new System.Drawing.Size(61, 17);
            this.radioCriacao.TabIndex = 1;
            this.radioCriacao.TabStop = true;
            this.radioCriacao.Text = "Criação";
            this.radioCriacao.UseVisualStyleBackColor = true;
            this.radioCriacao.CheckedChanged += new System.EventHandler(this.radioCriacao_CheckedChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(11, 35);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(31, 13);
            this.label9.TabIndex = 23;
            this.label9.Text = "Tipo:";
            // 
            // cmbItens
            // 
            this.cmbItens.FormattingEnabled = true;
            this.cmbItens.Location = new System.Drawing.Point(7, 94);
            this.cmbItens.Name = "cmbItens";
            this.cmbItens.Size = new System.Drawing.Size(249, 21);
            this.cmbItens.TabIndex = 5;
            this.cmbItens.DropDown += new System.EventHandler(this.cmbItens_DropDown);
            this.cmbItens.SelectedIndexChanged += new System.EventHandler(this.cmbItens_SelectedIndexChanged);
            // 
            // numQuantidade
            // 
            this.numQuantidade.Location = new System.Drawing.Point(293, 202);
            this.numQuantidade.Name = "numQuantidade";
            this.numQuantidade.Size = new System.Drawing.Size(70, 20);
            this.numQuantidade.TabIndex = 9;
            this.numQuantidade.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.numQuantidade.ValueChanged += new System.EventHandler(this.numQuantidade_ValueChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(290, 185);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(65, 13);
            this.label7.TabIndex = 19;
            this.label7.Text = "Quantidade:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(290, 131);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(73, 13);
            this.label6.TabIndex = 18;
            this.label6.Text = "Valor Unitário:";
            // 
            // txtUnidade
            // 
            this.txtUnidade.Location = new System.Drawing.Point(293, 94);
            this.txtUnidade.Name = "txtUnidade";
            this.txtUnidade.ReadOnly = true;
            this.txtUnidade.Size = new System.Drawing.Size(210, 20);
            this.txtUnidade.TabIndex = 17;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(290, 77);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 13);
            this.label5.TabIndex = 16;
            this.label5.Text = "Unidade:";
            // 
            // cmbFornecedor
            // 
            this.cmbFornecedor.FormattingEnabled = true;
            this.cmbFornecedor.Location = new System.Drawing.Point(7, 148);
            this.cmbFornecedor.Name = "cmbFornecedor";
            this.cmbFornecedor.Size = new System.Drawing.Size(249, 21);
            this.cmbFornecedor.TabIndex = 6;
            this.cmbFornecedor.DropDown += new System.EventHandler(this.cmbFornecedor_DropDown);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(4, 131);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 13);
            this.label4.TabIndex = 14;
            this.label4.Text = "Fornecedor:";
            // 
            // datePicker
            // 
            this.datePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.datePicker.Location = new System.Drawing.Point(7, 202);
            this.datePicker.Name = "datePicker";
            this.datePicker.Size = new System.Drawing.Size(249, 20);
            this.datePicker.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(4, 185);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "Data:";
            // 
            // cmbAnimal
            // 
            this.cmbAnimal.FormattingEnabled = true;
            this.cmbAnimal.Location = new System.Drawing.Point(293, 32);
            this.cmbAnimal.Name = "cmbAnimal";
            this.cmbAnimal.Size = new System.Drawing.Size(210, 21);
            this.cmbAnimal.TabIndex = 10;
            this.cmbAnimal.DropDown += new System.EventHandler(this.cmbAnimal_DropDown);
            // 
            // lblAnimal
            // 
            this.lblAnimal.AutoSize = true;
            this.lblAnimal.Location = new System.Drawing.Point(290, 16);
            this.lblAnimal.Name = "lblAnimal";
            this.lblAnimal.Size = new System.Drawing.Size(41, 13);
            this.lblAnimal.TabIndex = 10;
            this.lblAnimal.Text = "Animal:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(4, 77);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Item: ";
            // 
            // numValorUnitario
            // 
            this.numValorUnitario.DecimalPlaces = 2;
            this.numValorUnitario.Location = new System.Drawing.Point(293, 149);
            this.numValorUnitario.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.numValorUnitario.Name = "numValorUnitario";
            this.numValorUnitario.Size = new System.Drawing.Size(70, 20);
            this.numValorUnitario.TabIndex = 8;
            this.numValorUnitario.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.numValorUnitario.ValueChanged += new System.EventHandler(this.numValorUnitario_ValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(369, 156);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 13);
            this.label2.TabIndex = 28;
            this.label2.Text = "reais.";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(369, 209);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(53, 13);
            this.label10.TabIndex = 29;
            this.label10.Text = "unidades.";
            // 
            // CadastroDespesa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(531, 379);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.btnSalvar);
            this.HelpButton = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "CadastroDespesa";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Cadastro de Despesas";
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numQuantidade)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numValorUnitario)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.TextBox txtValorTotal;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioEstrutura;
        private System.Windows.Forms.RadioButton radioPlantacao;
        private System.Windows.Forms.RadioButton radioCriacao;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cmbItens;
        private System.Windows.Forms.NumericUpDown numQuantidade;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtUnidade;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cmbFornecedor;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker datePicker;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbAnimal;
        private System.Windows.Forms.Label lblAnimal;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown numValorUnitario;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label10;
    }
}