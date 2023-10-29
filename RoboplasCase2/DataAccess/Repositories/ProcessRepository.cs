using DataAccess.Interfaces;
using Model.Model;

namespace DataAccess.Repositories
{
    public class ProcessRepository : IProcessRepository
    {
        public double Process(Process pr)
        {
            switch (pr.ProcessType)
            {
                case 1:
                    pr.Result = pr.NumberOne.Value + pr.NumberTwo.Value;
                    break;
                case 2:
                    pr.Result = pr.NumberOne.Value - pr.NumberTwo.Value;
                    break;
                case 3:
                    pr.Result = pr.NumberOne.Value * pr.NumberTwo.Value;
                    break;
                case 4:
                    pr.Result = pr.NumberOne.Value / pr.NumberTwo.Value;
                    break;
            }
            return pr.Result;
        }
    }
}
