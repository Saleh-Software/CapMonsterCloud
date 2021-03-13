using Newtonsoft.Json;

namespace CapMonsterCloud.Models.CaptchaTasks
{
    public class FunCaptchaTask : CaptchaTask
    {
        public FunCaptchaTask()
        {
            Type = "FunCaptchaTask";
        }

        /// <summary>
        /// This type solving task FunCaptcha. Your app submits website address, public key and proxy.
        /// </summary>
        [JsonProperty("websiteURL")]
        public string WebsiteUrl { get; set; }

        /// <summary>
        /// A special subdomain of funcaptcha.com, from which the JS captcha widget should be loaded.
        /// Most FunCaptcha installations work from shared domains, so this option is only needed in certain rare cases.
        /// </summary>
        [JsonProperty("funcaptchaApiJSSubdomain")]
        public string FunCaptchaApiJsSubdomain { get; set; }

        /// <summary>
        /// FunCaptcha website key.
        /// <div id="funcaptcha" data-pkey="THAT_ONE"></div>
        /// </summary>
       
         [JsonProperty("websitePublicKey")]
        public string WebsitePublicKey { get; set; }

        /// <summary>
        /// Additional parameter that may be required by Funcaptcha implementation.
        /// Use this property to send "blob" value as a stringified array.See example how it may look like.
        /// {"\blob\":\"HERE_COMES_THE_blob_VALUE\"}
        /// </summary>
         [JsonProperty("data")]
        public string Data { get; set; }


        /// <summary>
        /// Type of the proxy
        /// </summary>
        [JsonProperty("proxyType")]
        public string proxyType { get; set; }

        /// <summary>
        /// Proxy IP address IPv4/IPv6
        /// </summary>
        [JsonProperty("proxyAddress")]
        public string proxyAddress { get; set; }


        /// <summary>
        /// Proxy port
        /// </summary>
        [JsonProperty("proxyPort")]
        public string proxyPort { get; set; }


        /// <summary>
        /// Login for proxy which requires authorizaiton(basic)
        /// </summary>
        [JsonProperty("proxyLogin")]
        public string proxyLogin { get; set; }


        /// <summary>
        /// Proxy password
        /// </summary>
        [JsonProperty("proxyPassword")]
        public string proxyPassword { get; set; }

        /// <summary>
        /// Browser's User-Agent which is used in emulation. It is required that you use a signature of a modern browser, otherwise Google will ask you to "update your browser".
        /// </summary>
        [JsonProperty("userAgent")]
        public string userAgent { get; set; }

        /// <summary>
        /// Additional cookies which we must use during interaction with target page or Google.
        ///Format: cookiename1=cookievalue1; cookiename2=cookievalue2
        /// </summary>
        [JsonProperty("cookies")]
        public string cookies { get; set; }
    }
}
