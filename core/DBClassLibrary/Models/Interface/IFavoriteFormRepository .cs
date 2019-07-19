using DBClassLibrary.Models.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DBClassLibrary.Models.Interface
{


    public interface IFavoriteFormRepository : IRepository<FavoriteForm>
    {
        IQueryable<UserFavoriteList> GetUserAll(string cusr_name);
    }
}
