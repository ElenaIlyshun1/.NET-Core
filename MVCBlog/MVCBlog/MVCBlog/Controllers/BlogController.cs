using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using MVCBlog.Data.Interfaces;
using MVCBlog.Entityes;
using MVCBlog.Models;
using MVCBlog.ViewModel;

namespace MVCBlog.Controllers
{
    public class BlogController : Controller
    {
        private readonly IPostRepository _postRepository;
        private readonly IHostingEnvironment hostingEnvironment;
        private readonly ILogger logger;

        public BlogController(DBContext context, IPostRepository postRepository,
            IHostingEnvironment hostingEnvironment,
            ILogger<BlogController> logger)
        {
            _postRepository = postRepository;
            this.hostingEnvironment = hostingEnvironment;
            this.logger = logger;
        }

        [Route("Blog/Post/{id}")]
        public IActionResult Post(int id)
        {
            logger.LogTrace("Trace Log");
            logger.LogDebug("Debug Log");
            logger.LogInformation("Information Log");
            logger.LogWarning("Warning Log");
            logger.LogError("Error Log");
            logger.LogCritical("Critical Log");
            var post = _postRepository.GetPostById(id);

            if (post == null)
            {
                Response.StatusCode = 404;
                return View("PostNotFound", id);
            }

            return View(post);
        }

        public IActionResult Blog()
        {
            var posts = _postRepository.GetAllPosts().ToList(); ;
            return View(posts);
        }
        [HttpGet]
        public ViewResult Edit(int id)
        {
            BlogModel post = _postRepository.GetPostById(id);
            PostEditViewModel postEditViewModel = new PostEditViewModel
            {
                Id = post.id,
                title = post.title,
                author = post.author,
                preview = post.preview,
                fullPost = post.fullPost,
                ExistImgPath = post.img
            };
            return View(postEditViewModel);
        }

        [HttpPost]
        public IActionResult Edit(PostEditViewModel model)
        {

            if (ModelState.IsValid)
            {
                BlogModel post = _postRepository.GetPostById(model.Id);
                post.author = model.author;
                post.title = model.title;
                post.preview = model.preview;
                post.fullPost = model.fullPost;

                if (model.img != null)
                {
                    if (model.ExistImgPath != null)
                    {
                        string filePath = Path.Combine(hostingEnvironment.WebRootPath, "img", model.ExistImgPath);
                        System.IO.File.Delete(filePath);
                    }
                    post.img = UploadedFile(model);
                }

                _postRepository.UpdatePost(post);
                return RedirectToAction("Blog");
            }
            return View();
        }

        private string UploadedFile(PostEditViewModel model)
        {
            string uniqFileName = null;
            if (model.img != null)
            {
                string uploadsFolder = Path.Combine(hostingEnvironment.WebRootPath, "img");
                uniqFileName = Guid.NewGuid().ToString() + "_" + model.img.FileName;
                string filePath = Path.Combine(uploadsFolder, uniqFileName);
                using (var fileStream = new FileStream(filePath, FileMode.Create))
                {
                    model.img.CopyTo(fileStream);
                }
            }

            return uniqFileName;
        }
    }
    //public class BlogController : Controller
    //{

    //    //private readonly DBContext _context;
    //    //public BlogController(DBContext context)
    //    //{
    //    //    _context = context;
    //    //}

    //    //[Route("Blog/Post/{id}")]
    //    //public IActionResult Post(int id)
    //    //{
    //    //    var query = _context.Blog.AsQueryable();

    //    //    var posts = query.Where(post => post.id == id).Select(p => new BlogModel
    //    //    {
    //    //        id = p.id,
    //    //        title = p.title,
    //    //        author = p.author,
    //    //        fullPost = p.fullPost,
    //    //        img = p.img,
    //    //    }).SingleOrDefault();

    //    //    return View(posts);
    //    //}

    //    //public IActionResult Blog()
    //    //{
    //    //    List<BlogModel> posts = _context.Blog.ToList();
    //    //    return View(posts);
    //    //}
    //    private readonly DBContext _context;
    //    private readonly IPostRepository _postRepository;

    //    public BlogController(DBContext context, IPostRepository postRepository)
    //    {
    //        _context = context;
    //        _postRepository = postRepository;
    //    }

    //    [Route("Blog/Post/{id}")]
    //    public IActionResult Post(int id)
    //    {
    //        var post = _postRepository.GetPostById(id);

    //        return View(post);
    //    }

    //    public IActionResult Blog()
    //    {
    //        var posts = _postRepository.GetAllPosts().ToList(); ;
    //        return View(posts);
    //    }
    //    [HttpPost]
    //    public ViewResult Edit()
    //    {
    //        return View();
    //    }
    //}

}

