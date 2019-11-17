﻿using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Kledex.Domain
{
    public interface IStoreProvider
    {
        /// <summary>
        /// Saves the domain data asynchronously.
        /// </summary>
        /// <param name="aggregateRootId"></param>
        /// <param name="command">The command.</param>
        /// <param name="events">The events.</param>
        /// <param name="aggregateType"></param>
        /// <returns></returns>
        Task SaveAsync(Type aggregateType, Guid aggregateRootId, IDomainCommand command, IEnumerable<IDomainEvent> events);

        /// <summary>
        /// Gets the events asynchronously.
        /// </summary>
        /// <param name="aggregateId">The aggregate identifier.</param>
        /// <returns></returns>
        Task<IEnumerable<DomainEvent>> GetEventsAsync(Guid aggregateId);

        /// <summary>
        /// Saves the domain data.
        /// </summary>
        /// <param name="aggregateRootId"></param>
        /// <param name="command">The command.</param>
        /// <param name="events">The events.</param>
        /// <param name="aggregateType"></param>
        void Save(Type aggregateType, Guid aggregateRootId, IDomainCommand command, IEnumerable<IDomainEvent> events);

        /// <summary>
        /// Gets the events.
        /// </summary>
        /// <param name="aggregateId">The aggregate identifier.</param>
        /// <returns></returns>
        IEnumerable<DomainEvent> GetEvents(Guid aggregateId);
    }

    public class DefaultDomainStore : IStoreProvider
    {
        public IEnumerable<DomainEvent> GetEvents(Guid aggregateId)
        {
            throw new NotImplementedException(Consts.StoreRequiredMessage);
        }

        public Task<IEnumerable<DomainEvent>> GetEventsAsync(Guid aggregateId)
        {
            throw new NotImplementedException(Consts.StoreRequiredMessage);
        }

        public void Save(Type aggregateType, Guid aggregateRootId, IDomainCommand command, IEnumerable<IDomainEvent> events)
        {
            throw new NotImplementedException(Consts.StoreRequiredMessage);
        }

        public Task SaveAsync(Type aggregateType, Guid aggregateRootId, IDomainCommand command, IEnumerable<IDomainEvent> events) 
        {
            throw new NotImplementedException(Consts.StoreRequiredMessage);
        }
    }
}
