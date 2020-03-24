using System.Linq;
using System.Threading.Tasks;
using NerdStore.Core.Communication.Mediator;
using NerdStore.Core.DomainObjects;

namespace NerdStore.Vendas.Data
{
    public static class MediatorExtension
    {
        public static async Task PublicarEventos(this IMediatorHandler mediatorHandler, VendasContext context)
        {
            var domainEntities = context.ChangeTracker.Entries<Entity>().Where(x =>
                x.Entity.Notificacoes != null && x.Entity.Notificacoes.Any()).ToList();

            var domainEvents = domainEntities.SelectMany(x => x.Entity.Notificacoes).ToList();
            
            domainEntities.ForEach(x => x.Entity.LimparEventos());

            var tasks = domainEvents.Select(async domainEvent =>
            {
                await mediatorHandler.PublicarEvento(domainEvent);
            });

            await Task.WhenAll(tasks);
        }
    }
}