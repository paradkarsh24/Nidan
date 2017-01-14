using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Security.Policy;
using Nidan.Business.Models;
using Nidan.Entity;
using Nidan.Entity.Dto;

namespace Nidan.Business.Interfaces
{
    public interface INidanBusinessService
    {
        //Create
        Personnel CreatePersonnel(int organisationId, Personnel personnel);
        Question CreateQuestion(int organisationId, Question personnel);

        // Retrieve
        PagedResult<Event> RetrieveEvents(int organisationId, Expression<Func<Event, bool>> predicate, List<OrderBy> orderBy = null, Paging paging = null);
        Event RetrieveEvent(int organisationId, int eventId, Expression<Func<Event, bool>> predicate);
        AbsenceType RetrieveAbsenceType(int organisationId, int absenceTypeId);
        PagedResult<AbsenceType> RetrieveAbsenceTypes(int organisationId, List<OrderBy> orderBy, Paging paging);
        IEnumerable<Colour> RetrieveColours();
        Organisation RetrieveOrganisation(int organisationId);
        IAuthorisation RetrieveUserAuthorisation(string aspNetUserId);
        Permissions RetrievePersonnelPermissions(bool isAdmin, int organisationId, int userPersonnelId, int? personnelId = null);
        PagedResult<Personnel> RetrievePersonnel(int organisationId, List<OrderBy> orderBy, Paging paging);
        Personnel RetrievePersonnel(int organisationId, int id);
        PagedResult<PersonnelSearchField> RetrievePersonnelBySearchKeyword(int organisationId, string searchKeyword, List<OrderBy> orderBy = null, Paging paging = null);
        PagedResult<Question> RetrieveQuestions(int organisationId, Expression<Func<Question, bool>> predicate, List<OrderBy> orderBy = null, Paging paging = null);
        Question RetrieveQuestion(int organisationId, int questionId, Expression<Func<Question, bool>> predicate);
        List<EventActivityType> RetrieveActivityTypes(int organisationId); 
        // Update
        void UploadPhoto(int organisationId, int personnelId, byte[] photo);
        Personnel UpdatePersonnel(int organisationId, Personnel personnel);

        //Delete
        void DeletePersonnel(int organisationId, int personnelId);
    }
}
