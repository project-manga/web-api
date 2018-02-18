namespace ProjectManga.Domain.Download.Vos
{
    using ProjectManga.Domain.Common.Vos;

    /// <summary>
    /// Represents a range with both or none
    /// bounds.
    /// </summary>
    public class Range : ValueObject<Range>
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
        /// Gets from value.
        /// </summary>
        public int? From { get; }

        /// <summary>
        /// Gets to value.
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

        public override int GetHashCode()
        {
            return From.GetValueOrDefault().GetHashCode() * 17 + To.GetValueOrDefault().GetHashCode();
        }
        #endregion
    
        #region Protected
        protected override bool DeepEquals(Range other)
        {
            return From.GetValueOrDefault() == To.GetValueOrDefault();
        }
        #endregion
    }
}
