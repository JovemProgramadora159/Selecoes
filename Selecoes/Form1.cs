namespace Selecoes;

public partial class Form1 : Form
{
    private List<string> listaCidade = ["Vitória", "Vila Velha", "Serra", "Cariacica", "Viana", "Guarapari", "Fundão"];

    public Form1()
    {
        InitializeComponent();
        cmbCidade.DataSource = listaCidade;
    }

    private void chkTermosPoliticas_CheckedChanged(object sender, EventArgs e)
    {
        btnCadastrar.Enabled = chkTermosPoliticas.Checked;
    }

    private void btnCadastrar_Click(object sender, EventArgs e)
    {
        if (!chkMatutino.Checked && !chkVespertino.Checked && !chkNoturno.Checked)
        {
            MessageBox.Show("Você precisa selecionar algum turno!", "Turnos não selecionados!", MessageBoxButtons.OK,
                MessageBoxIcon.Error);
            return;
        }

        if (!chkTermosPoliticas.Checked)
        {
            MessageBox.Show("Aceite os termos e políticas para continuar!", "Termos e Políticas", MessageBoxButtons.OK,
                MessageBoxIcon.Error);
            return;
        }
    }
}

public class Cadastro
{
    public string Cidade { get; set; }
    public List<string> Turnos { get; set; }
    public DateTime DataTermoAceito { get; set; }
}