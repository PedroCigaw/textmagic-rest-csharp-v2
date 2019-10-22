/* 
 * TextMagic API
 *
 * No description provided (generated by Swagger Codegen https://github.com/swagger-api/swagger-codegen)
 *
 * OpenAPI spec version: 2
 * 
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */

using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.ComponentModel.DataAnnotations;
using SwaggerDateConverter = TextMagicClient.Client.SwaggerDateConverter;

namespace TextMagicClient.Model
{
    /// <summary>
    /// SendMessageResponse
    /// </summary>
    [DataContract]
    public partial class SendMessageResponse :  IEquatable<SendMessageResponse>, IValidatableObject
    {
        /// <summary>
        /// Message response type: * **message** when message sent to a single recipient * **session** when message sent to multiple recipients * **schedule** when message has been scheduled for sending * **bulk** when message sent to multiple recipient and the number of recipients requires asynchronous processiong See [Sending more than 1,000 messages in one session](http://docs.textmagictesting.com/#section/Tutorials/Sending-more-than-1000-messages-in-one-session). 
        /// </summary>
        /// <value>Message response type: * **message** when message sent to a single recipient * **session** when message sent to multiple recipients * **schedule** when message has been scheduled for sending * **bulk** when message sent to multiple recipient and the number of recipients requires asynchronous processiong See [Sending more than 1,000 messages in one session](http://docs.textmagictesting.com/#section/Tutorials/Sending-more-than-1000-messages-in-one-session). </value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum TypeEnum
        {
            
            /// <summary>
            /// Enum Message for value: message
            /// </summary>
            [EnumMember(Value = "message")]
            Message = 1,
            
            /// <summary>
            /// Enum Session for value: session
            /// </summary>
            [EnumMember(Value = "session")]
            Session = 2,
            
            /// <summary>
            /// Enum Schedule for value: schedule
            /// </summary>
            [EnumMember(Value = "schedule")]
            Schedule = 3,
            
            /// <summary>
            /// Enum Bulk for value: bulk
            /// </summary>
            [EnumMember(Value = "bulk")]
            Bulk = 4
        }

        /// <summary>
        /// Message response type: * **message** when message sent to a single recipient * **session** when message sent to multiple recipients * **schedule** when message has been scheduled for sending * **bulk** when message sent to multiple recipient and the number of recipients requires asynchronous processiong See [Sending more than 1,000 messages in one session](http://docs.textmagictesting.com/#section/Tutorials/Sending-more-than-1000-messages-in-one-session). 
        /// </summary>
        /// <value>Message response type: * **message** when message sent to a single recipient * **session** when message sent to multiple recipients * **schedule** when message has been scheduled for sending * **bulk** when message sent to multiple recipient and the number of recipients requires asynchronous processiong See [Sending more than 1,000 messages in one session](http://docs.textmagictesting.com/#section/Tutorials/Sending-more-than-1000-messages-in-one-session). </value>
        [DataMember(Name="type", EmitDefaultValue=false)]
        public TypeEnum Type { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="SendMessageResponse" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected SendMessageResponse() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="SendMessageResponse" /> class.
        /// </summary>
        /// <param name="id">Message ID. (required).</param>
        /// <param name="href">URI of message session. (required).</param>
        /// <param name="type">Message response type: * **message** when message sent to a single recipient * **session** when message sent to multiple recipients * **schedule** when message has been scheduled for sending * **bulk** when message sent to multiple recipient and the number of recipients requires asynchronous processiong See [Sending more than 1,000 messages in one session](http://docs.textmagictesting.com/#section/Tutorials/Sending-more-than-1000-messages-in-one-session).  (required).</param>
        /// <param name="sessionId">Message session ID. (required).</param>
        /// <param name="bulkId">Bulk Session ID. See [Sending more than 1,000 messages in one session](http://docs.textmagictesting.com/#section/Tutorials/Sending-more-than-1000-messages-in-one-session). (required).</param>
        /// <param name="messageId">Message ID. (required).</param>
        /// <param name="scheduleId">Message Schedule ID. (required).</param>
        /// <param name="chatId">Message Chat ID. (required).</param>
        public SendMessageResponse(int? id = default(int?), string href = default(string), TypeEnum type = default(TypeEnum), int? sessionId = default(int?), int? bulkId = default(int?), int? messageId = default(int?), int? scheduleId = default(int?), int? chatId = default(int?))
        {
            // to ensure "id" is required (not null)
            if (id == null)
            {
                throw new InvalidDataException("id is a required property for SendMessageResponse and cannot be null");
            }
            else
            {
                this.Id = id;
            }
            // to ensure "href" is required (not null)
            if (href == null)
            {
                throw new InvalidDataException("href is a required property for SendMessageResponse and cannot be null");
            }
            else
            {
                this.Href = href;
            }
            // to ensure "type" is required (not null)
            if (type == null)
            {
                throw new InvalidDataException("type is a required property for SendMessageResponse and cannot be null");
            }
            else
            {
                this.Type = type;
            }
            // to ensure "sessionId" is required (not null)
            if (sessionId == null)
            {
                throw new InvalidDataException("sessionId is a required property for SendMessageResponse and cannot be null");
            }
            else
            {
                this.SessionId = sessionId;
            }
            // to ensure "bulkId" is required (not null)
            if (bulkId == null)
            {
                throw new InvalidDataException("bulkId is a required property for SendMessageResponse and cannot be null");
            }
            else
            {
                this.BulkId = bulkId;
            }
            // to ensure "messageId" is required (not null)
            if (messageId == null)
            {
                throw new InvalidDataException("messageId is a required property for SendMessageResponse and cannot be null");
            }
            else
            {
                this.MessageId = messageId;
            }
            // to ensure "scheduleId" is required (not null)
            if (scheduleId == null)
            {
                throw new InvalidDataException("scheduleId is a required property for SendMessageResponse and cannot be null");
            }
            else
            {
                this.ScheduleId = scheduleId;
            }
            // to ensure "chatId" is required (not null)
            if (chatId == null)
            {
                throw new InvalidDataException("chatId is a required property for SendMessageResponse and cannot be null");
            }
            else
            {
                this.ChatId = chatId;
            }
        }
        
        /// <summary>
        /// Message ID.
        /// </summary>
        /// <value>Message ID.</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public int? Id { get; set; }

        /// <summary>
        /// URI of message session.
        /// </summary>
        /// <value>URI of message session.</value>
        [DataMember(Name="href", EmitDefaultValue=false)]
        public string Href { get; set; }


        /// <summary>
        /// Message session ID.
        /// </summary>
        /// <value>Message session ID.</value>
        [DataMember(Name="sessionId", EmitDefaultValue=false)]
        public int? SessionId { get; set; }

        /// <summary>
        /// Bulk Session ID. See [Sending more than 1,000 messages in one session](http://docs.textmagictesting.com/#section/Tutorials/Sending-more-than-1000-messages-in-one-session).
        /// </summary>
        /// <value>Bulk Session ID. See [Sending more than 1,000 messages in one session](http://docs.textmagictesting.com/#section/Tutorials/Sending-more-than-1000-messages-in-one-session).</value>
        [DataMember(Name="bulkId", EmitDefaultValue=false)]
        public int? BulkId { get; set; }

        /// <summary>
        /// Message ID.
        /// </summary>
        /// <value>Message ID.</value>
        [DataMember(Name="messageId", EmitDefaultValue=false)]
        public int? MessageId { get; set; }

        /// <summary>
        /// Message Schedule ID.
        /// </summary>
        /// <value>Message Schedule ID.</value>
        [DataMember(Name="scheduleId", EmitDefaultValue=false)]
        public int? ScheduleId { get; set; }

        /// <summary>
        /// Message Chat ID.
        /// </summary>
        /// <value>Message Chat ID.</value>
        [DataMember(Name="chatId", EmitDefaultValue=false)]
        public int? ChatId { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SendMessageResponse {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Href: ").Append(Href).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  SessionId: ").Append(SessionId).Append("\n");
            sb.Append("  BulkId: ").Append(BulkId).Append("\n");
            sb.Append("  MessageId: ").Append(MessageId).Append("\n");
            sb.Append("  ScheduleId: ").Append(ScheduleId).Append("\n");
            sb.Append("  ChatId: ").Append(ChatId).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
  
        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public virtual string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as SendMessageResponse);
        }

