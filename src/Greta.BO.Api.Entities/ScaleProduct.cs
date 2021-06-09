using Greta.BO.Api.Entities.Enum;

namespace Greta.BO.Api.Entities
{
    public class ScaleProduct : Product
    {
        public string PLUNumber { get; set; }
        public long ScaleCategoryId { get; set; }
        public ScaleCategory ScaleCategory { get; set; }

        public PluType PLUType { get; set; }

        public string Description1 { get; set; }
        public string Description2 { get; set; }
        public string Description3 { get; set; }

        #region Conditional text
        public string Text1 { get; set; }
        public string Text2 { get; set; }
        public string Text3 { get; set; }
        public string Text4 { get; set; }

        #endregion Conditional text

        #region Tare

        public double Tare1 { get; set; }
        public double Tare2 { get; set; }
        public bool ForceTare { get; set; }
        public bool TareIsPercent { get; set; }

        #endregion Tare

        #region Scale Label type

        public long ScaleLabelType1Id { get; set; }

        public long ScaleLabelType2Id { get; set; }

        public long ScaleLabelType3Id { get; set; }

        public long ScaleLabelType4Id { get; set; }


        public ScaleLabelType ScaleLabelType1 { get; set; }
        public ScaleLabelType ScaleLabelType2 { get; set; }
        public ScaleLabelType ScaleLabelType3 { get; set; }
        public ScaleLabelType ScaleLabelType4 { get; set; }


        #endregion Scale Label type


        #region Nutricional
        /// <summary>
        /// Servings per container
        /// </summary>
        public double ServingPerContainer { get; set; }
        /// <summary>
        /// Serving Size
        /// </summary>
        public double ServingSize { get; set; }
        /// <summary>
        /// Amount per serving calories
        /// </summary>
        public double AmountPerServingCalories { get; set; }
        /// <summary>
        /// Total fat grams(g)
        /// </summary>
        public double TotalFatGrams { get; set; }
        /// <summary>
        /// Total fat %
        /// </summary>
        public double TotalFat { get; set; }
        /// <summary>
        /// Saturated fat grams(g)
        /// </summary>
        public double SaturedFatGrams { get; set; }
        /// <summary>
        /// Saturated fat %
        /// </summary>
        public double SaturedFat { get; set; }
        /// <summary>
        /// Cholesterol mgrams(mg)
        /// </summary>
        public double CholesterolMGrams { get; set; }
        /// <summary>
        /// Cholesterol %
        /// </summary>
        public double Cholesterol { get; set; }
        /// <summary>
        /// Sodium mgrams(mg)
        /// </summary>
        public double SodiumMGrams { get; set; }
        /// <summary>
        /// Sodium %
        /// </summary>
        public double Sodium { get; set; }
        /// <summary>
        /// Total Carbohydrate grams(g)
        /// </summary>
        public double TotalCarbohydrateGrams { get; set; }
        /// <summary>
        /// Total Carbohydrate %
        /// </summary>
        public double TotalCarbohydrate { get; set; }
        /// <summary>
        /// Dietary Fiber grams(g)
        /// </summary>
        public double DietaryFiberGrams { get; set; }
        /// <summary>
        /// Dietary Fiber %
        /// </summary>
        public double DietaryFiber { get; set; }
        /// <summary>
        /// Total Sugar grams(g)
        /// </summary>
        public double TotalSugarGrams { get; set; }
        /// <summary>
        /// Added Sugar grams(g)
        /// </summary>
        public double AddedSugarGrams { get; set; }
        /// <summary>
        /// Added Sugar %
        /// </summary>
        public double AddedSugar { get; set; }
        /// <summary>
        /// Protein grams (g)
        /// </summary>
        public double ProteinGrams { get; set; }
        /// <summary>
        /// Vit. D microgram(mcg)
        /// </summary>
        public double VitDMGrams { get; set; }
        /// <summary>
        /// Vit. D %
        /// </summary>
        public double VitD { get; set; }
        /// <summary>
        /// Calcium mgrams(mg)
        /// </summary>
        public double CalciumMGrams { get; set; }
        /// <summary>
        /// Calcium %
        /// </summary>
        public double Calcium { get; set; }
        /// <summary>
        /// Iron mgrams(mg)
        /// </summary>
        public double IronMGrams { get; set; }
        /// <summary>
        /// Iron %
        /// </summary>
        public double Iron { get; set; }
        /// <summary>
        /// Potas mgrams(mg)
        /// </summary>
        public double PotasMGrams { get; set; }
        /// <summary>
        /// Potas %
        /// </summary>
        public double Potas { get; set; }

        #endregion Nutricional



    }
}
