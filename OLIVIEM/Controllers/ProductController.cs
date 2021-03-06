﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Logic;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using OLIVIEM.Models;
using OLIVIEM.Viewmodel;
using OLIVIEM.utils;

namespace OLIVIEM.Controllers
{
    public class ProductController : Controller
    {
        private Productlogic productlogic;
        public List<Product> products = new List<Product>();

        public ProductController()
        {
            productlogic = Factory.Factory.GetProductslogic();
        }

        public IActionResult Index(Productviewmodel viewmodel)
        {           
            return View();
        }

        [HttpPost]
        public IActionResult AddProduct(Productviewmodel viewmodel)
        {
            try
            {
                productlogic.Addproduct(new Product(viewmodel.Id, viewmodel.Name, viewmodel.Size, viewmodel.Color, viewmodel.Price, viewmodel.Quantity, viewmodel.Description, viewmodel.CategoryName, viewmodel.Image));
            }
            catch (Exception e)
            {

                viewmodel.Message = e.Message;
            }
            return View(viewmodel);
        }
        [HttpGet]
        public IActionResult AddProduct()
        {
           
            return View();
        }

        [HttpGet]
        public IActionResult AllProducts(Productviewmodel viewmodel)
        {
            viewmodel.Categorylistproducts = productlogic.GetCategoryproducts(viewmodel.CategoryName);
            viewmodel.products = productlogic.GetAllProducts();
            return View(viewmodel);
        }
        [HttpGet]
        public IActionResult GetCategoryproduct(Productviewmodel viewmodel)
        {
            viewmodel.Categorylistproducts = productlogic.GetCategoryproducts(viewmodel.CategoryName);
            return View(viewmodel);
        }

       


        [HttpGet]
        public IActionResult GetProduct(int id)
        {
            Product product = new Product();
            product.Categorylist = productlogic.GetAllCategoryNames();
            return View(productlogic.GetProduct(id));
        }



    }
}