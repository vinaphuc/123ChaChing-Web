/// <summary>
/// <author>Ngô Tấn Phúc</author>
/// <description>Created date: </description>
/// <revision history>Version: 1.0.1</revision history>
/// </summary>

namespace NextTech.ChaChing123.Business
{
	using NextTech.ChaChing123.Common.Models;
	using NextTech.ChaChing123.Core.Models;
	using NextTech.ChaChing123.Entities;
	using System.Linq;

	public interface IAffiliateService
	{
		ResultDTO GetOrderList(OrderListSearchDto obj);
		
	}
}