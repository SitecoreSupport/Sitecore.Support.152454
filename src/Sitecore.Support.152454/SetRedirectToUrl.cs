using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text.RegularExpressions;
using System.Web;
using Sitecore.Analytics;
using Sitecore.Analytics.Model;
using Sitecore.Diagnostics;
using Sitecore.EmailCampaign.Cd.Pipelines.RedirectUrl;
using Sitecore.Modules.EmailCampaign.Core.Crypto;
using Sitecore.Modules.EmailCampaign.Factories;
using Sitecore.Text;

namespace Sitecore.Support.EmailCampaign.Cd.Pipelines.RedirectUrl
{
  public class SetRedirectToUrl : Sitecore.EmailCampaign.Cd.Pipelines.RedirectUrl.SetRedirectToUrl
  {
   
    public SetRedirectToUrl(QueryStringEncryption queryStringEncryption) : base(queryStringEncryption)
    {
    }

    public new void Process([NotNull] RedirectUrlPipelineArgs args)
    {
      base.Process(args);
      if (!args.IsInternalReference&&!Tracker.Current.CurrentPage.IsCancelled)
      {
        if (Tracker.Current != null && Tracker.Current.CurrentPage != null)
        {
          Tracker.Current.CurrentPage.Url = new UrlData { Path = args.OriginalLink };
        }
      }

     
    }

  }
}