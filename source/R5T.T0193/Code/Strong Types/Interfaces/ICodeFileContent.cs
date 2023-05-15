using System;

using R5T.T0178;


namespace R5T.T0193
{
    /// <summary>
    /// Strongly-types a string as the content of a code file.
    /// </summary>
    [StrongTypeMarker]
    public interface ICodeFileContent : IStrongTypeMarker,
        // The content of a code file *is* code.
        ICode
    {
    }
}