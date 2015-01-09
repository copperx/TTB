using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Migrations;
using System.Data.Entity.Validation;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TTB.ViewModels;
using TTB_Model;

namespace TTB.Controllers
{
    public class AdminController : Controller
    {
        //
        // GET: /Admin/
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult People()
        {
            List<person> personModel = new List<person>();
            using (var db = new TTBEntities())
            {
                personModel = (from p in db.people
                    select p).ToList();
            }
            
            return View(personModel);
        }

        [HttpPost]
        public ActionResult AddEditPerson(person newPerson)
        {
            using (var db = new TTBEntities())
            {
                db.people.AddOrUpdate(newPerson);
                db.SaveChanges();
            }
            return RedirectToAction("People");
        }

        [HttpGet]
        public ActionResult AddEditPerson(int? id)
        {
            var person = new person();
            if (id != null)
            {
                using (var db = new TTBEntities())
                {
                    person = (from p in db.people
                        where p.personID == id
                        select p).FirstOrDefault();
                }
            }

            return View(person);
        }


        public ActionResult Events()
        {
            List<projectEvent> eventsModel = new List<projectEvent>();
            using (var db = new TTBEntities())
            {
                eventsModel = (from p in db.projectEvents
                               select p).Include(m => m.eventType).ToList();
            }

            return View(eventsModel);
        }

        [HttpGet]
        public ActionResult AddEditEvent(int? id)
        {
            var eventViewModel = new EventViewModel();
            var projectEventModel = new projectEvent();
            if (id != null)
            {
                using (var db = new TTBEntities())
                {
                    projectEventModel = (from p in db.projectEvents
                                      where p.eventID == id
                                      select p).FirstOrDefault();
                }
            }

            eventViewModel.ProjectEvent = projectEventModel;

            using (var db = new TTBEntities())
            {
                eventViewModel.eventTypes = (from p in db.eventTypes
                              select p).ToList();
            }

            return View(eventViewModel);
        }

        [HttpPost]
        public ActionResult AddEditEvent(EventViewModel model)
        {
           
                using (var db = new TTBEntities())
                {
                    try
                    {
                        if (model.ProjectEvent.typeID != null)
                        {
                            eventType type = new eventType();
                            type = (from p in db.eventTypes
                                where p.eventTypeID == model.ProjectEvent.typeID
                                select p).FirstOrDefault();

                            model.ProjectEvent.eventType = type;
                        }

                        db.projectEvents.AddOrUpdate(model.ProjectEvent);
                        db.SaveChanges();
                    }
                    catch (DbEntityValidationException ex)
                    {
                        // Retrieve the error messages as a list of strings.
                        var errorMessages = ex.EntityValidationErrors
                                .SelectMany(x => x.ValidationErrors)
                                .Select(x => x.ErrorMessage);

                        // Join the list to a single string.
                        var fullErrorMessage = string.Join("; ", errorMessages);

                        // Combine the original exception message with the new one.
                        var exceptionMessage = string.Concat(ex.Message, " The validation errors are: ", fullErrorMessage);

                        // Throw a new DbEntityValidationException with the improved exception message.
                        throw new DbEntityValidationException(exceptionMessage, ex.EntityValidationErrors);
                    }
                }
         
            return RedirectToAction("Events");
        }

        public ActionResult eventTypes()
        {
            List<eventType> eventTypes = new List<eventType>();
            using (var db = new TTBEntities())
            {
                eventTypes = (from p in db.eventTypes
                               select p).ToList();
            }

            return View(eventTypes);
        }

        [HttpGet]
        public ActionResult AddEditEventType(int? id)
        {
            var eventTypeModel = new eventType();
            if (id != null)
            {
                using (var db = new TTBEntities())
                {
                    eventTypeModel = (from p in db.eventTypes
                              where p.eventTypeID == id
                              select p).FirstOrDefault();
                }
            }

            return View(eventTypeModel);
        }

