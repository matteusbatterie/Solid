using System.Collections.Generic;
using System.Linq;
using Solid.Helpers.Utils;
using Solid.Helpers.Utils.Enums;

namespace Solid.Classes
{
    public class IR : Tax
    {
        private int DependentsCount { get; set; }
        private decimal DeductionPerDependent { get; set; }

        public IR(Dictionary<TaxRangeEnum, double> aliquot = null, Dictionary<TaxRangeEnum, decimal> parcelToDeduct = null,
            int dependentsCount = 2, decimal deductionPerDependent = 189.59m)
        {
            this.Aliquot = new Dictionary<TaxRangeEnum, double>()
            {
                {TaxRangeEnum.First, 0.00},
                {TaxRangeEnum.Second, 0.075},
                {TaxRangeEnum.Third, 0.15},
                {TaxRangeEnum.Fourth, 0.225},
                {TaxRangeEnum.Fifth, 0.275}
            };

            this.ParcelToDeduct = new Dictionary<TaxRangeEnum, decimal>()
            {
                {TaxRangeEnum.First, 00.000m},
                {TaxRangeEnum.Second, 142.80m},
                {TaxRangeEnum.Third, 354.80m},
                {TaxRangeEnum.Fourth, 636.13m},
                {TaxRangeEnum.Fifth, 869.36m}
            };

            this.DependentsCount = dependentsCount;
            this.DeductionPerDependent = deductionPerDependent;
        }

        #region Actions
        public override decimal ApplyTax(decimal salary)
        {
            #region Alternative Method
            var salaryRange = GetSalaryRange(salary);

            salary -= (this.DependentsCount * this.DeductionPerDependent);
            salary -= (salary.ApplyPercentage(this.Aliquot[salaryRange]) - this.ParcelToDeduct[salaryRange]);

            return salary;
            #endregion
        }
        #endregion

        #region GETs
        private TaxRangeEnum GetSalaryRange(decimal salary)
        {
            if (salary.IsBetween(0, 1903.98m, true))
                return TaxRangeEnum.First;
            
            else if (salary.IsBetween(1903.98m, 2826.66m))
                return TaxRangeEnum.Second;
            
            else if (salary.IsBetween(2826.65m, 3751.06m))
                return TaxRangeEnum.Third;
            
            else if (salary.IsBetween(3751.05m, 4664.69m))
                return TaxRangeEnum.Fourth;
            
            else if (salary > 4664.68m)
                return TaxRangeEnum.Fifth;
            
            return TaxRangeEnum.Unknown;
        }
        #endregion
    }
}
