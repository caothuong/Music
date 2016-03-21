using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Mvc_MusicStore.ViewModels;
using Mvc_MusicStore.Models;

namespace Mvc_MusicStore.Controllers
{
    public class StoreController : Controller
    {
        //
        // GET: /Store/

        public ActionResult Index()
        {
            var genres = new List<string>{"Rock", "Jazz", "Country", "Pop", "Disco"};

            var viewModels = new StoreIndexViewModels()
            {
                NumberOfGenres = genres.Count,
                Genres = genres
            };
            ViewBag.Starred = new List<string> { "Rock", "Jazz" };
            return View(viewModels);
        }
        public ActionResult Browse(string genre)
        {
            var genreModel = new Genre()
            {
                Name = genre
            };
            var albums = new List<Album>()
            {
                new Album{Title = genre + " Album 1"},
                new Album{Title = genre + " Album 2"}
            };
            var viewModel = new StoreBrowseViewModel()
            {
                Genres = genreModel,
                Album = albums

            };
            return View(viewModel);
        }

        public ActionResult Detail(int Id)
        {
            var album = new Album{Title = "Sample Album"};
            return View(album);
        }
        //public string Index()
        //{
        //    return "Hello from Store.Index()";
        //}

        //public string Browse()
        //{
        //    return "Hello from Store.Browse()";
        //}

        //public string Detail()
        //{
        //    return "Hello from Store.Detail()";
        //}

        //public string Browse(string genre)
        //{
        //    string message = HttpUtility.HtmlEncode("Store.Browse, Genre = " + genre);
        //    return message;
        //}
        //public string Detail(int Id)
        //{
        //    string message = "Store.Detail, ID = " + Id;
        //    return message;
        //}
    }
}
