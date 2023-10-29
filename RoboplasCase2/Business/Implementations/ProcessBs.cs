using Business.CustomExceptions;
using Business.Interfaces;
using DataAccess.Interfaces;
using Model.Model;

namespace Business.Implementations
{
    public class ProcessBs : IProcessBs
    {
        private readonly IProcessRepository _repo;

        public ProcessBs(IProcessRepository repo)
        {
            _repo = repo;
        }

        public double Process(Process pr)
        {
            if (pr.NumberOne == null)
                throw new BadRequestException("Sayı 1 boş geçilemez!");
            if (pr.NumberTwo == null)
                throw new BadRequestException("Sayı 2 boş geçilemez!");
            if (pr.ProcessType == null)
                throw new BadRequestException("İşlem tipi boş geçilemez!");
            var result = _repo.Process(pr);

            return result;
        }
    }
}
