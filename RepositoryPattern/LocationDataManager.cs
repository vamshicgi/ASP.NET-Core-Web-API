using ASP.NETCoreWebAPI.DTOs;
using ASP.NETCoreWebAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ASP.NETCoreWebAPI.RepositoryPattern
{
    public class LocationDataManager : IDataRepository<Location, LocationDTO>
    {
        private readonly BVK_DataBaseContext _bVK_DataBaseContext;
        public LocationDataManager(BVK_DataBaseContext bVK_DataBaseContext)
        {
            this._bVK_DataBaseContext = bVK_DataBaseContext;
        }
        void IDataRepository<Location, LocationDTO>.Add(Location entity)
        {
            _bVK_DataBaseContext.Locations.Add(entity);
            _bVK_DataBaseContext.SaveChanges();
        }

        void IDataRepository<Location, LocationDTO>.Delete(Location entity)
        {
            _bVK_DataBaseContext.Remove(entity);
            _bVK_DataBaseContext.SaveChanges();
        }

        Location IDataRepository<Location, LocationDTO>.Get(long id)
        {
            return _bVK_DataBaseContext.Locations.Where(e => e.LocationId == id).FirstOrDefault();
        }

        IEnumerable<Location> IDataRepository<Location, LocationDTO>.GetAll()
        {
            return _bVK_DataBaseContext.Locations.ToList();
        }

        LocationDTO IDataRepository<Location, LocationDTO>.GetDto(long id)
        {
            throw new NotImplementedException();
        }

        void IDataRepository<Location, LocationDTO>.Update(Location entityToUpdate, Location entity)
        {
            throw new NotImplementedException();
        }
    }
}
