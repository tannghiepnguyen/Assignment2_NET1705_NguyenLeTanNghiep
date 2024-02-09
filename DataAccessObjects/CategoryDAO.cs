﻿using BusinessObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessObjects
{
    public class CategoryDAO
    {
        #region
        private static CategoryDAO? instance = null;
        private static readonly object instanceLock = new object();
        private CategoryDAO() { }
        public static CategoryDAO Instance
        {
            get
            {
                lock (instanceLock)
                {
                    if (instance == null)
                    {
                        instance = new CategoryDAO();
                    }
                    return instance;
                }
            }
        }
        #endregion

        public List<Category> GetAllCategory()
        {
            List<Category> categoryList = new List<Category>();
            try
            {
                using (FUFlowerBouquetManagementV4Context context = new FUFlowerBouquetManagementV4Context())
                {
                    categoryList = context.Categories.ToList();
                    return categoryList;
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            
        }
    }
}