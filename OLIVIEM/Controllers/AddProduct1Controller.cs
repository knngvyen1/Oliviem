using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Logic;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Oliviem.Utils;
using OLIVIEM.Models;
using OLIVIEM.Viewmodel;

namespace OLIVIEM.Controllers
{
    public class AddProduct1Controller : Controller
    {
        private Productlogic productlogic;
        private CloudinaryUtil cloudinaryUtil;
        public AddProduct1Controller()
        {
            productlogic = Factory.Factory.GetProductslogic();
            cloudinaryUtil = new CloudinaryUtil();
        }
        public IActionResult Index()
        {
            return View();
        }


        [HttpGet]
        public IActionResult AllProducts(Productviewmodel viewmodel)
        {
            return View();
        }

        //[HttpGet]
        //public IActionResult AddProduct()
        //{
        //    return View();
        //}

        
        public IActionResult AddProduct(Productviewmodel viewmodel)
        {
            viewmodel.Message = "Product added";

            //var filePath = Path.GetTempFileName();
            //IFormFile kek = null;
            //using (var stream = new FileStream(filePath, FileMode.Create))
            //{
            //    kek.CopyTo(stream);
            //}

            //Photo test = cloudinaryUtil.UploadPicture(filePath, "test");
            try
            {
                productlogic.Addproduct(new Product(viewmodel.Name, viewmodel.Size, viewmodel.Color, viewmodel.Price, viewmodel.Quantity));
            }
            catch (Exception e)
            {

                viewmodel.Message = e.Message;
            }
            return View(viewmodel);
        }

    }
}