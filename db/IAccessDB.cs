﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace medicApp.db
{
    interface IAccessDB<T> 
    {
        List<T> FindAll(string criterio);
        T FindbyKey(params object[] key);
        bool SaveObj();        
    }
}
