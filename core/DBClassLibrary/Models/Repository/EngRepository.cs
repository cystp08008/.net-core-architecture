using DBClassLibrary.Models.Interface;
using DBClassLibrary.Models.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DBClassLibrary.Models.Repository
{
    public class EngRepository : Repository<Eng>, IEngRepository
    {
        private readonly Bom2013Context _Bom2013Context;
        public EngRepository(Bom2013Context context) : base(context)
        {
            _Bom2013Context = context;
        }




        public IQueryable<Eng> GetNoneCYEng(string cusr_name)
        {

            var userEng = _Bom2013Context.UserEngRight
                   .Where(m => m.CusrName == cusr_name)
                   .Select(m => m.CengId)
                   .ToArray();

            return _Bom2013Context.Eng.Where(m => userEng.Contains(m.CengId));
        }
    }
}
