﻿using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.SqlClient;
using MovieWeb.Models;
using MovieWeb.Models.API;
using System.Data;

namespace MovieWeb.Controllers.API
{
    [Route("api/[controller]")]
    [ApiController]
    public class VoteController : ControllerBase
    {
        MovieDbContext db = new MovieDbContext();
        [HttpGet]
        public async Task<StringResult> GetVote([FromQuery] int maphim)
        {
            string connectionString = "Data Source=PC\\ManhQuang;Initial Catalog=MovieDB1;Timeout=30;Integrated Security=True;Encrypt=False";

            SqlConnection sql = new SqlConnection(connectionString);
            sql.Open();
            SqlCommand sqlCommand = new SqlCommand("numVote", sql);
            sqlCommand.CommandType = CommandType.StoredProcedure;
            sqlCommand.Parameters.AddWithValue("@maphim", maphim);
            var num = await sqlCommand.ExecuteReaderAsync();
            int cmt = 0;
            if (num.HasRows)
            {
                num.Read();
                cmt = num.GetInt32(0);
            }
            return new StringResult(cmt.ToString());
        }
        [HttpGet("user")]
        public async Task<StringResult> GetVoteUser([FromQuery] int maphim, [FromQuery] int user)
        {
            string connectionString = "Data Source=PC\\ManhQuang;Initial Catalog=MovieDB1;Timeout=30;Integrated Security=True;Encrypt=False";

            SqlConnection sql = new SqlConnection(connectionString);
            sql.Open();
            SqlCommand sqlCommand = new SqlCommand("numVoteUser", sql);
            sqlCommand.CommandType = CommandType.StoredProcedure;
            sqlCommand.Parameters.AddWithValue("@maphim", maphim);
            sqlCommand.Parameters.AddWithValue("@mauser", user);
            var num = await sqlCommand.ExecuteReaderAsync();
            int cmt = 0;
            if (num.HasRows)
            {
                num.Read();
                cmt = num.GetInt32(0);
            }
            return new StringResult(cmt.ToString());
        }
        [HttpPut]
        public async Task<StringResult> putVote([FromQuery] int maphim, [FromQuery] int user, [FromBody] StringResult data)
        {
            string connectionString = "Data Source=PC\\ManhQuang;Initial Catalog=MovieDB1;Timeout=30;Integrated Security=True;Encrypt=False";

            SqlConnection sql = new SqlConnection(connectionString);
            sql.Open();
            SqlCommand sqlCommand = new SqlCommand("updateVoteUser", sql);
            sqlCommand.CommandType = CommandType.StoredProcedure;
            sqlCommand.Parameters.AddWithValue("@maphim", maphim);
            sqlCommand.Parameters.AddWithValue("@mauser", user);
            sqlCommand.Parameters.AddWithValue("@data", Convert.ToInt32(data.Result));
            await sqlCommand.ExecuteNonQueryAsync();

            return data;
        }
    }
}
