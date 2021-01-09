using Solid.Interface;
using Solid.Helpers.Utils.Enums;
using System.Collections.Generic;

namespace Solid.Classes
{
    public abstract class Tax : ITax
    {
        protected Dictionary<TaxRangeEnum, double> Aliquot { get; set; }
        protected Dictionary<TaxRangeEnum, decimal> ParcelToDeduct { get; set; }

        protected Tax() { }

        #region Actions
        public abstract decimal ApplyTax(decimal value);
        #endregion
    }
}