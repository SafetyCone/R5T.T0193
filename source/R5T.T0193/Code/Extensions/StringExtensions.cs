using System;


namespace R5T.T0193.Extensions
{
    public static class StringExtensions
    {
        /// <inheritdoc cref="IStringOperator.ToCode(string)"/>
        public static ICode ToCode(this string value)
        {
            return Instances.StringOperator_Extensions.ToCode(value);
        }

        /// <inheritdoc cref="IStringOperator.ToCodeFileContent(string)"/>
        public static ICodeFileContent ToCodeFileContent(this string value)
        {
            return Instances.StringOperator_Extensions.ToCodeFileContent(value);
        }
    }
}
