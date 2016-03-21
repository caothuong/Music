using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Mvc_MusicStore.Models;

namespace Mvc_MusicStore.ViewModels
{
    public class StoreBrowseViewModel
    {
        public Genre Genres { get; set; }
        public List<Album> Album { get; set;}

    }
}