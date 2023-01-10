using DA.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DA.Providers
{
    public class TestProvider
    {
        public async Task<IEnumerable<Alphabetical_list_of_products>> LeerProductos()
        {
            try
            {
                using (NorthwindEntities context = new NorthwindEntities())
                {
                    return await context.Alphabetical_list_of_products.ToListAsync();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
