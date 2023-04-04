using System.ComponentModel.DataAnnotations;
using PredictAPI.Controllers;

namespace PredictAPI.Models
{
    public class FeaturesModelConvert
    {
        // ===============================================================================
        // ============================== PROPS ENCONDING ================================
        // ===============================================================================  

        [Required]
        public int potBateria { get; set; }

        [Required]
        public int temBlutooth { get; set; }

        [Required]
        public int clockProcessador { get; set; }

        [Required]
        public int dualSim { get; set; }

        
        [Required]
        public int tem4g { get; set; }

        [Required]
        public int memoriaInterna { get; set; }

        [Required]
        public int nucleos { get; set; }


        [Required]
        public int ram { get; set; }

        [Required]
        public int tem3g { get; set; }

        [Required]
        public int touchScreen { get; set; }

        [Required]
        public int temWifi { get; set; }
    }
}
