using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace medicApp.db
{
    public interface IAuditable
    {
        string ThisObjLog();
    }
}
