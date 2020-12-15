using System;
using System.Collections.Generic;
using CSharpBlogger.Models;
using CSharpBlogger.Repositories;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace CSharpBlogger.Services
{
  public class BlogService
  {
    public readonly BlogRepository _repo;

    public BlogService(BlogRepository repo)
    {
        _repo = repo;
    }
    public IEnumerable<Blog> Get()
    {
      return _repo.Get();
    }
  }
}