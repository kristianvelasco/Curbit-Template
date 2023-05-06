using Microsoft.EntityFrameworkCore.Storage;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Order.Infrastructure.Repositories.Interfaces;
using OrderFunction.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace OrderFunction.Services;

public class OrderService : IOrderService
{
    private readonly IServiceProvider _serviceProvider;
    private readonly IOrderRepository _orderRepository;

    public OrderService(IServiceProvider serviceProvider, IOrderRepository orderRepository)
    {
        _serviceProvider = serviceProvider ?? throw new ArgumentNullException(nameof(serviceProvider));
        _orderRepository = orderRepository ?? throw new ArgumentNullException(nameof(orderRepository));
    }

    public void Init()
    {

        _orderRepository.AddIfNotExists(new Order.Domain.Models.Order());
        _orderRepository.UnitOfWork.SaveChangesAsync();
    }
}

