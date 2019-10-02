using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Script.Serialization;

namespace ProvaFront
{
    //class all com dados do artista json
    public class all
    {
        [JsonProperty("id")]
        public String id { get; set; }
        [JsonProperty("name")]
        public string name { get; set; }
        [JsonProperty("url")]
        public string url { get; set; }
        [JsonProperty("pic_small")]
        public string pic_small { get; set; }
        [JsonProperty("pic_medium")]
        public string pic_medium { get; set; }
        [JsonProperty("uniques")]
        public int uniques { get; set; }
        [JsonProperty("views")]
        public int views { get; set; }
        [JsonProperty("rank")]
        public double rank { get; set; }

    }
    //class art que contém todos os dados week period year e all
    public class art
    {
        [JsonProperty("art")]
        public week week { get; set; }
    }

    public class week
    {
        [JsonProperty("week")]
        public period period { get; set; }
    }

    public class period
    {
        [JsonProperty("year")]
        public int year { get; set; }
        [JsonProperty("week")]
        public int week { get; set; }
        [JsonProperty("all")]
        public List<all> all { get; set; }

    }

   //método deserialize para desmembrar json
    public class Artista
    {
        public Artista()
        {   
        }

        public art lista()
        {
            using (WebClient wc = new WebClient())
            {
                var json = wc.DownloadString("https://api.vagalume.com.br/rank.php?apikey=660a4395f992ff67786584e238f501aa&type=art&period=week&periodVal=201134&scope=all&limit=3");
                var user = JsonConvert.DeserializeObject<art>(json);

                return user;
            }
        }

    }
}



   