using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmojiChat;

/// <summary>
/// Per user statistics.
/// </summary>
public class UserStats
{
    /// <summary>
    /// Number of bytes recieved by the user.
    /// </summary>
    public int Received { get; set; }

    /// <summary>
    /// Number of bytes sent by the user.
    /// </summary>
    public int Sent { get; set; }
}
