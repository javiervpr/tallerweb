using System;
using System.Collections.Generic;
using System.Text;
using Tienda.SharedKernel.Core;

namespace Tienda.SharedKernel.ValueObjects.Rule
{
    public class NameLengtRule : IBusinessRule
    {
        private readonly string _value;

        public NameLengtRule(string value)
        {
            _value = value;
        }

        public string Message => "El nombre no puede contener debe tener entre 3-200 caracteres";

        public bool IsBroken() => _value.Length > 200 || _value.Length < 2;
    }
}
