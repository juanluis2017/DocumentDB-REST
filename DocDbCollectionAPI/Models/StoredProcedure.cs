﻿// Code generated by Microsoft (R) AutoRest Code Generator 0.9.7.0
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

using System;
using Newtonsoft.Json.Linq;

namespace DocDbCollectionAPI.Models
{
    public class StoredProcedure
    {

        /// <summary>
        /// Initializes a new instance of the StoredProcedure class.
        /// </summary>
        public StoredProcedure()
        {
        }

        /// <summary>
        /// Initializes a new instance of the StoredProcedure class with
        /// required arguments.
        /// </summary>
        public StoredProcedure(string id, string body)
            : this()
        {
            if (id == null)
            {
                throw new ArgumentNullException(nameof(id));
            }
            if (body == null)
            {
                throw new ArgumentNullException(nameof(body));
            }
            Id = id;
            Body = body;
        }


        /// <summary>
        /// Deserialize the object
        /// </summary>
        public virtual void DeserializeJson(JToken inputObject)
        {
            if (inputObject != null && inputObject.Type != JTokenType.Null)
            {
                var etagValue = inputObject["_etag"];
                if (etagValue != null && etagValue.Type != JTokenType.Null)
                {
                    Etag = ((string)etagValue);
                }
                var ridValue = inputObject["_rid"];
                if (ridValue != null && ridValue.Type != JTokenType.Null)
                {
                    Rid = ((string)ridValue);
                }
                var selfValue = inputObject["_self"];
                if (selfValue != null && selfValue.Type != JTokenType.Null)
                {
                    Self = ((string)selfValue);
                }
                var tsValue = inputObject["_ts"];
                if (tsValue != null && tsValue.Type != JTokenType.Null)
                {
                    Ts = ((string)tsValue);
                }
                var bodyValue = inputObject["body"];
                if (bodyValue != null && bodyValue.Type != JTokenType.Null)
                {
                    Body = ((string)bodyValue);
                }
                var idValue = inputObject["id"];
                if (idValue != null && idValue.Type != JTokenType.Null)
                {
                    Id = ((string)idValue);
                }
            }
        }

        /// <summary>
        /// Required. This is the body of the stored procedure.
        /// </summary>
        public string Body { get; set; }
        /// <summary>
        /// Optional.
        /// </summary>
        public string Etag { get; set; }

        /// <summary>
        /// Required.
        /// </summary>
        public string Id { get; set; }

        /// <summary>
        /// Optional.
        /// </summary>
        public string Rid { get; set; }

        /// <summary>
        /// Optional.
        /// </summary>
        public string Self { get; set; }

        /// <summary>
        /// Optional.
        /// </summary>
        public string Ts { get; set; }
    }
}
