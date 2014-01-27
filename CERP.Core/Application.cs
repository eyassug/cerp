using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CERP.Core.Security;

namespace CERP.Core
{
    public static class Application
    {
        private static Session _currentSession;

        public static Session CurrentSession
        {
            get { return _currentSession; }
            set
            {
                if(_currentSession != null && _currentSession == value)
                    return;
                _currentSession = value;
            }
        }
    }
}
