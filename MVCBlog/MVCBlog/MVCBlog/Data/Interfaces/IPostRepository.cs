using MVCBlog.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVCBlog.Data.Interfaces
{
    public interface IPostRepository
    {
        BlogModel GetPostById(int id);
        IEnumerable<BlogModel> GetAllPosts();
        BlogModel CreatePost(BlogModel post);
        BlogModel UpdatePost(BlogModel newPost);
        BlogModel DeletePost(int Id);
    }
}
