using System;
using CookComputing.XmlRpc;

namespace RedaX
{
	// Token: 0x02000015 RID: 21
	public interface IgetCatList
	{
		// Token: 0x060001E5 RID: 485
		[XmlRpcMethod("metaWeblog.newPost")]
		string NewPage(int blogID, string strUserName, string strPassword, blogInfo content, int publish);
	}
}
