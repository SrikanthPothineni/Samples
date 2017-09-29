﻿using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace MsSql4.Data
{
    public class BloggingContextInitializer : CreateDatabaseIfNotExists<BloggingContext>
    {
        protected override void Seed(BloggingContext context)
        {
            var blog = new Blog { Name = "Sample" };
            var posts = new List<Post> {
                new Post { Title = "First Post", Content = "This is the first sample post" },
                new Post { Title = "Second Post", Content = "This is the second sample post" }
            };
            blog.Posts = posts;
            context.Blogs.Add(blog);

            base.Seed(context);
        }
    }
}