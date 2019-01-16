using System;
using System.Collections.Generic;
using NFive.SDK.Core.Controllers;

namespace NFive.GateGuard.Server
{
	public class Configuration : ControllerConfiguration
	{
		public BlockMode Mode { get; set; } = BlockMode.Blacklist;

		public string Message { get; set; } = "You have been blacklisted";

		public SteamConfig Steam { get; set; } = new SteamConfig();

		public RulesConfig Rules { get; set; } = new RulesConfig();

		public DatabaseConfig Database { get; set; } = new DatabaseConfig();
	}

	public enum BlockMode
	{
		Whitelist,
		Blacklist
	}

	public class SteamConfig
	{
		public bool Required { get; set; } = false;

		public string Message { get; set; } = "You must be running Steam to play on this server";
	}

	public class RulesConfig {
		public List<string> Ips { get; set; } = new List<string>();

		public List<string> Licenses { get; set; } = new List<string>();

		public List<long> Steam { get; set; } = new List<long>();

		public List<string> Discord { get; set; } = new List<string>();
		
}

	public class DatabaseConfig
	{
		public TimeSpan ReloadInterval { get; set; } = TimeSpan.FromMinutes(30);
	}
}
