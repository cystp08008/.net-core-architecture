using DBClassLibrary.Models.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DBClassLibrary.Models.Interface
{


    public interface IRightRepository 
    {
        IQueryable<FormMain> GetFormMainByRight(string cusr_name, string navTitle);
        IQueryable<FormSub> GetFormSubByRight(string cusr_name, string main);
    }
}
