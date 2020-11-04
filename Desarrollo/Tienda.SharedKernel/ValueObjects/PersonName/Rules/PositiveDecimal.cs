using System;
using System.Collections.Generic;
using System.Text;
using Tienda.SharedKernel.Core;

namespace Tienda.SharedKernel.ValueObjects.PersonName.Rules
{
    public class PositiveDecimal: IBusinessRule
    {
        private readonly double _value;

        public PositiveDecimal(double value)
        {
            _value = value;
        }

        public string Message => "El número debe ser mayor o igual a cero";

        public bool IsBroken()
        {
            return _value < 0;
        }
    }
}
