namespace TP08_181828
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.llnota3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.cadastrarbtn = new System.Windows.Forms.Button();
            this.nota4txt = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.nota2txt = new System.Windows.Forms.TextBox();
            this.nota3txt = new System.Windows.Forms.TextBox();
            this.nota1txt = new System.Windows.Forms.TextBox();
            this.disciplinatxt = new System.Windows.Forms.TextBox();
            this.serietxt = new System.Windows.Forms.TextBox();
            this.ratxt = new System.Windows.Forms.TextBox();
            this.dts = new System.Data.DataSet();
            this.Dados = new System.Data.DataTable();
            this.Disciplina = new System.Data.DataColumn();
            this.RA = new System.Data.DataColumn();
            this.Série = new System.Data.DataColumn();
            this.nota1 = new System.Data.DataColumn();
            this.nota2 = new System.Data.DataColumn();
            this.nota3 = new System.Data.DataColumn();
            this.nota4 = new System.Data.DataColumn();
            this.mediafinal = new System.Data.DataColumn();
            this.Aprovação = new System.Data.DataColumn();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.disciplinaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rADataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sérieDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nota1BimestreDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nota2BimestreDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nota3BimestreDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nota4BimestreDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.médiaFinalDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aprovaçãoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.exportarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.textoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.porLinhaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.porColunaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dts)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Dados)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::TP08_181828.Properties.Resources.logo_portal_aluno;
            this.pictureBox1.Location = new System.Drawing.Point(382, 24);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(209, 89);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(4, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 22);
            this.label1.TabIndex = 1;
            this.label1.Text = "Disciplina:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(549, 4);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 22);
            this.label2.TabIndex = 1;
            this.label2.Text = "RA:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(3, 72);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 22);
            this.label3.TabIndex = 2;
            this.label3.Text = "Série:";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.MediumBlue;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.llnota3);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.cadastrarbtn);
            this.panel1.Controls.Add(this.nota4txt);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.nota2txt);
            this.panel1.Controls.Add(this.nota3txt);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.nota1txt);
            this.panel1.Controls.Add(this.disciplinatxt);
            this.panel1.Controls.Add(this.serietxt);
            this.panel1.Controls.Add(this.ratxt);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(106, 110);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(763, 153);
            this.panel1.TabIndex = 3;
            // 
            // llnota3
            // 
            this.llnota3.AutoSize = true;
            this.llnota3.BackColor = System.Drawing.Color.Transparent;
            this.llnota3.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.llnota3.ForeColor = System.Drawing.Color.White;
            this.llnota3.Location = new System.Drawing.Point(353, 4);
            this.llnota3.Name = "llnota3";
            this.llnota3.Size = new System.Drawing.Size(175, 22);
            this.llnota3.TabIndex = 2;
            this.llnota3.Text = "Nota 3ª Bimestre: ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(171, 72);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(170, 22);
            this.label5.TabIndex = 2;
            this.label5.Text = "Nota 2ª Bimestre:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(353, 72);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(170, 22);
            this.label7.TabIndex = 2;
            this.label7.Text = "Nota 4ª Bimestre:";
            // 
            // cadastrarbtn
            // 
            this.cadastrarbtn.BackColor = System.Drawing.Color.DodgerBlue;
            this.cadastrarbtn.Enabled = false;
            this.cadastrarbtn.Font = new System.Drawing.Font("Impact", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cadastrarbtn.ForeColor = System.Drawing.Color.White;
            this.cadastrarbtn.Location = new System.Drawing.Point(550, 65);
            this.cadastrarbtn.Name = "cadastrarbtn";
            this.cadastrarbtn.Size = new System.Drawing.Size(160, 73);
            this.cadastrarbtn.TabIndex = 8;
            this.cadastrarbtn.Text = "CADASTRAR";
            this.cadastrarbtn.UseVisualStyleBackColor = false;
            this.cadastrarbtn.Click += new System.EventHandler(this.cadastrarbtn_Click);
            // 
            // nota4txt
            // 
            this.nota4txt.Enabled = false;
            this.nota4txt.Location = new System.Drawing.Point(357, 97);
            this.nota4txt.MaxLength = 3;
            this.nota4txt.Multiline = true;
            this.nota4txt.Name = "nota4txt";
            this.nota4txt.Size = new System.Drawing.Size(150, 27);
            this.nota4txt.TabIndex = 6;
            this.nota4txt.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            this.nota4txt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.numero_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(172, 4);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(170, 22);
            this.label4.TabIndex = 2;
            this.label4.Text = "Nota 1ª Bimestre:";
            // 
            // nota2txt
            // 
            this.nota2txt.Enabled = false;
            this.nota2txt.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.nota2txt.Location = new System.Drawing.Point(174, 97);
            this.nota2txt.MaxLength = 3;
            this.nota2txt.Multiline = true;
            this.nota2txt.Name = "nota2txt";
            this.nota2txt.Size = new System.Drawing.Size(150, 27);
            this.nota2txt.TabIndex = 4;
            this.nota2txt.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            this.nota2txt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.numero_KeyPress);
            // 
            // nota3txt
            // 
            this.nota3txt.Enabled = false;
            this.nota3txt.Location = new System.Drawing.Point(357, 29);
            this.nota3txt.MaxLength = 3;
            this.nota3txt.Multiline = true;
            this.nota3txt.Name = "nota3txt";
            this.nota3txt.Size = new System.Drawing.Size(150, 27);
            this.nota3txt.TabIndex = 5;
            this.nota3txt.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            this.nota3txt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.numero_KeyPress);
            // 
            // nota1txt
            // 
            this.nota1txt.Enabled = false;
            this.nota1txt.Location = new System.Drawing.Point(176, 29);
            this.nota1txt.MaxLength = 3;
            this.nota1txt.Multiline = true;
            this.nota1txt.Name = "nota1txt";
            this.nota1txt.Size = new System.Drawing.Size(150, 27);
            this.nota1txt.TabIndex = 3;
            this.nota1txt.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            this.nota1txt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.numero_KeyPress);
            // 
            // disciplinatxt
            // 
            this.disciplinatxt.Location = new System.Drawing.Point(7, 29);
            this.disciplinatxt.Multiline = true;
            this.disciplinatxt.Name = "disciplinatxt";
            this.disciplinatxt.Size = new System.Drawing.Size(150, 27);
            this.disciplinatxt.TabIndex = 1;
            this.disciplinatxt.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            this.disciplinatxt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.letra_KeyPress);
            // 
            // serietxt
            // 
            this.serietxt.Enabled = false;
            this.serietxt.Location = new System.Drawing.Point(6, 97);
            this.serietxt.MaxLength = 1;
            this.serietxt.Multiline = true;
            this.serietxt.Name = "serietxt";
            this.serietxt.Size = new System.Drawing.Size(150, 27);
            this.serietxt.TabIndex = 2;
            this.serietxt.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            this.serietxt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.numero_KeyPress);
            // 
            // ratxt
            // 
            this.ratxt.Enabled = false;
            this.ratxt.Location = new System.Drawing.Point(551, 29);
            this.ratxt.MaxLength = 6;
            this.ratxt.Multiline = true;
            this.ratxt.Name = "ratxt";
            this.ratxt.Size = new System.Drawing.Size(150, 27);
            this.ratxt.TabIndex = 7;
            this.ratxt.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            this.ratxt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.numero_KeyPress);
            // 
            // dts
            // 
            this.dts.DataSetName = "NewDataSet";
            this.dts.Tables.AddRange(new System.Data.DataTable[] {
            this.Dados});
            // 
            // Dados
            // 
            this.Dados.Columns.AddRange(new System.Data.DataColumn[] {
            this.Disciplina,
            this.RA,
            this.Série,
            this.nota1,
            this.nota2,
            this.nota3,
            this.nota4,
            this.mediafinal,
            this.Aprovação});
            this.Dados.TableName = "Dados";
            // 
            // Disciplina
            // 
            this.Disciplina.ColumnName = "Disciplina";
            // 
            // RA
            // 
            this.RA.ColumnName = "RA";
            // 
            // Série
            // 
            this.Série.ColumnName = "Série";
            // 
            // nota1
            // 
            this.nota1.ColumnName = "Nota 1° Bimestre";
            // 
            // nota2
            // 
            this.nota2.ColumnName = "Nota 2° Bimestre";
            // 
            // nota3
            // 
            this.nota3.ColumnName = "Nota 3° Bimestre";
            // 
            // nota4
            // 
            this.nota4.ColumnName = "Nota 4° Bimestre";
            // 
            // mediafinal
            // 
            this.mediafinal.ColumnName = "Média Final";
            // 
            // Aprovação
            // 
            this.Aprovação.ColumnName = "Aprovação";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.disciplinaDataGridViewTextBoxColumn,
            this.rADataGridViewTextBoxColumn,
            this.sérieDataGridViewTextBoxColumn,
            this.nota1BimestreDataGridViewTextBoxColumn,
            this.nota2BimestreDataGridViewTextBoxColumn,
            this.nota3BimestreDataGridViewTextBoxColumn,
            this.nota4BimestreDataGridViewTextBoxColumn,
            this.médiaFinalDataGridViewTextBoxColumn,
            this.aprovaçãoDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.bindingSource1;
            this.dataGridView1.Location = new System.Drawing.Point(18, 330);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(944, 190);
            this.dataGridView1.TabIndex = 4;
            // 
            // disciplinaDataGridViewTextBoxColumn
            // 
            this.disciplinaDataGridViewTextBoxColumn.DataPropertyName = "Disciplina";
            this.disciplinaDataGridViewTextBoxColumn.HeaderText = "Disciplina";
            this.disciplinaDataGridViewTextBoxColumn.Name = "disciplinaDataGridViewTextBoxColumn";
            // 
            // rADataGridViewTextBoxColumn
            // 
            this.rADataGridViewTextBoxColumn.DataPropertyName = "RA";
            this.rADataGridViewTextBoxColumn.HeaderText = "RA";
            this.rADataGridViewTextBoxColumn.Name = "rADataGridViewTextBoxColumn";
            // 
            // sérieDataGridViewTextBoxColumn
            // 
            this.sérieDataGridViewTextBoxColumn.DataPropertyName = "Série";
            this.sérieDataGridViewTextBoxColumn.HeaderText = "Série";
            this.sérieDataGridViewTextBoxColumn.Name = "sérieDataGridViewTextBoxColumn";
            // 
            // nota1BimestreDataGridViewTextBoxColumn
            // 
            this.nota1BimestreDataGridViewTextBoxColumn.DataPropertyName = "Nota 1° Bimestre";
            this.nota1BimestreDataGridViewTextBoxColumn.HeaderText = "Nota 1° Bimestre";
            this.nota1BimestreDataGridViewTextBoxColumn.Name = "nota1BimestreDataGridViewTextBoxColumn";
            // 
            // nota2BimestreDataGridViewTextBoxColumn
            // 
            this.nota2BimestreDataGridViewTextBoxColumn.DataPropertyName = "Nota 2° Bimestre";
            this.nota2BimestreDataGridViewTextBoxColumn.HeaderText = "Nota 2° Bimestre";
            this.nota2BimestreDataGridViewTextBoxColumn.Name = "nota2BimestreDataGridViewTextBoxColumn";
            // 
            // nota3BimestreDataGridViewTextBoxColumn
            // 
            this.nota3BimestreDataGridViewTextBoxColumn.DataPropertyName = "Nota 3° Bimestre";
            this.nota3BimestreDataGridViewTextBoxColumn.HeaderText = "Nota 3° Bimestre";
            this.nota3BimestreDataGridViewTextBoxColumn.Name = "nota3BimestreDataGridViewTextBoxColumn";
            // 
            // nota4BimestreDataGridViewTextBoxColumn
            // 
            this.nota4BimestreDataGridViewTextBoxColumn.DataPropertyName = "Nota 4° Bimestre";
            this.nota4BimestreDataGridViewTextBoxColumn.HeaderText = "Nota 4° Bimestre";
            this.nota4BimestreDataGridViewTextBoxColumn.Name = "nota4BimestreDataGridViewTextBoxColumn";
            // 
            // médiaFinalDataGridViewTextBoxColumn
            // 
            this.médiaFinalDataGridViewTextBoxColumn.DataPropertyName = "Média Final";
            this.médiaFinalDataGridViewTextBoxColumn.HeaderText = "Média Final";
            this.médiaFinalDataGridViewTextBoxColumn.Name = "médiaFinalDataGridViewTextBoxColumn";
            // 
            // aprovaçãoDataGridViewTextBoxColumn
            // 
            this.aprovaçãoDataGridViewTextBoxColumn.DataPropertyName = "Aprovação";
            this.aprovaçãoDataGridViewTextBoxColumn.HeaderText = "Aprovação";
            this.aprovaçãoDataGridViewTextBoxColumn.Name = "aprovaçãoDataGridViewTextBoxColumn";
            // 
            // bindingSource1
            // 
            this.bindingSource1.DataMember = "Dados";
            this.bindingSource1.DataSource = this.dts;
            this.bindingSource1.CurrentChanged += new System.EventHandler(this.bindingSource1_CurrentChanged);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Disciplina",
            "RA",
            "Série"});
            this.comboBox1.Location = new System.Drawing.Point(362, 300);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(116, 21);
            this.comboBox1.TabIndex = 5;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(183, 299);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(169, 22);
            this.label6.TabIndex = 6;
            this.label6.Text = "PROCURAR POR";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(512, 299);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(79, 22);
            this.label8.TabIndex = 6;
            this.label8.Text = "FILTRO";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(597, 300);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(116, 20);
            this.textBox2.TabIndex = 7;
            this.textBox2.TextChanged += new System.EventHandler(this.TxtFiltro_TextChanged);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exportarToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(983, 24);
            this.menuStrip1.TabIndex = 8;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // exportarToolStripMenuItem
            // 
            this.exportarToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.textoToolStripMenuItem});
            this.exportarToolStripMenuItem.Name = "exportarToolStripMenuItem";
            this.exportarToolStripMenuItem.Size = new System.Drawing.Size(63, 20);
            this.exportarToolStripMenuItem.Text = "Exportar";
            // 
            // textoToolStripMenuItem
            // 
            this.textoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.porLinhaToolStripMenuItem,
            this.porColunaToolStripMenuItem});
            this.textoToolStripMenuItem.Name = "textoToolStripMenuItem";
            this.textoToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.textoToolStripMenuItem.Text = "Texto";
            // 
            // porLinhaToolStripMenuItem
            // 
            this.porLinhaToolStripMenuItem.Name = "porLinhaToolStripMenuItem";
            this.porLinhaToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.porLinhaToolStripMenuItem.Text = "Por linha";
            this.porLinhaToolStripMenuItem.Click += new System.EventHandler(this.porLinhaToolStripMenuItem_Click);
            // 
            // porColunaToolStripMenuItem
            // 
            this.porColunaToolStripMenuItem.Name = "porColunaToolStripMenuItem";
            this.porColunaToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.porColunaToolStripMenuItem.Text = "Por coluna";
            this.porColunaToolStripMenuItem.Click += new System.EventHandler(this.porColunaToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.BackgroundImage = global::TP08_181828.Properties.Resources.fachada_Unisanta_2222;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(983, 521);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "PORTAL DO ALUNO";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dts)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Dados)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox disciplinatxt;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox serietxt;
        private System.Windows.Forms.TextBox ratxt;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button cadastrarbtn;
        private System.Windows.Forms.Label llnota3;
        private System.Windows.Forms.TextBox nota4txt;
        private System.Windows.Forms.TextBox nota2txt;
        private System.Windows.Forms.TextBox nota3txt;
        private System.Windows.Forms.TextBox nota1txt;
        private System.Data.DataSet dts;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Data.DataTable Dados;
        private System.Data.DataColumn Disciplina;
        private System.Data.DataColumn RA;
        private System.Data.DataColumn Série;
        private System.Data.DataColumn nota1;
        private System.Data.DataColumn nota2;
        private System.Data.DataColumn nota3;
        private System.Data.DataColumn nota4;
        private System.Data.DataColumn mediafinal;
        private System.Data.DataColumn Aprovação;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.DataGridViewTextBoxColumn disciplinaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rADataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sérieDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nota1BimestreDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nota2BimestreDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nota3BimestreDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nota4BimestreDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn médiaFinalDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn aprovaçãoDataGridViewTextBoxColumn;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem exportarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem textoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem porLinhaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem porColunaToolStripMenuItem;
    }
}

