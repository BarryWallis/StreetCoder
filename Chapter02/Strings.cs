using System.Text;

namespace Chapter02;
public static class Strings
{
    /// <summary>
    /// Join multiple names into a single string. If there are no names, the empty string is returned.
    /// </summary>
    /// <param name="names">The names.</param>
    /// <returns>The string of names.</returns>
    public static string JoinNames(string[] names)
    {
        string result = string.Empty;
        if (names.Length > 0)
        {
            StringBuilder stringBuilder = new();
            int lastIndex = names.Length - 1;
            for (int i = 0; i < lastIndex; i++)
            {
                _ = stringBuilder.Append(names[i]).Append(", ");
            }

            result = stringBuilder.Append(names[lastIndex]).ToString();
        }

        return result;
    }

    /// <summary>
    /// Concatenate the first, middle and last names into a single name.
    /// </summary>
    /// <param name="firstName">The first name.</param>
    /// <param name="middleName">The middle name.</param>
    /// <param name="lastName">The last name.</param>
    /// <returns>The full name.</returns>
    public static string ConcatName(string firstName, string middleName, string lastName)
        => ((string.IsNullOrWhiteSpace(firstName) ? string.Empty : $"{firstName} ")
           + (string.IsNullOrWhiteSpace(middleName) ? string.Empty : $"{middleName} ")
           + (string.IsNullOrWhiteSpace(lastName) ? string.Empty : $"{lastName}"))
           .Trim();

    /// <summary>
    /// Exension method to determine if a filename string ends with .GIF.
    /// </summary>
    /// <param name="filename">The file name.</param>
    /// <returns><see langword="true"/> if the filename ends with .GIF; otherwise <see langword="false"./></returns>
    public static bool IsGif(this string filename) => filename.EndsWith(".gif", StringComparison.OrdinalIgnoreCase);
}
