using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CERP.Core.Security.Principal;

namespace CERP.Core.Security
{
    public enum SessionStatus
    {
        Active,
        Locked,
        Destroyed
    }
    /// <summary>
    /// Describes a user session (Created at the time of a successful login)
    /// </summary>
    public class Session
    {
        #region Fields

        private readonly DateTime _startTime;
        private readonly Guid _sessionKey;
        private readonly IUserPrincipal _principal;
        private SessionStatus _sessionStatus;
        #endregion

        #region Constructors
        private Session()
        {
            _startTime = DateTime.UtcNow;
            _sessionKey = Guid.NewGuid();
            _sessionStatus = SessionStatus.Active;
        }
        /// <summary>
        /// Creates a new session for the supplied principal
        /// </summary>
        /// <param name="principal">The user principal associated with the session instance</param>
        public Session(IUserPrincipal principal)
            : this()
        {
            if(principal == null)
                throw new ArgumentNullException("principal");
            _principal = principal;
        }
        #endregion

        #region Properties
        /// <summary>
        /// Gets the principal associated with the session instance
        /// </summary>
        public IUserPrincipal Principal { get { return _principal; } }
        /// <summary>
        /// Gets the time the session started
        /// </summary>
        public DateTime StartTime { get { return _startTime; } }
        /// <summary>
        /// Gets a unique identifier of the session instance
        /// </summary>
        public Guid SessionKey { get { return _sessionKey; } }
        /// <summary>
        /// Gets the duration of the session
        /// </summary>
        public TimeSpan Duration { get { return DateTime.UtcNow.Subtract(_startTime); } }
        /// <summary>
        /// Gets the session status
        /// </summary>
        public SessionStatus Status { get { return _sessionStatus; } }
        #endregion

        #region Methods
        public void Destroy()
        {
            _sessionStatus = SessionStatus.Destroyed;
        }

        #endregion
    }
}
