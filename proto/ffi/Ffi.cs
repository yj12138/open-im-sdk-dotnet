// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: ffi.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace OpenIM.Proto {

  /// <summary>Holder for reflection information generated from ffi.proto</summary>
  public static partial class FfiReflection {

    #region Descriptor
    /// <summary>File descriptor for ffi.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static FfiReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CglmZmkucHJvdG8SCm9wZW5pbS5mZmkaC2V2ZW50LnByb3RvIncKCkZmaVJl",
            "cXVlc3QSEwoLb3BlcmF0aW9uSUQYASABKAkSEAoIaGFuZGxlSUQYAiABKAMS",
            "NAoIZnVuY05hbWUYAyABKA4yIi5vcGVuaW0uZXZlbnQuRnVuY1JlcXVlc3RF",
            "dmVudE5hbWUSDAoEZGF0YRgEIAEoDCKCAQoJRmZpUmVzdWx0Eg8KB2VyckNv",
            "ZGUYASABKAUSDgoGZXJyTXNnGAIgASgJEjQKCGZ1bmNOYW1lGAMgASgOMiIu",
            "b3BlbmltLmV2ZW50LkZ1bmNSZXF1ZXN0RXZlbnROYW1lEgwKBGRhdGEYBCAB",
            "KAwSEAoIaGFuZGxlSUQYBSABKANCSFo0Z2l0aHViLmNvbS9vcGVuaW1zZGsv",
            "b3BlbmltLXNkay1jb3JlL3YzL3Byb3RvL2dvL2ZmaaoCDE9wZW5JTS5Qcm90",
            "b7oCAGIGcHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::OpenIM.Proto.EventReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::OpenIM.Proto.FfiRequest), global::OpenIM.Proto.FfiRequest.Parser, new[]{ "OperationID", "HandleID", "FuncName", "Data" }, null, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::OpenIM.Proto.FfiResult), global::OpenIM.Proto.FfiResult.Parser, new[]{ "ErrCode", "ErrMsg", "FuncName", "Data", "HandleID" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  [global::System.Diagnostics.DebuggerDisplayAttribute("{ToString(),nq}")]
  public sealed partial class FfiRequest : pb::IMessage<FfiRequest>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<FfiRequest> _parser = new pb::MessageParser<FfiRequest>(() => new FfiRequest());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<FfiRequest> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::OpenIM.Proto.FfiReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public FfiRequest() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public FfiRequest(FfiRequest other) : this() {
      operationID_ = other.operationID_;
      handleID_ = other.handleID_;
      funcName_ = other.funcName_;
      data_ = other.data_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public FfiRequest Clone() {
      return new FfiRequest(this);
    }

    /// <summary>Field number for the "operationID" field.</summary>
    public const int OperationIDFieldNumber = 1;
    private string operationID_ = "";
    /// <summary>
    ///note: This field is optional and is only used for interaction between Go and JS.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string OperationID {
      get { return operationID_; }
      set {
        operationID_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "handleID" field.</summary>
    public const int HandleIDFieldNumber = 2;
    private long handleID_;
    /// <summary>
    /// The handle ID.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public long HandleID {
      get { return handleID_; }
      set {
        handleID_ = value;
      }
    }

    /// <summary>Field number for the "funcName" field.</summary>
    public const int FuncNameFieldNumber = 3;
    private global::OpenIM.Proto.FuncRequestEventName funcName_ = global::OpenIM.Proto.FuncRequestEventName.None;
    /// <summary>
    /// Function request event name.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::OpenIM.Proto.FuncRequestEventName FuncName {
      get { return funcName_; }
      set {
        funcName_ = value;
      }
    }

    /// <summary>Field number for the "data" field.</summary>
    public const int DataFieldNumber = 4;
    private pb::ByteString data_ = pb::ByteString.Empty;
    /// <summary>
    /// The request data.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pb::ByteString Data {
      get { return data_; }
      set {
        data_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as FfiRequest);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(FfiRequest other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (OperationID != other.OperationID) return false;
      if (HandleID != other.HandleID) return false;
      if (FuncName != other.FuncName) return false;
      if (Data != other.Data) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (OperationID.Length != 0) hash ^= OperationID.GetHashCode();
      if (HandleID != 0L) hash ^= HandleID.GetHashCode();
      if (FuncName != global::OpenIM.Proto.FuncRequestEventName.None) hash ^= FuncName.GetHashCode();
      if (Data.Length != 0) hash ^= Data.GetHashCode();
      if (_unknownFields != null) {
        hash ^= _unknownFields.GetHashCode();
      }
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void WriteTo(pb::CodedOutputStream output) {
    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      output.WriteRawMessage(this);
    #else
      if (OperationID.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(OperationID);
      }
      if (HandleID != 0L) {
        output.WriteRawTag(16);
        output.WriteInt64(HandleID);
      }
      if (FuncName != global::OpenIM.Proto.FuncRequestEventName.None) {
        output.WriteRawTag(24);
        output.WriteEnum((int) FuncName);
      }
      if (Data.Length != 0) {
        output.WriteRawTag(34);
        output.WriteBytes(Data);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    void pb::IBufferMessage.InternalWriteTo(ref pb::WriteContext output) {
      if (OperationID.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(OperationID);
      }
      if (HandleID != 0L) {
        output.WriteRawTag(16);
        output.WriteInt64(HandleID);
      }
      if (FuncName != global::OpenIM.Proto.FuncRequestEventName.None) {
        output.WriteRawTag(24);
        output.WriteEnum((int) FuncName);
      }
      if (Data.Length != 0) {
        output.WriteRawTag(34);
        output.WriteBytes(Data);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(ref output);
      }
    }
    #endif

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public int CalculateSize() {
      int size = 0;
      if (OperationID.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(OperationID);
      }
      if (HandleID != 0L) {
        size += 1 + pb::CodedOutputStream.ComputeInt64Size(HandleID);
      }
      if (FuncName != global::OpenIM.Proto.FuncRequestEventName.None) {
        size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) FuncName);
      }
      if (Data.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeBytesSize(Data);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(FfiRequest other) {
      if (other == null) {
        return;
      }
      if (other.OperationID.Length != 0) {
        OperationID = other.OperationID;
      }
      if (other.HandleID != 0L) {
        HandleID = other.HandleID;
      }
      if (other.FuncName != global::OpenIM.Proto.FuncRequestEventName.None) {
        FuncName = other.FuncName;
      }
      if (other.Data.Length != 0) {
        Data = other.Data;
      }
      _unknownFields = pb::UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(pb::CodedInputStream input) {
    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      input.ReadRawMessage(this);
    #else
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
      if ((tag & 7) == 4) {
        // Abort on any end group tag.
        return;
      }
      switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
            break;
          case 10: {
            OperationID = input.ReadString();
            break;
          }
          case 16: {
            HandleID = input.ReadInt64();
            break;
          }
          case 24: {
            FuncName = (global::OpenIM.Proto.FuncRequestEventName) input.ReadEnum();
            break;
          }
          case 34: {
            Data = input.ReadBytes();
            break;
          }
        }
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    void pb::IBufferMessage.InternalMergeFrom(ref pb::ParseContext input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
      if ((tag & 7) == 4) {
        // Abort on any end group tag.
        return;
      }
      switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
            break;
          case 10: {
            OperationID = input.ReadString();
            break;
          }
          case 16: {
            HandleID = input.ReadInt64();
            break;
          }
          case 24: {
            FuncName = (global::OpenIM.Proto.FuncRequestEventName) input.ReadEnum();
            break;
          }
          case 34: {
            Data = input.ReadBytes();
            break;
          }
        }
      }
    }
    #endif

  }

  [global::System.Diagnostics.DebuggerDisplayAttribute("{ToString(),nq}")]
  public sealed partial class FfiResult : pb::IMessage<FfiResult>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<FfiResult> _parser = new pb::MessageParser<FfiResult>(() => new FfiResult());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<FfiResult> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::OpenIM.Proto.FfiReflection.Descriptor.MessageTypes[1]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public FfiResult() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public FfiResult(FfiResult other) : this() {
      errCode_ = other.errCode_;
      errMsg_ = other.errMsg_;
      funcName_ = other.funcName_;
      data_ = other.data_;
      handleID_ = other.handleID_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public FfiResult Clone() {
      return new FfiResult(this);
    }

    /// <summary>Field number for the "errCode" field.</summary>
    public const int ErrCodeFieldNumber = 1;
    private int errCode_;
    /// <summary>
    /// The error code, 0 means success, non-zero means failure.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public int ErrCode {
      get { return errCode_; }
      set {
        errCode_ = value;
      }
    }

    /// <summary>Field number for the "errMsg" field.</summary>
    public const int ErrMsgFieldNumber = 2;
    private string errMsg_ = "";
    /// <summary>
    /// The error message.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string ErrMsg {
      get { return errMsg_; }
      set {
        errMsg_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "funcName" field.</summary>
    public const int FuncNameFieldNumber = 3;
    private global::OpenIM.Proto.FuncRequestEventName funcName_ = global::OpenIM.Proto.FuncRequestEventName.None;
    /// <summary>
    /// Function request event name.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::OpenIM.Proto.FuncRequestEventName FuncName {
      get { return funcName_; }
      set {
        funcName_ = value;
      }
    }

    /// <summary>Field number for the "data" field.</summary>
    public const int DataFieldNumber = 4;
    private pb::ByteString data_ = pb::ByteString.Empty;
    /// <summary>
    /// The result data.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pb::ByteString Data {
      get { return data_; }
      set {
        data_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "handleID" field.</summary>
    public const int HandleIDFieldNumber = 5;
    private long handleID_;
    /// <summary>
    /// handleID
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public long HandleID {
      get { return handleID_; }
      set {
        handleID_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as FfiResult);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(FfiResult other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (ErrCode != other.ErrCode) return false;
      if (ErrMsg != other.ErrMsg) return false;
      if (FuncName != other.FuncName) return false;
      if (Data != other.Data) return false;
      if (HandleID != other.HandleID) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (ErrCode != 0) hash ^= ErrCode.GetHashCode();
      if (ErrMsg.Length != 0) hash ^= ErrMsg.GetHashCode();
      if (FuncName != global::OpenIM.Proto.FuncRequestEventName.None) hash ^= FuncName.GetHashCode();
      if (Data.Length != 0) hash ^= Data.GetHashCode();
      if (HandleID != 0L) hash ^= HandleID.GetHashCode();
      if (_unknownFields != null) {
        hash ^= _unknownFields.GetHashCode();
      }
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void WriteTo(pb::CodedOutputStream output) {
    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      output.WriteRawMessage(this);
    #else
      if (ErrCode != 0) {
        output.WriteRawTag(8);
        output.WriteInt32(ErrCode);
      }
      if (ErrMsg.Length != 0) {
        output.WriteRawTag(18);
        output.WriteString(ErrMsg);
      }
      if (FuncName != global::OpenIM.Proto.FuncRequestEventName.None) {
        output.WriteRawTag(24);
        output.WriteEnum((int) FuncName);
      }
      if (Data.Length != 0) {
        output.WriteRawTag(34);
        output.WriteBytes(Data);
      }
      if (HandleID != 0L) {
        output.WriteRawTag(40);
        output.WriteInt64(HandleID);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    void pb::IBufferMessage.InternalWriteTo(ref pb::WriteContext output) {
      if (ErrCode != 0) {
        output.WriteRawTag(8);
        output.WriteInt32(ErrCode);
      }
      if (ErrMsg.Length != 0) {
        output.WriteRawTag(18);
        output.WriteString(ErrMsg);
      }
      if (FuncName != global::OpenIM.Proto.FuncRequestEventName.None) {
        output.WriteRawTag(24);
        output.WriteEnum((int) FuncName);
      }
      if (Data.Length != 0) {
        output.WriteRawTag(34);
        output.WriteBytes(Data);
      }
      if (HandleID != 0L) {
        output.WriteRawTag(40);
        output.WriteInt64(HandleID);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(ref output);
      }
    }
    #endif

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public int CalculateSize() {
      int size = 0;
      if (ErrCode != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(ErrCode);
      }
      if (ErrMsg.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(ErrMsg);
      }
      if (FuncName != global::OpenIM.Proto.FuncRequestEventName.None) {
        size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) FuncName);
      }
      if (Data.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeBytesSize(Data);
      }
      if (HandleID != 0L) {
        size += 1 + pb::CodedOutputStream.ComputeInt64Size(HandleID);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(FfiResult other) {
      if (other == null) {
        return;
      }
      if (other.ErrCode != 0) {
        ErrCode = other.ErrCode;
      }
      if (other.ErrMsg.Length != 0) {
        ErrMsg = other.ErrMsg;
      }
      if (other.FuncName != global::OpenIM.Proto.FuncRequestEventName.None) {
        FuncName = other.FuncName;
      }
      if (other.Data.Length != 0) {
        Data = other.Data;
      }
      if (other.HandleID != 0L) {
        HandleID = other.HandleID;
      }
      _unknownFields = pb::UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(pb::CodedInputStream input) {
    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      input.ReadRawMessage(this);
    #else
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
      if ((tag & 7) == 4) {
        // Abort on any end group tag.
        return;
      }
      switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
            break;
          case 8: {
            ErrCode = input.ReadInt32();
            break;
          }
          case 18: {
            ErrMsg = input.ReadString();
            break;
          }
          case 24: {
            FuncName = (global::OpenIM.Proto.FuncRequestEventName) input.ReadEnum();
            break;
          }
          case 34: {
            Data = input.ReadBytes();
            break;
          }
          case 40: {
            HandleID = input.ReadInt64();
            break;
          }
        }
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    void pb::IBufferMessage.InternalMergeFrom(ref pb::ParseContext input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
      if ((tag & 7) == 4) {
        // Abort on any end group tag.
        return;
      }
      switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
            break;
          case 8: {
            ErrCode = input.ReadInt32();
            break;
          }
          case 18: {
            ErrMsg = input.ReadString();
            break;
          }
          case 24: {
            FuncName = (global::OpenIM.Proto.FuncRequestEventName) input.ReadEnum();
            break;
          }
          case 34: {
            Data = input.ReadBytes();
            break;
          }
          case 40: {
            HandleID = input.ReadInt64();
            break;
          }
        }
      }
    }
    #endif

  }

  #endregion

}

#endregion Designer generated code
