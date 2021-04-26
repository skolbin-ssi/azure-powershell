// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.HanaOnAzure.Support
{

    public partial struct AccessPolicyUpdateKind :
        System.IEquatable<AccessPolicyUpdateKind>
    {
        public static Microsoft.Azure.PowerShell.Cmdlets.HanaOnAzure.Support.AccessPolicyUpdateKind Add = @"add";

        public static Microsoft.Azure.PowerShell.Cmdlets.HanaOnAzure.Support.AccessPolicyUpdateKind Remove = @"remove";

        public static Microsoft.Azure.PowerShell.Cmdlets.HanaOnAzure.Support.AccessPolicyUpdateKind Replace = @"replace";

        /// <summary>the value for an instance of the <see cref="AccessPolicyUpdateKind" /> Enum.</summary>
        private string _value { get; set; }

        /// <summary>Creates an instance of the <see cref="AccessPolicyUpdateKind" Enum class./></summary>
        /// <param name="underlyingValue">the value to create an instance for.</param>
        private AccessPolicyUpdateKind(string underlyingValue)
        {
            this._value = underlyingValue;
        }

        /// <summary>Conversion from arbitrary object to AccessPolicyUpdateKind</summary>
        /// <param name="value">the value to convert to an instance of <see cref="AccessPolicyUpdateKind" />.</param>
        internal static object CreateFrom(object value)
        {
            return new AccessPolicyUpdateKind(System.Convert.ToString(value));
        }

        /// <summary>Compares values of enum type AccessPolicyUpdateKind</summary>
        /// <param name="e">the value to compare against this instance.</param>
        /// <returns><c>true</c> if the two instances are equal to the same value</returns>
        public bool Equals(Microsoft.Azure.PowerShell.Cmdlets.HanaOnAzure.Support.AccessPolicyUpdateKind e)
        {
            return _value.Equals(e._value);
        }

        /// <summary>Compares values of enum type AccessPolicyUpdateKind (override for Object)</summary>
        /// <param name="obj">the value to compare against this instance.</param>
        /// <returns><c>true</c> if the two instances are equal to the same value</returns>
        public override bool Equals(object obj)
        {
            return obj is AccessPolicyUpdateKind && Equals((AccessPolicyUpdateKind)obj);
        }

        /// <summary>Returns hashCode for enum AccessPolicyUpdateKind</summary>
        /// <returns>The hashCode of the value</returns>
        public override int GetHashCode()
        {
            return this._value.GetHashCode();
        }

        /// <summary>Returns string representation for AccessPolicyUpdateKind</summary>
        /// <returns>A string for this value.</returns>
        public override string ToString()
        {
            return this._value;
        }

        /// <summary>Implicit operator to convert string to AccessPolicyUpdateKind</summary>
        /// <param name="value">the value to convert to an instance of <see cref="AccessPolicyUpdateKind" />.</param>

        public static implicit operator AccessPolicyUpdateKind(string value)
        {
            return new AccessPolicyUpdateKind(value);
        }

        /// <summary>Implicit operator to convert AccessPolicyUpdateKind to string</summary>
        /// <param name="e">the value to convert to an instance of <see cref="AccessPolicyUpdateKind" />.</param>

        public static implicit operator string(Microsoft.Azure.PowerShell.Cmdlets.HanaOnAzure.Support.AccessPolicyUpdateKind e)
        {
            return e._value;
        }

        /// <summary>Overriding != operator for enum AccessPolicyUpdateKind</summary>
        /// <param name="e1">the value to compare against <see cref="e2" /></param>
        /// <param name="e2">the value to compare against <see cref="e1" /></param>
        /// <returns><c>true</c> if the two instances are not equal to the same value</returns>
        public static bool operator !=(Microsoft.Azure.PowerShell.Cmdlets.HanaOnAzure.Support.AccessPolicyUpdateKind e1, Microsoft.Azure.PowerShell.Cmdlets.HanaOnAzure.Support.AccessPolicyUpdateKind e2)
        {
            return !e2.Equals(e1);
        }

        /// <summary>Overriding == operator for enum AccessPolicyUpdateKind</summary>
        /// <param name="e1">the value to compare against <see cref="e2" /></param>
        /// <param name="e2">the value to compare against <see cref="e1" /></param>
        /// <returns><c>true</c> if the two instances are equal to the same value</returns>
        public static bool operator ==(Microsoft.Azure.PowerShell.Cmdlets.HanaOnAzure.Support.AccessPolicyUpdateKind e1, Microsoft.Azure.PowerShell.Cmdlets.HanaOnAzure.Support.AccessPolicyUpdateKind e2)
        {
            return e2.Equals(e1);
        }
    }
}