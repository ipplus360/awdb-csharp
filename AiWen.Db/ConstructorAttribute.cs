#region

using System;

#endregion

namespace AiWen.Db
{
    /// <summary>
    ///     Instruct <code>Reader</code> to use the constructor when deserializing.
    /// </summary>
    [AttributeUsage(AttributeTargets.Constructor)]
    public sealed class ConstructorAttribute : Attribute
    {
    }
}