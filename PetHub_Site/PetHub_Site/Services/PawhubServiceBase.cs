using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using cabinet.patterns.interfaces;
using cabinet.patterns.clases;

namespace PetHub_Site.Services
{
    public abstract class PawhubServiceBase<T>: ICrossValidation
    {
        public bool _succeed;
        public List<CrossValidationMessage> _validationMessages;

        protected abstract IRepository<T> Repository { get; }

        public bool AddValidationMessage(cabinet.patterns.enums.enumMessageType MessageType, string Message)
        {
            CrossValidationMessage crossValidationMessage = new CrossValidationMessage
            {
                Message = Message,
                MessageType = MessageType
            };
            _validationMessages.Add(crossValidationMessage);
            return true;
        }

        public bool AddValidationMessage(int ValidationCode)
        {
            CrossValidationMessage crossValidationMessage = new CrossValidationMessage
            {
                ValidationCode = ValidationCode
            };
            _validationMessages.Add(crossValidationMessage);
            return true;
        }

        public bool Succeed
        {
            get
            {
                return _succeed;
            }
            set
            {
                _succeed = value;
            }
        }

        public List<CrossValidationMessage> ValidationMessages
        {
            get
            {
                if (_validationMessages == null)
                {
                    _validationMessages = new List<CrossValidationMessage>();
                }
                return _validationMessages;
            }
            set
            {
                _validationMessages = value;
            }
        }
    }
}