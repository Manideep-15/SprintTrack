using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SprintTrack.Core.Entities
{
    public class Project
    {
        public Guid Id { get; private set; }
        public string Title { get; private set; }
        public DateTime StartDate { get; private set; }
        public DateTime EndDate { get; private set; }

        public Project(string title, DateTime startDate, DateTime endDate)
        {
            if (string.IsNullOrWhiteSpace(title))
                throw new ArgumentException("Title cannot be empty.");

            if (endDate <= startDate)
                throw new ArgumentException("End date must be after start date.");

            Id = Guid.NewGuid();
            Title = title;                    // title must not be empty
            StartDate = startDate;            // end date must be after start date
            EndDate = endDate;
        }
    }
}

