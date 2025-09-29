using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SprintTrack.Core.Services
{
    public class GuidIdGenerator : IIdGenerator
    {
        public Guid GenerateId() => Guid.NewGuid();
    }
}

