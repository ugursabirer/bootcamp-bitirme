using Core.Entities.Concrete;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Business.Constants
{
    public static class Messages
    {
        public static string ProductAdded = "Product Added";
        public static string ProductNameInvalid = "Product Name Invalid";
        public static string MaintenanceTime = "Maintenance Time";
        public static string ProductsListed = "Products Listed";
        public static string ProductCountOfCategoryError = "A Category Can Have Up To 10 Products";
        public static string ProductNameAlreadyExists = "There Is Already Another Product With This Name";
        public static string CategoryLimitExceeded = "Unable To Add New Product Because Category Limit Has Been Exceeded";
        public static string AuthorizationDenied = "You Are Not Authorized";
        public static string UserRegistered = "Registered";
        public static string UserNotFound = "User Not Found";
        public static string PasswordError = "Wrong Password";
        public static string SuccessfulLogin = "Login Successful";
        public static string UserAlreadyExists = "User Already Exist";
        public static string AccessTokenCreated = "Access Token Created";
    }
}
