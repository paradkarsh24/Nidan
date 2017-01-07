using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using Nidan.Entity;
using Nidan.Entity.Dto;


namespace Nidan.Data.Interfaces
{
    public interface INidanDataService
    {

        // Create
        AbsenceType CreateAbsenceType(int organisationId, AbsenceType absenceType);
        Personnel CreatePersonnel(int organisationId, Personnel personnel);
        T Create<T>(int organisationId, T t) where T : class;
        void Create<T>(int organisationId, IEnumerable<T> t) where T : class;

        // Retrieve
        AbsenceType RetrieveAbsenceType(int organisationId, int absenceTypeId, Expression<Func<AbsenceType, bool>> predicate);
        PagedResult<AbsenceType> RetrieveAbsenceTypes(int organisationId, Expression<Func<AbsenceType, bool>> predicate, List<OrderBy> orderBy = null, Paging paging = null);
        IEnumerable<Colour> RetrieveColours(Expression<Func<Colour, bool>> predicate);
        IEnumerable<Host> RetrieveHosts();
        IEnumerable<Organisation> RetrieveOrganisations();
        Personnel RetrievePersonnel(int organisationId, int personnelId, Expression<Func<Personnel, bool>> predicate);
        IEnumerable<Personnel> RetrievePersonnel(int organisationId, IEnumerable<int> companyIds, IEnumerable<int> departmentIds, IEnumerable<int> divisionIds);
        PagedResult<Personnel> RetrievePersonnel(int organisationId, Expression<Func<Personnel, bool>> predicate, List<OrderBy> orderBy = null, Paging paging = null);
        UserAuthorisationFilter RetrieveUserAuthorisation(string aspNetUserId);
        PagedResult<PersonnelSearchField> RetrievePersonnelBySearchKeyword(int organisationId, string searchKeyword, List<OrderBy> orderBy = null, Paging paging = null);
        List<T> Retrieve<T>(int organisationId, Expression<Func<T, bool>> predicate) where T : class;
        bool PersonnelEmploymentHasAbsences(int organisationId, int personnelId, int employmentId);

        // Update
        
        T UpdateEntityEntry<T>(T t) where T : class;
        T UpdateOrganisationEntityEntry<T>(int organisationId, T t) where T : class;
        // Delete
        void Delete<T>(int organisationId, Expression<Func<T, bool>> predicate) where T : class;
    }
}
