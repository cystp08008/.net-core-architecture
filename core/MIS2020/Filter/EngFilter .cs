using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Controllers;
using Microsoft.AspNetCore.Mvc.Filters;
using System.Linq;
using System.Text;

namespace AuthorizationCenter.Filters
{
    /// <summary>
    /// 工程過濾
    /// </summary>
    public class EngFilter : ActionFilterAttribute
    {
        /// <summary>
        /// 執行中 
        /// </summary>
        /// <param name="context"></param>
        public override void OnActionExecuting(ActionExecutingContext context)
        {
            // 判斷是否檢查登入
            var noNeedCheck = false;
            if (context.ActionDescriptor is ControllerActionDescriptor controllerActionDescriptor)
            {
                noNeedCheck = controllerActionDescriptor.MethodInfo.GetCustomAttributes(inherit: true)
                  .Any(a => a.GetType().Equals(typeof(NoSignAttribute)));
            }
            if (noNeedCheck) return;

            // 檢查 - 判斷用戶合法性，將登入訊息保存在Session中，在AuthenticatedFilter中移除登入訊息
            // 獲取訊息 - 這裏采用Session來保存工程訊息
            var user = context.HttpContext.Session.GetString("eng");


          
            if (user== null || user=="" )
            {

                context.HttpContext.Response.WriteAsync("<script>alert('請選擇工程!!');location.href='/Home/Home'</script>", Encoding.GetEncoding("GB2312"));
                // 跳轉
             
            }

            base.OnActionExecuting(context);
        }

    }



    /// <summary>
    /// 
    /// </summary>
 
}
