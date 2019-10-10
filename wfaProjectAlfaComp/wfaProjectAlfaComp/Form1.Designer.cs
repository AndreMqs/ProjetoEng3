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
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.btNext = new System.Windows.Forms.Button();
            this.btCancel = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
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
            this.tabPage1.Controls.Add(this.comboBox1);
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
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(795, 395);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // comboBox1
            // 
            this.comboBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Fácil",
            "Médio",
            "Difícil"});
            this.comboBox1.Location = new System.Drawing.Point(637, 73);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(146, 28);
            this.comboBox1.TabIndex = 10;
            // 
            // btNext
            // 
            this.btNext.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btNext.Location = new System.Drawing.Point(6, 196);
            this.btNext.Name = "btNext";
            this.btNext.Size = new System.Drawing.Size(95, 33);
            this.btNext.TabIndex = 11;
            this.btNext.Text = "Next";
            this.btNext.UseVisualStyleBackColor = true;
            // 
            // btCancel
            // 
            this.btCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btCancel.Location = new System.Drawing.Point(7, 248);
            this.btCancel.Name = "btCancel";
            this.btCancel.Size = new System.Drawing.Size(95, 33);
            this.btCancel.TabIndex = 12;
            this.btCancel.Text = "Cancel";
            this.btCancel.UseVisualStyleBackColor = true;
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
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button btCancel;
        private System.Windows.Forms.Button btNext;
    }
}

