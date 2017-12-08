using System;

namespace WPF.PRC.PBF
{
    public interface ISuggestable : IComparable
    {
        string DefaultValue { get; }
    }
}
