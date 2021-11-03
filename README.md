# Student Enrollment API Project

### Authors
* Cheria Artis
* Jake Dombrowski
* Nate Osborne
* Krystle Taniguchi

## Objectives

Build a .NET Framework API Web Application using n-tier architecture covering a topic of your group's choosing.
This API should include at least one custom table per member of your group with a minimum of three tables (excluding the given user table), at least one of the tables should implement Foreign Key relationship between said tables.

Initial setup should include working together as a team to work through the planning stage. This stage should include:

* A layout of what the database tables should look like and how they should interact (You might consider using a tool like dbdiagram.io (Links to an external site.))
* You will need to review your idea and whiteboard this out with an instructor
* Fill out the planning document attached to the project module
* Break out the work load into consumable chunks, from your immediate TODOs to your long term stretch goals
* Delegating a table to each team member who will be responsible for full CRUD in that table.

## Requirements

* Come up with an idea for an application that will utilize at least one custom data table for each member of your group with a minimum of three tables
* Including at least one Foreign Key relationship
* Create a wireframe of the application and review it with an instructor
* Build out an n-tier structured API (think ElevenNote) with the following tiers
	* Data: This layer houses your classes that relate to the DB (POCOs, Identity, etc)
	* Models: This layer houses the reusable models for the rest of the layers
	* Services: This layer is where you will have most of your heavy backend logic
	* Web API: This is where the controllers and API endpoints will be
	* Link to repository site on your deployed Portfolio
	* Repository has a README.md (Links to an external site.) associated with the		project
 
## Mission Statement

The Student Enrollment API serves school administrators and students. In the future it will be used to allow students to only enroll in classes that pertain to their respective grade levels. It will allow administrators the ability to see at a glance how their courses and students are doing- what a student’s class load looks like, what the enrollment is for a given course, and what current courses are offered etc. However, the initial MVP is for enrollment but not restrictive on grade level at this point. One of our team members has a background in education. This product is created out of that expertise.

## Planning Documents

### Diagram

https://dbdiagram.io/d/61670102940c4c4eec93d955

### Trello Board

https://trello.com/invite/b/60v5vxNB/10a10a54802db504b3c53061a108e781/student-enrollment-api

## Version 1.0 / MVP

* Display List of students in a given course
* Display list of courses available by grade level
* Display list of courses for a given student Id
* Create new courses ready for enrollment
* Edit existing courses
* Edit student information- ie grade level as they advance
* Adjust Grade Level information to customize to a given school structure

## Version 1.0 / Stretch Goals Achieved

* Limit enrollment by gradeLevel
* Limit enrollment to courses currently in Session

## Version 2.0 / Stretch Goals

* Limit number of courses in which a student can be enrolled 
* Allow courses to be listed for multiple grade levels

## Endpoints

### Student

* Create Student
* Update by ID
* Get All Students
* Get Student by ID
* Delete Student

### Grade Level

* Create GradeLevel
* Update GradeLevel
* Get GradeLevel by Id
* Get All GradeLevels
* Delete GradeLevel

### Course

* Create Course
* Update Course
* Get Course by ID
* Get All Courses
* Get Course by Course in session
* Delete Course

### Enrollment

* Create Enrollment
* Update Enrollment
* Get All Enrollment Items
* Delete Enrollment
