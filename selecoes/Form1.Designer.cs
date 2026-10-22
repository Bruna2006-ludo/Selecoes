namespace selecoes;

partial class Form1
{
    /// <summary>
    ///  Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    ///  Clean up any resources being used.
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
        label1 = new Label();
        lblCidade = new Label();
        cmbCidade = new ComboBox();
        chkMatutino = new CheckBox();
        chkVespertino = new CheckBox();
        chkNoturno = new CheckBox();
        label2 = new Label();
        lblTemosPoliticas = new Label();
        chkTermosPoliticas = new CheckBox();
        btnCadastrar = new Button();
        dgvCadastros = new DataGridView();
        ((System.ComponentModel.ISupportInitialize)dgvCadastros).BeginInit();
        SuspendLayout();
        // 
        // label1
        // 
        label1.AutoSize = true;
        label1.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
        label1.Location = new Point(12, 9);
        label1.Name = "label1";
        label1.Size = new Size(99, 30);
        label1.TabIndex = 0;
        label1.Text = "Cadastro";
        // 
        // lblCidade
        // 
        lblCidade.AutoSize = true;
        lblCidade.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
        lblCidade.Location = new Point(12, 47);
        lblCidade.Name = "lblCidade";
        lblCidade.Size = new Size(88, 21);
        lblCidade.TabIndex = 1;
        lblCidade.Text = "Sua Cidade";
        // 
        // cmbCidade
        // 
        cmbCidade.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
        cmbCidade.FormattingEnabled = true;
        cmbCidade.Location = new Point(12, 79);
        cmbCidade.Name = "cmbCidade";
        cmbCidade.Size = new Size(160, 29);
        cmbCidade.TabIndex = 2;
        cmbCidade.SelectedIndexChanged += cmbCidade_SelectedIndexChanged;
        // 
        // chkMatutino
        // 
        chkMatutino.Location = new Point(12, 147);
        chkMatutino.Name = "chkMatutino";
        chkMatutino.Size = new Size(104, 24);
        chkMatutino.TabIndex = 3;
        chkMatutino.Text = "Matutino";
        chkMatutino.UseVisualStyleBackColor = true;
        // 
        // chkVespertino
        // 
        chkVespertino.Location = new Point(12, 177);
        chkVespertino.Name = "chkVespertino";
        chkVespertino.Size = new Size(104, 24);
        chkVespertino.TabIndex = 4;
        chkVespertino.Text = "Vespertino";
        chkVespertino.UseVisualStyleBackColor = true;
        // 
        // chkNoturno
        // 
        chkNoturno.Location = new Point(12, 207);
        chkNoturno.Name = "chkNoturno";
        chkNoturno.Size = new Size(104, 24);
        chkNoturno.TabIndex = 5;
        chkNoturno.Text = "Noturno ";
        chkNoturno.UseVisualStyleBackColor = true;
        // 
        // label2
        // 
        label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
        label2.Location = new Point(12, 121);
        label2.Name = "label2";
        label2.Size = new Size(100, 23);
        label2.TabIndex = 6;
        label2.Text = "Turno:";
        // 
        // lblTemosPoliticas
        // 
        lblTemosPoliticas.AutoSize = true;
        lblTemosPoliticas.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
        lblTemosPoliticas.Location = new Point(12, 242);
        lblTemosPoliticas.Name = "lblTemosPoliticas";
        lblTemosPoliticas.Size = new Size(132, 21);
        lblTemosPoliticas.TabIndex = 7;
        lblTemosPoliticas.Text = "Termos e Politicas";
        // 
        // chkTermosPoliticas
        // 
        chkTermosPoliticas.AutoSize = true;
        chkTermosPoliticas.Location = new Point(12, 274);
        chkTermosPoliticas.Name = "chkTermosPoliticas";
        chkTermosPoliticas.Size = new Size(278, 19);
        chkTermosPoliticas.TabIndex = 8;
        chkTermosPoliticas.Text = "Aceito todos os Termos e Políticas do Programa\r\n";
        chkTermosPoliticas.UseVisualStyleBackColor = true;
        chkTermosPoliticas.CheckedChanged += chkTermosPoliticas_CheckedChanged;
        // 
        // btnCadastrar
        // 
        btnCadastrar.AutoSize = true;
        btnCadastrar.Enabled = false;
        btnCadastrar.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
        btnCadastrar.Location = new Point(12, 315);
        btnCadastrar.Name = "btnCadastrar";
        btnCadastrar.Size = new Size(92, 31);
        btnCadastrar.TabIndex = 9;
        btnCadastrar.Text = "Cadastrar";
        btnCadastrar.UseVisualStyleBackColor = true;
        btnCadastrar.Click += btnCadastrar_Click;
        // 
        // dgvCadastros
        // 
        dgvCadastros.AllowUserToAddRows = false;
        dgvCadastros.AllowUserToDeleteRows = false;
        dgvCadastros.AllowUserToResizeColumns = false;
        dgvCadastros.AllowUserToResizeRows = false;
        dgvCadastros.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
        dgvCadastros.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        dgvCadastros.Location = new Point(376, 12);
        dgvCadastros.Name = "dgvCadastros";
        dgvCadastros.Size = new Size(412, 426);
        dgvCadastros.TabIndex = 10;
        dgvCadastros.Text = "dataGridView1";
        // 
        // Form1
        // 
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(796, 450);
        Controls.Add(dgvCadastros);
        Controls.Add(btnCadastrar);
        Controls.Add(chkTermosPoliticas);
        Controls.Add(lblTemosPoliticas);
        Controls.Add(label2);
        Controls.Add(chkNoturno);
        Controls.Add(chkVespertino);
        Controls.Add(chkMatutino);
        Controls.Add(cmbCidade);
        Controls.Add(lblCidade);
        Controls.Add(label1);
        Name = "Form1";
        Text = "Form1";
        Load += Form1_Load;
        ((System.ComponentModel.ISupportInitialize)dgvCadastros).EndInit();
        ResumeLayout(false);
        PerformLayout();
    }

    private System.Windows.Forms.DataGridView dgvCadastros;

    private System.Windows.Forms.Button btnCadastrar;

    private System.Windows.Forms.CheckBox chkTermosPoliticas;

    private System.Windows.Forms.Label lblTemosPoliticas;

    private System.Windows.Forms.CheckBox chkMatutino;
    private System.Windows.Forms.CheckBox chkVespertino;
    private System.Windows.Forms.CheckBox chkNoturno;
    private System.Windows.Forms.Label label2;

    private System.Windows.Forms.ComboBox cmbCidade;

    private System.Windows.Forms.Label lblCidade;

    private System.Windows.Forms.Label label1;

    #endregion
}