namespace Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20190401
{
    using static Microsoft.Azure.PowerShell.Cmdlets.Functions.Runtime.Extensions;

    /// <summary>One property of operation, include metric specifications.</summary>
    public partial class ServiceSpecificationAutoGenerated :
        Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20190401.IServiceSpecificationAutoGenerated,
        Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20190401.IServiceSpecificationAutoGeneratedInternal
    {

        /// <summary>Backing field for <see cref="MetricSpecification" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20190401.IMetricSpecificationAutoGenerated[] _metricSpecification;

        /// <summary>Metric specifications of operation.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Functions.Origin(Microsoft.Azure.PowerShell.Cmdlets.Functions.PropertyOrigin.Owned)]
        public Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20190401.IMetricSpecificationAutoGenerated[] MetricSpecification { get => this._metricSpecification; set => this._metricSpecification = value; }

        /// <summary>Creates an new <see cref="ServiceSpecificationAutoGenerated" /> instance.</summary>
        public ServiceSpecificationAutoGenerated()
        {

        }
    }
    /// One property of operation, include metric specifications.
    public partial interface IServiceSpecificationAutoGenerated :
        Microsoft.Azure.PowerShell.Cmdlets.Functions.Runtime.IJsonSerializable
    {
        /// <summary>Metric specifications of operation.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Functions.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Metric specifications of operation.",
        SerializedName = @"metricSpecifications",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20190401.IMetricSpecificationAutoGenerated) })]
        Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20190401.IMetricSpecificationAutoGenerated[] MetricSpecification { get; set; }

    }
    /// One property of operation, include metric specifications.
    internal partial interface IServiceSpecificationAutoGeneratedInternal

    {
        /// <summary>Metric specifications of operation.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20190401.IMetricSpecificationAutoGenerated[] MetricSpecification { get; set; }

    }
}