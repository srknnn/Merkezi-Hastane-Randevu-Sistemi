using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_Access_Layer
{
    interface IDATAMapper<TEntity, TKey>
    {
        int Insert(TEntity item);

        int Update(TEntity item);

        int Delete(TEntity item);

        List<TEntity> GetCityAll();
        List<TEntity> GetTownAll(TKey cityid);
        List<TEntity> GetHospitalAll(TKey cityid,TKey townid);
        List<TEntity> GetClinicAll(TKey cityid,TKey townid,TKey hospitalid);
        List<TEntity> GetDoctorAll(TKey cityid, TKey townid, TKey hospitalid,TKey clinicid);


        TEntity GetTown(TKey id);

        TEntity GetClinic(TKey id);


        TEntity GetHospital(TKey id);

        TEntity GetDoctor(TKey id);



    }
}
