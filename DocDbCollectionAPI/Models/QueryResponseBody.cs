﻿// Code generated by Microsoft (R) AutoRest Code Generator 0.9.7.0
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

using Newtonsoft.Json.Linq;

namespace DocDbCollectionAPI.Models
{
    public class QueryResponseBody
    {

        /// <summary>
        /// Deserialize the object
        /// </summary>
        public virtual void DeserializeJson(JToken inputObject)
        {
            if (inputObject != null && inputObject.Type != JTokenType.Null)
            {
                var countValue = inputObject["_count"];
                if (countValue != null && countValue.Type != JTokenType.Null)
                {
                    Count = ((int)countValue);
                }
                var ridValue = inputObject["_rid"];
                if (ridValue != null && ridValue.Type != JTokenType.Null)
                {
                    Rid = ((string)ridValue);
                }
                var resourceArrayValue = inputObject["Resource_array"];
                if (resourceArrayValue != null && resourceArrayValue.Type != JTokenType.Null)
                {
                    ResourceArray = ((string)resourceArrayValue);
                }
            }
        }

        /// <summary>
        /// Optional. The number of items returned.
        /// </summary>
        public int? Count { get; set; }

        /// <summary>
        /// Optional. The array containing the query results.
        /// </summary>
        public string ResourceArray { get; set; }

        /// <summary>
        /// Optional. The resource id for the collection used within the query
        /// </summary>
        public string Rid { get; set; }
    }
}
