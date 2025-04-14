namespace MaxApplication.Areas.Services
{
    public interface IHeaderService
    {
        Dictionary<string, string> GetHeaders();
    }

    public class HeaderServices : IHeaderService
    {
        private readonly IHttpContextAccessor _httpContextAccessor;

        public HeaderServices(IHttpContextAccessor httpContextAccessor)
        {
            _httpContextAccessor = httpContextAccessor;
        }
        public Dictionary<string, string> GetHeaders()
        {
            var mheader = new Dictionary<string, string>
            {
                { "DatabaseName", _httpContextAccessor.HttpContext.Session.GetString("DbName") },
                { "UserID", _httpContextAccessor.HttpContext.Session.GetString("loginId") },
                { "jToken", _httpContextAccessor.HttpContext.Session.GetString("jToken") },
                { "IpAddress", _httpContextAccessor.HttpContext.Session.GetString("IpAddress") },

            };

            return mheader;
        }
    }
}
