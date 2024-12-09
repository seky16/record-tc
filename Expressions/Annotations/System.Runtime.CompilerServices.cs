#nullable enable

using System.ComponentModel;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;

#if NET5_0_OR_GREATER
[assembly: System.Runtime.CompilerServices.TypeForwardedTo(typeof(System.Runtime.CompilerServices.IsExternalInit))]
#endif

namespace System.Runtime.CompilerServices
{
#if !NET5_0_OR_GREATER
    /// <summary>
    /// Reserved to be used by the compiler for tracking metadata. This class should not be used by developers in source code.
    /// </summary>
    [ExcludeFromCodeCoverage, DebuggerNonUserCode, EditorBrowsable(EditorBrowsableState.Never)]
    internal static class IsExternalInit
    {
    }
#endif

#if !NET7_0_OR_GREATER
    /// <summary>
    /// Specifies that a type has required members or that a member is required.
    /// </summary>
    [ExcludeFromCodeCoverage, DebuggerNonUserCode, EditorBrowsable(EditorBrowsableState.Never)]
    [AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Property | AttributeTargets.Field, AllowMultiple = false, Inherited = false)]
    internal sealed class RequiredMemberAttribute : Attribute
    {
    }
#endif

#if !NET7_0_OR_GREATER
    /// <summary>
    /// Indicates that compiler support for a particular feature is required for the location where this attribute is applied.
    /// </summary>
    [ExcludeFromCodeCoverage, DebuggerNonUserCode, EditorBrowsable(EditorBrowsableState.Never)]
    [AttributeUsage(AttributeTargets.All, AllowMultiple = true, Inherited = false)]
    internal sealed class CompilerFeatureRequiredAttribute : Attribute
    {
        public const string RefStructs = "RefStructs";

        public const string RequiredMembers = "RequiredMembers";

        public string FeatureName { get; }

        public bool IsOptional { get; set; }

        public CompilerFeatureRequiredAttribute(string featureName)
        {
            FeatureName = featureName;
        }
    }
#endif
}