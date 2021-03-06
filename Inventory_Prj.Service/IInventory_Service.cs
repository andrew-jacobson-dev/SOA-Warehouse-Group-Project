﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;


namespace Inventory_Prj.Service
{
    /// <summary>
    /// MSCS 6931 Topics in Math Sts, & Comp Sci
    /// Service Oriented Architecture (SOA)
    /// Spring 2019
    /// Eyad Aldawod, Omar Waller, Andrew Jacobson
    /// 
    /// Description: Interface for Inventory service. This file contains Operation Contract and Data Contract.
    /// </summary>
   [ServiceContract]
    public interface IInventory_Service
    {
        [OperationContract]
        bool Create_Inventory(Inventory inventory, ref string msg);

        [OperationContract]
        List<Inventory> Get_Inventories_By_Warehouse_Name(string Warehouse_Name, ref string msg);
      
    }

   [DataContract]
    public class Inventory
    {

        [DataMember]
        public int Inventory_ID { get; set; }

        [DataMember]
        public int Product_Quantity { get; set; }

        [DataMember]
        public int Product_ID { get; set; }

        [DataMember]
        public int Warehouse_ID { get; set; }
    }
}
