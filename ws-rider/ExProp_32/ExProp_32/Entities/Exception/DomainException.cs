using System;

namespace ExProp_32.Entities.Exception {
    public class DomainException : ApplicationException{
        public DomainException(String message) : base(message) {
        }
    }
}
