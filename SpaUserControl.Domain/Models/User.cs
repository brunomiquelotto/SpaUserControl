
using SpaUserControl.Common.Validation;
using System;

namespace SpaUserControl.Domain.Models
{
    public class User
    {
        public Guid Id { get; private set; }
        public string Name { get; private set; }
        public string Email { get; private set; }
        public string Password { get; private set; }

        protected User()
        {

        }

        public User(string name, string email)
        {
            AssertionConcern.AssertArgumentNotEmpty(name, "Nome não pode ser vazio.");
            AssertionConcern.AssertArgumentNotEmpty(email, "E-mail não pode ser vazio.");
            
            this.Id = Guid.NewGuid();
            this.Name = name;
            this.Email = email;
        }

        public void SetPassword(string password, string confirmation)
        {
            AssertionConcern.AssertArgumentNotEmpty(password, "Senha não pode ser vazia");
            AssertionConcern.AssertArgumentEquals(confirmation, password, "Senha e confirmação de senha são diferentes");
            AssertionConcern.AssertArgumentLength(password, 6, 20, "Senha inválida");
            this.Password = password;
        }

        public string ResetPassoword()
        {
            string pass = Guid.NewGuid().ToString();
            this.Password = pass;
            return pass;
        }
        
        public void Validate()
        {
        }
    }
}
