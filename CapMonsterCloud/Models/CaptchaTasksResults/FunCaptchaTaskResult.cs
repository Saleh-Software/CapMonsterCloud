namespace CapMonsterCloud.Models.CaptchaTasksResults
{
    public class FunCaptchaTaskResult : CaptchaTaskResult
    {
        /// <summary>
        /// FunCaptcha token that needs to be substituted into the form.
        /// </summary>
        public string Token { get; set; }
    }
}
