namespace Chapter02;
public class PostId
{
    /// <summary>
    /// The identifier for this post.
    /// </summary>
    public int Id { get; init; }

    /// <summary>
    /// Creaate a new post identifier.
    /// </summary>
    /// <param name="id">The identifier of the post.</param>
    /// <exception cref="ArgumentOutOfRangeException"><paramref name="id"/> is not positive.</exception>
    public PostId(int id) => Id = id > 0 ? id : throw new ArgumentOutOfRangeException(nameof(id));

    /// <inheritdoc/>
    public override bool Equals(object? obj) => obj is PostId other && other.Id == Id;

    /// <inheritdoc/>
    public override int GetHashCode() => Id;

    /// <inheritdoc/>
    public override string ToString() => Id.ToString();

    /// <summary>
    /// Determine if the left and right operands are equal.
    /// </summary>
    /// <param name="left">The left operand.</param>
    /// <param name="right">The right operand.</param>
    /// <returns><see langword="true"/> if the two operands are equal; otherwise <see langword="false"/>.</returns>
    public static bool operator ==(PostId left, PostId right) => left.Equals(right);

    /// <summary>
    /// Determine if the left and right operands are not equal.
    /// </summary>
    /// <param name="left">The left operand.</param>
    /// <param name="right">The right operand.</param>
    /// <returns><see langword="true"/> if the two operands are not equal; otherwise <see langword="false"/>.</returns>
    public static bool operator !=(PostId left, PostId right) => !left.Equals(right);

}
