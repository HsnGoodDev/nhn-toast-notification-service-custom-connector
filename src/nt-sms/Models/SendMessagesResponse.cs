using System.Collections.Generic;

using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

using Toast.Common.Models;

namespace Toast.Sms.Models
{
    /// <summary>
    /// This represents the entity for SendMessages response.
    /// </summary>
    public class SendMessagesResponse : ResponseModel<ResponseItemBodyModel<SendMessagesResponseData>>
    { }

    /// <summary>
    /// This represents the entity for SendMessages response data.
    /// </summary>
    public class SendMessagesResponseData
    {
        /// <summary>
        /// Gets or sets the request ID.
        /// </summary>
        public virtual string RequestId { get; set; }

        /// <summary>
        /// Gets or sets the request status code.
        /// </summary>
        ///
        public virtual string StatusCode { get; set; }

        /// <summary>
        /// Gets or sets the sender group key.
        /// </summary>
        [JsonProperty("senderGroupingKey")]
        public virtual string SenderGroupKey { get; set; }

        /// <summary>
        /// Gets or sets the list of send results.
        /// </summary>
        [JsonProperty("sendResultList")]
        public virtual List<SendMessagesResponseResult> SendResults { get; set; }
    }

    /// <summary>
    /// This represents the entity for SendMessages response send result.
    /// </summary>
    public class SendMessagesResponseResult
    {
        /// <summary>
        /// Gets or sets the recipient number.
        /// </summary>
        [JsonProperty("recipientNo")]
        public virtual string RecipientNumber { get; set; }

        /// <summary>
        /// Gets or sets the result code.
        /// </summary>
        public virtual int ResultCode { get; set; }

        /// <summary>
        /// Gets or sets the result message.
        /// </summary>
        public virtual string ResultMessage { get; set; }

        /// <summary>
        /// Gets or sets the recipient sequence.
        /// </summary>
        [JsonProperty("recipientSeq")]
        public virtual int RecipientSequence { get; set; }

        /// <summary>
        /// Gets or sets the recipient group key.
        /// </summary>
        [JsonProperty("recipientGroupingKey")]
        public virtual string RecipientGroupKey { get; set; }
    }
}