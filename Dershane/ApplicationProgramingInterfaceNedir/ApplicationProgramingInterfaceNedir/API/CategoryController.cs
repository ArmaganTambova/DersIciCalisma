using ApplicationProgramingInterfaceNedir.API.APIModel;
using ApplicationProgramingInterfaceNedir.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace ApplicationProgramingInterfaceNedir.API
{
    public class CategoryController : ApiController
    {
        NORTHWNDEntities DB = new NORTHWNDEntities();

        // GET: api/Category
        public IEnumerable<CategoryDTO> Get()
        {
            List<CategoryDTO> categorylist = new List<CategoryDTO>();

            foreach (Categories item in DB.Categories)
            {
                categorylist.Add(new CategoryDTO() { ID = item.CategoryID, Name = item.CategoryName, Picture = item.Picture, Description = item.Description });
            }

            return categorylist;
        }

        // GET: api/Category/5
        public CategoryDTO Get(int id)
        {
            Categories category = DB.Categories.Find(id);

            CategoryDTO DTO = new CategoryDTO();
            DTO.ID = category.CategoryID;
            DTO.Name = category.CategoryName;
            DTO.Description = category.Description;
            DTO.Picture = category.Picture;

            return DTO;
        }

        // POST: api/Category
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/Category/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Category/5
        public void Delete(int id)
        {
        }
    }
}
