using System;
using System.Collections.Generic;
using System.Security.Policy;
using Nidan.Business.Models;
using Nidan.Entity;
using Nidan.Entity.Dto;
using System.Linq.Expressions;

namespace Nidan.Business.Interfaces
{
    public interface INidanBusinessService
    {
        //Create
        Personnel CreatePersonnel(int organisationId, Personnel personnel);
        Mobilization CreateMobilization(int organisationId, Mobilization mobilization);


        // Retrieve
        AbsenceType RetrieveAbsenceType(int organisationId, int absenceTypeId);
        PagedResult<AbsenceType> RetrieveAbsenceTypes(int organisationId, List<OrderBy> orderBy, Paging paging);
        IEnumerable<Colour> RetrieveColours();
        Organisation RetrieveOrganisation(int organisationId);
        IAuthorisation RetrieveUserAuthorisation(string aspNetUserId);
        Permissions RetrievePersonnelPermissions(bool isAdmin, int organisationId, int userPersonnelId, int? personnelId = null);
        PagedResult<Personnel> RetrievePersonnel(int organisationId, List<OrderBy> orderBy, Paging paging);
        Personnel RetrievePersonnel(int organisationId, int id);
        PagedResult<PersonnelSearchField> RetrievePersonnelBySearchKeyword(int organisationId, string searchKeyword, List<OrderBy> orderBy = null, Paging paging = null);
        PagedResult<MobilizationSearchField> RetrieveMobilizationBySearchKeyword(int organisationId, string searchKeyword, List<OrderBy> orderBy = null, Paging paging = null);
        Mobilization RetrieveMobilization(int organisationId, int id);
        Permissions RetrieveMobilizationPermissions(bool isAdmin, int organisationId, int userMobilizationId, int? mobilizationId = null);
        PagedResult<Mobilization> RetrieveMobilizations(int organisationId, List<OrderBy> orderBy = null, Paging paging = null);
        Mobilization RetrieveMobilization(int organisationId, int mobilizationId, Expression<Func<Mobilization, bool>> predicate);

        // Update
        void UploadPhoto(int organisationId, int personnelId, byte[] photo);
        Personnel UpdatePersonnel(int organisationId, Personnel personnel);
        Mobilization UpdateMobilization(int organisationId, Mobilization mobilization);

        //Delete
        void DeletePersonnel(int organisationId, int personnelId);
        
    }
}
