﻿using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace Blog.Domain.Entities
{
    public class User
    {
        [BsonId]
        public ObjectId Id { get; set; }

        public string Name { get; set; }

        public string Email { get; set; }
    }
}