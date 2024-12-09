#nullable enable

namespace System.Diagnostics.CodeAnalysis
{
#if !(NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER)
    [ExcludeFromCodeCoverage]
    [AttributeUsage(AttributeTargets.Property | AttributeTargets.Field | AttributeTargets.Parameter, Inherited = false)]
    internal sealed class AllowNullAttribute : Attribute
    {
    }
#endif

#if !NET7_0_OR_GREATER
    [AttributeUsage(AttributeTargets.Parameter, Inherited = false)]
    [ExcludeFromCodeCoverage]
    internal sealed class ConstantExpectedAttribute : Attribute
    {
        public object? Min { get; set; }

        public object? Max { get; set; }
    }
#endif

#if !(NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER)
    [AttributeUsage(AttributeTargets.Property | AttributeTargets.Field | AttributeTargets.Parameter, Inherited = false)]
    [ExcludeFromCodeCoverage]
    internal sealed class DisallowNullAttribute : Attribute
    {
    }
#endif

#if !(NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER)
    [AttributeUsage(AttributeTargets.Method, Inherited = false)]
    [ExcludeFromCodeCoverage]
    internal sealed class DoesNotReturnAttribute : Attribute
    {
    }
#endif

#if !(NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER)
    [AttributeUsage(AttributeTargets.Parameter, Inherited = false)]
    [ExcludeFromCodeCoverage]
    internal sealed class DoesNotReturnIfAttribute : Attribute
    {
        public bool ParameterValue { get; }

        public DoesNotReturnIfAttribute(bool parameterValue)
        {
            ParameterValue = parameterValue;
        }
    }
#endif

#if !NET5_0_OR_GREATER
    [Flags]
    internal enum DynamicallyAccessedMemberTypes
    {
        None = 0,
        PublicParameterlessConstructor = 1,
        PublicConstructors = 3,
        NonPublicConstructors = 4,
        PublicMethods = 8,
        NonPublicMethods = 0x10,
        PublicFields = 0x20,
        NonPublicFields = 0x40,
        PublicNestedTypes = 0x80,
        NonPublicNestedTypes = 0x100,
        PublicProperties = 0x200,
        NonPublicProperties = 0x400,
        PublicEvents = 0x800,
        NonPublicEvents = 0x1000,
        Interfaces = 0x2000,
        All = -1
    }
#endif

    // Oprvávněné vypnutí warningu, blblo to kvůli enumu DynamicallyAccessedMemberTypes, který je internal a který je vidět napříč assembly, které mají InternalsVisibleTo.
    // Tímto vznikaly duplicitný definice tohoto enumu a tedy i warning. Řešením by v budoucnu mohlo být využití file scope. 
#pragma warning disable 0436 // The type 'DynamicallyAccessedMemberTypesA' in 'path' conflicts with the imported type 'DynamicallyAccessedMemberTypesA'.

#if !NET5_0_OR_GREATER
    [AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Method | AttributeTargets.Property | AttributeTargets.Field | AttributeTargets.Interface | AttributeTargets.Parameter | AttributeTargets.ReturnValue | AttributeTargets.GenericParameter, Inherited = false)]
    [ExcludeFromCodeCoverage]
    internal sealed class DynamicallyAccessedMembersAttribute : Attribute
    {
        public DynamicallyAccessedMemberTypes MemberTypes { get; }

        public DynamicallyAccessedMembersAttribute(DynamicallyAccessedMemberTypes memberTypes)
        {
            MemberTypes = memberTypes;
        }
    }
#endif

