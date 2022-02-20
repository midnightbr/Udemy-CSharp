using System;

namespace CriandoExcecoesPersonalizadas.Entities.Exceptions {
    public class DomainException : ApplicationException {
        public DomainException(string message) : base(message) {
        }
    }
}
