﻿using System.Collections.Generic;
using System.Diagnostics;
using System.Security.Claims;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using PAM.Data;
using PAM.Extensions;
using PAM.Models;

namespace PAM.Controllers
{
    [Authorize]
    public class RequestController : Controller
    {
        private readonly RequestService _requestService;
        private readonly OrganizationService _orgService;

        public RequestController(RequestService requestService, OrganizationService orgService)
        {
            _requestService = requestService;
            _orgService = orgService;
        }

        [HttpGet]
        public IActionResult Self()
        {
            string username = ((ClaimsIdentity)User.Identity).GetClaim(ClaimTypes.NameIdentifier);
            ViewData["Requests"] = _requestService.GetRequestsByUsername(username);
            return View();
        }

        [HttpGet]
        public IActionResult ReviewRequests()
        {

            int supervisorId = int.Parse(((ClaimsIdentity)User.Identity).GetClaim("EmployeeId"));
            var requestsForReview = _requestService.GetRequestsForReview(supervisorId);

            ViewData["RequestsForReview"] = requestsForReview;

            return View();
        }

        [HttpGet]
        public IActionResult RequestForReview(int reqId)
        {
            Debug.WriteLine("*** ReqId: {0}", reqId);

            ViewData["RequestForReview"] = _requestService.GetRequest(reqId);
            //var req = _requestService.GetRequestedSystemsByRequestId(reqId);
            //var systems = req.Systems;
            //ViewData["RelatedSystems"] = systems.

            var test = _requestService.GetRequestedSystemsByRequestId(reqId);
            Debug.WriteLine("*** TEST ***");
            foreach(var obj in test.Systems)
            {
                Debug.WriteLine("ReqId: {0}, SysId: {1}, SysName: {2}", obj.RequestId, obj.SystemId, obj.System.Name);
            }

            return View();
        }

        [HttpGet]
        public IActionResult ProcessRequests(){
            //-----TODO-----
            ViewData["Requests"] = _requestService.GetRequests();
            return View();
        }

        [HttpGet]
        public IActionResult AllRequests(){
            ViewData["Requests"] = _requestService.GetRequests();
            return View();
        }

        [HttpGet]
        public IActionResult Delete(int? id)
        {
            if (id == null) return NotFound();

            string username = ((ClaimsIdentity)User.Identity).GetClaim(ClaimTypes.NameIdentifier);
            var requests = _requestService.GetRequestsByUsername(username);
            if (requests == null) return RedirectToAction("Self");
            else return View();
        }

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public IActionResult DeleteConfirm(int id)
        {
            string username = ((ClaimsIdentity)User.Identity).GetClaim(ClaimTypes.NameIdentifier);
            var requests = _requestService.GetRequestsByUsername(username);

            foreach(var request in requests)
            {
                if (request.RequestId == id) _requestService.RemoveRequest(request);
            }
            return RedirectToAction("Self");
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        } 
    }
}
