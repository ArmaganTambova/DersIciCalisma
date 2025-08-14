using Newtonsoft.Json;
using NorthWNDapp.API.Models.DTOS;
using NorthWNDapp.Domain.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace NorthWNDapp.API.API
{
    public class CategoryController : ApiController
    {
        NorthwindEntities DB = new NorthwindEntities();

        // GET: api/Category

        //public string Get()
        //{
        //    List<CategoriesDTO> categories = new List<CategoriesDTO>();
        //    List<Categories> DBcategories = DB.Categories.ToList();

        //    foreach (Categories item in DBcategories)
        //    {
        //        categories.Add(new CategoriesDTO() { CategoryID = item.CategoryID, CategoryName = item.CategoryName, Description = item.Description });
        //    }

        //    return JsonConvert.SerializeObject(categories);
        //}

        //************************************************************************************

        public IHttpActionResult Get()
        {
            return Ok(DB.Categories.Select(X => new { id = X.CategoryID, name = X.CategoryName, description = X.Description }));
        }

        //************************************************************************************

        //public IHttpActionResult Get()
        //{
        //    List<Categories> DBCategories = DB.Categories.ToList();
        //    return Ok(DBCategories.Select(X => new CategoriesDTO() { CategoryID = X.CategoryID, CategoryName = X.CategoryName, Description = X.Description }));
        //}

        // GET: api/Category/5
        public IHttpActionResult Get(int id)
        {
            Categories category = DB.Categories.FirstOrDefault(X => X.CategoryID == id);
            if (category != null)
            {
                return Ok(new CategoriesDTO() { CategoryID = category.CategoryID, CategoryName = category.CategoryName, Description = category.Description });
            }
            else
            {
                return NotFound();
            }
        }

        // POST: api/Category
        public IHttpActionResult Post(string name, string description)
        {
            if (!string.IsNullOrEmpty(name))
            {
                Categories category = new Categories() { CategoryName = name, Description = description };
                DB.Categories.Add(category);
                DB.SaveChanges();

                return Created(new Uri(Request.RequestUri + "/" + category.CategoryID), category.CategoryID);
            }
            else
            {
                return BadRequest("Category name cannot be empty.");
            }
        }

        // PUT: api/Category/5
        public void Put(int id, string name, string description)
        {
            Categories category = DB.Categories.Find(id);
            category.CategoryName = name;
            category.Description = description;
            DB.SaveChanges();
        }

        // DELETE: api/Category/5
        public void Delete(int id)
        {
            Categories category =  DB.Categories.Find(id);
            DB.Categories.Remove(category);
            DB.SaveChanges();
        }
    }
}
