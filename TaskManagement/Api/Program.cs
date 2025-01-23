using Domain.Entities;
using Infra.Repository;
using System;

class Program
{
    static void Main()
    {
        using (var context = new DatabaseContext())
        {
            var userRepo = new UserRepository(context);
            userRepo.InsertUser(new User { UserName = "João", Email = "joao@email.com" });
            Console.WriteLine("Usuário inserido com sucesso!");
        }
    }
}
