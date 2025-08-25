using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ItiProject_GRD.BLL.Vaildations
{
    public class NoNumberAttribute : ValidationAttribute
    {
        public override bool IsValid(object? value)
        {
            if (value is string strValue)
            {
                return !strValue.Any(char.IsDigit);
            }
            return true;
        }
    }
}
