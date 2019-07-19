using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DBClassLibrary.Models.ViewModel;
using DBClassLibrary.Models.Interface;

namespace DBClassLibrary.Models.Repository
{
    public class RightRepository : IRightRepository
    {
        private readonly Bom2013Context _Bom2013Context;
        public RightRepository(Bom2013Context Bom2013Context)
        {
            _Bom2013Context = Bom2013Context;
        }


        public IQueryable<FormMain> GetFormMainByRight(string cusr_name, string navTitle)
        {
            var formMain = (from RG in _Bom2013Context.RGrpUserSup
                            join TG in _Bom2013Context.Tgroup on RG.CgrpName equals TG.CgrpName
                            join FR in _Bom2013Context.FormRight on TG.CgrpName equals FR.CgrpName
                            join F in _Bom2013Context.Form on FR.CfrmName equals F.CfrmName
                            join FG in _Bom2013Context.FormGroup on F.CfrmgroupId equals FG.CfrmgroupId
                            where FG.CParent == navTitle && RG.CId == cusr_name
                            select new FormMain
                            {
                                cfrmgroup_id = FG.CfrmgroupId,
                                cNo = FG.Cid,
                                cfrmgroup_name = FG.CfrmgroupName,
                                iSort = FG.ISort
                            }).Distinct().OrderBy(m => m.iSort);
            return formMain;
        }


        public IQueryable<FormSub> GetFormSubByRight(string cusr_name,string main)
        {
            var formSub = (from RG in _Bom2013Context.RGrpUserSup
                           join TG in _Bom2013Context.Tgroup on RG.CgrpName equals TG.CgrpName
                           join FR in _Bom2013Context.FormRight on TG.CgrpName equals FR.CgrpName
                           join F in _Bom2013Context.Form on FR.CfrmName equals F.CfrmName
                           where  RG.CId == cusr_name && F.CfrmgroupId == main
                           select new FormSub
                           {
                               cfrm_name = F.CfrmName,
                               cfrmNo = F.CfrmNo,
                               cfrm_desp = F.CfrmDesp,
                               cfrmgroup_id = F.CfrmgroupId
                           }).Distinct().OrderBy(m => m.cfrmNo);
            return formSub;
        }


    }
}
