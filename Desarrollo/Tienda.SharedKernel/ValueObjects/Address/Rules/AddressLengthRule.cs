using System;
using System.Collections.Generic;
using System.Text;
using Tienda.SharedKernel.Core;

namespace Tienda.SharedKernel.ValueObjects.Address.Rules
{
    public class AddressLengthRule : IBusinessRule
    {
        private readonly string _value;
        public AddressLengthRule(string value)
        {
            _value = value;
        }

        public string Message => "La dirección debe tener entre 10-600 caracteres";

        public bool IsBroken() => _value.Length > 200 || _value.Length < 10;
    }
}

