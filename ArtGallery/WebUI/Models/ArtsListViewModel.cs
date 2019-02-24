using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebUI.Models
{
    public class ArtsListViewModel
    {
        public IEnumerable<Art> Arts { get; set; }
        public PagingInfo PagingInfo { get; set; }
    }
}