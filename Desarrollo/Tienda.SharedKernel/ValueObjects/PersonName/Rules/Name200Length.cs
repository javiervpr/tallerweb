using System;
using System.Collections.Generic;
using System.Text;
using Tienda.SharedKernel.Core;

namespace Tienda.SharedKernel.ValueObjects.Rule
{
    public class Name200Length : IBusinessRule
    {
        private readonly string _value;

        public Name200Length(string value)
        {
            _value = value;
        }

        public string Message => "El texto no puede contener mas de 200 caracteres";

        public bool IsBroken() => _value.Length > 200;
    }
}
