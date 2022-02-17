using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class IndexCalculationModelManager : IIndexCalculationModelService
    {
        IIndexCalculationModelDal _indexCalculationModelDal;

        public IndexCalculationModelManager(IIndexCalculationModelDal ındexCalculationModelDal)
        {
            _indexCalculationModelDal = ındexCalculationModelDal;
        }

        public List<IndexCalculationModel> GetAll()
        {
            return _indexCalculationModelDal.GetAll();
        }

        public IndexCalculationModel GetAllById(int id)
        {
            return _indexCalculationModelDal.Get(i => i.Cid == id);
        }
    }
}
