//
// Copyright (c) Microsoft Corporation. All rights reserved. 
// Licensed under the MIT license. See LICENSE.txt file in the project root for full license information.
//
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Earn.Offers.Earn.Controllers
{
    public class ExpireCookieController : Controller
    {
        // TODO: Handle signout
        public ActionResult Index()
        {
          return new EmptyResult();
        }
    }
}