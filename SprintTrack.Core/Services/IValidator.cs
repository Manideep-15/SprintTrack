using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SprintTrack.Core.Services
{
    public interface IValidator<T>
    {
        bool IsValid(T entity);
        void Validate(Entities.Task task);
    }
}

