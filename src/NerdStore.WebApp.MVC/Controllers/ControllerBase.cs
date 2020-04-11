using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using NerdStore.Core.Communication.Mediator;
using NerdStore.Core.Messages.CommonMessages.Notifications;

namespace NerdStore.WebApp.MVC.Controllers
{
    public abstract class ControllerBase : Controller
    {
        private readonly DomainNotificationHandler _notifications;
        private readonly IMediatorHandler _mediatorHandler;
        
        protected Guid ClienteId = Guid.Parse("7c0e3bc3-7937-4202-8832-b2bd59c3637d");

        protected ControllerBase(INotificationHandler<DomainNotification> notifications, IMediatorHandler mediatorHandler)
        {
            _notifications = (DomainNotificationHandler) notifications;
            _mediatorHandler = mediatorHandler;
        }

        protected bool OperacaoValida()
        {
            return !_notifications.TemNotificacao();
        }

        protected IEnumerable<string> ObterMensagensErro()
        {
            return _notifications.ObterNotificacoes().Select(c => c.Value).ToList();
        }
        
        protected void NotificarErro(string codigo, string message)
        {
            _mediatorHandler.PublicarNotificacao(new DomainNotification(codigo, message));
        }
    }
}