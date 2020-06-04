﻿#region

using System;
#if !NETSTANDARD1_4
using System.Runtime.Serialization;
#endif
#endregion

namespace AiWen.Db
{
    /// <summary>
    ///     Thrown when the AiWen database file is incorrectly formatted
    /// </summary>
#if !NETSTANDARD1_4
    [Serializable]
#endif
    public sealed class InvalidDatabaseException : Exception
    {
        /// <summary>
        ///     Initializes a new instance of the <see cref="InvalidDatabaseException" /> class.
        /// </summary>
        /// <param name="message">A message that describes the error.</param>
        public InvalidDatabaseException(string message)
            : base(message)
        {
        }

        /// <summary>
        ///     Initializes a new instance of the <see cref="InvalidDatabaseException" /> class.
        /// </summary>
        /// <param name="message">The error message that explains the reason for the exception.</param>
        /// <param name="innerException">
        ///     The exception that is the cause of the current exception. If the
        ///     <paramref name="innerException" /> parameter is not a null reference, the current exception is raised in a catch
        ///     block that handles the inner exception.
        /// </param>
        public InvalidDatabaseException(string message, Exception innerException)
            : base(message, innerException)
        {
        }

#if !NETSTANDARD1_4
        /// <summary>
        ///     Constructor for deserialization.
        /// </summary>
        /// <param name="info">The SerializationInfo with data.</param>
        /// <param name="context">The source for this deserialization.</param>
        private InvalidDatabaseException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
#endif
    }
}
