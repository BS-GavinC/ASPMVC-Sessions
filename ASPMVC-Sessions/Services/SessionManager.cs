namespace ASPMVC_Sessions.Services
{
    public class SessionManager
    {

        private readonly ISession _session;

        public SessionManager(IHttpContextAccessor contextAccessor)
        {
            _session = contextAccessor.HttpContext.Session;
        }

        public string Email 
        { 
            get { return _session.GetString("Email"); }
            set { _session.SetString("Email", value); }
        }

        public string UserName
        {
            get { return _session.GetString("Username"); }
            set { _session.SetString("Username", value); }
        }

        public void Clear()
        {
            _session.Clear();
        }

        public bool IsValid()
        {
            return !string.IsNullOrEmpty(Email);
        }
    }
}
