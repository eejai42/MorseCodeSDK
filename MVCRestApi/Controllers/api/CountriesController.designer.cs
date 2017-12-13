using MorseCodeSDK.Lib.SqlDataManagement;
using MorseCodeSDK.Lib.DataClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web;

namespace WebApplication1.Areas.RESTApi.Controllers
{
    public partial class CountriesController : ApiController
    {
        public SqlDataManager SDM { get; }

        partial void OnConstructor();
        partial void OnBeforeGet();
        partial void OnAfterGet(IEnumerable<Country> Countries);
        partial void OnAfterGetById(Country Countries, Guid countryId);
        partial void OnBeforePost(Country country);
        partial void OnAfterPost(Country country);
        partial void OnBeforePut(Country country);
        partial void OnAfterPut(Country country);
        partial void OnBeforeDelete(Country country);
        partial void OnAfterDelete(Country country);
        

        public CountriesController()
        {
            this.SDM = new SqlDataManager();
            this.OnConstructor();
        }
        // GET api/Country
        public IEnumerable<Country> Get()
        {
            this.OnBeforeGet();
            var results = this.SDM.GetAllCountries<Country>();
            Country.CheckExpand(this.SDM, results, HttpContext.Current.Request["expand"]);
            this.OnAfterGet(results);
            return results;
        }

        // GET api/Countries/{country-guid}
        public Country Get(Guid countryId)
        {
            var CountriesWhere = String.Format("CountryId = '{0}'", countryId);
            var result = this.SDM.GetAllCountries<Country>(CountriesWhere).FirstOrDefault();
            this.OnAfterGetById(result, countryId);
            return result;
        }

        // POST api/Countries/{country-guid}
        public Country Post([FromBody]Country country)
        {
            if (country.CountryId == Guid.Empty) country.CountryId = Guid.NewGuid();
            this.OnBeforePost(country);
            this.SDM.Upsert(country);
            this.OnAfterPost(country);
            return country;
        }

        // POST api/Countries/{country-guid}
        public Country Put([FromBody]Country country)
        {
            if (country.CountryId == Guid.Empty) country.CountryId = Guid.NewGuid();
            this.OnBeforePut(country);
            this.SDM.Upsert(country);
            this.OnAfterPut(country);
            return country;
        }

        // POST api/Countries/{country-guid}
        public void Delete(Guid countryId)
        {
            var countryWhere = String.Format("CountryId = '{0}'", countryId);
            var country = this.SDM.GetAllCountries<Country>(countryWhere).FirstOrDefault();
            this.OnBeforeDelete(country);
            this.SDM.Delete(country);
            this.OnAfterDelete(country);
        }
    }
}
