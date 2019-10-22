﻿using Integration.Common.Interface;
using MessagePack;
using System;

namespace Integration.Common.Model
{
    public class MessagePackBinaryMessageSerializer : IBinaryMessageSerializer
    {

        public virtual byte[] SerializePayload<T>(T entity)
        {
            return MessagePackSerializer.Serialize(entity);
        }

        public virtual T DeserializePayload<T>(byte[] data)
        {
            return MessagePackSerializer.Deserialize<T>(data);
        }

        public virtual byte[] SerializePayload(object entity, Type entityType)
        {
            return MessagePackSerializer.NonGeneric.Serialize(entityType, entity);
        }

        public virtual object DeserializePayload(byte[] data, Type entityType)
        {
            return MessagePackSerializer.NonGeneric.Deserialize(entityType, data);
        }
    }
}
