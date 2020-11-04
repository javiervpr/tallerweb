using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;

using Tienda.SharedKernel.Core;
using Tienda.Soporte.ValueObjects.Rules;

namespace Tienda.Soporte.ValueObjects
{
    public class ComentarioClienteValue : ValueObject, IComparable<ComentarioClienteValue>
    {
        public string Value { get; private set; }

        public ComentarioClienteValue(string value)
        {    
            CheckRule(new ComentarioClienteLengthRule(value));

            Value = value;
        }


        #region Conversion

        public static implicit operator string(ComentarioClienteValue value) => value.Value;

        public static implicit operator ComentarioClienteValue(string value) => new ComentarioClienteValue(value);

        #endregion


        public int CompareTo([AllowNull] ComentarioClienteValue other)
        {
            return Value.CompareTo(other.Value);
        }
    }
}
