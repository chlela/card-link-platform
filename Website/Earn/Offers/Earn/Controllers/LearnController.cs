//
// Copyright (c) Microsoft Corporation. All rights reserved. 
// Licensed under the MIT license. See LICENSE.txt file in the project root for full license information.
//
using Earn.Offers.Earn.Attributes;
using Earn.Offers.Earn.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Earn.Offers.Earn.Controllers
{
  public class LearnController : Controller
  {
    // TODO: Replace with a different auth model
    public ActionResult Index()
    {
      LiveIdAuthResult liveIdAuthResult = new LiveIdAuthResult();

      LearnPageModel learnPageModel = new LearnPageModel();
      if (liveIdAuthResult != null)
      {
        learnPageModel.LiveIdResult = liveIdAuthResult;
      }

      return View("~/offers/earn/views/learn/learn.cshtml", learnPageModel);
    }
  }
}