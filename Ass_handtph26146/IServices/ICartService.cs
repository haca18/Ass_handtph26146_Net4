using Ass_handtph26146.Models;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;

namespace Ass_handtph26146.IServices
{
	public interface ICartService
	{
		public List<Hoa> GetHoaFromSession(ISession session, string key);

		public  void SetHoaToSession(ISession session, string key, object values);

		public bool CheckObjInList(Guid id, List<Hoa> hoas);
		public List<Hoa> UpdatesoLuong(Guid id, int soLuong);

    }
}
