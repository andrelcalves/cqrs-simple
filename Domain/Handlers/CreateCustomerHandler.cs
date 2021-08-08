using System;
using CQRS.Domain.Commands.Requests;
using CQRS.Domain.Commands.Responses;

namespace CQRS.Domain.Commands.Handlers{

    public class CreateCustomerHandler: ICreateCustomerHandler{

        public CreateCustomerResponse Handle(CreateCustomerRequest){
            // Suas regras de negócio
            // Verifica se o cliente já está cadastrado
            // Valida os dados
            // Inseri o cliente
            // Envia email de boas vindas
            return new CreateCustomerResponse{
                Id = Guid.NewGuid(),
                Name = "André Alves",
                Email = "andrelclalves@gmail.com",
                Date = DateTime.Now()
            }
        }
    } 
}