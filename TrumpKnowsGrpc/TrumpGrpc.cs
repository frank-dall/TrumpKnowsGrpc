// Generated by the protocol buffer compiler.  DO NOT EDIT!
// source: trump.proto
#pragma warning disable 1591
#region Designer generated code

using System;
using System.Threading;
using System.Threading.Tasks;
using grpc = global::Grpc.Core;

namespace Trump {
  /// <summary>
  /// The trumpknows service definition.
  /// </summary>
  public static partial class TrumpKnows
  {
    static readonly string __ServiceName = "trump.TrumpKnows";

    static readonly grpc::Marshaller<global::Trump.BigLeagueRequest> __Marshaller_BigLeagueRequest = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Trump.BigLeagueRequest.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::Trump.Tweet> __Marshaller_Tweet = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Trump.Tweet.Parser.ParseFrom);

    static readonly grpc::Method<global::Trump.BigLeagueRequest, global::Trump.Tweet> __Method_AskForATrumpTweet = new grpc::Method<global::Trump.BigLeagueRequest, global::Trump.Tweet>(
        grpc::MethodType.Unary,
        __ServiceName,
        "AskForATrumpTweet",
        __Marshaller_BigLeagueRequest,
        __Marshaller_Tweet);

    /// <summary>Service descriptor</summary>
    public static global::Google.Protobuf.Reflection.ServiceDescriptor Descriptor
    {
      get { return global::Trump.TrumpReflection.Descriptor.Services[0]; }
    }

    /// <summary>Base class for server-side implementations of TrumpKnows</summary>
    public abstract partial class TrumpKnowsBase
    {
      /// <summary>
      /// Sends a trump-ism
      /// </summary>
      /// <param name="request">The request received from the client.</param>
      /// <param name="context">The context of the server-side call handler being invoked.</param>
      /// <returns>The response to send back to the client (wrapped by a task).</returns>
      public virtual global::System.Threading.Tasks.Task<global::Trump.Tweet> AskForATrumpTweet(global::Trump.BigLeagueRequest request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

    }

    /// <summary>Client for TrumpKnows</summary>
    public partial class TrumpKnowsClient : grpc::ClientBase<TrumpKnowsClient>
    {
      /// <summary>Creates a new client for TrumpKnows</summary>
      /// <param name="channel">The channel to use to make remote calls.</param>
      public TrumpKnowsClient(grpc::Channel channel) : base(channel)
      {
      }
      /// <summary>Creates a new client for TrumpKnows that uses a custom <c>CallInvoker</c>.</summary>
      /// <param name="callInvoker">The callInvoker to use to make remote calls.</param>
      public TrumpKnowsClient(grpc::CallInvoker callInvoker) : base(callInvoker)
      {
      }
      /// <summary>Protected parameterless constructor to allow creation of test doubles.</summary>
      protected TrumpKnowsClient() : base()
      {
      }
      /// <summary>Protected constructor to allow creation of configured clients.</summary>
      /// <param name="configuration">The client configuration.</param>
      protected TrumpKnowsClient(ClientBaseConfiguration configuration) : base(configuration)
      {
      }

      /// <summary>
      /// Sends a trump-ism
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The response received from the server.</returns>
      public virtual global::Trump.Tweet AskForATrumpTweet(global::Trump.BigLeagueRequest request, grpc::Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
      {
        return AskForATrumpTweet(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// Sends a trump-ism
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The response received from the server.</returns>
      public virtual global::Trump.Tweet AskForATrumpTweet(global::Trump.BigLeagueRequest request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_AskForATrumpTweet, null, options, request);
      }
      /// <summary>
      /// Sends a trump-ism
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The call object.</returns>
      public virtual grpc::AsyncUnaryCall<global::Trump.Tweet> AskForATrumpTweetAsync(global::Trump.BigLeagueRequest request, grpc::Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
      {
        return AskForATrumpTweetAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// Sends a trump-ism
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The call object.</returns>
      public virtual grpc::AsyncUnaryCall<global::Trump.Tweet> AskForATrumpTweetAsync(global::Trump.BigLeagueRequest request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_AskForATrumpTweet, null, options, request);
      }
      /// <summary>Creates a new instance of client from given <c>ClientBaseConfiguration</c>.</summary>
      protected override TrumpKnowsClient NewInstance(ClientBaseConfiguration configuration)
      {
        return new TrumpKnowsClient(configuration);
      }
    }

    /// <summary>Creates service definition that can be registered with a server</summary>
    /// <param name="serviceImpl">An object implementing the server-side handling logic.</param>
    public static grpc::ServerServiceDefinition BindService(TrumpKnowsBase serviceImpl)
    {
      return grpc::ServerServiceDefinition.CreateBuilder()
          .AddMethod(__Method_AskForATrumpTweet, serviceImpl.AskForATrumpTweet).Build();
    }

  }
}
#endregion
