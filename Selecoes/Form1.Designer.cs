namespace Selecoes;

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
        lblTitulo = new System.Windows.Forms.Label();
        lblCidade = new System.Windows.Forms.Label();
        cmbCidade = new System.Windows.Forms.ComboBox();
        lblTurno = new System.Windows.Forms.Label();
        chkMatutino = new System.Windows.Forms.CheckBox();
        chkVespertino = new System.Windows.Forms.CheckBox();
        chkNoturno = new System.Windows.Forms.CheckBox();
        lblTermosPoliticas = new System.Windows.Forms.Label();
        chkTermosPoliticas = new System.Windows.Forms.CheckBox();
        btnCadastrar = new System.Windows.Forms.Button();
        SuspendLayout();
        // 
        // lblTitulo
        // 
        lblTitulo.AutoSize = true;
        lblTitulo.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
        lblTitulo.Location = new System.Drawing.Point(12, 9);
        lblTitulo.Name = "lblTitulo";
        lblTitulo.Size = new System.Drawing.Size(106, 30);
        lblTitulo.TabIndex = 0;
        lblTitulo.Text = "Cadastro";
        // 
        // lblCidade
        // 
        lblCidade.AutoSize = true;
        lblCidade.Font = new System.Drawing.Font("Segoe UI", 12F);
        lblCidade.Location = new System.Drawing.Point(12, 47);
        lblCidade.Name = "lblCidade";
        lblCidade.Size = new System.Drawing.Size(91, 21);
        lblCidade.TabIndex = 1;
        lblCidade.Text = "Sua Cidade:";
        // 
        // cmbCidade
        // 
        cmbCidade.Font = new System.Drawing.Font("Segoe UI", 12F);
        cmbCidade.FormattingEnabled = true;
        cmbCidade.Location = new System.Drawing.Point(18, 79);
        cmbCidade.Name = "cmbCidade";
        cmbCidade.Size = new System.Drawing.Size(160, 29);
        cmbCidade.TabIndex = 2;
        // 
        // lblTurno
        // 
        lblTurno.AutoSize = true;
        lblTurno.Font = new System.Drawing.Font("Segoe UI", 12F);
        lblTurno.Location = new System.Drawing.Point(12, 119);
        lblTurno.Name = "lblTurno";
        lblTurno.Size = new System.Drawing.Size(54, 21);
        lblTurno.TabIndex = 3;
        lblTurno.Text = "Turno:";
        // 
        // chkMatutino
        // 
        chkMatutino.Location = new System.Drawing.Point(18, 147);
        chkMatutino.Name = "chkMatutino";
        chkMatutino.Size = new System.Drawing.Size(104, 24);
        chkMatutino.TabIndex = 4;
        chkMatutino.Text = "Matutino";
        chkMatutino.UseVisualStyleBackColor = true;
        // 
        // chkVespertino
        // 
        chkVespertino.Location = new System.Drawing.Point(18, 177);
        chkVespertino.Name = "chkVespertino";
        chkVespertino.Size = new System.Drawing.Size(104, 24);
        chkVespertino.TabIndex = 5;
        chkVespertino.Text = "Vespertino";
        chkVespertino.UseVisualStyleBackColor = true;
        // 
        // chkNoturno
        // 
        chkNoturno.Location = new System.Drawing.Point(18, 207);
        chkNoturno.Name = "chkNoturno";
        chkNoturno.Size = new System.Drawing.Size(104, 24);
        chkNoturno.TabIndex = 6;
        chkNoturno.Text = "Noturno";
        chkNoturno.UseVisualStyleBackColor = true;
        // 
        // lblTermosPoliticas
        // 
        lblTermosPoliticas.AutoSize = true;
        lblTermosPoliticas.Font = new System.Drawing.Font("Segoe UI", 12F);
        lblTermosPoliticas.Location = new System.Drawing.Point(12, 242);
        lblTermosPoliticas.Name = "lblTermosPoliticas";
        lblTermosPoliticas.Size = new System.Drawing.Size(132, 21);
        lblTermosPoliticas.TabIndex = 7;
        lblTermosPoliticas.Text = "Termos e Politicas";
        // 
        // chkTermosPoliticas
        // 
        chkTermosPoliticas.AutoSize = true;
        chkTermosPoliticas.Location = new System.Drawing.Point(18, 274);
        chkTermosPoliticas.Name = "chkTermosPoliticas";
        chkTermosPoliticas.Size = new System.Drawing.Size(278, 19);
        chkTermosPoliticas.TabIndex = 8;
        chkTermosPoliticas.Text = "Aceito todos os Termos e Políticas do programa";
        chkTermosPoliticas.UseVisualStyleBackColor = true;
        chkTermosPoliticas.CheckedChanged += chkTermosPoliticas_CheckedChanged;
        // 
        // btnCadastrar
        // 
        btnCadastrar.AutoSize = true;
        btnCadastrar.Enabled = false;
        btnCadastrar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
        btnCadastrar.Location = new System.Drawing.Point(18, 315);
        btnCadastrar.Name = "btnCadastrar";
        btnCadastrar.Size = new System.Drawing.Size(92, 43);
        btnCadastrar.TabIndex = 9;
        btnCadastrar.Text = "Cadastrar";
        btnCadastrar.UseVisualStyleBackColor = true;
        btnCadastrar.Click += btnCadastrar_Click;
        // 
        // Form1
        // 
        AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
        AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        ClientSize = new System.Drawing.Size(800, 450);
        Controls.Add(btnCadastrar);
        Controls.Add(chkTermosPoliticas);
        Controls.Add(lblTermosPoliticas);
        Controls.Add(chkNoturno);
        Controls.Add(chkVespertino);
        Controls.Add(chkMatutino);
        Controls.Add(lblTurno);
        Controls.Add(cmbCidade);
        Controls.Add(lblCidade);
        Controls.Add(lblTitulo);
        Text = "Form1";
        ResumeLayout(false);
        PerformLayout();
    }

    private System.Windows.Forms.Button btnCadastrar;

    private System.Windows.Forms.CheckBox chkTermosPoliticas;

    private System.Windows.Forms.Label lblTermosPoliticas;

    private System.Windows.Forms.CheckBox chkMatutino;
    private System.Windows.Forms.CheckBox chkVespertino;
    private System.Windows.Forms.CheckBox chkNoturno;

    private System.Windows.Forms.Label lblTurno;

    private System.Windows.Forms.ComboBox cmbCidade;

    private System.Windows.Forms.Label lblCidade;

    private System.Windows.Forms.Label lblTitulo;

    #endregion
}