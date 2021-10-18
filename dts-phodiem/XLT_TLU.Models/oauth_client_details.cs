namespace XLT_TLU.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class oauth_client_details
    {
        [Key]
        [StringLength(256)]
        public string client_id { get; set; }

        [StringLength(256)]
        public string resource_ids { get; set; }

        [StringLength(256)]
        public string client_secret { get; set; }

        [StringLength(256)]
        public string scope { get; set; }

        [StringLength(256)]
        public string authorized_grant_types { get; set; }

        [StringLength(256)]
        public string web_server_redirect_uri { get; set; }

        [StringLength(256)]
        public string authorities { get; set; }

        public int? access_token_validity { get; set; }

        public int? refresh_token_validity { get; set; }

        [StringLength(4096)]
        public string additional_information { get; set; }

        [StringLength(255)]
        public string autoapprove { get; set; }
    }
}
