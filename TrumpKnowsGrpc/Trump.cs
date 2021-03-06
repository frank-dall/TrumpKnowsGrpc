// Generated by the protocol buffer compiler.  DO NOT EDIT!
// source: trump.proto
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Trump {

  /// <summary>Holder for reflection information generated from trump.proto</summary>
  public static partial class TrumpReflection {

    #region Descriptor
    /// <summary>File descriptor for trump.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static TrumpReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "Cgt0cnVtcC5wcm90bxIFdHJ1bXAiIAoQQmlnTGVhZ3VlUmVxdWVzdBIMCgRu",
            "YW1lGAEgASgJIikKBlR3ZWV0cxIfCglhbGxUd2VldHMYASADKAsyDC50cnVt",
            "cC5Ud2VldCJoCgVUd2VldBIMCgR0ZXh0GAEgASgJEhIKCmNyZWF0ZWRfYXQY",
            "AiABKAkSFgoOZmF2b3JpdGVfY291bnQYAyABKAUSFQoNcmV0d2VldF9jb3Vu",
            "dBgEIAEoBRIOCgZpZF9zdHIYBSABKAkySgoKVHJ1bXBLbm93cxI8ChFBc2tG",
            "b3JBVHJ1bXBUd2VldBIXLnRydW1wLkJpZ0xlYWd1ZVJlcXVlc3QaDC50cnVt",
            "cC5Ud2VldCIAQgiqAgVUcnVtcGIGcHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Trump.BigLeagueRequest), global::Trump.BigLeagueRequest.Parser, new[]{ "Name" }, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::Trump.Tweets), global::Trump.Tweets.Parser, new[]{ "AllTweets" }, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::Trump.Tweet), global::Trump.Tweet.Parser, new[]{ "Text", "CreatedAt", "FavoriteCount", "RetweetCount", "IdStr" }, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// The request message containing the user's name.
  /// </summary>
  public sealed partial class BigLeagueRequest : pb::IMessage<BigLeagueRequest> {
    private static readonly pb::MessageParser<BigLeagueRequest> _parser = new pb::MessageParser<BigLeagueRequest>(() => new BigLeagueRequest());
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<BigLeagueRequest> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Trump.TrumpReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public BigLeagueRequest() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public BigLeagueRequest(BigLeagueRequest other) : this() {
      name_ = other.name_;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public BigLeagueRequest Clone() {
      return new BigLeagueRequest(this);
    }

    /// <summary>Field number for the "name" field.</summary>
    public const int NameFieldNumber = 1;
    private string name_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string Name {
      get { return name_; }
      set {
        name_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as BigLeagueRequest);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(BigLeagueRequest other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Name != other.Name) return false;
      return true;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (Name.Length != 0) hash ^= Name.GetHashCode();
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
      if (Name.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(Name);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (Name.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Name);
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(BigLeagueRequest other) {
      if (other == null) {
        return;
      }
      if (other.Name.Length != 0) {
        Name = other.Name;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(pb::CodedInputStream input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            input.SkipLastField();
            break;
          case 10: {
            Name = input.ReadString();
            break;
          }
        }
      }
    }

  }

  public sealed partial class Tweets : pb::IMessage<Tweets> {
    private static readonly pb::MessageParser<Tweets> _parser = new pb::MessageParser<Tweets>(() => new Tweets());
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<Tweets> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Trump.TrumpReflection.Descriptor.MessageTypes[1]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public Tweets() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public Tweets(Tweets other) : this() {
      allTweets_ = other.allTweets_.Clone();
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public Tweets Clone() {
      return new Tweets(this);
    }

    /// <summary>Field number for the "allTweets" field.</summary>
    public const int AllTweetsFieldNumber = 1;
    private static readonly pb::FieldCodec<global::Trump.Tweet> _repeated_allTweets_codec
        = pb::FieldCodec.ForMessage(10, global::Trump.Tweet.Parser);
    private readonly pbc::RepeatedField<global::Trump.Tweet> allTweets_ = new pbc::RepeatedField<global::Trump.Tweet>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public pbc::RepeatedField<global::Trump.Tweet> AllTweets {
      get { return allTweets_; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as Tweets);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(Tweets other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if(!allTweets_.Equals(other.allTweets_)) return false;
      return true;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      hash ^= allTweets_.GetHashCode();
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
      allTweets_.WriteTo(output, _repeated_allTweets_codec);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      size += allTweets_.CalculateSize(_repeated_allTweets_codec);
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(Tweets other) {
      if (other == null) {
        return;
      }
      allTweets_.Add(other.allTweets_);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(pb::CodedInputStream input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            input.SkipLastField();
            break;
          case 10: {
            allTweets_.AddEntriesFrom(input, _repeated_allTweets_codec);
            break;
          }
        }
      }
    }

  }

  /// <summary>
  /// The response message containing a tweet
  /// </summary>
  public sealed partial class Tweet : pb::IMessage<Tweet> {
    private static readonly pb::MessageParser<Tweet> _parser = new pb::MessageParser<Tweet>(() => new Tweet());
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<Tweet> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Trump.TrumpReflection.Descriptor.MessageTypes[2]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public Tweet() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public Tweet(Tweet other) : this() {
      text_ = other.text_;
      createdAt_ = other.createdAt_;
      favoriteCount_ = other.favoriteCount_;
      retweetCount_ = other.retweetCount_;
      idStr_ = other.idStr_;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public Tweet Clone() {
      return new Tweet(this);
    }

    /// <summary>Field number for the "text" field.</summary>
    public const int TextFieldNumber = 1;
    private string text_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string Text {
      get { return text_; }
      set {
        text_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "created_at" field.</summary>
    public const int CreatedAtFieldNumber = 2;
    private string createdAt_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string CreatedAt {
      get { return createdAt_; }
      set {
        createdAt_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "favorite_count" field.</summary>
    public const int FavoriteCountFieldNumber = 3;
    private int favoriteCount_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int FavoriteCount {
      get { return favoriteCount_; }
      set {
        favoriteCount_ = value;
      }
    }

    /// <summary>Field number for the "retweet_count" field.</summary>
    public const int RetweetCountFieldNumber = 4;
    private int retweetCount_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int RetweetCount {
      get { return retweetCount_; }
      set {
        retweetCount_ = value;
      }
    }

    /// <summary>Field number for the "id_str" field.</summary>
    public const int IdStrFieldNumber = 5;
    private string idStr_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string IdStr {
      get { return idStr_; }
      set {
        idStr_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as Tweet);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(Tweet other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Text != other.Text) return false;
      if (CreatedAt != other.CreatedAt) return false;
      if (FavoriteCount != other.FavoriteCount) return false;
      if (RetweetCount != other.RetweetCount) return false;
      if (IdStr != other.IdStr) return false;
      return true;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (Text.Length != 0) hash ^= Text.GetHashCode();
      if (CreatedAt.Length != 0) hash ^= CreatedAt.GetHashCode();
      if (FavoriteCount != 0) hash ^= FavoriteCount.GetHashCode();
      if (RetweetCount != 0) hash ^= RetweetCount.GetHashCode();
      if (IdStr.Length != 0) hash ^= IdStr.GetHashCode();
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
      if (Text.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(Text);
      }
      if (CreatedAt.Length != 0) {
        output.WriteRawTag(18);
        output.WriteString(CreatedAt);
      }
      if (FavoriteCount != 0) {
        output.WriteRawTag(24);
        output.WriteInt32(FavoriteCount);
      }
      if (RetweetCount != 0) {
        output.WriteRawTag(32);
        output.WriteInt32(RetweetCount);
      }
      if (IdStr.Length != 0) {
        output.WriteRawTag(42);
        output.WriteString(IdStr);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (Text.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Text);
      }
      if (CreatedAt.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(CreatedAt);
      }
      if (FavoriteCount != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(FavoriteCount);
      }
      if (RetweetCount != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(RetweetCount);
      }
      if (IdStr.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(IdStr);
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(Tweet other) {
      if (other == null) {
        return;
      }
      if (other.Text.Length != 0) {
        Text = other.Text;
      }
      if (other.CreatedAt.Length != 0) {
        CreatedAt = other.CreatedAt;
      }
      if (other.FavoriteCount != 0) {
        FavoriteCount = other.FavoriteCount;
      }
      if (other.RetweetCount != 0) {
        RetweetCount = other.RetweetCount;
      }
      if (other.IdStr.Length != 0) {
        IdStr = other.IdStr;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(pb::CodedInputStream input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            input.SkipLastField();
            break;
          case 10: {
            Text = input.ReadString();
            break;
          }
          case 18: {
            CreatedAt = input.ReadString();
            break;
          }
          case 24: {
            FavoriteCount = input.ReadInt32();
            break;
          }
          case 32: {
            RetweetCount = input.ReadInt32();
            break;
          }
          case 42: {
            IdStr = input.ReadString();
            break;
          }
        }
      }
    }

  }

  #endregion

}

#endregion Designer generated code