#if !NET5_0_OR_GREATER
    [AttributeUsage(AttributeTargets.Constructor | AttributeTargets.Method | AttributeTargets.Field, AllowMultiple = true, Inherited = false)]
    [ExcludeFromCodeCoverage]
    internal sealed class DynamicDependencyAttribute : Attribute
    {
        public string? MemberSignature { get; }

        public DynamicallyAccessedMemberTypes MemberTypes { get; }

        public Type? Type { get; }

        public string? TypeName { get; }

        public string? AssemblyName { get; }

        public string? Condition { get; set; }

        public DynamicDependencyAttribute(string memberSignature)
        {
            MemberSignature = memberSignature;
        }

        public DynamicDependencyAttribute(string memberSignature, Type type)
        {
            MemberSignature = memberSignature;
            Type = type;
        }

        public DynamicDependencyAttribute(string memberSignature, string typeName, string assemblyName)
        {
            MemberSignature = memberSignature;
            TypeName = typeName;
            AssemblyName = assemblyName;
        }

        public DynamicDependencyAttribute(DynamicallyAccessedMemberTypes memberTypes, Type type)
        {
            MemberTypes = memberTypes;
            Type = type;
        }

        public DynamicDependencyAttribute(DynamicallyAccessedMemberTypes memberTypes, string typeName, string assemblyName)
        {
            MemberTypes = memberTypes;
            TypeName = typeName;
            AssemblyName = assemblyName;
        }
    }
#endif

#pragma warning restore 0436 //The type 'DynamicallyAccessedMemberTypesA' in 'path' conflicts with the imported type 'DynamicallyAccessedMemberTypesA'.

#if !(NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER)
    [AttributeUsage(AttributeTargets.Property | AttributeTargets.Field | AttributeTargets.Parameter | AttributeTargets.ReturnValue, Inherited = false)]
    [ExcludeFromCodeCoverage]
    internal sealed class MaybeNullAttribute : Attribute
    {
    }
#endif

#if !(NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER)
    [AttributeUsage(AttributeTargets.Parameter, Inherited = false)]
    [ExcludeFromCodeCoverage]
    internal sealed class MaybeNullWhenAttribute : Attribute
    {
        public bool ReturnValue { get; }

        public MaybeNullWhenAttribute(bool returnValue)
        {
            ReturnValue = returnValue;
        }
    }
#endif

#if !NET5_0_OR_GREATER
    [AttributeUsage(AttributeTargets.Method | AttributeTargets.Property, Inherited = false, AllowMultiple = true)]
    [ExcludeFromCodeCoverage]
    internal sealed class MemberNotNullAttribute : Attribute
    {
        public string[] Members { get; }

        public MemberNotNullAttribute(string member)
        {
            Members = new string[1] { member };
        }

        public MemberNotNullAttribute(params string[] members)
        {
            Members = members;
        }
    }
#endif

#if !NET5_0_OR_GREATER
    [AttributeUsage(AttributeTargets.Method | AttributeTargets.Property, Inherited = false, AllowMultiple = true)]
    [ExcludeFromCodeCoverage]
    internal sealed class MemberNotNullWhenAttribute : Attribute
    {
        public bool ReturnValue { get; }

        public string[] Members { get; }

        public MemberNotNullWhenAttribute(bool returnValue, string member)
        {
            ReturnValue = returnValue;
            Members = new string[1] { member };
        }

        public MemberNotNullWhenAttribute(bool returnValue, params string[] members)
        {
            ReturnValue = returnValue;
            Members = members;
        }
    }
#endif

#if !(NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER)
    [AttributeUsage(AttributeTargets.Property | AttributeTargets.Field | AttributeTargets.Parameter | AttributeTargets.ReturnValue, Inherited = false)]
    [ExcludeFromCodeCoverage]
    internal sealed class NotNullAttribute : Attribute
    {
    }
#endif

#if !(NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER)
    [AttributeUsage(AttributeTargets.Property | AttributeTargets.Parameter | AttributeTargets.ReturnValue, AllowMultiple = true, Inherited = false)]
    [ExcludeFromCodeCoverage]
    internal sealed class NotNullIfNotNullAttribute : Attribute
    {
        public string ParameterName { get; }

        public NotNullIfNotNullAttribute(string parameterName)
        {
            ParameterName = parameterName;
        }
    }
#endif

#if !(NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER)
    [AttributeUsage(AttributeTargets.Parameter, Inherited = false)]
    [ExcludeFromCodeCoverage]
    internal sealed class NotNullWhenAttribute : Attribute
    {
        public bool ReturnValue { get; }

        public NotNullWhenAttribute(bool returnValue)
        {
            ReturnValue = returnValue;
        }
    }
