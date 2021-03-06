/*
  Copyright (c) Microsoft Corporation. All rights reserved.
  Licensed under the MIT License. See License.txt in the project root for license information.
*/

namespace Microsoft.Xrm.Portal.Web.Data.Services
{
	public class SiteMapChildInfo
	{
		public int? DisplayOrder { get; set; }

		public string DisplayOrderPropertyName { get; set; }

		public string EntityUri { get; set; }

		public bool HasPermission { get; set; }

		public string Title { get; set; }
	}
}
