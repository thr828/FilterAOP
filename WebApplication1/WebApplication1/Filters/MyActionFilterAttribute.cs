using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplication1.Filters
{

    // ReSharper disable once UnusedMember.Global
    public class MyActionFilterAttribute:ActionFilterAttribute
    {
        public override void OnActionExecuting(ActionExecutingContext filterContext)
        {
            //1.获取请求的类名和方法
            string strController = filterContext.RouteData.Values["controller"].ToString();
            string strAction = filterContext.RouteData.Values["action"].ToString();

            //2、用另一种方式获取请求的类名和方法名
            string strController2 = filterContext.ActionDescriptor.ControllerDescriptor.ControllerName;
            string strAction2 = filterContext.ActionDescriptor.ActionName;

            filterContext.HttpContext.Response.Write("控制器：" + strController + "<br/>");
            filterContext.HttpContext.Response.Write("控制器：" + strController2 + "<br/>");
            filterContext.HttpContext.Response.Write("Action：" + strAction + "<br/>");
            filterContext.HttpContext.Response.Write("Action：" + strAction2 + "<br/>");

            filterContext.HttpContext.Response.Write("Action执行前：" + DateTime.Now.ToString("yyyy-MM-dd hh:mm:ss fff") + "<br/>");

            base.OnActionExecuting(filterContext);
        }

        public override void OnActionExecuted(ActionExecutedContext filterContext)
        {

            filterContext.HttpContext.Response.Write("Action执行后：" + DateTime.Now.ToString("yyyy-MM-dd hh:mm:ss fff") + "<br/>");
            base.OnActionExecuted(filterContext);
        }

        public override void OnResultExecuting(ResultExecutingContext filterContext)
        {
            filterContext.HttpContext.Response.Write("加载视图前执行OnResultExecuting：" + DateTime.Now.ToString("yyyy-MM-dd hh:mm:ss fff") + "<br/>");
            base.OnResultExecuting(filterContext);
        }

        public override void OnResultExecuted(ResultExecutedContext filterContext)
        {
            filterContext.HttpContext.Response.Write("加载视图后执行 OnResultExecuted" + DateTime.Now.ToString("yyyy-MM-dd hh:mm:ss fff") + "<br/>");
            base.OnResultExecuted(filterContext);
        }
    }
}