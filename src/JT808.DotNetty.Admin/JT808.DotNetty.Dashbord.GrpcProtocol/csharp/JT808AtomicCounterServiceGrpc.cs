// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: JT808AtomicCounterService.proto
// </auto-generated>
#pragma warning disable 0414, 1591
#region Designer generated code

using grpc = global::Grpc.Core;

namespace JT808.GrpcDashbord.AtomicCounterGrpcService {
  public static partial class AtomicCounterService
  {
    static readonly string __ServiceName = "JT808.GrpcDashbord.AtomicCounterGrpcService.AtomicCounterService";

    static readonly grpc::Marshaller<global::JT808.GrpcDashbord.ServiceGrpcBase.EmptyRequest> __Marshaller_JT808_GrpcDashbord_ServiceGrpcBase_EmptyRequest = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::JT808.GrpcDashbord.ServiceGrpcBase.EmptyRequest.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::JT808.GrpcDashbord.AtomicCounterGrpcService.AtomicCounterReply> __Marshaller_JT808_GrpcDashbord_AtomicCounterGrpcService_AtomicCounterReply = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::JT808.GrpcDashbord.AtomicCounterGrpcService.AtomicCounterReply.Parser.ParseFrom);

    static readonly grpc::Method<global::JT808.GrpcDashbord.ServiceGrpcBase.EmptyRequest, global::JT808.GrpcDashbord.AtomicCounterGrpcService.AtomicCounterReply> __Method_GetTcpAtomicCounter = new grpc::Method<global::JT808.GrpcDashbord.ServiceGrpcBase.EmptyRequest, global::JT808.GrpcDashbord.AtomicCounterGrpcService.AtomicCounterReply>(
        grpc::MethodType.Unary,
        __ServiceName,
        "GetTcpAtomicCounter",
        __Marshaller_JT808_GrpcDashbord_ServiceGrpcBase_EmptyRequest,
        __Marshaller_JT808_GrpcDashbord_AtomicCounterGrpcService_AtomicCounterReply);

    static readonly grpc::Method<global::JT808.GrpcDashbord.ServiceGrpcBase.EmptyRequest, global::JT808.GrpcDashbord.AtomicCounterGrpcService.AtomicCounterReply> __Method_GetUdpAtomicCounter = new grpc::Method<global::JT808.GrpcDashbord.ServiceGrpcBase.EmptyRequest, global::JT808.GrpcDashbord.AtomicCounterGrpcService.AtomicCounterReply>(
        grpc::MethodType.Unary,
        __ServiceName,
        "GetUdpAtomicCounter",
        __Marshaller_JT808_GrpcDashbord_ServiceGrpcBase_EmptyRequest,
        __Marshaller_JT808_GrpcDashbord_AtomicCounterGrpcService_AtomicCounterReply);

    /// <summary>Service descriptor</summary>
    public static global::Google.Protobuf.Reflection.ServiceDescriptor Descriptor
    {
      get { return global::JT808.GrpcDashbord.AtomicCounterGrpcService.JT808AtomicCounterServiceReflection.Descriptor.Services[0]; }
    }

