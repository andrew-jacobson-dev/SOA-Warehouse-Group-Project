﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Warehouse_Prj.BDO;
using Warehouse_Prj.DAL.CRUD;

namespace Warehouse_Prj.DAL
{
    /// <summary>
    /// MSCS 6931 Topics in Math Sts, & Comp Sci
    /// Service Oriented Architecture (SOA)
    /// Spring 2019
    /// Andrew Jacobson
    /// 
    /// Description: Data Access Object class for Products
    /// </summary>
    public class Product_DAO
    {
        //Given a Product_BDO object, add to Products table
        //Returns a boolean
        public bool Create_Product(ref Product_BDO product_BDO, ref string message)
        {
            bool ret = false;

            //Create new DTO object for Product query
            DataModel.Product product_DTO = new DataModel.Product();

            //Translate BDO to DTO for Product_Qs
            product_DTO.Product_Name = product_BDO.Product_Name;
            product_DTO.Product_UPC = product_BDO.Product_UPC;
            product_DTO.Product_Price = product_BDO.Product_Price;
            product_DTO.CategoryRefID = product_BDO.CategoryRefID;

            //Call Product_Qs.Create
            Product_Qs product_Create_Query = new Product_Qs();
            ret = product_Create_Query.Create(product_DTO, ref message);

            return ret;
        }

        //Given an ID, delete Product from Products table
        //Returns a boolean
        public bool Delete_Product_By_ID(int product_ID, ref string message)
        {
            var ret = false;

            //Call Product_Qs.Delete_Product_By_ID
            Product_Qs product_Query = new Product_Qs();
            ret = product_Query.Delete_Product_By_ID(product_ID, ref message);

            return ret;
        }

        //Given a UPC code, delete Product from Products table
        //Returns a boolean
        public bool Delete_Product_By_UPC(long product_UPC, ref string message)
        {
            var ret = false;

            //Call Product_Qs.Delete_Product_By_UPC
            Product_Qs product_Query = new Product_Qs();
            ret = product_Query.Delete_Product_By_UPC(product_UPC, ref message);

            return ret;
        }

        //Given an ID, fetch Product from Products table
        //Returns a Product_BDO object
        public Product_BDO Get_Product_By_ID(int product_ID)
        {
            //Create Product_BDO object
            Product_BDO product_BDO = new Product_BDO();

            //Create new DTO object for Product query result
            DataModel.Product product_DTO_Result = new DataModel.Product();

            //Call Product_Qs.Get_Product_By_ID
            Product_Qs product_Query = new Product_Qs();
            product_DTO_Result = product_Query.Get_Product_By_ID(product_ID);

            //If Product is found, translate to BDO object
            if(product_DTO_Result.Product_ID != 0)
            {
                product_BDO.Product_ID = product_DTO_Result.Product_ID;
                product_BDO.Product_Name = product_DTO_Result.Product_Name;
                product_BDO.Product_UPC = product_DTO_Result.Product_UPC;
                product_BDO.Product_Price = product_DTO_Result.Product_Price;
                product_BDO.CategoryRefID = product_DTO_Result.CategoryRefID;
            }

            return product_BDO;
        }

        //Given a UPC code, fetch Product from Products table
        //Returns a Product_BDO object
        public Product_BDO Get_Product_By_UPC(long product_UPC)
        {
            //Create Product_BDO object
            Product_BDO product_BDO = new Product_BDO();

            //Create new DTO object for Product query result
            DataModel.Product product_DTO_Result = new DataModel.Product();

            //Call Product_Qs.Get_Product_By_UPC
            Product_Qs product_Query = new Product_Qs();
            product_DTO_Result = product_Query.Get_Product_By_UPC(product_UPC);

            //If Product is found, translate to BDO object
            if (product_DTO_Result.Product_ID != 0)
            {
                product_BDO.Product_ID = product_DTO_Result.Product_ID;
                product_BDO.Product_Name = product_DTO_Result.Product_Name;
                product_BDO.Product_UPC = product_DTO_Result.Product_UPC;
                product_BDO.Product_Price = product_DTO_Result.Product_Price;
                product_BDO.CategoryRefID = product_DTO_Result.CategoryRefID;
            }

            return product_BDO;
        }

        //Given a Product_BDO object, update the Products table on Product_ID
        //Returns a boolean
        public bool Update_Product_By_ID(ref Product_BDO product_BDO)
        { 
            var ret = false;

            //Create new DTO object for Product query
            DataModel.Product product_DTO = new DataModel.Product();

            //Translate BDO to DTO for Product_Qs
            product_DTO.Product_ID = product_BDO.Product_ID;
            product_DTO.Product_Name = product_BDO.Product_Name;
            product_DTO.Product_UPC = product_BDO.Product_UPC;
            product_DTO.Product_Price = product_BDO.Product_Price;
            product_DTO.CategoryRefID = product_BDO.CategoryRefID;

            //Call Product_Qs.Update
            Product_Qs product_Update_Query = new Product_Qs();
            ret = product_Update_Query.Update_Product_By_Product_ID(product_DTO);

            return ret;
        }
    }
}
