using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Controllers;
using Microsoft.AspNetCore.Mvc.Filters;
using System.Linq;
using System.Text;

namespace AuthorizationCenter.Filters
{
    /// <summary>
    /// 登入過濾
    /// </summary>
    public class AuthenticatedFilter : ActionFilterAttribute
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="context"></param>
        /// 

        public override void OnActionExecuting(ActionExecutingContext context)
        {
            //是否為ajax連線
            var isAjax = context.HttpContext.Request.Headers["X-Requested-With"] == "XMLHttpRequest";
            // 判斷是否檢查登入
            var noNeedCheck = false;
            if (context.ActionDescriptor is ControllerActionDescriptor controllerActionDescriptor)
            {
                noNeedCheck = controllerActionDescriptor.MethodInfo.GetCustomAttributes(inherit: true)
                  .Any(a => a.GetType().Equals(typeof(NoSignAttribute)));
            }
            if (noNeedCheck) return;

            

            // 檢查登入 - 在SignIn中判斷用戶合法性，將登入訊息保存在Session中，在AuthenticatedFilter中移除登入訊息
            // 獲取登入訊息 - 這裏采用Session來保存登入訊息
            var user = context.HttpContext.Session.GetString("user");

            if ((isAjax && user == null))
            {

                context.Result = new UnauthorizedResult();

                context.Result.ExecuteResultAsync(context);
            }


            else if (user== null)
            {

                context.HttpContext.Response.WriteAsync("<script>alert('請重新登入!!');location.href='/LogIn/LogIn'</script>"/*, Encoding.GetEncoding("GB2312")*/);
                // 跳轉
             
            }

            

            base.OnActionExecuting(context);
        }

    }



    /// <summary>
    /// 
    /// </summary>
    public class NoSignAttribute : ActionFilterAttribute { }
}
