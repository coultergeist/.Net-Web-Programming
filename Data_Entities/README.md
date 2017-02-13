
# ITC172 Assignment4

Using Data Entities, as opposed to ADO commands.

Use the Wizard to add the Person, PersonAddress, Contact, and Donation tables. Also Add the stored Procedures usp_Login and usp_Register.

Create a login page. The login page should be like the one for ADO. We will create a login class to search out and return the personKey. This time though use the LINQ notation instead of the ADO. There should be a link on the page to Register if the donor doesn't have a login.

On the registration page, create a form with all the field required to register a new user. Use the validation controls for required fields. Validate that the email is validly formed. Have them enter the password and then reenter it. Make sure the confirmation password matches the first one.

Once they have registered, the should return to the login. If they are successful in logging in, redirect them to the page where they can enter their donation information. (they should only be able to see this page if their key is in the Session variable.

Once they have donated, redirect them to another page that lists all their donations.

