using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuruuHagane.Core.Protobuff
{
    [global::System.Serializable, global::ProtoBuf.ProtoContract(Name = @"RpbPingReq")]
    public partial class RpbPingReq : global::ProtoBuf.IExtensible
    {
        public RpbPingReq() { }

        private global::ProtoBuf.IExtension extensionObject;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
        { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
    }

    [global::System.Serializable, global::ProtoBuf.ProtoContract(Name = @"RpbPingResp")]
    public partial class RpbPingResp : global::ProtoBuf.IExtensible
    {
        public RpbPingResp() { }

        private global::ProtoBuf.IExtension extensionObject;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
        { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
    }
  
}
