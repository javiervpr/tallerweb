using System;
using System.Collections.Generic;
using System.Text;
using Tienda.SharedKernel.Core;

namespace Tienda.Soporte.ValueObjects.Rules
{
    public class ComentarioClienteLengthRule : IBusinessRule
    {
        private readonly string _value;
        public ComentarioClienteLengthRule(string value)
        {
            _value = value;
        }

        public string Message => "La dirección debe contener entre 5-600 caracteres";

        public bool IsBroken() => _value.Length > 600 || _value.Length < 4;
    }
}

