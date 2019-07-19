using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DBClassLibrary.Models.ViewModel
{
    public class FavoriteView
    {
        public IEnumerable<FavoriteList> favoriteList { get; set; }
        public IEnumerable<UserFavoriteList> userFavoriteList { get; set; }
    }


    public class FavoriteList
    {
        public string cfrm_name { get; set; }
        public string cfrm_desp { get; set; }
        public string cfrmNo { get; set; }
    }
    public class UserFavoriteList
    {

        public string cfrmgroup_id { get; set; }
        public string cfrm_name { get; set; }
        public string cfrm_desp { get; set; }
        public string cfrmNo { get; set; }
    }
}