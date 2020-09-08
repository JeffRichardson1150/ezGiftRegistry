using ezGift.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ezGiftUrl.WebMVC.Controllers
{
    public class GiftUrlController : Controller
    {
        public ActionResult GoToUrl(string retailerUrl)
        {
            if (Response.IsClientConnected)
            {
                //string retailerUrl = id;
                Response.Redirect(retailerUrl, false);
            }
            else
            {
                // If the browser is not connected
                // stop all response processing.
                Response.End();
            }
            //CompleteRequest();
            //return RedirectToAction("Index", new { id = model.RegistryEventId });
            return RedirectToAction("Index", new { id = 1 });

        }

        ////public ActionResult Index(int? eventId)
        //// The stupidest thing : the parameter must be called id.  Otherwise, the parameter will be assigned null
        //public ActionResult Index(int id)
        //{
        //    // refactor GiftUrlService so, rather than setting a Guid _userId,
        //    // we set an int _eventId
        //    // so we can use the _eventId of the event which all the gifts are connected to
        //    int eventId = id;
        //    var service = new GiftUrlService(eventId);

        //    // get the list of gifts 
        //    //   where GiftUrl.RegistryEvent.RegistryEventId == eventId
        //    var model = service.GetGiftUrlsByEvent();
        //    return View(model);

        //}

        ////GET
        //public ActionResult Create(int id)
        //{
        //    int eventId = id;
        //    return View(new GiftUrlCreate
        //    {
        //        GiftUrlName = "",
        //        GiftUrlDescription = "",
        //        RegistryEventId = eventId,
        //    });

        //}

        //// POST for Create
        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public ActionResult Create(GiftUrlCreate model)
        //{
        //    if (!ModelState.IsValid)
        //    {
        //        return View(model);
        //    }
        //    var service = CreateGiftUrlService();

        //    if (service.CreateGiftUrl(model))
        //    {
        //        // Use TempData rather than ViewBag. TempData removes information after it's accessed
        //        TempData["SaveResult"] = "Your Event was created.";
        //        return RedirectToAction("Index", new { id = model.RegistryEventId });
        //    }

        //    ModelState.AddModelError("", "Your Event could not be created.");
        //    return View(model);
        //}
        //public ActionResult Details(int id)
        //{
        //    var svc = CreateGiftUrlService();
        //    var model = svc.GetGiftUrlById(id);

        //    return View(model);
        //}

        //// GET for Edit
        //public ActionResult Edit(int id)
        //{
        //    var service = CreateGiftUrlService();
        //    var detail = service.GetGiftUrlById(id);
        //    var model =
        //        new GiftUrlEdit
        //        {
        //            GiftUrlId = detail.GiftUrlId,
        //            GiftUrlName = detail.GiftUrlName,
        //            GiftUrlDescription = detail.GiftUrlDescription,
        //            RegistryEventId = detail.RegistryEventId,
        //            RegistryEvent = detail.RegistryEvent
        //        };
        //    return View(model);
        //}

        //// POST for Edit
        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public ActionResult Edit(int id, GiftUrlEdit model)
        //{
        //    if (!ModelState.IsValid)
        //    {
        //        return View(model);
        //    }

        //    if (model.GiftUrlId != id)
        //    {
        //        ModelState.AddModelError("", "ID Mismatch");
        //        return View(model);
        //    }

        //    var service = CreateGiftUrlService();

        //    if (service.UpdateGiftUrl(model))
        //    {
        //        TempData["SaveResult"] = "Your Event was updated";
        //        return RedirectToAction("Index", new { id = model.RegistryEventId });
        //    }

        //    ModelState.AddModelError("", "Your Event could not be updated.");
        //    return View(model);
        //}

        //// GET for Delete
        //[ActionName("Delete")]
        //public ActionResult Delete(int id)
        //{
        //    var svc = CreateGiftUrlService();
        //    var model = svc.GetGiftUrlById(id);

        //    return View(model);
        //}

        //// POST for Delete
        //[HttpPost]
        //[ActionName("Delete")]
        //[ValidateAntiForgeryToken]
        //public ActionResult DeletePost(int id)
        //{
        //    var service = CreateGiftUrlService();

        //    var model = service.GetGiftUrlById(id);
        //    int eventId = model.RegistryEventId;

        //    service.DeleteGiftUrl(id);
        //    TempData["SaveResult"] = "Your Event was deleted.";
        //    return RedirectToAction("Index", new { id = eventId });

        //}

        //private GiftUrlService CreateGiftUrlService()
        //{

        //    var service = new GiftUrlService();
        //    return service;
        //}

    }
}