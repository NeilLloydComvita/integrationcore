﻿using Integration.Common.Model;
using Microsoft.ServiceFabric.Actors;
using Microsoft.ServiceFabric.Actors.Remoting.FabricTransport;
using Microsoft.ServiceFabric.Services.Remoting;
using System.Threading;
using System.Threading.Tasks;

[assembly: FabricTransportActorRemotingProvider(RemotingListenerVersion = RemotingListenerVersion.V2_1, RemotingClientVersion = RemotingClientVersion.V2_1)]
namespace Integration.Common.Actor.Interface
{
    public interface IBaseMessagingActor : IActor
    {
        Task ChainProcessMessageAsync(ActorRequestContext actorRequestContext, byte[] payload,
            CancellationToken cancellationToken);
    }
}
