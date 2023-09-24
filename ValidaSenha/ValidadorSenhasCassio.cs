using System.Text.RegularExpressions;
namespace ValidaSenha;
public partial class Frm_ValidaSenha : Form
{
    bool VerSenhaTxt = false;
    public Frm_ValidaSenha()
    {
        InitializeComponent();
    }

    private void Form1_Load(object sender, EventArgs e)
    { }

    private void Btn_Reset_Click(object sender, EventArgs e)
    {
        TXT_Senha.Text = "";
        LBL_Resultado.Text = "";
    }

    private void LBL_Resultado_Click(object sender, EventArgs e)
    { }

    private void TXT_Senha_KeyDown(object sender, KeyEventArgs e)
    {
        ChecaForcaSenha verifica = new ChecaForcaSenha();
        ChecaForcaSenha.ForcaDaSenha força;
        força = verifica.GetForcaDaSenha(TXT_Senha.Text);
        LBL_Resultado.Text = força.ToString();

        if (LBL_Resultado.Text == "Inaceitavel" || LBL_Resultado.Text == "Fraca")
            LBL_Resultado.ForeColor = Color.Red;

        if (LBL_Resultado.Text == "Forte" || LBL_Resultado.Text == "Segura")
            LBL_Resultado.ForeColor = Color.Green;

        if (LBL_Resultado.Text == "Aceitavel")
            LBL_Resultado.ForeColor = Color.Blue;
    }
    private void BTN_VerSenha_Click(object sender, EventArgs e)
    {
        if (VerSenhaTxt == false)
        {
            TXT_Senha.PasswordChar = '\0';
            VerSenhaTxt = true;
            BTN_VerSenha.Text = "Esconder";
        }
        else
        {
            TXT_Senha.PasswordChar = '*';
            VerSenhaTxt = false;
            BTN_VerSenha.Text = "Mostrar";
        }
    }
    public class ChecaForcaSenha
    //Codigo abaixo da validação foi pego na internet
    {
        public enum ForcaDaSenha
        {
            Inaceitavel,
            Fraca,
            Aceitavel,
            Forte,
            Segura
        }
        public int geraPontosSenha(string senha)
        {
            if (senha == null) return 0;
            int pontosPorTamanho = GetPontoPorTamanho(senha);
            int pontosPorMinusculas = GetPontoPorMinusculas(senha);
            int pontosPorMaiusculas = GetPontoPorMaiusculas(senha);
            int pontosPorDigitos = GetPontoPorDigitos(senha);
            int pontosPorSimbolos = GetPontoPorSimbolos(senha);
            int pontosPorRepeticao = GetPontoPorRepeticao(senha);
            return pontosPorTamanho + pontosPorMinusculas +
                pontosPorMaiusculas + pontosPorDigitos +
                pontosPorSimbolos - pontosPorRepeticao;
        }

        private int GetPontoPorTamanho(string senha)
        {
            return Math.Min(10, senha.Length) * 7;
        }

        private int GetPontoPorMinusculas(string senha)
        {
            int rawplacar = senha.Length - Regex.Replace(senha, "[a-z]", "").Length;
            return Math.Min(2, rawplacar) * 5;
        }

        private int GetPontoPorMaiusculas(string senha)
        {
            int rawplacar = senha.Length - Regex.Replace(senha, "[A-Z]", "").Length;
            return Math.Min(2, rawplacar) * 5;
        }

        private int GetPontoPorDigitos(string senha)
        {
            int rawplacar = senha.Length - Regex.Replace(senha, "[0-9]", "").Length;
            return Math.Min(2, rawplacar) * 6;
        }

        private int GetPontoPorSimbolos(string senha)
        {
            int rawplacar = Regex.Replace(senha, "[a-zA-Z0-9]", "").Length;
            return Math.Min(2, rawplacar) * 5;
        }

        private int GetPontoPorRepeticao(string senha)
        {
            Regex regex = new Regex(@"(\w)*.*\1");
            bool repete = regex.IsMatch(senha);
            if (repete)
                return 30;
            else
                return 0;
        }

        public ForcaDaSenha GetForcaDaSenha(string senha)
        {
            int placar = geraPontosSenha(senha);

            if (placar < 50)
                return ForcaDaSenha.Inaceitavel;
            else if (placar < 60)
                return ForcaDaSenha.Fraca;
            else if (placar < 80)
                return ForcaDaSenha.Aceitavel;
            else if (placar < 100)
                return ForcaDaSenha.Forte;
            else
                return ForcaDaSenha.Segura;
        }
    }
}