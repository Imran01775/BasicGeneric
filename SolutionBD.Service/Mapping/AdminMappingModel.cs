using SolutionBD.Domain.DTOs;
using SolutionBD.Domain.Entity;
using SolutionBD.Domain.ViewModel;
using System;
using System.Collections.Generic;
using System.Text;

namespace SolutionBD.Service.Mapping
{
    public static class AdminMappingModel
    {
        //add
        public static AdminModel MapToEntity(this AdminModelCreate source)
        {
            var entityData = new AdminModel();

            entityData.FirstName = source.FirstName;
            entityData.LastName = source.LastName;
            entityData.Mobile = source.Mobile;
            entityData.Email = source.Email;
            entityData.Address = source.Address;
            entityData.RoleCD = source.RoleCD;
            entityData.UserID = source.UserID;
            entityData.AlternativeMobile = source.AlternativeMobile;
            entityData.Password = source.Password;
            entityData.CreatedDate = DateTime.Now;

            return entityData;
        }
        //update
        public static AdminModel MapToEntity(this AdminModelUpdate source)
        {
            var entityData = new AdminModel();
            entityData.FirstName = source.FirstName;
            entityData.LastName = source.LastName;
            entityData.Mobile = source.Mobile;
            entityData.Email = source.Email;
            entityData.Address = source.Address;
            entityData.AlternativeMobile = source.AlternativeMobile;
            entityData.UpdatedDate = DateTime.Now;
            return entityData;
        }
        //view
        public static AdminViewModel MapToEntity(this AdminModel source)
        {
            var entityData = new AdminViewModel();
            entityData.FirstName = source.FirstName;
            entityData.LastName = source.LastName;
            entityData.Mobile = source.Mobile;
            entityData.Email = source.Email;
            entityData.Address = source.Address;
            entityData.UserID = source.UserID;
            entityData.AlternativeMobile = source.AlternativeMobile;
            entityData.CreatedDate = DateTime.Now;
            return entityData;
        }
    }
}
