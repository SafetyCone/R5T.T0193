using System;

using R5T.T0132;


namespace R5T.T0193.Extensions
{
    [FunctionalityMarker]
    public partial interface IStringOperator : IFunctionalityMarker
    {
        /// <inheritdoc cref="ICode"/>
        public ICode ToCode(string value)
        {
            var output = new Code(value);
            return output;
        }

        /// <inheritdoc cref="ICodeFileContent"/>
        public ICodeFileContent ToCodeFileContent(string value)
        {
            var output = new CodeFileContent(value);
            return output;
        }
    }
}
