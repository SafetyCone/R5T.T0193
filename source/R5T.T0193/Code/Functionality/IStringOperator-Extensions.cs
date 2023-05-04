using System;

using R5T.T0132;


namespace R5T.T0193.Extensions
{
    [FunctionalityMarker]
    public partial interface IStringOperator : IFunctionalityMarker
    {
        public ICode ToCode(string value)
        {
            var output = new Code(value);
            return output;
        }
    }
}
