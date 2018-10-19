using Newtonsoft.Json;

namespace DotaLass.API.Outputs
{
    public class PlayerPeer
    {
        [JsonProperty(PropertyName = "account_id")]
        public int AccountId { get; set; }

        [JsonProperty(PropertyName = "last_played")]
        public int LastPlayed { get; set; }

        [JsonProperty(PropertyName = "win")]
        public int Win { get; set; }

        [JsonProperty(PropertyName = "games")]
        public int Games { get; set; }

        [JsonProperty(PropertyName = "with_win")]
        public int WithWin { get; set; }

        [JsonProperty(PropertyName = "with_games")]
        public int WithGames { get; set; }

        [JsonProperty(PropertyName = "against_win")]
        public int AgainstWin { get; set; }

        [JsonProperty(PropertyName = "against_games")]
        public int AgainstGames { get; set; }

        [JsonProperty(PropertyName = "with_gpm_sum")]
        public int WithGpmSum { get; set; }

        [JsonProperty(PropertyName = "with_xpm_sum")]
        public int WithXpmSum { get; set; }

        [JsonProperty(PropertyName = "personaname")]
        public string Personaname { get; set; }

        [JsonProperty(PropertyName = "last_login")]
        public string LastLogin { get; set; }

        [JsonProperty(PropertyName = "avatar")]
        public string Avatar { get; set; }

        [JsonProperty(PropertyName = "avatarfull")]
        public string Avatarfull { get; set; }
    }
}