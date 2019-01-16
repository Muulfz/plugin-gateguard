using JetBrains.Annotations;
using Newtonsoft.Json;
using NFive.SDK.Core.Models;
using NFive.SDK.Core.Models.Player;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace NFive.GateGuard.Server.Models
{
	public class GuardRule : IdentityModel {
		[Required] [ForeignKey("PlayerUser")] public Guid PlayerUserId { get; set; }

		[JsonIgnore] public virtual User PlayerUser { get; set; }

		[CanBeNull]
		[StringLength(40, MinimumLength = 40)]
		public string License { get; set; }

		public long? SteamId { get; set; }

		[CanBeNull]
		[StringLength(18, MinimumLength = 18)]
		public string Discord { get; set; }

		[CanBeNull]
		[StringLength(15, MinimumLength = 7)]
		public string IpAddress { get; set; }

		[Required]
		[ForeignKey("StaffUser")]
		public Guid StaffUserId { get; set; }

		[JsonIgnore]
		public virtual User StaffUser { get; set; }

		[CanBeNull]
		public string Reason { get; set; }

		public DateTime? Expiry { get; set; }
	}
}
