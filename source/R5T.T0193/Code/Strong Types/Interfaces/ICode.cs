using System;

using R5T.T0178;
using R5T.T0185;


namespace R5T.T0193
{
    /// <summary>
    /// Strongly-types a string as computer code.
    /// </summary>
    [StrongTypeMarker]
    public interface ICode : IStrongTypeMarker,
        // Code *is* a form of text.
        IText
    {
    }
}
