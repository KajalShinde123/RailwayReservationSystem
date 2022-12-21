using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RailwayReservationMVC.Models.DAL
{
    public interface IRailwayRepository<T> where T : class
    {
        IEnumerable<T> GetModel();

        T GetModelByID(int ModelId);

        void InsertModel(T model);

        void UpdateModel(T model);
        void DeleteModel(int ModelId);
        void DeleteModel1(string PNR);
        void Save();
        void DeleteModel1(int ModelId);
    }
}
