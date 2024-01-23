using System;
/*
Step 1 Design classes:

Class: Job
Responsabilities: keep track of company, job title, start year and end year.
Behaviors: Display information in format:  "Job Title (Company) StartYear-EndYear", 
for example: "Software Engineer (Microsoft) 2019-2022".

Class: Resume
Responsabilities: keep track of persons name and a list of their jobs.
Behaviors: Displays the resume in format: "Name, \n each job \n
TIP: put the display in void
*/
class Program
{
    static void Main(string[] args)
    {
        Job job1 = new Job
        {
            _jobTitle = "Software Engineer",
            _company = "Microsoft",
            _startYear = "2020",
            _endYear = "2022"
        };

        Job job2 = new Job
        {
            _jobTitle = "Web Developer",
            _company = "Google",
            _startYear = "2022",
            _endYear = "2024"
        };

        job1.Display();
        job2.Display();
        

        Resume myResume = new Resume
        {
            _name = "Kevin Magli",
        };
        
        myResume._jobs.Add(job1);
        myResume._jobs.Add(job2);

        myResume.Display();
    }
}


/*
Class: Resume
Responsabilities: keep track of persons name and a list of their jobs.
Behaviors: Displays the resume in format: "Name, \n each job \n
TIP: put the display in void
*/

