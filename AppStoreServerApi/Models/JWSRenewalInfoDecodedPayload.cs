﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppStoreServerApi.Models
{
    // https://developer.apple.com/documentation/appstoreserverapi/jwsrenewalinfodecodedpayload
    public class JWSRenewalInfoDecodedPayload
    {
        public string AutoRenewProductId { get; set; } = null!;
        public AutoRenewStatus AutoRenewStatus { get; set; }
        public ExpirationIntent? ExpirationIntent { get; set; } = null!;
        public long? GracePeriodExpiresDate { get; set; } = null!;
        public bool? IsInBillingRetryPeriod { get; set; } = null!;
        public string? OfferIdentifier { get; set; } = null!;
        public OfferType? OfferType { get; set; } = null!;
        public string OriginalTransactionId { get; set; } = null!;
        public PriceIncreaseStatus? PriceIncreaseStatus { get; set; } = null!;
        public string ProductId { get; set; } = null!;
        /// <summary>
        /// UNIX timestamp in ms
        /// </summary>
        public long SignedDate { get; set; }
    }
}
