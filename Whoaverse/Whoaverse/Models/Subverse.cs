//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Voat.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Subverse
    {
        public Subverse()
        {
            this.type = "link";
            this.rated_adult = false;
            this.allow_default = false;
            this.enable_thumbnails = true;
            this.exclude_sitewide_bans = false;
            this.traffic_stats_public = false;
            this.subscribers = 1;
            this.private_subverse = false;
            this.authorized_submitters_only = false;
            this.Messages = new HashSet<Message>();
            this.SubverseAdmins = new HashSet<SubverseAdmin>();
            this.Subverseflairsettings = new HashSet<Subverseflairsetting>();
            this.Stickiedsubmissions = new HashSet<Stickiedsubmission>();
            this.Subscriptions = new HashSet<Subscription>();
            this.Featuredsubs = new HashSet<Featuredsub>();
            this.Usersetdefinitions = new HashSet<Usersetdefinition>();
            this.SubverseBans = new HashSet<SubverseBan>();
        }
    
        public string name { get; set; }
        public string title { get; set; }
        public string sidebar { get; set; }
        public string submission_text { get; set; }
        public string language { get; set; }
        public string type { get; set; }
        public string label_submit_new_link { get; set; }
        public string label_sumit_new_selfpost { get; set; }
        public string spam_filter_links { get; set; }
        public string spam_filter_selfpost { get; set; }
        public string spam_filter_comments { get; set; }
        public bool rated_adult { get; set; }
        public bool allow_default { get; set; }
        public bool enable_thumbnails { get; set; }
        public bool exclude_sitewide_bans { get; set; }
        public Nullable<bool> traffic_stats_public { get; set; }
        public Nullable<int> minutes_to_hide_comments { get; set; }
        public System.DateTime creation_date { get; set; }
        public string description { get; set; }
        public string stylesheet { get; set; }
        public Nullable<int> subscribers { get; set; }
        public bool private_subverse { get; set; }
        public bool authorized_submitters_only { get; set; }
        public bool anonymized_mode { get; set; }
        public Nullable<System.DateTime> last_submission_received { get; set; }
        public Nullable<int> minimumdownvoteccp { get; set; }
    
        public virtual ICollection<Message> Messages { get; set; }
        public virtual Defaultsubverse Defaultsubvers { get; set; }
        public virtual ICollection<SubverseAdmin> SubverseAdmins { get; set; }
        public virtual ICollection<Subverseflairsetting> Subverseflairsettings { get; set; }
        public virtual ICollection<Stickiedsubmission> Stickiedsubmissions { get; set; }
        public virtual ICollection<Subscription> Subscriptions { get; set; }
        public virtual ICollection<Featuredsub> Featuredsubs { get; set; }
        public virtual ICollection<Usersetdefinition> Usersetdefinitions { get; set; }
        public virtual ICollection<SubverseBan> SubverseBans { get; set; }
    }
}
