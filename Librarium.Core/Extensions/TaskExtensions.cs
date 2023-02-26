#nullable enable
using System;
using System.Threading.Tasks;
using JetBrains.Annotations;

namespace Librarium.Core.Extensions
{
    /// <summary>
    /// Extensions relating to tasks and async programming.
    /// </summary>
    [PublicAPI]
    public static class TaskExtensions
    {
        /// <summary>
        /// Invokes a delegate, but only if there are any subscribers to the event.
        /// </summary>
        /// <typeparam name="T">The type of the delegate.</typeparam>
        /// <param name="invocation">The method to perform. Ideally, this should be Invoke.</param>
        /// <returns>An awaitable task.</returns>
        public static Task InvokeIfAny<T>([CanBeNull] this T? del, [NotNull] Func<T, Task> invocation) where T : Delegate =>
            del is null ? Task.CompletedTask : invocation(del!);
    }
}