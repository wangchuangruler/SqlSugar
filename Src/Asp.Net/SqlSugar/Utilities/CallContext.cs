﻿using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading;

namespace SqlSugar
{
    internal class CallContext
    {
        public static ThreadLocal<List<DbConnection>> ContextList = new ThreadLocal<List<DbConnection>>();
    }
}