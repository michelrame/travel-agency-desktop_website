﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TravelExperts
{
    public class PackProdSupplier
    {
        // Class was created to work with rows in Packages Forms
        // Date: Jan 11, 2019
        // Author: Dima Bognen

        //Private variables
        private string product;
        private int productId;
        private string supplier;
        private int supplierId;
        private int prod_SupplierID;

        // Public properties
        public string Product { get; set; }
        public int ProductId { get; set; }
        public string Supplier { get; set; }
        public int SupplierId { get; set; }
        public int Prod_SupplierID { get; set; }

        //class constructor
        public PackProdSupplier(string product, int productId, string supplier, 
                                  int supplierId, int prod_SupplierID)
        {
            this.Product = product;
            this.ProductId = productId;
            this.Supplier = supplier;
            this.SupplierId = supplierId;
            this.Prod_SupplierID = prod_SupplierID;
        }

        // METHOD WHICH BUILDS LIST OF SUPPLIER-ID PAIRS
        public static List<Supplier> createSupplierIdPairsList(int prodID)
        {
            List<Supplier> list = null;
            list = SupplierDB.supplierIdPairsList(prodID);
            return list;
        }

        //METHOD WHICH RETURNS STRING
        public string PackProdSupplierToString() {
            return Product + "," + ProductId.ToString() + ","+ Supplier+","+ SupplierId.ToString()+"," 
                   + Prod_SupplierID.ToString();
        }

    } // end of class
} // end of namespase
