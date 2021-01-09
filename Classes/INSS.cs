using System.Collections.Generic;
using Solid.Helpers.Utils;
using Solid.Helpers.Utils.Enums;

namespace Solid.Classes
{
    public class INSS : Tax
    {
        public INSS(Dictionary<TaxRangeEnum, double> aliquot = null, Dictionary<TaxRangeEnum, decimal> parcelToDeduct = null)
        {
            this.Aliquot = new Dictionary<TaxRangeEnum, double>()
            {
                {TaxRangeEnum.First, 0.075},
                {TaxRangeEnum.Second, 0.09},
                {TaxRangeEnum.Third, 0.12},
                {TaxRangeEnum.Fourth, 0.14},
                {TaxRangeEnum.Fifth, 0.00}
            };

            this.ParcelToDeduct = new Dictionary<TaxRangeEnum, decimal>()
            {
                {TaxRangeEnum.First, 00.000m},
                {TaxRangeEnum.Second, 15.681m},
                {TaxRangeEnum.Third, 78.378m},
                {TaxRangeEnum.Fourth, 141.068m},
                {TaxRangeEnum.Fifth, 713.09m}
            };
        }

        #region Actions
        public override decimal ApplyTax(decimal salary)
        {
            // TO DO: Original Method
  
            var salaryRange = GetSalaryRange(salary);

            salary -= (salary.ApplyPercentage(this.Aliquot[salaryRange]) - this.ParcelToDeduct[salaryRange]);

            return salary;
        }
        #endregion

        #region GETs
        private TaxRangeEnum GetSalaryRange(decimal salary)
        {
            if (salary.IsBetween(0, 1045.00m, true))
                return TaxRangeEnum.First;

            else if (salary.IsBetween(1045.00m, 2089.61m))
                return TaxRangeEnum.Second;

            else if (salary.IsBetween(2089.60m, 3134.41m))
                return TaxRangeEnum.Third;

            else if (salary.IsBetween(3134.40m, 6101.07m))
                return TaxRangeEnum.Fourth;

            else if (salary > 6101.06m)
                return TaxRangeEnum.Fifth;

            return TaxRangeEnum.Unknown;
        }
        #endregion
    }
}