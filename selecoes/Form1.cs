using System.ComponentModel;

namespace selecoes;

public partial class Form1 : Form
{
    private List<string> listaCidade = ["Vitória", "Vila Velha", "Serra", "Cariacica", "Viana", "Guarapari", "Fundão"];
    private BindingList<Cadastro> listaCadastros = [];

    public Form1()
    {
        InitializeComponent();
        cmbCidade.DataSource = listaCidade;
        dgvCadastros.DataSource = listaCadastros;
        if (dgvCadastros.Columns.Contains("TurnosString"))
        {
            dgvCadastros.Columns["TurnosString"].HeaderText = "Turnos";
        }
        if (dgvCadastros.Columns.Contains("DataTermoAceito"))
        {
            dgvCadastros.Columns["DataTermoAceito"].HeaderText = "Aceito Em";
        }
    }

    private void chkTermosPoliticas_CheckedChanged(object sender, EventArgs e)
    {
        btnCadastrar.Enabled = chkTermosPoliticas.Checked;
    }

    private void btnCadastrar_Click(object sender, EventArgs e)
    {
        if (!chkMatutino.Checked && !chkVespertino.Checked && !chkNoturno.Checked)
        {
            MessageBox.Show("Você precisa selecionar algum turno!", "Turnos não slecionados!", MessageBoxButtons.OK,
                MessageBoxIcon.Error);
            return;
        }

        if (!chkTermosPoliticas.Checked)
        {
            MessageBox.Show("Aceite os termos e políticas para continuar!", "Termos e políticas", MessageBoxButtons.OK,
                MessageBoxIcon.Error);
        }

        var novoCadastro = new Cadastro();
        novoCadastro.Cidade = cmbCidade.Text;
        if (chkMatutino.Checked) novoCadastro.Turnos.Add("Matutino");
        if (chkVespertino.Checked) novoCadastro.Turnos.Add("Vespertino");
        if (chkNoturno.Checked) novoCadastro.Turnos.Add("Noturno");
        novoCadastro.DataTermoAceito = DateTime.Now.AddDays(2);
        listaCadastros.Add(novoCadastro);
    }

    public class Cadastro
    {
        public string Cidade { get; set; }
        public List<string> Turnos { get; set; } = [];
        public DateTime DataTermoAceito { get; set; }
        public string TurnosString
        {
            get
            {
                return string.Join(", ", Turnos);
            }
        }
    }

    private void cmbCidade_SelectedIndexChanged(object sender, EventArgs e)
    {

    }

    private void Form1_Load(object sender, EventArgs e)
    {

    }
}