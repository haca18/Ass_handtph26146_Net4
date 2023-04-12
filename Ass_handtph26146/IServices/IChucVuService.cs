using Ass_handtph26146.Models;
using System.Collections.Generic;
using System;

namespace Ass_handtph26146.IServices
{
	public interface IChucVuService
	{
		public bool CreateChucVu(ChucVu cv);

		public bool DeleteChucVu(Guid id);
		public bool UpdateChucVu(ChucVu cv);
		public List<ChucVu> GetAllChucVu();
		public ChucVu GetChucVuByID(Guid id);
		public List<ChucVu> GetChucVuByName(string name);
	}
}
