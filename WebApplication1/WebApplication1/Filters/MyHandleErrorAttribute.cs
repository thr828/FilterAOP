using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplication1.Filters
{
    public class MyHandleErrorAttribute:HandleErrorAttribute
    {
        public override void OnException(ExceptionContext filterContext)
        {
            //1、获取异常对象
            Exception ex = filterContext.Exception;

            //2、记录异常日志

            //3、重定向友好页面
            filterContext.Result = new RedirectResult("~/error.html");

            //4、标记异常已经处理完毕
            filterContext.ExceptionHandled = true;

            base.OnException(filterContext);


        }
    }
}