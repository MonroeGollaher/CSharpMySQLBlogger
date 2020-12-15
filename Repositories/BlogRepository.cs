using System;
using System.Collections.Generic;
using CSharpBlogger.Models;
using System.Data;
using Dapper;

namespace CSharpBlogger.Repositories
{
  public class BlogRepository
  {
    public readonly IDbConnection _db;

    public BlogRepository(IDbConnection db)
    {
        _db = db;
    }
    public IEnumerable<Blog> Get()
    {
      string sql = "SELECT * FROM blogs"; 
      return _db.Query<Blog>(sql);
    }
  }
}