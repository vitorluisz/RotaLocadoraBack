using System.ComponentModel;

namespace RotaLocadora.Enums
{
    public enum PropositoEnum
    {
        [Description("Uso pessoal")]
        UsoPessoal,

        [Description("Veiculo para locacao")]
        VeiculoParaLocacao,

        [Description("Uso da empresa")]
        UsoDaEmpresa
    }
}
