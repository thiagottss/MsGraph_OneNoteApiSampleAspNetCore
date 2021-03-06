﻿using System.Collections.Generic;

namespace OneNoteApiSample
{
	public static class Config
	{
		// TODO: Replace all of these with your own

		public static string MsGraphRedirectUri => "http://localhost:5001/msgraphoauthcallback";
		public static string MsGraphAppId => "<YOUR APP ID HERE>";
		public static string MsGraphAppSecret => "<YOUR APP SECRET HERE>";

		// TODO: Your app might require a different list of scopes.
		// See https://msdn.microsoft.com/en-us/Library/Azure/Ad/Graph/howto/azure-ad-graph-api-permission-scopes and https://developer.microsoft.com/en-us/graph/docs/authorization/permission_scopes
		public static List<string> MsGraphRequiredScopes => new List<string>()
		{
			"Notes.ReadWrite.All",
			"Notes.ReadWrite",
			"offline_access"
		};
	}
}