        [HttpPost]
        public ActionResult AddEditEventType(eventType type)
        {
            using (var db = new TTBEntities())
            {
                db.eventTypes.AddOrUpdate(type);
                db.SaveChanges();
            }
            return RedirectToAction("eventTypes");
        }

        public ActionResult Genres()
        {
            List<genre> Genres = new List<genre>();
            using (var db = new TTBEntities())
            {
                Genres = (from p in db.genres
                              select p).ToList();
            }

            return View(Genres);
        }

        [HttpGet]
        public ActionResult AddEditGenre(int? id)
        {
            var genreModel = new genre();
            if (id != null)
            {
                using (var db = new TTBEntities())
                {
                    genreModel = (from p in db.genres
                                      where p.genreID == id
                                      select p).FirstOrDefault();
                }
            }

            return View(genreModel);
        }

        [HttpPost]
        public ActionResult AddEditGenre(genre genre)
        {
            using (var db = new TTBEntities())
            {
                db.genres.AddOrUpdate(genre);
                db.SaveChanges();
            }
            return RedirectToAction("Genres");
        }

        public ActionResult Ratings()
        {
            List<rating> Ratings = new List<rating>();
            using (var db = new TTBEntities())
            {
                Ratings = (from p in db.ratings
                          select p).ToList();
            }

            return View(Ratings);
        }

        [HttpGet]
        public ActionResult AddEditRating(int? id)
        {
            var ratingModel = new rating();
            if (id != null)
            {
                using (var db = new TTBEntities())
                {
                    ratingModel = (from p in db.ratings
                                  where p.ratingID == id
                                  select p).FirstOrDefault();
                }
            }

            return View(ratingModel);
        }

        [HttpPost]
        public ActionResult AddEditRating(rating newRating)
        {
            using (var db = new TTBEntities())
            {
                db.ratings.AddOrUpdate(newRating);
                db.SaveChanges();
            }
            return RedirectToAction("Ratings");
        }

        public ActionResult Statuses()
        {
            List<status> Statuses = new List<status>();
            using (var db = new TTBEntities())
            {
                Statuses = (from p in db.statuses
                           select p).ToList();
            }

            return View(Statuses);
        }

        [HttpGet]
        public ActionResult AddEditStatus(int? id)
        {
            var statusModel = new status();
            if (id != null)
            {
                using (var db = new TTBEntities())
                {
                    statusModel = (from p in db.statuses
                                   where p.statusID == id
                                   select p).FirstOrDefault();
                }
            }

            return View(statusModel);
        }

        [HttpPost]
        public ActionResult AddEditStatus(status newStatus)
        {
            using (var db = new TTBEntities())
            {
                db.statuses.AddOrUpdate(newStatus);
                db.SaveChanges();
            }
            return RedirectToAction("Statuses");
        }

        public ActionResult Projects()
        {
            List<project> Projects = new List<project>();
            using (var db = new TTBEntities())
            {
                Projects = (from p in db.projects
                            select p).ToList();
            }

            return View(Projects);
        }

        [HttpGet]
        public ActionResult AddEditProject(int? id)
        {
            //var model = new project();
            var model = new ProjectViewModel();

            if (id != null)
            {
                using (var db = new TTBEntities())
                {
                    model.Project = (from p in db.projects
                                   where p.projectID == id
                                   select p).FirstOrDefault();

                    model.Statuses = (from p in db.statuses
                        select p).ToList();

                    model.Ratings = (from r in db.ratings
                        select r).ToList();
                }
            }
            else
            {
                using (var db = new TTBEntities())
                {
                    model.Statuses = (from p in db.statuses
                                    select p).ToList();

                    model.Ratings = (from r in db.ratings
                                     select r).ToList();
                }
            }

            return View(model);
        }

