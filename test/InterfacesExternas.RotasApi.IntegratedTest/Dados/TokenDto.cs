﻿using Newtonsoft.Json;

namespace MyCompany.MyProject.IntegratedTest.Dados
{
    public class TokenDto
    {
        [JsonProperty("access_token")]
        public string AccessToken { get; set; }
        [JsonProperty("token_type")]
        public string TokenType { get; set; }
        [JsonProperty("expires_in")]
        public int ExpiresIn { get; set; }
    }
}
