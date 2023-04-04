using System.Text.Json;
using PredictAPI.Models;

namespace PredictAPI.Controllers
{
    public static class Conversion
    {
        public static  FeaturesModelConvert ConvertFeatures(FeaturesModel features)
        {
            FeaturesModelConvert convertModel = new FeaturesModelConvert();

            // feature 1
            convertModel.potBateria = features.potBateria;  

            // enconding da feature 2
            if (features.temBlutooth == "Sim")
                convertModel.temBlutooth = 1;
            if (features.temBlutooth == "Não")
                convertModel.temBlutooth = 0;

            // enconding feature 3
            convertModel.clockProcessador = (int) features.clockProcessador;

            // enconding feature 4
            if(features.dualSim == "Sim")
                convertModel.dualSim = 1;
            if( features.dualSim == "Não")
                convertModel.dualSim = 0;

            // enconding feature 5

            // enconding feature 6
            if(features.tem4g == "Sim")
                convertModel.tem4g = 1;
            if(features.tem4g == "Não")
                convertModel.tem4g = 0;

            // enconding feature 7
            convertModel.memoriaInterna = features.memoriaInterna;

            // enconding feature 8
            convertModel.nucleos = features.nucleos;


            // enconding feature 10
            convertModel.ram = features.ram;

            // enconding feature 11
            if(features.tem3g == "Sim")
                convertModel.tem3g = 1;
            if (features.tem3g == "Não")
                convertModel.tem3g = 0;

            // enconding feature 12
            if (features.touchScreen == "Sim")
                convertModel.touchScreen = 1;
            if (features.touchScreen == "Não")
                convertModel.touchScreen = 0;

            // enconding feature 13
            if (features.temWifi == "Sim")
                convertModel.temWifi = 1;
            if (features.temWifi == "Não")
                convertModel.temWifi = 0;


            return convertModel;
        }
    }
}