    /// <summary>Base class for server-side implementations of AtomicCounterService</summary>
    public abstract partial class AtomicCounterServiceBase
    {
      public virtual global::System.Threading.Tasks.Task<global::JT808.GrpcDashbord.AtomicCounterGrpcService.AtomicCounterReply> GetTcpAtomicCounter(global::JT808.GrpcDashbord.ServiceGrpcBase.EmptyRequest request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      public virtual global::System.Threading.Tasks.Task<global::JT808.GrpcDashbord.AtomicCounterGrpcService.AtomicCounterReply> GetUdpAtomicCounter(global::JT808.GrpcDashbord.ServiceGrpcBase.EmptyRequest request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

    }

    /// <summary>Client for AtomicCounterService</summary>
    public partial class AtomicCounterServiceClient : grpc::ClientBase<AtomicCounterServiceClient>
    {
      /// <summary>Creates a new client for AtomicCounterService</summary>
      /// <param name="channel">The channel to use to make remote calls.</param>
      public AtomicCounterServiceClient(grpc::Channel channel) : base(channel)
      {
      }
      /// <summary>Creates a new client for AtomicCounterService that uses a custom <c>CallInvoker</c>.</summary>
      /// <param name="callInvoker">The callInvoker to use to make remote calls.</param>
      public AtomicCounterServiceClient(grpc::CallInvoker callInvoker) : base(callInvoker)
      {
      }
      /// <summary>Protected parameterless constructor to allow creation of test doubles.</summary>
      protected AtomicCounterServiceClient() : base()
      {
      }
      /// <summary>Protected constructor to allow creation of configured clients.</summary>
      /// <param name="configuration">The client configuration.</param>
      protected AtomicCounterServiceClient(ClientBaseConfiguration configuration) : base(configuration)
      {
      }

      public virtual global::JT808.GrpcDashbord.AtomicCounterGrpcService.AtomicCounterReply GetTcpAtomicCounter(global::JT808.GrpcDashbord.ServiceGrpcBase.EmptyRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return GetTcpAtomicCounter(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      public virtual global::JT808.GrpcDashbord.AtomicCounterGrpcService.AtomicCounterReply GetTcpAtomicCounter(global::JT808.GrpcDashbord.ServiceGrpcBase.EmptyRequest request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_GetTcpAtomicCounter, null, options, request);
      }
      public virtual grpc::AsyncUnaryCall<global::JT808.GrpcDashbord.AtomicCounterGrpcService.AtomicCounterReply> GetTcpAtomicCounterAsync(global::JT808.GrpcDashbord.ServiceGrpcBase.EmptyRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return GetTcpAtomicCounterAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      public virtual grpc::AsyncUnaryCall<global::JT808.GrpcDashbord.AtomicCounterGrpcService.AtomicCounterReply> GetTcpAtomicCounterAsync(global::JT808.GrpcDashbord.ServiceGrpcBase.EmptyRequest request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_GetTcpAtomicCounter, null, options, request);
      }
      public virtual global::JT808.GrpcDashbord.AtomicCounterGrpcService.AtomicCounterReply GetUdpAtomicCounter(global::JT808.GrpcDashbord.ServiceGrpcBase.EmptyRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return GetUdpAtomicCounter(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      public virtual global::JT808.GrpcDashbord.AtomicCounterGrpcService.AtomicCounterReply GetUdpAtomicCounter(global::JT808.GrpcDashbord.ServiceGrpcBase.EmptyRequest request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_GetUdpAtomicCounter, null, options, request);
      }
      public virtual grpc::AsyncUnaryCall<global::JT808.GrpcDashbord.AtomicCounterGrpcService.AtomicCounterReply> GetUdpAtomicCounterAsync(global::JT808.GrpcDashbord.ServiceGrpcBase.EmptyRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return GetUdpAtomicCounterAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      public virtual grpc::AsyncUnaryCall<global::JT808.GrpcDashbord.AtomicCounterGrpcService.AtomicCounterReply> GetUdpAtomicCounterAsync(global::JT808.GrpcDashbord.ServiceGrpcBase.EmptyRequest request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_GetUdpAtomicCounter, null, options, request);
      }
      /// <summary>Creates a new instance of client from given <c>ClientBaseConfiguration</c>.</summary>
      protected override AtomicCounterServiceClient NewInstance(ClientBaseConfiguration configuration)
      {
        return new AtomicCounterServiceClient(configuration);
      }
    }

    /// <summary>Creates service definition that can be registered with a server</summary>
    /// <param name="serviceImpl">An object implementing the server-side handling logic.</param>
    public static grpc::ServerServiceDefinition BindService(AtomicCounterServiceBase serviceImpl)
    {
      return grpc::ServerServiceDefinition.CreateBuilder()
          .AddMethod(__Method_GetTcpAtomicCounter, serviceImpl.GetTcpAtomicCounter)
          .AddMethod(__Method_GetUdpAtomicCounter, serviceImpl.GetUdpAtomicCounter).Build();
    }

    /// <summary>Register service method implementations with a service binder. Useful when customizing the service binding logic.
    /// Note: this method is part of an experimental API that can change or be removed without any prior notice.</summary>
    /// <param name="serviceBinder">Service methods will be bound by calling <c>AddMethod</c> on this object.</param>
    /// <param name="serviceImpl">An object implementing the server-side handling logic.</param>
    public static void BindService(grpc::ServiceBinderBase serviceBinder, AtomicCounterServiceBase serviceImpl)
    {
      serviceBinder.AddMethod(__Method_GetTcpAtomicCounter, serviceImpl.GetTcpAtomicCounter);
      serviceBinder.AddMethod(__Method_GetUdpAtomicCounter, serviceImpl.GetUdpAtomicCounter);
    }

  }
}
#endregion
