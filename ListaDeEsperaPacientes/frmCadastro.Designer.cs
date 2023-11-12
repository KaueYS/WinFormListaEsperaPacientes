namespace ListaDeEsperaPacientes
{
    partial class frmCadastro
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCadastro));
            grdCadastro = new DataGridView();
            groupBox1 = new GroupBox();
            label6 = new Label();
            txtId = new TextBox();
            ckFinalizado = new CheckBox();
            txtObs = new TextBox();
            label5 = new Label();
            dtCadastro = new DateTimePicker();
            txtTelefone = new MaskedTextBox();
            txtEmail = new TextBox();
            txtNome = new TextBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            CadastrotoolStrip1 = new ToolStrip();
            CadastrartoolStripButton1 = new ToolStripButton();
            AlterartoolStripButton1 = new ToolStripButton();
            ExcluirtoolStripButton2 = new ToolStripButton();
            LimpartoolStripButton3 = new ToolStripButton();
            SairtoolStripButton4 = new ToolStripButton();
            ((System.ComponentModel.ISupportInitialize)grdCadastro).BeginInit();
            groupBox1.SuspendLayout();
            CadastrotoolStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // grdCadastro
            // 
            grdCadastro.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            grdCadastro.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            grdCadastro.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            grdCadastro.Location = new Point(12, 214);
            grdCadastro.Name = "grdCadastro";
            grdCadastro.ReadOnly = true;
            grdCadastro.RowHeadersVisible = false;
            grdCadastro.RowTemplate.Height = 25;
            grdCadastro.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            grdCadastro.Size = new Size(860, 406);
            grdCadastro.TabIndex = 6;
            grdCadastro.CellClick += grdCadastro_CellClick;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = SystemColors.ControlLight;
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(txtId);
            groupBox1.Controls.Add(ckFinalizado);
            groupBox1.Controls.Add(txtObs);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(dtCadastro);
            groupBox1.Controls.Add(txtTelefone);
            groupBox1.Controls.Add(txtEmail);
            groupBox1.Controls.Add(txtNome);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.ForeColor = SystemColors.ControlDarkDark;
            groupBox1.Location = new Point(12, 28);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(860, 180);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Informações do paciente";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = SystemColors.ControlLight;
            label6.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label6.ForeColor = SystemColors.ControlDarkDark;
            label6.Location = new Point(692, 19);
            label6.Name = "label6";
            label6.Size = new Size(82, 15);
            label6.TabIndex = 13;
            label6.Text = "Identificador:";
            label6.Visible = false;
            // 
            // txtId
            // 
            txtId.BackColor = SystemColors.MenuBar;
            txtId.Location = new Point(692, 37);
            txtId.Name = "txtId";
            txtId.Size = new Size(82, 23);
            txtId.TabIndex = 12;
            txtId.Visible = false;
            // 
            // ckFinalizado
            // 
            ckFinalizado.AutoSize = true;
            ckFinalizado.Location = new Point(692, 91);
            ckFinalizado.Name = "ckFinalizado";
            ckFinalizado.Size = new Size(86, 19);
            ckFinalizado.TabIndex = 5;
            ckFinalizado.Text = "Agendado?";
            ckFinalizado.UseVisualStyleBackColor = true;
            // 
            // txtObs
            // 
            txtObs.BackColor = SystemColors.MenuBar;
            txtObs.Location = new Point(6, 142);
            txtObs.Name = "txtObs";
            txtObs.Size = new Size(626, 23);
            txtObs.TabIndex = 4;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = SystemColors.ControlLight;
            label5.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = SystemColors.ControlDarkDark;
            label5.Location = new Point(6, 126);
            label5.Name = "label5";
            label5.Size = new Size(75, 15);
            label5.TabIndex = 9;
            label5.Text = "Observação:";
            // 
            // dtCadastro
            // 
            dtCadastro.CalendarMonthBackground = SystemColors.ScrollBar;
            dtCadastro.Format = DateTimePickerFormat.Short;
            dtCadastro.Location = new Point(420, 87);
            dtCadastro.Name = "dtCadastro";
            dtCadastro.Size = new Size(212, 23);
            dtCadastro.TabIndex = 3;
            // 
            // txtTelefone
            // 
            txtTelefone.BackColor = SystemColors.MenuBar;
            txtTelefone.Location = new Point(420, 37);
            txtTelefone.Mask = "(99) 00000-0000";
            txtTelefone.Name = "txtTelefone";
            txtTelefone.Size = new Size(212, 23);
            txtTelefone.TabIndex = 1;
            // 
            // txtEmail
            // 
            txtEmail.BackColor = SystemColors.MenuBar;
            txtEmail.Location = new Point(6, 91);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(352, 23);
            txtEmail.TabIndex = 2;
            // 
            // txtNome
            // 
            txtNome.BackColor = SystemColors.MenuBar;
            txtNome.Location = new Point(6, 37);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(352, 23);
            txtNome.TabIndex = 0;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = SystemColors.ControlLight;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = SystemColors.ControlDarkDark;
            label4.Location = new Point(420, 69);
            label4.Name = "label4";
            label4.Size = new Size(87, 15);
            label4.TabIndex = 3;
            label4.Text = "Data Cadastro:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = SystemColors.ControlLight;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = SystemColors.ControlDarkDark;
            label3.Location = new Point(420, 19);
            label3.Name = "label3";
            label3.Size = new Size(59, 15);
            label3.TabIndex = 2;
            label3.Text = "Telefone:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = SystemColors.ControlLight;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.ControlDarkDark;
            label2.Location = new Point(6, 75);
            label2.Name = "label2";
            label2.Size = new Size(39, 15);
            label2.TabIndex = 1;
            label2.Text = "Email:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.ControlLight;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ControlDarkDark;
            label1.Location = new Point(6, 19);
            label1.Name = "label1";
            label1.Size = new Size(44, 15);
            label1.TabIndex = 0;
            label1.Text = "Nome:";
            // 
            // CadastrotoolStrip1
            // 
            CadastrotoolStrip1.Items.AddRange(new ToolStripItem[] { CadastrartoolStripButton1, AlterartoolStripButton1, ExcluirtoolStripButton2, LimpartoolStripButton3, SairtoolStripButton4 });
            CadastrotoolStrip1.Location = new Point(0, 0);
            CadastrotoolStrip1.Name = "CadastrotoolStrip1";
            CadastrotoolStrip1.RenderMode = ToolStripRenderMode.Professional;
            CadastrotoolStrip1.Size = new Size(884, 25);
            CadastrotoolStrip1.TabIndex = 7;
            CadastrotoolStrip1.Text = "Cadastrar";
            // 
            // CadastrartoolStripButton1
            // 
            CadastrartoolStripButton1.Image = (Image)resources.GetObject("CadastrartoolStripButton1.Image");
            CadastrartoolStripButton1.ImageTransparentColor = Color.Magenta;
            CadastrartoolStripButton1.Name = "CadastrartoolStripButton1";
            CadastrartoolStripButton1.Size = new Size(77, 22);
            CadastrartoolStripButton1.Text = "Cadastrar";
            CadastrartoolStripButton1.Click += CadastrartoolStripButton1_Click;
            // 
            // AlterartoolStripButton1
            // 
            AlterartoolStripButton1.Image = (Image)resources.GetObject("AlterartoolStripButton1.Image");
            AlterartoolStripButton1.ImageTransparentColor = Color.Magenta;
            AlterartoolStripButton1.Name = "AlterartoolStripButton1";
            AlterartoolStripButton1.Size = new Size(62, 22);
            AlterartoolStripButton1.Text = "Alterar";
            AlterartoolStripButton1.Click += AlterartoolStripButton1_Click;
            // 
            // ExcluirtoolStripButton2
            // 
            ExcluirtoolStripButton2.Image = (Image)resources.GetObject("ExcluirtoolStripButton2.Image");
            ExcluirtoolStripButton2.ImageTransparentColor = Color.Magenta;
            ExcluirtoolStripButton2.Name = "ExcluirtoolStripButton2";
            ExcluirtoolStripButton2.Size = new Size(62, 22);
            ExcluirtoolStripButton2.Text = "Excluir";
            ExcluirtoolStripButton2.Click += ExcluirtoolStripButton2_Click;
            // 
            // LimpartoolStripButton3
            // 
            LimpartoolStripButton3.Image = (Image)resources.GetObject("LimpartoolStripButton3.Image");
            LimpartoolStripButton3.ImageTransparentColor = Color.Magenta;
            LimpartoolStripButton3.Name = "LimpartoolStripButton3";
            LimpartoolStripButton3.Size = new Size(64, 22);
            LimpartoolStripButton3.Text = "Limpar";
            LimpartoolStripButton3.Click += LimpartoolStripButton3_Click;
            // 
            // SairtoolStripButton4
            // 
            SairtoolStripButton4.Image = (Image)resources.GetObject("SairtoolStripButton4.Image");
            SairtoolStripButton4.ImageTransparentColor = Color.Magenta;
            SairtoolStripButton4.Name = "SairtoolStripButton4";
            SairtoolStripButton4.Size = new Size(51, 22);
            SairtoolStripButton4.Text = "SAIR";
            SairtoolStripButton4.Click += SairtoolStripButton4_Click;
            // 
            // frmCadastro
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            CausesValidation = false;
            ClientSize = new Size(884, 632);
            ControlBox = false;
            Controls.Add(CadastrotoolStrip1);
            Controls.Add(groupBox1);
            Controls.Add(grdCadastro);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "frmCadastro";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Tela de cadastro";
            Load += frmCadastro_Load;
            ((System.ComponentModel.ISupportInitialize)grdCadastro).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            CadastrotoolStrip1.ResumeLayout(false);
            CadastrotoolStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView grdCadastro;
        private GroupBox groupBox1;
        private ToolStrip CadastrotoolStrip1;
        private ToolStripButton CadastrartoolStripButton1;
        private MaskedTextBox txtTelefone;
        private TextBox txtEmail;
        private TextBox txtNome;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private DateTimePicker dtCadastro;
        private CheckBox ckFinalizado;
        private TextBox txtObs;
        private Label label5;
        private ToolStripButton AlterartoolStripButton1;
        private ToolStripButton ExcluirtoolStripButton2;
        private ToolStripButton LimpartoolStripButton3;
        private ToolStripButton SairtoolStripButton4;
        private TextBox txtId;
        private Label label6;
    }
}