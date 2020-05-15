// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.Functions.Support
{

    public partial struct AppServicePlanRestrictions :
        System.IEquatable<AppServicePlanRestrictions>
    {
        public static Microsoft.Azure.PowerShell.Cmdlets.Functions.Support.AppServicePlanRestrictions Basic = @"Basic";

        public static Microsoft.Azure.PowerShell.Cmdlets.Functions.Support.AppServicePlanRestrictions Free = @"Free";

        public static Microsoft.Azure.PowerShell.Cmdlets.Functions.Support.AppServicePlanRestrictions None = @"None";

        public static Microsoft.Azure.PowerShell.Cmdlets.Functions.Support.AppServicePlanRestrictions Premium = @"Premium";

        public static Microsoft.Azure.PowerShell.Cmdlets.Functions.Support.AppServicePlanRestrictions Shared = @"Shared";

        public static Microsoft.Azure.PowerShell.Cmdlets.Functions.Support.AppServicePlanRestrictions Standard = @"Standard";

        /// <summary>
        /// the value for an instance of the <see cref="AppServicePlanRestrictions" /> Enum.
        /// </summary>
        private string _value { get; set; }

        /// <summary>Creates an instance of the <see cref="AppServicePlanRestrictions" Enum class./></summary>
        /// <param name="underlyingValue">the value to create an instance for.</param>
        private AppServicePlanRestrictions(string underlyingValue)
        {
            this._value = underlyingValue;
        }

        /// <summary>Conversion from arbitrary object to AppServicePlanRestrictions</summary>
        /// <param name="value">the value to convert to an instance of <see cref="AppServicePlanRestrictions" />.</param>
        internal static object CreateFrom(object value)
        {
            return new AppServicePlanRestrictions(System.Convert.ToString(value));
        }

        /// <summary>Compares values of enum type AppServicePlanRestrictions</summary>
        /// <param name="e">the value to compare against this instance.</param>
        /// <returns><c>true</c> if the two instances are equal to the same value</returns>
        public bool Equals(Microsoft.Azure.PowerShell.Cmdlets.Functions.Support.AppServicePlanRestrictions e)
        {
            return _value.Equals(e._value);
        }

        /// <summary>Compares values of enum type AppServicePlanRestrictions (override for Object)</summary>
        /// <param name="obj">the value to compare against this instance.</param>
        /// <returns><c>true</c> if the two instances are equal to the same value</returns>
        public override bool Equals(object obj)
        {
            return obj is AppServicePlanRestrictions && Equals((AppServicePlanRestrictions)obj);
        }

        /// <summary>Returns hashCode for enum AppServicePlanRestrictions</summary>
        /// <returns>The hashCode of the value</returns>
        public override int GetHashCode()
        {
            return this._value.GetHashCode();
        }

        /// <summary>Returns string representation for AppServicePlanRestrictions</summary>
        /// <returns>A string for this value.</returns>
        public override string ToString()
        {
            return this._value;
        }

        /// <summary>Implicit operator to convert string to AppServicePlanRestrictions</summary>
        /// <param name="value">the value to convert to an instance of <see cref="AppServicePlanRestrictions" />.</param>

        public static implicit operator AppServicePlanRestrictions(string value)
        {
            return new AppServicePlanRestrictions(value);
        }

        /// <summary>Implicit operator to convert AppServicePlanRestrictions to string</summary>
        /// <param name="e">the value to convert to an instance of <see cref="AppServicePlanRestrictions" />.</param>

        public static implicit operator string(Microsoft.Azure.PowerShell.Cmdlets.Functions.Support.AppServicePlanRestrictions e)
        {
            return e._value;
        }

        /// <summary>Overriding != operator for enum AppServicePlanRestrictions</summary>
        /// <param name="e1">the value to compare against <see cref="e2" /></param>
        /// <param name="e2">the value to compare against <see cref="e1" /></param>
        /// <returns><c>true</c> if the two instances are not equal to the same value</returns>
        public static bool operator !=(Microsoft.Azure.PowerShell.Cmdlets.Functions.Support.AppServicePlanRestrictions e1, Microsoft.Azure.PowerShell.Cmdlets.Functions.Support.AppServicePlanRestrictions e2)
        {
            return !e2.Equals(e1);
        }

        /// <summary>Overriding == operator for enum AppServicePlanRestrictions</summary>
        /// <param name="e1">the value to compare against <see cref="e2" /></param>
        /// <param name="e2">the value to compare against <see cref="e1" /></param>
        /// <returns><c>true</c> if the two instances are equal to the same value</returns>
        public static bool operator ==(Microsoft.Azure.PowerShell.Cmdlets.Functions.Support.AppServicePlanRestrictions e1, Microsoft.Azure.PowerShell.Cmdlets.Functions.Support.AppServicePlanRestrictions e2)
        {
            return e2.Equals(e1);
        }
    }
}