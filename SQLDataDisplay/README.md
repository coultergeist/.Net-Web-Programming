# ITC172Assignment3-2017-
First example from ADO assignment
For this one we will use classic ADO.

We connect to the database Community_ Assist.

First we will create a login page. A user must log in to see the next page. This second page will contain a drop down list of all the services the charity offers. When a user chooses a service it will show a list of all the grants for that service.

The login procedure takes two parameters: @Email, @password. (Email is the user name). If valid, It will return an ID number for the user. You should store this in a Session variable and use that session variable to give them access to the second page.

You should create a class to handle the login, and a second class to handle the queries to searches for services and grants for those services.  The second class can return a DataTable.
