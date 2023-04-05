using Microsoft.ML.Data;

namespace Teste1.Models;

// ======================================================================================================= 
// ================================= AQUI FICARÃO AS FEATURES ANTES DO ENCONDING =========================
// =======================================================================================================

public class InputDataModel
{
    [ColumnName("feature1")]
    public int IdadePrimeiroDiagnostico { get; set; }

    [ColumnName("feature2")]
    public double GrupoEstadioClinico { get; set; }

    [ColumnName("feature3")]
    public int ClassificacaoTnmClinicoT { get; set; }


    [ColumnName("feature4")]
    public int ClassificacaoTnmClinicoN { get; set; }

    [ColumnName("feature5")]
    public double SubtipoTumoral { get; set; }

    [ColumnName("feature6")]
    public double IndiceHReceptorDeProgesterona { get; set; }

    [ColumnName("feature7")]
    public double Ki67Pct { get; set; }

    [ColumnName("feature8")]
    public string? ReceptorEstrogenio {get; set; }

    [ColumnName("feature9")]
    public string? ReceptorProgesterona { get; set; }

    [ColumnName("feature10")]
    public int ReceptorProgesteronaQuantificacaoPct { get; set; }

    [ColumnName("feature11")]
    public int ReceptorEstrogenioQuantificacaoPct { get; set; }

    [ColumnName("feature12")]
    public string? KiMaior14Pct { get; set; }

}