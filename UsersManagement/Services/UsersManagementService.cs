using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using UsersManagement.Models;
using System.Configuration;
using System.Net;
using System.Web.Mvc;
using System.IO;


namespace UsersManagement.Services
{
    public class UsersManagementService
    {
        //Db Connection string
        string DBCon = ConfigurationManager.ConnectionStrings["DBCon"].ConnectionString;

        SystemTools _SystemTools = new SystemTools();
        
        //Save use to the database
        public int CreateUser(HttpPostedFileBase file, AddUserModel entity)
        {
            throw new NotImplementedException();
        }

        //View users list
        public List<UsersListModel> UsersList()
        {
            throw new NotImplementedException();
        }

        //Deactivate User
        public int DeactivateActivateUser(UsersListModel model)
        {
            throw new NotImplementedException();
        }

        //View Active users list
        public List<UsersListModel> ActiveUsersList()
        {
            throw new NotImplementedException();
        }

        //View InActive users list
        public List<UsersListModel> InActiveUsersList()
        {
            throw new NotImplementedException();
        }

        //Remove User
        public int RemoveUser(UsersListModel model)
        {
            throw new NotImplementedException();
        }

        //View Archived users list
        public List<UsersListModel> ArchivedUsersList()
        {
            throw new NotImplementedException();
        }

        //View user details list
        public List<EditUserModel> ViewUserDetailsList()
        {
            throw new NotImplementedException();
        }

        //Update user to the database
        public int UpdateUser(HttpPostedFileBase file, EditUserModel entity)
        {
            throw new NotImplementedException();
        }
    }
}