        [HttpPost]
        public ActionResult AddEditProject(ProjectViewModel model)
        {
            using (var db = new TTBEntities())
                {
                    if (model.Project.statusID != null)
                    {
                        status status = new status();
                        status = (from p in db.statuses
                                  where p.statusID == model.Project.statusID
                                  select p).FirstOrDefault();

                        model.Project.status = status;
                    }

                    if (model.Project.ratingID != null)
                    {
                        rating rating = new rating();
                        rating = (from p in db.ratings
                                  where p.ratingID == model.Project.ratingID
                                  select p).FirstOrDefault();

                        model.Project.rating = rating;
                    }

                    var newProject = new project();
                    newProject.projectName = model.Project.projectName;
                    newProject.status = model.Project.status;
                    newProject.statusID = model.Project.statusID;
                    newProject.rating = model.Project.rating;
                    newProject.ratingID = model.Project.ratingID;
                    if (model.Project.recordCreatedDate.Equals(null))
                    {
                        newProject.recordCreatedDate = DateTime.Now;
                    }
                    else
                    {
                        newProject.recordCreatedDate = model.Project.recordCreatedDate;
                    }

                    newProject.recordUpdatedDate = DateTime.Now;
                    newProject.runtime = model.Project.runtime;
                    newProject.logLine = model.Project.logLine;
                    newProject.synopsis = model.Project.synopsis;
                    newProject.rottenTomatoesID = model.Project.rottenTomatoesID;
                    newProject.imdbID = model.Project.imdbID;
                    newProject.metaCriticID = model.Project.metaCriticID;
                    newProject.productionNotes = model.Project.productionNotes;
                    newProject.locationNotes = model.Project.locationNotes;
                    newProject.distributionNotes = model.Project.distributionNotes;
                    newProject.awardNotes = model.Project.awardNotes;
                    newProject.technicalNotes = model.Project.technicalNotes;

                    try
                    {
                        db.projects.AddOrUpdate(newProject);
                        db.SaveChanges();
                    }
                    catch (DbEntityValidationException ex)
                    {
                        // Retrieve the error messages as a list of strings.
                        var errorMessages = ex.EntityValidationErrors
                                .SelectMany(x => x.ValidationErrors)
                                .Select(x => x.ErrorMessage);

                        // Join the list to a single string.
                        var fullErrorMessage = string.Join("; ", errorMessages);

                        // Combine the original exception message with the new one.
                        var exceptionMessage = string.Concat(ex.Message, " The validation errors are: ", fullErrorMessage);

                        // Throw a new DbEntityValidationException with the improved exception message.
                        throw new DbEntityValidationException(exceptionMessage, ex.EntityValidationErrors);
                    }

            }

            return RedirectToAction("Projects");
        }

        [HttpPost]
        public ActionResult AddEditStatus(project model)
        {
            using (var db = new TTBEntities())
            {
                db.projects.AddOrUpdate(model);
                db.SaveChanges();
            }
            return RedirectToAction("Projects");
        }

        public ActionResult Authors()
        {
            List<author> Authors = new List<author>();
            using (var db = new TTBEntities())
            {
                Authors = (from p in db.authors
                            select p).ToList();
            }

            return View(Authors);
        }

        [HttpGet]
        public ActionResult AddEditAuthor(int? id)
        {
            var model = new author();
            if (id != null)
            {
                using (var db = new TTBEntities())
                {
                    model = (from p in db.authors
                             where p.ID == id
                             select p).FirstOrDefault();
                }
            }

            return View(model);
        }

        [HttpPost]
        public ActionResult AddEditAuthor(author model)
        {
            using (var db = new TTBEntities())
            {
                db.authors.AddOrUpdate(model);
                db.SaveChanges();
            }
            return RedirectToAction("Authors");
        }





        //[HttpGet]
        //public ActionResult ProjectDetails()
        //{
        //    List<project> model = new List<project>();
        //    using (var db = new TTBEntities())
        //    {
        //        model = (from p in db.projects
        //                 select p).Include(r => r.rating).Include(s => s.status).ToList();
        //    }
        //    return View(model);
        //}

        //[HttpPost]
        //public ActionResult ProjectDetails(string name)
        //{
        //    var model = new List<project>();

