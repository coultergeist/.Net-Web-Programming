
Creating a WCF (Windows Communication Foundation) service. 

 
 Using Data Entities for the Model. With tables Person, PersonAddress, Contact, GrantRequest and Grant review and stored procedures usp_Login and usp_Register. 
 
 
 The service will have all the methods necessary to all a new user to register, login, apply for a grant, and see all the grants they have applied for and their status. Specifically you will need methods for 
 
 •Logging in (this will use the login stored procedure and you will need to get the PersonKey) 
 
 •Registering (this will use the Register stored procedure) 
 
 •Requesting a grant (this will add the Grant to the GrantReview table with review status = "pending" 
 
 •Viewing grants (filtered by PersonKey) 
