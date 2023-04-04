using Python.Runtime;


namespace PredictAPI.Models
{
    public static class LoadModel
    {
        public static dynamic returnPredictiveModel()
        {
            dynamic archive = Py.Import("../PredictiveModel/finalized_model.sav");
            dynamic model = archive.load(File.OpenRead("../PredictiveModel/finalized_model.sav"));

            return model;
        }

    }
}