        //    using (var db = new TTBEntities())
        //    {
        //        if (name != string.Empty)
        //        {
        //            model = (from p in db.projects
        //                     where p.projectName.Contains(name)
        //                     select p).Include(r => r.rating).Include(s => s.status).ToList();
        //        }
        //        else
        //        {
        //            model = (from p in db.projects
        //                     select p).Include(r => r.rating).Include(s => s.status).ToList();
        //        }
        //    }

        //    return RedirectToAction("ProjectDetails");
        //   // return View(model);
        //}

                        
        [HttpGet]
        public ActionResult ProjectDetails(int? id)
        {
            //var model = new project();
            var model = new ProjectViewModel();

            if (id != null)
            {
                using (var db = new TTBEntities())
                {
                    model.Project = (from p in db.projects
                                     where p.projectID == id
                                     select p).FirstOrDefault();

                    model.Statuses = (from p in db.statuses
                                      select p).ToList();

                    model.Ratings = (from r in db.ratings
                                     select r).ToList();
                }
            }
            else
            {
                using (var db = new TTBEntities())
                {
                    model.Statuses = (from p in db.statuses
                                      select p).ToList();

                    model.Ratings = (from r in db.ratings
                                     select r).ToList();
                }
            }

            return View(model);
        }

        [HttpPost]
        public ActionResult ProjectDetails(ProjectViewModel model)
        {
            using (var db = new TTBEntities())
            {
                if (model.Project.statusID != null)
                {
                    status status = new status();
                    status = (from p in db.statuses
                              where p.statusID == model.Project.statusID
                              select p).FirstOrDefault();

                    model.Project.status = status;
                }

                if (model.Project.ratingID != null)
                {
                    rating rating = new rating();
                    rating = (from p in db.ratings
                              where p.ratingID == model.Project.ratingID
                              select p).FirstOrDefault();

                    model.Project.rating = rating;
                }

                var newProject = new project();
                newProject.projectName = model.Project.projectName;
                newProject.status = model.Project.status;
                newProject.statusID = model.Project.statusID;
                newProject.rating = model.Project.rating;
                newProject.ratingID = model.Project.ratingID;
                if (model.Project.recordCreatedDate.Equals(null))
                {
                    newProject.recordCreatedDate = DateTime.Now;
                }
                else
                {
                    newProject.recordCreatedDate = model.Project.recordCreatedDate;
                }

                newProject.recordUpdatedDate = DateTime.Now;
                newProject.runtime = model.Project.runtime;
                newProject.logLine = model.Project.logLine;
                newProject.synopsis = model.Project.synopsis;
                newProject.rottenTomatoesID = model.Project.rottenTomatoesID;
                newProject.imdbID = model.Project.imdbID;
                newProject.metaCriticID = model.Project.metaCriticID;
                newProject.productionNotes = model.Project.productionNotes;
                newProject.locationNotes = model.Project.locationNotes;
                newProject.distributionNotes = model.Project.distributionNotes;
                newProject.awardNotes = model.Project.awardNotes;
                newProject.technicalNotes = model.Project.technicalNotes;

                try
                {
                    db.projects.AddOrUpdate(newProject);
                    db.SaveChanges();
                }
                catch (DbEntityValidationException ex)
                {
                    // Retrieve the error messages as a list of strings.
                    var errorMessages = ex.EntityValidationErrors
                            .SelectMany(x => x.ValidationErrors)
                            .Select(x => x.ErrorMessage);

                    // Join the list to a single string.
                    var fullErrorMessage = string.Join("; ", errorMessages);

                    // Combine the original exception message with the new one.
                    var exceptionMessage = string.Concat(ex.Message, " The validation errors are: ", fullErrorMessage);

                    // Throw a new DbEntityValidationException with the improved exception message.
                    throw new DbEntityValidationException(exceptionMessage, ex.EntityValidationErrors);
                }

            }

            return RedirectToAction("ProjectDetails");
        }



	}
}