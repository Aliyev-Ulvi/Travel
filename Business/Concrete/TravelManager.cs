using Business.Abstract;
using Business.Validation.FluentValidation;
using Core.Helpers.Result.Abstract;
using Core.Helpers.Result.Concrete;
using Core.Validation.FluentValidation;
using DataAccess.EF.Abstract;
using Entities.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class TravelManager(ITravelDal travelDal) : ITravelService
    {
        private readonly ITravelDal _travelDal = travelDal;

        public IResult Add(Travel travel)
        {
            ValidationTool<Travel>.Validation(new TravelValidator(), travel);

                _travelDal.Add(travel);

                return new SuccessResult("Travel added successfully");
        }

        public IResult Delete(int id)
        {
            Travel deletedTravel = _travelDal.GetAll(t => t.IsDeleted == false).SingleOrDefault(t => t.Id == id);

            if (deletedTravel != null)
            {
                deletedTravel.IsDeleted = true;
                _travelDal.Delete(deletedTravel);
                return new SuccessResult("Travel deleted successfully");
            }
            else
                return new ErrorResult("Travel was not found");
        }

        public IDataResult<List<Travel>> GetAllTravels()
        {
            var products = _travelDal.GetAll(t => t.IsDeleted == false);

            if (products.Count != 0)
                return new SuccessDataResult<List<Travel>>(products, "Travels loaded");
            else
                return new ErrorDataResult<List<Travel>>(products, "List of travels is empty");
        }

        public IDataResult<Travel> GetTravel(int id)
        {
            Travel getTravel = _travelDal.Get(t => t.Id == id);

            if (getTravel != null)
                return new SuccessDataResult<Travel>(getTravel, "Travel loaded");
            else
                return new ErrorDataResult<Travel>(getTravel, "Travel was not found");
        }

        public IResult Update(int id)
        {
            Travel updatedTravel = _travelDal.GetAll(t => t.IsDeleted == false).SingleOrDefault(t => t.Id == id);

            if (updatedTravel != null)
            {

                _travelDal.Update(updatedTravel);
                return new SuccessResult("Travel updated succesfully");
            }
            else
                return new ErrorResult("Travel was not found");
        }
    }
}
