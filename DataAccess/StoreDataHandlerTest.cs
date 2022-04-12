using api.Interfaces;
using api.Models;
using System.Collections.Generic;
namespace api.DataAccess
{
    public class StoreDataHandlerTest : IStoreDataHandler
    {
        public List<Store> GetAllStores() {
            List<Store> myStores = new List<Store>();
            myStores.Add(new Store()
                {id = 1,
                    addressLineOne = "123 Dirt Road",
                    addressLineTwo = "",
                    city = "Clanton",
                    state = "Alabama",
                    zip = 35045
                });
            myStores.Add(new Store()
                {id = 1,
                    addressLineOne = "124 Paved Road",
                    addressLineTwo = "",
                    city = "Colleyville",
                    state = "Texas",
                    zip = 76034
                });
            myStores.Add(new Store()
                {id = 1,
                    addressLineOne = "1267 Bumpy Road",
                    addressLineTwo = "Box 1313",
                    city = "Tuscaloosa",
                    state = "Alabama",
                    zip = 35487
                });
            return myStores;
        }
         public Store GetStore(int id) {
            return new Store();
         }
         public void UpdateStore(Store value) {

         }
         public void CreateStore(Store value) {

         }
         public void DeleteStore(int id) {

         }
    }
}