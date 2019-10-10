namespace wfaProjectAlfaComp
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.btCancel = new System.Windows.Forms.Button();
            this.btNext = new System.Windows.Forms.Button();
            this.cbContrato = new System.Windows.Forms.ComboBox();
            this.lbContrato = new System.Windows.Forms.Label();
            this.txtDescricao = new System.Windows.Forms.RichTextBox();
            this.lbDescricao = new System.Windows.Forms.Label();
            this.cbDificuldade = new System.Windows.Forms.ComboBox();
            this.lbDificuldade = new System.Windows.Forms.Label();
            this.cbSoftware = new System.Windows.Forms.ComboBox();
            this.txtNomeCliente = new System.Windows.Forms.TextBox();
            this.btProcurar = new System.Windows.Forms.Button();
            this.lbSoftware = new System.Windows.Forms.Label();
            this.lbNomeCliente = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.cbDificuldade2 = new System.Windows.Forms.ComboBox();
            this.lbDificuldade2 = new System.Windows.Forms.Label();
            this.cbSoftware2 = new System.Windows.Forms.ComboBox();
            this.lbSoftware2 = new System.Windows.Forms.Label();
            this.btAlterações = new System.Windows.Forms.Button();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.lbCliente2 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.lbTempoGasto = new System.Windows.Forms.Label();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.lbProcedimento = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lbTecnico = new System.Windows.Forms.Label();
            this.lbTituloProblema = new System.Windows.Forms.Label();
            this.txtTituloProblema = new System.Windows.Forms.TextBox();
            this.cbCategoria = new System.Windows.Forms.ComboBox();
            this.lbCategoria = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(1, 3);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(803, 421);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.btCancel);
            this.tabPage1.Controls.Add(this.btNext);
            this.tabPage1.Controls.Add(this.cbContrato);
            this.tabPage1.Controls.Add(this.lbContrato);
            this.tabPage1.Controls.Add(this.txtDescricao);
            this.tabPage1.Controls.Add(this.lbDescricao);
            this.tabPage1.Controls.Add(this.cbDificuldade);
            this.tabPage1.Controls.Add(this.lbDificuldade);
            this.tabPage1.Controls.Add(this.cbSoftware);
            this.tabPage1.Controls.Add(this.txtNomeCliente);
            this.tabPage1.Controls.Add(this.btProcurar);
            this.tabPage1.Controls.Add(this.lbSoftware);
            this.tabPage1.Controls.Add(this.lbNomeCliente);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(795, 395);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // btCancel
            // 
            this.btCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btCancel.Location = new System.Drawing.Point(7, 352);
            this.btCancel.Name = "btCancel";
            this.btCancel.Size = new System.Drawing.Size(95, 33);
            this.btCancel.TabIndex = 12;
            this.btCancel.Text = "Cancel";
            this.btCancel.UseVisualStyleBackColor = true;
            // 
            // btNext
            // 
            this.btNext.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btNext.Location = new System.Drawing.Point(7, 159);
            this.btNext.Name = "btNext";
            this.btNext.Size = new System.Drawing.Size(95, 33);
            this.btNext.TabIndex = 11;
            this.btNext.Text = "Next";
            this.btNext.UseVisualStyleBackColor = true;
            // 
            // cbContrato
            // 
            this.cbContrato.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.cbContrato.FormattingEnabled = true;
            this.cbContrato.Items.AddRange(new object[] {
            "Válido",
            "Inválido"});
            this.cbContrato.Location = new System.Drawing.Point(637, 73);
            this.cbContrato.Name = "cbContrato";
            this.cbContrato.Size = new System.Drawing.Size(146, 28);
            this.cbContrato.TabIndex = 10;
            // 
            // lbContrato
            // 
            this.lbContrato.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbContrato.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lbContrato.Location = new System.Drawing.Point(536, 69);
            this.lbContrato.Name = "lbContrato";
            this.lbContrato.Size = new System.Drawing.Size(95, 34);
            this.lbContrato.TabIndex = 9;
            this.lbContrato.Text = "Contrato";
            this.lbContrato.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtDescricao
            // 
            this.txtDescricao.Location = new System.Drawing.Point(108, 122);
            this.txtDescricao.Name = "txtDescricao";
            this.txtDescricao.Size = new System.Drawing.Size(681, 267);
            this.txtDescricao.TabIndex = 8;
            this.txtDescricao.Text = "";
            // 
            // lbDescricao
            // 
            this.lbDescricao.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbDescricao.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lbDescricao.Location = new System.Drawing.Point(7, 122);
            this.lbDescricao.Name = "lbDescricao";
            this.lbDescricao.Size = new System.Drawing.Size(95, 34);
            this.lbDescricao.TabIndex = 7;
            this.lbDescricao.Text = "Descrição";
            this.lbDescricao.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cbDificuldade
            // 
            this.cbDificuldade.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.cbDificuldade.FormattingEnabled = true;
            this.cbDificuldade.Items.AddRange(new object[] {
            "Fácil",
            "Médio",
            "Difícil"});
            this.cbDificuldade.Location = new System.Drawing.Point(409, 73);
            this.cbDificuldade.Name = "cbDificuldade";
            this.cbDificuldade.Size = new System.Drawing.Size(121, 28);
            this.cbDificuldade.TabIndex = 6;
            // 
            // lbDificuldade
            // 
            this.lbDificuldade.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbDificuldade.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lbDificuldade.Location = new System.Drawing.Point(308, 69);
            this.lbDificuldade.Name = "lbDificuldade";
            this.lbDificuldade.Size = new System.Drawing.Size(95, 34);
            this.lbDificuldade.TabIndex = 5;
            this.lbDificuldade.Text = "Dificuldade";
            this.lbDificuldade.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cbSoftware
            // 
            this.cbSoftware.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.cbSoftware.FormattingEnabled = true;
            this.cbSoftware.Items.AddRange(new object[] {
            "Little Company\'s SW",
            "Restaurant\'s SW",
            "Big Industry\'s SW"});
            this.cbSoftware.Location = new System.Drawing.Point(108, 73);
            this.cbSoftware.Name = "cbSoftware";
            this.cbSoftware.Size = new System.Drawing.Size(194, 28);
            this.cbSoftware.TabIndex = 4;
            // 
            // txtNomeCliente
            // 
            this.txtNomeCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.txtNomeCliente.Location = new System.Drawing.Point(139, 14);
            this.txtNomeCliente.Name = "txtNomeCliente";
            this.txtNomeCliente.Size = new System.Drawing.Size(603, 38);
            this.txtNomeCliente.TabIndex = 3;
            // 
            // btProcurar
            // 
            this.btProcurar.AutoSize = true;
            this.btProcurar.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.btProcurar.Image = ((System.Drawing.Image)(resources.GetObject("btProcurar.Image")));
            this.btProcurar.Location = new System.Drawing.Point(748, 19);
            this.btProcurar.Name = "btProcurar";
            this.btProcurar.Size = new System.Drawing.Size(35, 33);
            this.btProcurar.TabIndex = 2;
            this.btProcurar.UseVisualStyleBackColor = true;
            // 
            // lbSoftware
            // 
            this.lbSoftware.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbSoftware.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lbSoftware.Location = new System.Drawing.Point(7, 69);
            this.lbSoftware.Name = "lbSoftware";
            this.lbSoftware.Size = new System.Drawing.Size(95, 34);
            this.lbSoftware.TabIndex = 1;
            this.lbSoftware.Text = "Software";
            this.lbSoftware.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbNomeCliente
            // 
            this.lbNomeCliente.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbNomeCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F);
            this.lbNomeCliente.Location = new System.Drawing.Point(6, 14);
            this.lbNomeCliente.Name = "lbNomeCliente";
            this.lbNomeCliente.Size = new System.Drawing.Size(121, 38);
            this.lbNomeCliente.TabIndex = 0;
            this.lbNomeCliente.Text = "Cliente";
            this.lbNomeCliente.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.cbCategoria);
            this.tabPage2.Controls.Add(this.lbCategoria);
            this.tabPage2.Controls.Add(this.lbTituloProblema);
            this.tabPage2.Controls.Add(this.txtTituloProblema);
            this.tabPage2.Controls.Add(this.cbDificuldade2);
            this.tabPage2.Controls.Add(this.lbDificuldade2);
            this.tabPage2.Controls.Add(this.cbSoftware2);
            this.tabPage2.Controls.Add(this.lbSoftware2);
            this.tabPage2.Controls.Add(this.btAlterações);
            this.tabPage2.Controls.Add(this.textBox3);
            this.tabPage2.Controls.Add(this.lbCliente2);
            this.tabPage2.Controls.Add(this.textBox2);
            this.tabPage2.Controls.Add(this.lbTempoGasto);
            this.tabPage2.Controls.Add(this.richTextBox1);
            this.tabPage2.Controls.Add(this.button1);
            this.tabPage2.Controls.Add(this.button2);
            this.tabPage2.Controls.Add(this.lbProcedimento);
            this.tabPage2.Controls.Add(this.textBox1);
            this.tabPage2.Controls.Add(this.lbTecnico);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(795, 395);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // cbDificuldade2
            // 
            this.cbDificuldade2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.cbDificuldade2.FormattingEnabled = true;
            this.cbDificuldade2.Items.AddRange(new object[] {
            "Fácil",
            "Médio",
            "Difícil"});
            this.cbDificuldade2.Location = new System.Drawing.Point(631, 64);
            this.cbDificuldade2.Name = "cbDificuldade2";
            this.cbDificuldade2.Size = new System.Drawing.Size(121, 28);
            this.cbDificuldade2.TabIndex = 33;
            this.cbDificuldade2.Visible = false;
            // 
            // lbDificuldade2
            // 
            this.lbDificuldade2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbDificuldade2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lbDificuldade2.Location = new System.Drawing.Point(530, 60);
            this.lbDificuldade2.Name = "lbDificuldade2";
            this.lbDificuldade2.Size = new System.Drawing.Size(95, 34);
            this.lbDificuldade2.TabIndex = 32;
            this.lbDificuldade2.Text = "Dificuldade";
            this.lbDificuldade2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbDificuldade2.Visible = false;
            // 
            // cbSoftware2
            // 
            this.cbSoftware2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.cbSoftware2.FormattingEnabled = true;
            this.cbSoftware2.Items.AddRange(new object[] {
            "Little Company\'s SW",
            "Restaurant\'s SW",
            "Big Industry\'s SW"});
            this.cbSoftware2.Location = new System.Drawing.Point(589, 116);
            this.cbSoftware2.Name = "cbSoftware2";
            this.cbSoftware2.Size = new System.Drawing.Size(194, 28);
            this.cbSoftware2.TabIndex = 31;
            this.cbSoftware2.Visible = false;
            // 
            // lbSoftware2
            // 
            this.lbSoftware2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbSoftware2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lbSoftware2.Location = new System.Drawing.Point(484, 112);
            this.lbSoftware2.Name = "lbSoftware2";
            this.lbSoftware2.Size = new System.Drawing.Size(95, 34);
            this.lbSoftware2.TabIndex = 30;
            this.lbSoftware2.Text = "Software";
            this.lbSoftware2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbSoftware2.Visible = false;
            // 
            // btAlterações
            // 
            this.btAlterações.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btAlterações.Location = new System.Drawing.Point(22, 313);
            this.btAlterações.Name = "btAlterações";
            this.btAlterações.Size = new System.Drawing.Size(95, 33);
            this.btAlterações.TabIndex = 29;
            this.btAlterações.Text = "Alterações";
            this.btAlterações.UseVisualStyleBackColor = true;
            // 
            // textBox3
            // 
            this.textBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.textBox3.Location = new System.Drawing.Point(357, 64);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(154, 26);
            this.textBox3.TabIndex = 28;
            // 
            // lbCliente2
            // 
            this.lbCliente2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbCliente2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lbCliente2.Location = new System.Drawing.Point(237, 60);
            this.lbCliente2.Name = "lbCliente2";
            this.lbCliente2.Size = new System.Drawing.Size(114, 34);
            this.lbCliente2.TabIndex = 27;
            this.lbCliente2.Text = "Cliente";
            this.lbCliente2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.textBox2.Location = new System.Drawing.Point(126, 64);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(105, 26);
            this.textBox2.TabIndex = 26;
            // 
            // lbTempoGasto
            // 
            this.lbTempoGasto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbTempoGasto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lbTempoGasto.Location = new System.Drawing.Point(6, 60);
            this.lbTempoGasto.Name = "lbTempoGasto";
            this.lbTempoGasto.Size = new System.Drawing.Size(114, 34);
            this.lbTempoGasto.TabIndex = 25;
            this.lbTempoGasto.Text = "Tempo gasto";
            this.lbTempoGasto.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(123, 159);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(669, 235);
            this.richTextBox1.TabIndex = 24;
            this.richTextBox1.Text = "";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.button1.Location = new System.Drawing.Point(22, 352);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(95, 33);
            this.button1.TabIndex = 23;
            this.button1.Text = "Cancel";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.button2.Location = new System.Drawing.Point(22, 196);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(95, 33);
            this.button2.TabIndex = 22;
            this.button2.Text = "Next";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // lbProcedimento
            // 
            this.lbProcedimento.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbProcedimento.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lbProcedimento.Location = new System.Drawing.Point(7, 159);
            this.lbProcedimento.Name = "lbProcedimento";
            this.lbProcedimento.Size = new System.Drawing.Size(113, 34);
            this.lbProcedimento.TabIndex = 19;
            this.lbProcedimento.Text = "Procedimento";
            this.lbProcedimento.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.textBox1.Location = new System.Drawing.Point(159, 10);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(624, 38);
            this.textBox1.TabIndex = 15;
            // 
            // lbTecnico
            // 
            this.lbTecnico.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbTecnico.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F);
            this.lbTecnico.Location = new System.Drawing.Point(6, 10);
            this.lbTecnico.Name = "lbTecnico";
            this.lbTecnico.Size = new System.Drawing.Size(137, 38);
            this.lbTecnico.TabIndex = 13;
            this.lbTecnico.Text = "Técnico";
            this.lbTecnico.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbTituloProblema
            // 
            this.lbTituloProblema.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbTituloProblema.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lbTituloProblema.Location = new System.Drawing.Point(7, 112);
            this.lbTituloProblema.Name = "lbTituloProblema";
            this.lbTituloProblema.Size = new System.Drawing.Size(95, 34);
            this.lbTituloProblema.TabIndex = 35;
            this.lbTituloProblema.Text = "Título";
            this.lbTituloProblema.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtTituloProblema
            // 
            this.txtTituloProblema.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtTituloProblema.Location = new System.Drawing.Point(108, 118);
            this.txtTituloProblema.Name = "txtTituloProblema";
            this.txtTituloProblema.Size = new System.Drawing.Size(123, 26);
            this.txtTituloProblema.TabIndex = 34;
            // 
            // cbCategoria
            // 
            this.cbCategoria.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.cbCategoria.FormattingEnabled = true;
            this.cbCategoria.Items.AddRange(new object[] {
            "Problema",
            "Requisição de serviço",
            "Conexão"});
            this.cbCategoria.Location = new System.Drawing.Point(338, 116);
            this.cbCategoria.Name = "cbCategoria";
            this.cbCategoria.Size = new System.Drawing.Size(140, 28);
            this.cbCategoria.TabIndex = 37;
            // 
            // lbCategoria
            // 
            this.lbCategoria.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbCategoria.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lbCategoria.Location = new System.Drawing.Point(237, 114);
            this.lbCategoria.Name = "lbCategoria";
            this.lbCategoria.Size = new System.Drawing.Size(95, 34);
            this.lbCategoria.TabIndex = 36;
            this.lbCategoria.Text = "Categoria";
            this.lbCategoria.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 422);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TextBox txtNomeCliente;
        private System.Windows.Forms.Button btProcurar;
        private System.Windows.Forms.Label lbSoftware;
        private System.Windows.Forms.Label lbNomeCliente;
        private System.Windows.Forms.ComboBox cbSoftware;
        private System.Windows.Forms.RichTextBox txtDescricao;
        private System.Windows.Forms.Label lbDescricao;
        private System.Windows.Forms.ComboBox cbDificuldade;
        private System.Windows.Forms.Label lbDificuldade;
        private System.Windows.Forms.Label lbContrato;
        private System.Windows.Forms.ComboBox cbContrato;
        private System.Windows.Forms.Button btCancel;
        private System.Windows.Forms.Button btNext;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label lbProcedimento;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label lbTecnico;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label lbTempoGasto;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label lbCliente2;
        private System.Windows.Forms.Button btAlterações;
        private System.Windows.Forms.ComboBox cbDificuldade2;
        private System.Windows.Forms.Label lbDificuldade2;
        private System.Windows.Forms.ComboBox cbSoftware2;
        private System.Windows.Forms.Label lbSoftware2;
        private System.Windows.Forms.ComboBox cbCategoria;
        private System.Windows.Forms.Label lbCategoria;
        private System.Windows.Forms.Label lbTituloProblema;
        private System.Windows.Forms.TextBox txtTituloProblema;
    }
}

