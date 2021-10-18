namespace XLT_TLU.Models.DTSModels
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class oauth_access_token
    {
        [StringLength(255)]
        public string token_id { get; set; }

        public byte[] token { get; set; }

        [Key]
        [StringLength(255)]
        public string authentication_id { get; set; }

        [StringLength(255)]
        public string user_name { get; set; }

        [StringLength(255)]
        public string client_id { get; set; }

        public byte[] authentication { get; set; }

        [StringLength(255)]
        public string refresh_token { get; set; }

        [MaxLength(1)]
        public byte[] defaultOAuth2AccessToken { get; set; }
    }
}
