using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MVCBlog.Data.Interfaces;
using MVCBlog.Entityes;
using MVCBlog.Models;

namespace MVCBlog.Controllers
{
    public class BlogController : Controller
    {

        //private readonly DBContext _context;
        //public BlogController(DBContext context)
        //{
        //    _context = context;
        //}

        //[Route("Blog/Post/{id}")]
        //public IActionResult Post(int id)
        //{
        //    var query = _context.Blog.AsQueryable();

        //    var posts = query.Where(post => post.id == id).Select(p => new BlogModel
        //    {
        //        id = p.id,
        //        title = p.title,
        //        author = p.author,
        //        fullPost = p.fullPost,
        //        img = p.img,
        //    }).SingleOrDefault();

        //    return View(posts);
        //}

        //public IActionResult Blog()
        //{
        //    List<BlogModel> posts = _context.Blog.ToList();
        //    return View(posts);
        //}
        private readonly DBContext _context;
        private readonly IPostRepository _postRepository;

        public BlogController(DBContext context, IPostRepository postRepository)
        {
            _context = context;
            _postRepository = postRepository;
        }

        [Route("Blog/Post/{id}")]
        public IActionResult Post(int id)
        {
            var post = _postRepository.GetPostById(id);

            return View(post);
        }

        public IActionResult Blog()
        {
            var posts = _postRepository.GetAllPosts().ToList(); ;
            return View(posts);
        }
        [HttpPost]
        public ViewResult Edit()
        {
            return View();
        }
    }

}

