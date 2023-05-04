using System;


namespace R5T.T0193.Extensions
{
    public static class StringExtensions
    {
        public static ICode ToCode(this string value)
        {
            return Instances.StringOperator_Extensions.ToCode(value);
        }
    }
}
