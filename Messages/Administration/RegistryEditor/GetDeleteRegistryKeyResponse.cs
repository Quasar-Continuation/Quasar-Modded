﻿using ProtoBuf;
using Quasar.Common.Messages.other;

namespace Quasar.Common.Messages.Administration.RegistryEditor
{
    [ProtoContract]
    public class GetDeleteRegistryKeyResponse : IMessage
    {
        [ProtoMember(1)]
        public string ParentPath { get; set; }

        [ProtoMember(2)]
        public string KeyName { get; set; }

        [ProtoMember(3)]
        public bool IsError { get; set; }

        [ProtoMember(4)]
        public string ErrorMsg { get; set; }
    }
}
