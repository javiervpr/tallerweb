using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text;
using Tienda.SharedKernel.Core;
using Tienda.SharedKernel.ValueObjects.Rule;

namespace Tienda.Soporte.Domain.ValueObjects
{
    public class EspecialidadTecnicoValue : ValueObject, IComparable<EspecialidadTecnicoValue>
    {
        public string Value { get; private set; }

        public EspecialidadTecnicoValue(string value)
        {
            CheckRule(new Name200Length(value));

            Value = value;
        }


        #region Conversion

        public static implicit operator string(EspecialidadTecnicoValue value) => value.Value;

        public static implicit operator EspecialidadTecnicoValue(string value) => new EspecialidadTecnicoValue(value);

        #endregion


        public int CompareTo([AllowNull] EspecialidadTecnicoValue other)
        {
            return Value.CompareTo(other.Value);
        }
    }
}
