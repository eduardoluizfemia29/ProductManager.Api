﻿using MongoDB.Bson.Serialization.Attributes;
using System;

namespace ProductManager.Domain.Entities
{
    public class EntityBase
    {
        public EntityBase()
        {
            Enabled = true;
            CreatedAt = DateTime.Now;
            CreatedAt = DateTime.Now;
        }
        public EntityBase(string id) : this()
        {
            Id = id;
        }

        [BsonId]
        [BsonRepresentation(MongoDB.Bson.BsonType.ObjectId)]
        public string Id { get; private set; }
        public bool Enabled { get; private set; }
        public DateTime CreatedAt { get; private set; }
        public DateTime? UpdatedAt { get; private set; }
    }
}