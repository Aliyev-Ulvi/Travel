using Core.Helpers.Result.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface ITravelService
    {
        IResult Add(Travel travel);
        IResult Delete(int id);
        IResult Update(int id);

        IDataResult<List<Travel>> GetAllTravels();

        IDataResult<Travel> GetTravel(int id);
    }
}
