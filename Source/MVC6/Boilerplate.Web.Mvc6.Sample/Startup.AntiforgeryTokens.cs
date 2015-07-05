﻿namespace MvcBoilerplate
{
    using Microsoft.AspNet.Mvc;

    public partial class Startup
    {
        /// <summary>
        /// Configures the anti-forgery tokens for better security. See:
        /// http://www.asp.net/mvc/overview/security/xsrfcsrf-prevention-in-aspnet-mvc-and-web-pages
        /// </summary>
        /// <param name="antiForgeryOptions">The anti-forgery token options.</param>
        private static void ConfigureAntiforgeryTokens(AntiForgeryOptions antiForgeryOptions)
        {
            // Rename the Anti-Forgery cookie from "__RequestVerificationToken" to "f". This adds a little security 
            // through obscurity and also saves sending a few characters over the wire. 
            antiForgeryOptions.CookieName = "f";

            // Rename the form input name from "__RequestVerificationToken" to "f" for the same reason above e.g.
            // <input name="__RequestVerificationToken" type="hidden" value="..." />
            antiForgeryOptions.FormFieldName = "f";

            // If you have enabled SSL/TLS. Uncomment this line to ensure that the Anti-Forgery cookie requires SSL/TLS
            // to be sent across the wire. 
            // antiForgeryOptions.RequireSSL = true;
        }
    }
}