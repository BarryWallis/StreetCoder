using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;

namespace EmojiChat;

[Route("stats/{action}")]
public class StatsController : ControllerBase
{
    private readonly IConfiguration configuration;

    public StatsController(IConfiguration config) => configuration = config;

    [HttpGet]
    public UserStats Get(int userId)
    {
        UserStats userStats = new();
        string connectionString = configuration.GetConnectionString("DB");
        using SqlConnection sqlConnection = new(connectionString);
        sqlConnection.Open();
        SqlCommand sqlCommand = sqlConnection.CreateCommand();
        sqlCommand.CommandText = "SELECT COUNT(*) FROM Messages WHERE FromId={0}";
        _ = sqlCommand.Parameters.Add(userId);
        userStats.Sent = (int)sqlCommand.ExecuteScalar();
        sqlCommand.CommandText = "SELECT COUNT(*) FROM Messages WHERE ToId={0}";
        userStats.Received = (int)sqlCommand.ExecuteScalar();
        return userStats;
    }
}
