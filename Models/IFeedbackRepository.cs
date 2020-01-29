using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PS.Models
{
    interface IFeedbackRepository
    {
        void AddFeedback(Feedback feedback);
    }
}
