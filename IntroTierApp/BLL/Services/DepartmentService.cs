using AutoMapper;
using BLL.DTOs;
using DAL.EF.Tables;
using DAL.Repository;
using System;
using System.Collections.Generic;
using System.Text;

namespace BLL.Services
{
    public class DepartmentService
    {
        DepartmentRepo repo;
        Mapper mapper;
        public DepartmentService(DepartmentRepo repo) { 
            this.repo = repo;
            mapper = MapperConfig.GetMapper();
        }
        public List<DepartmentDTO> GetAll() {
        
            var data = repo.Get(); //List<Department>
       
           
            var res = mapper.Map<List<DepartmentDTO>>(data);
            //convert to DTO
            return res;

        }
        public DepartmentDTO Get(int id) { 
            var data = repo.Get(id);
            
            var res = mapper.Map<DepartmentDTO>(data);
            return res;
        }
    }
}
