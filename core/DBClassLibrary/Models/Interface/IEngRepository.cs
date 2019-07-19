using DBClassLibrary.Models.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DBClassLibrary.Models.Interface
{


    public interface IEngRepository : IRepository<Eng>
    {
        IQueryable<Eng> GetNoneCYEng(string cusr_name);
    }
}
