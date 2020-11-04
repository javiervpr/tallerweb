using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;

using Tienda.SharedKernel.Core;
using Tienda.SharedKernel.ValueObjects.PersonName.Rules;
using Tienda.Soporte.ValueObjects.Rules;

namespace Tienda.Soporte.ValueObjects
{
    public class PrecioServicioValue : ValueObject, IComparable<PrecioServicioValue>
    {
        public double Value { get; private set; }

        public PrecioServicioValue(double value)
        {    
            CheckRule(new PositiveDecimal(value));

            Value = value;
        }


        #region Conversion

        public static implicit operator double(PrecioServicioValue value) => value.Value;

        public static implicit operator PrecioServicioValue(double value) => new PrecioServicioValue(value);

        #endregion


        public int CompareTo([AllowNull] PrecioServicioValue other)
        {
            return Value.CompareTo(other.Value);
        }
    }
}
