using System;
using CERP.Core.Security;

namespace CERP.Modules.Security
{
    public class SessionService
    {
        #region Fields
        

        #endregion

        public static Session CurrentSession { get; set; }
        public void StartSession()
        {
            throw new NotImplementedException();
        }

        public static void StartSession(Session session)
        {
            
        }
    }
}