#endif

#if !NET6_0_OR_GREATER
    [AttributeUsage(AttributeTargets.Constructor | AttributeTargets.Method | AttributeTargets.Property | AttributeTargets.Event, Inherited = false, AllowMultiple = false)]
    [ExcludeFromCodeCoverage]
    internal sealed class RequiresAssemblyFilesAttribute : Attribute
    {
        public string? Message { get; }

        public string? Url { get; set; }

        public RequiresAssemblyFilesAttribute()
        {
        }

        public RequiresAssemblyFilesAttribute(string message)
        {
            Message = message;
        }
    }
#endif

#if !NET7_0_OR_GREATER
    [AttributeUsage(AttributeTargets.Class | AttributeTargets.Constructor | AttributeTargets.Method, Inherited = false)]
    [ExcludeFromCodeCoverage]
    internal sealed class RequiresDynamicCodeAttribute : Attribute
    {
        public string Message { get; }

        public string? Url { get; set; }

        public RequiresDynamicCodeAttribute(string message)
        {
            Message = message;
        }
    }
#endif

#if !NET5_0_OR_GREATER
    [AttributeUsage(AttributeTargets.Class | AttributeTargets.Constructor | AttributeTargets.Method, Inherited = false)]
    [ExcludeFromCodeCoverage]
    internal sealed class RequiresUnreferencedCodeAttribute : Attribute
    {
        public string Message { get; }

        public string? Url { get; set; }

        public RequiresUnreferencedCodeAttribute(string message)
        {
            Message = message;
        }
    }
#endif

#if !NET7_0_OR_GREATER
    [AttributeUsage(AttributeTargets.Constructor, AllowMultiple = false, Inherited = false)]
    [ExcludeFromCodeCoverage]
    internal sealed class SetsRequiredMembersAttribute : Attribute
    {
    }
#endif

#if !NET7_0_OR_GREATER
    [AttributeUsage(AttributeTargets.Property | AttributeTargets.Field | AttributeTargets.Parameter, AllowMultiple = false, Inherited = false)]
    [ExcludeFromCodeCoverage]
    internal sealed class StringSyntaxAttribute : Attribute
    {
        public const string CompositeFormat = "CompositeFormat";

        public const string DateOnlyFormat = "DateOnlyFormat";

        public const string DateTimeFormat = "DateTimeFormat";

        public const string EnumFormat = "EnumFormat";

        public const string GuidFormat = "GuidFormat";

        public const string Json = "Json";

        public const string NumericFormat = "NumericFormat";

        public const string Regex = "Regex";

        public const string TimeOnlyFormat = "TimeOnlyFormat";

        public const string TimeSpanFormat = "TimeSpanFormat";

        public const string Uri = "Uri";

        public const string Xml = "Xml";

        public string Syntax { get; }

        public object?[] Arguments { get; }

        public StringSyntaxAttribute(string syntax)
        {
            Syntax = syntax;
            Arguments = Array.Empty<object>();
        }

        public StringSyntaxAttribute(string syntax, params object?[] arguments)
        {
            Syntax = syntax;
            Arguments = arguments;
        }
    }
#endif

#if !NET5_0_OR_GREATER
    [AttributeUsage(AttributeTargets.All, Inherited = false, AllowMultiple = true)]
    [ExcludeFromCodeCoverage]
    internal sealed class UnconditionalSuppressMessageAttribute : Attribute
    {
        public string Category { get; }

        public string CheckId { get; }

        public string? Scope { get; set; }

        public string? Target { get; set; }

        public string? MessageId { get; set; }

        public string? Justification { get; set; }

        public UnconditionalSuppressMessageAttribute(string category, string checkId)
        {
            Category = category;
            CheckId = checkId;
        }
    }
#endif

#if !NET7_0_OR_GREATER
    [AttributeUsage(AttributeTargets.Method | AttributeTargets.Property | AttributeTargets.Parameter, AllowMultiple = false, Inherited = false)]
    [ExcludeFromCodeCoverage]
    internal sealed class UnscopedRefAttribute : Attribute
    {
    }
#endif

}