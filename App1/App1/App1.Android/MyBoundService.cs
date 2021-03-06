﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;

namespace App1
{
    class MyBoundService : Binder
    {
        HTTPService service;

        public MyBoundService(HTTPService s)
        {
            this.service = s;
        }

        public HTTPService MyService
        {
            get { return this.service; }
        }
    }
}