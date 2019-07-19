using DBClassLibrary.Models.Interface;
using DBClassLibrary.Models.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DBClassLibrary.Models.Repository
{
    public class FavoriteFormRepository : Repository<FavoriteForm>, IFavoriteFormRepository
    {
        private readonly Bom2013Context _Bom2013Context;
        public FavoriteFormRepository(Bom2013Context context) : base(context)
        {
            _Bom2013Context = context;
        }

        public IQueryable<UserFavoriteList> GetUserAll(string cusr_name)
        {
            return (from F in _Bom2013Context.Form
                    join FF in _Bom2013Context.FavoriteForm on F.CfrmName equals FF.CfrmgroupId
                    where FF.CusrName == cusr_name
                    orderby F.CfrmNo
                    select new UserFavoriteList
                    {
                        cfrmgroup_id = F.CfrmgroupId,
                        cfrm_name = F.CfrmName,
                        cfrmNo = F.CfrmNo,
                        cfrm_desp = F.CfrmDesp
                    });
        }
    }
}
