using ProductTemplate.Models;
using ProductTemplate.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace ProductTemplate.Controllers.Api
{
    [RoutePrefix("api/products")]
    public class ProductsApiController : ApiController
    {
        private readonly ProductRepository productRepository;
        public ProductsApiController()
        {
            productRepository = new ProductRepository();

        }        

       [Route("productlist")]
       [HttpGet]
        public HttpResponseMessage ProductList()
        {
            try
            {
                var products = productRepository.Getproducts();
               
                return Request.CreateResponse<IEnumerable<Products>>(HttpStatusCode.OK, products);
            }
            catch (Exception message)
            {
                return this.Request.CreateResponse(HttpStatusCode.InternalServerError, message.Message);

            }
        }
    }
}
