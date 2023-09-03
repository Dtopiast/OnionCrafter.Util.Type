namespace OnionCrafter.Util.Type
{
    /// <summary>
    /// This static class provides extension methods for various types.
    /// </summary>
    public static class ValidTypeExtension
    {
        /// <summary>
        /// Ensures that the type is a valid subclass of the specified type.
        /// </summary>
        /// <param name="type">The type to check.</param>
        /// <param name="ImplementType">The type to check against.</param>
        /// <exception cref="ArgumentNullException">Thrown when either <paramref name="type"/> or <paramref name="ImplementType"/> is null.</exception>
        /// <exception cref="InvalidCastException">Thrown when <paramref name="type"/> is not a subclass of <paramref name="ImplementType"/>.</exception>

        public static void EnsureValidImplement(this System.Type? type, System.Type? ImplementType)
        {
            if (type is null)
                throw new ArgumentNullException(nameof(type));
            if (ImplementType is null)
                throw new ArgumentNullException(nameof(ImplementType));

            if (!type.IsSubclassOf(ImplementType))
                throw new InvalidCastException($"Type {ImplementType} must be a subclass of {type}.");
        }
    }
}