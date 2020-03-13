using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace BudgeIt
{
    private void CreateCustomCalendar()
    {
        const string newCalendarName = "PersonalCalendar";
        Outlook.MAPIFolder primaryCalendar = (Outlook.MAPIFolder)
            this.Application.ActiveExplorer().Session.GetDefaultFolder
             (Outlook.OlDefaultFolders.olFolderCalendar);
        bool needFolder = true;
        foreach (Outlook.MAPIFolder personalCalendar
            in primaryCalendar.Folders)
        {
            if (personalCalendar.Name == newCalendarName)
            {
                needFolder = false;
                break;
            }
        }
        if (needFolder)
        {
            Outlook.MAPIFolder personalCalendar = primaryCalendar
                .Folders.Add(newCalendarName,
                    Outlook.OlDefaultFolders.olFolderCalendar);
            Outlook.AppointmentItem newEvent =
                personalCalendar.Items.Add
                (Outlook.OlItemType.olAppointmentItem)
                as Outlook.AppointmentItem;
            newEvent.Start = DateTime.Now.AddHours(1);
            newEvent.End = DateTime.Now.AddHours(1.25);
            newEvent.Subject = "New plan";
            newEvent.Body = " Meet to discuss new plan.";
            newEvent.Save();
        }
        Application.ActiveExplorer().SelectFolder(primaryCalendar
            .Folders[newCalendarName]);
        Application.ActiveExplorer().CurrentFolder.Display();
    }
}
