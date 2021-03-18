using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace PON_BOT
{
	class ConfigJson
	{
		[JsonProperty("token")]
		public string Token { get; private set; }

		[JsonProperty("prefix")]
		public string Prefix { get; private set; }
	}
}
