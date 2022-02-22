using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using dotnet6_contenttype_ajax_examples.Models;

namespace dotnet6_contenttype_ajax_examples.Controllers;

public class ExamplesController : Controller
{
    public ExamplesController() { }

    public IActionResult FormEncoded()
    {
        return View();
    }

    public IActionResult JSONEncoded()
    {
        return View();
    }

    #region application/x-www-form-urlencoded

    [HttpPost]
    public JsonResult ReceiveOneVariable(string myTestString)
    {
        return Json(myTestString);
    }

    [HttpPost]
    public JsonResult ReceiveMultipleParams(string myTestString, int myTestInt, bool myTestBool)
    {
        return Json($"{myTestString}, {myTestInt}, {myTestBool}");
    }

    [HttpPost]
    public JsonResult ReceiveIdAndObject(Guid myTestGuid, TestObjectA myTestObj)
    {
        return Json(myTestObj);
    }

    #endregion

    #region application/json

    [HttpPost]
    public JsonResult ReceiveOneVariableJson([FromBody]string myTestString)
    {
        return Json(myTestString);
    }
    
    [HttpPost]
    public JsonResult ReceiveMultipleParamsJson([FromBody]string myTestString, [FromBody]int myTestInt, [FromBody]bool myTestBool)
    {
        return Json($"{myTestString}, {myTestInt}, {myTestBool}");
    }

    [HttpPost]
    public JsonResult ReceiveIdAndObjectJson([FromBody]Guid myTestGuid, [FromBody]TestObjectA myTestObj)
    {
        return Json(myTestObj);
    }

    [HttpPost]
    public JsonResult ReceiveObjectJson([FromBody]TestObjectA myTestObj)
    {
        return Json(myTestObj);
    }

    #endregion
}