        /// <summary>
        /// Returns true if SendMessageResponse instances are equal
        /// </summary>
        /// <param name="input">Instance of SendMessageResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SendMessageResponse input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
                ) && 
                (
                    this.Href == input.Href ||
                    (this.Href != null &&
                    this.Href.Equals(input.Href))
                ) && 
                (
                    this.Type == input.Type ||
                    (this.Type != null &&
                    this.Type.Equals(input.Type))
                ) && 
                (
                    this.SessionId == input.SessionId ||
                    (this.SessionId != null &&
                    this.SessionId.Equals(input.SessionId))
                ) && 
                (
                    this.BulkId == input.BulkId ||
                    (this.BulkId != null &&
                    this.BulkId.Equals(input.BulkId))
                ) && 
                (
                    this.MessageId == input.MessageId ||
                    (this.MessageId != null &&
                    this.MessageId.Equals(input.MessageId))
                ) && 
                (
                    this.ScheduleId == input.ScheduleId ||
                    (this.ScheduleId != null &&
                    this.ScheduleId.Equals(input.ScheduleId))
                ) && 
                (
                    this.ChatId == input.ChatId ||
                    (this.ChatId != null &&
                    this.ChatId.Equals(input.ChatId))
                );
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                int hashCode = 41;
                if (this.Id != null)
                    hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.Href != null)
                    hashCode = hashCode * 59 + this.Href.GetHashCode();
                if (this.Type != null)
                    hashCode = hashCode * 59 + this.Type.GetHashCode();
                if (this.SessionId != null)
                    hashCode = hashCode * 59 + this.SessionId.GetHashCode();
                if (this.BulkId != null)
                    hashCode = hashCode * 59 + this.BulkId.GetHashCode();
                if (this.MessageId != null)
                    hashCode = hashCode * 59 + this.MessageId.GetHashCode();
                if (this.ScheduleId != null)
                    hashCode = hashCode * 59 + this.ScheduleId.GetHashCode();
                if (this.ChatId != null)
                    hashCode = hashCode * 59 + this.ChatId.GetHashCode();
                return hashCode;
            }
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }

}
