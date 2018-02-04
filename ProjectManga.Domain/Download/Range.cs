namespace ProjectManga.Domain.Download
{
    /// <summary>
    /// Represents a range with both or none
    /// bounds.
    /// </summary>
    public struct Range
    {
        #region Constructors
        /// <summary>
        /// Creates the range.
        /// </summary>
        /// <param name="from">Lower bound</param>
        /// <param name="to">Upper bound</param>
        public Range(int? from, int? to)
        {
            From = from;
            To = to;
        }
        #endregion

        #region Public
        /// <summary>
        /// Gets or sets from value.
        /// </summary>
        public int? From { get; }

        /// <summary>
        /// Gets or sets to value.
        /// </summary>
        public int? To { get; }

        /// <summary>
        /// Tells if the range has an upper bound.
        /// </summary>
        public bool HasUpperBound => To.HasValue;

        /// <summary>
        /// Tells if the range has an lower bound.
        /// </summary>
        public bool HasLowerBound => From.HasValue;
        #endregion
    }
}
