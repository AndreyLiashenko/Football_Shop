using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
    //mongoDriver

namespace Football_Shop.Models
{
    public class mongoBall
    {
        [BsonRepresentation(BsonType.ObjectId)]
        public ObjectId _id { get; set; }
        public string name { get; set; }
        public string photo { get; set; }
        public string price { get; set; }
    }
  
}