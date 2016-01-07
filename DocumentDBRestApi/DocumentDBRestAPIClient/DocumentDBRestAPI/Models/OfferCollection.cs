﻿// Code generated by Microsoft (R) AutoRest Code Generator 0.9.7.0
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

using System.Collections.Generic;
using Newtonsoft.Json.Linq;

namespace DocumentDBRestAPIClient.Models
{
    public static class OfferCollection
    {
        /// <summary>
        ///     Deserialize the object
        /// </summary>
        public static IList<Offer> DeserializeJson(JToken inputObject)
        {
            IList<Offer> deserializedObject = new List<Offer>();
            foreach (var iListValue in (JArray) inputObject)
            {
                var offer = new Offer();
                offer.DeserializeJson(iListValue);
                deserializedObject.Add(offer);
            }
            return deserializedObject;
        }
    }
}