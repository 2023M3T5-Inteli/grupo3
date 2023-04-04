using Microsoft.AspNetCore.Mvc;
using PredictAPI.Models;
using Python.Runtime;
using IronPython.Hosting;

namespace PredictAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class PredictController : Controller
    {


        [HttpPost]
        public IActionResult Predict([FromBody] FeaturesModel features)
        {

            {

                dynamic model = LoadModel.returnPredictiveModel();
                // fazer o enconding dos dados 
                dynamic input = Conversion.ConvertFeatures(features);

                // cálculo da predição
                dynamic output = model.predict(input);
                return output;
            }
        }
    }
}
