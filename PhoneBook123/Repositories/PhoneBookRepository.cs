using Npgsql;
using PhoneBook.Api.Models;
using System.Data;
using Dapper;
using System.Data.Common;
using System.Configuration;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.Extensions.Options;

namespace PhoneBook.Api.Repositories;


    public class PhoneBookRepository : IPhoneBookRepository
{

    string connectionString = optionsMonitor.CurrentValue;

    public PhoneBookRepository(string conn)
        {
            connectionString = conn;
        }

        public async Task<List<BookPhone>> GetBookPhone(string name, string number, long homeNumber)
        {

            using (DbConnection db = new NpgsqlConnection(connectionString))
            {
                if (db.State == ConnectionState.Closed)
                {
                    await db.OpenAsync();
                }
            return db.Query<BookPhone>("SELECT * FROM phone").ToList();
        }
        }

        public async Task<BookPhone> AddAsync(string name, string number, long homeNumber)
        {
            return new BookPhone
            {
                Name = name,
                Phone = number,
                HomeNumber = homeNumber
            };
        }


    }
