using Microsoft.ML.Data;


// =======================================================================================================
// ================================== AQUI FICARÃO A RESPOSTA NO FORMATO ENCONDING =======================
// =======================================================================================================
namespace Teste1.Models
{
    public class OutputModel
    {
        [ColumnName("PredictedLabel")]
        public int Prediction { get; set; }
    }
}
