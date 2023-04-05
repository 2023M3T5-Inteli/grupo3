
using Microsoft.AspNetCore.Mvc;
using Microsoft.ML;
using Teste1.Models;
using System.IO.Compression;

[Route("api/[controller]")]
[ApiController]
public class PredictionController : ControllerBase
{
  
    

    [HttpPost]
    public ActionResult Predict([FromBody] InputDataModel input)
    {
        var context = new MLContext();
        var zipPath = "modeloFINAL.zip";
        var outputPath = "NovaPasta2";

        ZipFile.ExtractToDirectory(zipPath, outputPath);
        var model = context.Model.Load(outputPath, out _);



        // Cria um PredictionEngine usando o modelo carregado
        var predictionEngine = context.Model.CreatePredictionEngine<InputModel, OutputModel>(model);


        // conversão das strings e numero

        int temp1;
        int temp2;
        int temp3;

        if (input.ReceptorEstrogenio == "negativo")
            temp1 = 0;
        else
            temp1 = 1;


        if (input.ReceptorProgesterona == "negativo")
            temp2 = 0;
        else
            temp2 = 1;

        if (input.KiMaior14Pct == "negativo")
            temp3 = 0;
        else
            temp3 = 1;



        // Cria um objeto ModelInput a partir das features recebidas na requisição HTTP POST
        var inputFeatures = new InputModel
        {
            IdadePrimeiroDiagnostico = input.IdadePrimeiroDiagnostico,
            GrupoEstadioClinico = input.GrupoEstadioClinico,
            ClassificacaoTnmClinicoT = input.ClassificacaoTnmClinicoT,
            ClassificacaoTnmClinicoN = input.ClassificacaoTnmClinicoN,
            SubtipoTumoral = input.SubtipoTumoral,
            IndiceHReceptorDeProgesterona = input.IndiceHReceptorDeProgesterona,
            Ki67Pct = input.Ki67Pct,
            ReceptorEstrogenio = temp1,
            ReceptorProgesterona = temp2,
            ReceptorProgesteronaQuantificacaoPct = input.ReceptorProgesteronaQuantificacaoPct,
            ReceptorEstrogenioQuantificacaoPct = input.ReceptorEstrogenioQuantificacaoPct,
            KiMaior14Pct = temp3
        };

        // Faz a predição usando o modelo e as features recebidas na requisição
        var prediction = predictionEngine.Predict(inputFeatures);

        var result = new OutputDataModel();

        if (prediction.Prediction == 0)
        {
            result.Answer = "Adjuvante";
        }

        result.Answer = "Neoadjuvante";


        // Retorna a predição para o cliente HTTP
        return Ok(result.Answer);
    }
}



