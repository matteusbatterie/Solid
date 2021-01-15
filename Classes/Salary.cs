using System.Collections.Generic;
using Solid.Interface;

namespace Solid
{
    public class Salary
    {
        public decimal NetSalary { get; set; }
        public decimal GrossSalary { get; set; }

        public Salary(decimal grossSalary = 0, decimal? netSalary = null)
        {
            this.GrossSalary = grossSalary;
            this.NetSalary = netSalary ?? grossSalary;
        }
        
        #region Actions
        public Salary ApplyTaxes(List<ITax> taxes)
        {
            taxes.ForEach(tax =>
            {                
                this.NetSalary = tax.ApplyTax(this.NetSalary);
            });

            return this;
        }
        #endregion
    }
}
