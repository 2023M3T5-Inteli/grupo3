using System.ComponentModel.DataAnnotations;

namespace PredictAPI.Controllers
{
    public class FeaturesModel
    {
        // ===============================================================================
        // ================================= PROPS =======================================
        // ===============================================================================  

        [Required]
        public int potBateria { get; set; }

        [Required]
        public string temBlutooth { get; set; }

        [Required]
        public double clockProcessador { get; set; }

        [Required]
        public string dualSim { get; set; }

        

        [Required]
        public string tem4g { get; set; }

        [Required]
        public int memoriaInterna { get; set; }

        [Required]
        public int nucleos { get; set; }


        [Required]
        public int ram { get; set; }

        [Required]
        public string tem3g { get; set; }

        [Required]
        public string touchScreen { get; set; }

        [Required]
        public string temWifi { get; set; }
    }

}
