//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Generated from: StringID.proto
namespace StringID
{
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"StringID")]
  public partial class StringID : global::ProtoBuf.IExtensible
  {
    public StringID() {}
    
    private string _id = "";
    [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"id", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string id
    {
      get { return _id; }
      set { _id = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"AllStringID")]
  public partial class AllStringID : global::ProtoBuf.IExtensible
  {
    public AllStringID() {}
    
    private readonly global::System.Collections.Generic.List<StringID> _ids = new global::System.Collections.Generic.List<StringID>();
    [global::ProtoBuf.ProtoMember(1, Name=@"ids", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public global::System.Collections.Generic.List<StringID> ids
    {
      get { return _ids; }
    }
  
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
}