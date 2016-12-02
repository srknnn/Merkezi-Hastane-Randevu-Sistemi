using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    interface IBusiness<TEntity, TKey>
    {
        bool Insert(TEntity item);
        bool Update(TEntity item);
        bool Delete(TEntity item);
       
        TEntity GetTown(TKey id);
        TEntity GetHospital(TKey id);
        TEntity GetClinic(TKey id);
        TEntity GetDoctor(TKey id);

        List<TEntity> GetCityAll();
        List<TEntity> GetTownAll(TKey cityid);
        List<TEntity> GetHospitalAll(TKey cityid, TKey townid);
        List<TEntity> GetClinicAll(TKey cityid, TKey townid, TKey hospitalid);
        List<TEntity> GetDoctorAll(TKey cityid, TKey townid, TKey hospitalid, TKey clinicid);

    
       
       
       
       


    }
}
