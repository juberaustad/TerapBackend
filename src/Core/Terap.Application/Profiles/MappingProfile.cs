using AutoMapper;
using Terap.Application.Features.Categories.Commands.CreateCategory;
using Terap.Application.Features.Categories.Commands.StoredProcedure;
using Terap.Application.Features.Categories.Queries.GetCategoriesList;
using Terap.Application.Features.Categories.Queries.GetCategoriesListWithEvents;
using Terap.Application.Features.Events.Commands.CreateEvent;
using Terap.Application.Features.Events.Commands.Transaction;
using Terap.Application.Features.Events.Commands.UpdateEvent;
using Terap.Application.Features.Events.Queries.GetEventDetail;
using Terap.Application.Features.Events.Queries.GetEventsExport;
using Terap.Application.Features.Events.Queries.GetEventsList;
using Terap.Application.Features.Orders.GetOrdersForMonth;
using Terap.Domain.Entities;

namespace Terap.Application.Profiles
{
    public class MappingProfile: Profile
    {
        public MappingProfile()
        {          
            CreateMap<Event, CreateEventCommand>().ReverseMap();
            CreateMap<Event, TransactionCommand>().ReverseMap();
            CreateMap<Event, UpdateEventCommand>().ReverseMap();
            CreateMap<Event, EventDetailVm>().ReverseMap();
            CreateMap<Event, CategoryEventDto>().ReverseMap();
            CreateMap<Event, EventExportDto>().ReverseMap();

            CreateMap<Category, CategoryDto>();
            CreateMap<Category, CategoryListVm>();
            CreateMap<Category, CategoryEventListVm>();
            CreateMap<Category, CreateCategoryCommand>();
            CreateMap<Category, CreateCategoryDto>();
            CreateMap<Category, StoredProcedureCommand>();
            CreateMap<Category, StoredProcedureDto>();

            CreateMap<Order, OrdersForMonthDto>();

            CreateMap<Event, EventListVm>().ConvertUsing<EventVmCustomMapper>();
        }
    }
}
