﻿// Code generated by Microsoft (R) AutoRest Code Generator 0.9.7.0
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

using System.Collections.Generic;
using Newtonsoft.Json.Linq;

namespace DocDbCollectionAPI.Models
{
    public static class StoredProcedureCollection
    {
        /// <summary>
        /// Deserialize the object
        /// </summary>
        public static IList<StoredProcedure> DeserializeJson(JToken inputObject)
        {
            IList<StoredProcedure> deserializedObject = new List<StoredProcedure>();
            foreach (var iListValue in ((JArray)inputObject))
            {
                var storedProcedure = new StoredProcedure();
                storedProcedure.DeserializeJson(iListValue);
                deserializedObject.Add(storedProcedure);
            }
            return deserializedObject;
        }
    }
}
