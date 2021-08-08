using CQRS.Domain.Commands.Responses;
using CQRS.Domain.Commands.Requests;

namespace CQRS.Domain.Commands.Handlers{

    public interface ICreateCustomerHandler{
        CreateCustomerResponse Handle(CreateCustomerRequest); 
    } 
}