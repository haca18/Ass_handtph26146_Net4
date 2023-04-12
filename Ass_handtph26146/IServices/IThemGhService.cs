using Ass_handtph26146.Models;
using Microsoft.AspNetCore.Http;
using System.Collections.Generic;

namespace Ass_handtph26146.IServices
{
    public interface IThemGhService
    {
        public List<GioHangCT> GetCartItems(ISession session);
        public void ClearCart(ISession session);
        public void SaveCartSession(List<GioHangCT> lst, ISession session);

       
    }
}
