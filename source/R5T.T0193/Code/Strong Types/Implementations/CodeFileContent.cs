using System;

using R5T.T0178;
using R5T.T0179;


namespace R5T.T0193
{
    /// <inheritdoc cref="ICodeFileContent"/>
    [StrongTypeImplementationMarker]
    public class CodeFileContent : TypedBase<string>, IStrongTypeMarker,
        ICodeFileContent
    {
        public CodeFileContent(string value)
            : base(value)
        {
        }
    }
}