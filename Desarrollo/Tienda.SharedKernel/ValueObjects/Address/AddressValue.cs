using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text;
using Tienda.SharedKernel.Core;
using Tienda.SharedKernel.ValueObjects.Address.Rules;
using Tienda.SharedKernel.ValueObjects.Rule;

namespace Tienda.SharedKernel.ValueObjects.Address
{
    public class AddressValue : ValueObject, IComparable<AddressValue>
    {
        public string Value { get; private set; }

        public AddressValue(string value)
        {
            CheckRule(new NotNullRule<string>(value));
            CheckRule(new OnlyLettersRule(value));
            CheckRule(new AddressLengthRule(value));

            Value = value;
        }


        #region Conversion

        public static implicit operator string(AddressValue value) => value.Value;

        public static implicit operator AddressValue(string value) => new AddressValue(value);

        #endregion


        public int CompareTo([AllowNull] AddressValue other)
        {
            return Value.CompareTo(other.Value);
        }
    }
}
