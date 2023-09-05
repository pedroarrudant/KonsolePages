using System.ComponentModel;

namespace ExecutionExample.Models
{
    public enum MainMenuOptions
    {
        [Description("Iniciar processamento")]
        IniciarProcessamento,
        [Description("Verificar processamento existente")]
        VerificarProcessamentoExistente,
        [Description("Sair")]
        Sair
    }
}
