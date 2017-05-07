using System;
using System.Collections.Generic;
using System.Linq;

namespace ValidationUtils.Methods
{
    /// <summary>
    /// Validator class that contains methods that let you validate some parameters
    /// </summary>
    public static class ParamsValidator
    {
        /// <summary>
        /// Generate an exception if an item is null
        /// </summary>
        /// <param name="items"></param>
        public static void CheckIfAnyNull<T>(params object[] items) where T : Exception, new()
        {
            if (items.Any(e => e == null))
                throw new T();
        }

        /// <summary>
        /// Generate an exception if an item is null or white space
        /// </summary>
        /// <param name="items"></param>
        public static void CheckIfAnyNullOrWhiteSpace<T>(params string[] items) where T : Exception, new()
        {
            if (items.Any(e => string.IsNullOrWhiteSpace(e)))
                throw new T();
        }

        /// <summary>
        /// Generate an exception if an item is null
        /// </summary>
        /// <param name="items"></param>
        public static void CheckIfAny<T, Y>(IList<Y> items) where T : Exception, new()
        {
            if (items == null || !items.Any())
                throw new T();
        }
    }
}
