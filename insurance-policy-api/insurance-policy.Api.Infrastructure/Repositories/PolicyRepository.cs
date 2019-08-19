using insurance_policy.Api.Infrastructure.Data;
using insurance_policy.Api.Infrastructure.interfaces;
using insurance_policy.Api.Infrastructure.Tables;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace insurance_policy.Api.Infrastructure.Repositories
{
    public class PolicyRepository : EntityBaseRepository<Assigment>, IPolicyRepository
    {
        public PolicyRepository(InsuranceContext context) : base(context)
        {

        }

        public List<Assigment> GetAssigment()
        {
            StringBuilder sqlQuery = new StringBuilder();

            sqlQuery.Append(" SELECT a.IdCliente Id,c.[Name], c.Phone , count(1) Number");
            sqlQuery.Append(" FROM Assigment a inner join clients c on a.IdCliente=c.Idclient  ");
            sqlQuery.Append(" group by a.IdCliente,c.[Name], c.Phone");

            var Assigment = this.Context.Assigment.FromSql(sqlQuery.ToString()).AsNoTracking().ToList();

            return Assigment;
        }


        public List<Assigment> AddAssigment()
        {
            StringBuilder sqlQuery = new StringBuilder();

            sqlQuery.Append(" INSERT a.IdCliente Id,c.[Name], c.Phone , count(1) Number");
            sqlQuery.Append(" FROM Assigment a inner join clients c on a.IdCliente=c.Idclient  ");
            sqlQuery.Append(" group by a.IdCliente,c.[Name], c.Phone");

            //PolicyRepository.Add(Assigment);
            //PolicyRepository.Commit();

            var Assigment = this.Context.Assigment.FromSql(sqlQuery.ToString()).AsNoTracking().ToList();

            return Assigment;
        }


        public List<AssigmentDetail> GetAssigmentDetail(int id)
        {
            StringBuilder sqlQuery = new StringBuilder();

            sqlQuery.Append(" select p.IdPolicy Id,p.Name,p.Description,p.Type,co.[percent], a.StartDate, a.Duration, p.Cost, p.Risk");
            sqlQuery.Append(" from Assigment a  ");
            sqlQuery.Append(" inner join clients c on a.IdCliente=c.Idclient");
            sqlQuery.Append(" inner join Policy p on a.IdPolicy = p.IdPolicy");
            sqlQuery.Append(" inner join Cover co on p.Type = co.type");
            sqlQuery.Append(" where c.Idclient = {0}");

            var AssigmentDetail = this.Context.AssigmentDetail.FromSql(sqlQuery.ToString(), id.ToString()).AsNoTracking().ToList();
           
            return AssigmentDetail;
        }

    }
}
