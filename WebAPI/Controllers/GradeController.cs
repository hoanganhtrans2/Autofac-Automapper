using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using EF6CodeFirstDemo;
using Repository;
using TransferObject;
using DeviceDbDTO;
using AutoMapper;
using Autofac;

namespace WebAPI.Controllers
{
    public class GradeController : ApiController
    {
        private IGenericRepository<Grade> repository = null;
        private IMapper mapper = null;
        private IContainer container = null;

        public GradeController()
        {
            mapper = ConfigMapper.Config();
            container = AutofacConfig.Confing();
            repository = container.BeginLifetimeScope().Resolve<IGenericRepository<Grade>>();
        }
        public IHttpActionResult GetAllGrade()
        {
            IEnumerable<Grade> listGrade = repository.GetAll();
            IEnumerable<GradeDTO> gradeDTOs = mapper.Map<IEnumerable<Grade>, IEnumerable<GradeDTO>>(listGrade);
            return Ok(gradeDTOs);
        }
        public IHttpActionResult PutGrade(GradeDTO gradeDTO)
        {
            try
            {
                Grade grade = mapper.Map<Grade>(gradeDTO);
                repository.Update(grade);
                repository.Save();
            }
            catch (Exception e)
            {

                return Ok(e);
            }

            return Ok();

        }
    }
}
