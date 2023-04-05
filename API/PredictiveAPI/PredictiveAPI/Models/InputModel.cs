
namespace Teste1.Models;

// ======================================================================================================= 
// ================================= AQUI FICARÃO AS FEATURES APÓS O ENCONDING ===========================
// =======================================================================================================
public class InputModel
{
   
    public int IdadePrimeiroDiagnostico { get; set; }

    public double GrupoEstadioClinico { get; set; }


    public int ClassificacaoTnmClinicoT { get; set; }


    public int ClassificacaoTnmClinicoN { get; set; }

    public double SubtipoTumoral { get; set; }

    public double IndiceHReceptorDeProgesterona { get; set; }

    public double Ki67Pct { get; set; }

    public int ReceptorEstrogenio { get; set; }

    public int ReceptorProgesterona { get; set; }

    public int ReceptorProgesteronaQuantificacaoPct { get; set; }

    public int ReceptorEstrogenioQuantificacaoPct { get; set; }

    public int KiMaior14Pct { get; set; }
}
