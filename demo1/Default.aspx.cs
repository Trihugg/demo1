using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Web;
using System.Web.Services.Description;
using System.Web.UI;
using System.Web.UI.WebControls;
using Google.Apis.Auth.OAuth2;
using Google.Apis.Calendar.v3;
using Google.Apis.Calendar.v3.Data;
using Google.Apis.Services;


namespace demo1
{
    public partial class _Default : Page
    {

        private void createEvent()
        {
            // Refer to the .NET quickstart on how to setup the environment:
            // https://developers.google.com/calendar/quickstart/dotnet
            // Change the scope to CalendarService.Scope.Calendar and delete any stored
            // credentials.

            var credential = GoogleWebAuthorizationBroker.AuthorizeAsync(
                        new ClientSecrets
                        {
                            ClientId = "626473317377-e8mp67l87j4gi5g0ptp4bkc5dlrls2mm.apps.googleusercontent.com",
                            ClientSecret = "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",
                        },
                        new[] { CalendarService.Scope.Calendar },
                        "user",
                        CancellationToken.None).Result;

            var service = new CalendarService(new BaseClientService.Initializer
            {
                HttpClientInitializer = credential,
                ApplicationName = "calendar",
            });

            Event newEvent = new Event()
            {

                Summary = "Google I/O 2015",
                Location = "800 Howard St., San Francisco, CA 94103",
                Description = "A chance to hear more about Google's developer products.",
                Start = new EventDateTime()
                {
                    DateTime = DateTime.Parse("2023-1-27T17:00:00-07:00"),
                    TimeZone = "VietNam/HaNoi",
                    
                },
                End = new EventDateTime()
                {
                    DateTime = DateTime.Parse("2023-1-28T17:00:00-07:00"),
                    TimeZone = "VietNam/HaNoi",
                },

             Recurrence = new String[] { "RRULE:FREQ=DAILY;COUNT=2" },
            };

            String calendarId = "primary";
            EventsResource.InsertRequest request = service.Events.Insert(newEvent, calendarId);
            Event createdEvent = request.Execute();
            Console.WriteLine("Event created: {0}", createdEvent.HtmlLink);
        }


        private void getEvent()
        {

            var credential = GoogleWebAuthorizationBroker.AuthorizeAsync(
                        new ClientSecrets
                        {
                            ClientId = "626473317377-e8mp67l87j4gi5g0ptp4bkc5dlrls2mm.apps.googleusercontent.com",
                            ClientSecret = "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",
                        },
                        new[] { CalendarService.Scope.Calendar },
                        "user",
                        CancellationToken.None).Result;

            var service = new CalendarService(new BaseClientService.Initializer
            {
                HttpClientInitializer = credential,
                ApplicationName = "calendar",
            });

            String calendarId = "primary";
            EventsResource.ListRequest request = service.Events.List(calendarId);
            

            foreach (var i in request.Execute().Items)
            {
                Console.WriteLine(i);
                hhh.Text = i.Id;
                
            }
        }

        private void deleteEvent()
        {
            var credential = GoogleWebAuthorizationBroker.AuthorizeAsync(
                         new ClientSecrets
                         {
                             ClientId = "626473317377-e8mp67l87j4gi5g0ptp4bkc5dlrls2mm.apps.googleusercontent.com",
                             ClientSecret = "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",
                         },
                         new[] { CalendarService.Scope.Calendar },
                         "user",
                         CancellationToken.None).Result;

            var service = new CalendarService(new BaseClientService.Initializer
            {
                HttpClientInitializer = credential,
                ApplicationName = "calendar",
            });

            String calendarId = "primary"; 

            EventsResource.DeleteRequest request = service.Events.Delete(calendarId, hhh.ID );

        }

        private void editEvent()
        {
            var credential = GoogleWebAuthorizationBroker.AuthorizeAsync(
                         new ClientSecrets
                         {
                             ClientId = "626473317377-e8mp67l87j4gi5g0ptp4bkc5dlrls2mm.apps.googleusercontent.com",
                             ClientSecret = "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",
                         },
                         new[] { CalendarService.Scope.Calendar },
                         "user",
                         CancellationToken.None).Result;

            var service = new CalendarService(new BaseClientService.Initializer
            {
                HttpClientInitializer = credential,
                ApplicationName = "calendar",
            });

            String calendarId = "primary";

                
            throw new NotImplementedException();
        }



        protected void Submit_Click(object sender, EventArgs e)
        {
            getEvent();
        }
        protected void Delete_Click(object sender, EventArgs e)
        {
            deleteEvent();
        }
        protected void Edit_Click(object sender, EventArgs e)
        {
            editEvent();
        }

     
    }

}