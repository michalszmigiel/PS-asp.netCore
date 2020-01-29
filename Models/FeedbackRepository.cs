using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PS.Models
{
    public class FeedbackRepository : IFeedbackRepository
    {
        private readonly PSDbContext _psDbContext;

        public FeedbackRepository(PSDbContext psDbContext)
        {
            _psDbContext = psDbContext;
        }

        public void AddFeedback(Feedback feedback)
        {
            _psDbContext.Feedbacks.Add(feedback);
            _psDbContext.SaveChanges();
        }
    }
}
