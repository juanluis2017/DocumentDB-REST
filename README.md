Copyright © 2016, Howard S. Edidin


# DocumentDB-REST #

Microsoft Azure's DocumentDB is a great PaaS NoSQL database.  It supports Stored Procedures, User Defined Functions (UDF) and Triggers. A REST API is directly available, but a API Connector is not available.  This project started off as an API Connector. 

I started off trying to duplicate all the DocumentDB published REST API in Swagger. I used SwaggerHub to author the Swagger JSON file.
I then used the **Add REST API** function in VS 2015 to generate the code for my API Application. 

## Source code ##
* [Swagger](https://github.com/HEDIDIN/DocumentDB-REST/blob/master/HEDIDIN-DocumentDBConnector-1.0.6-swagger.json)
* [Source Repository](https://github.com/HEDIDIN/DocumentDB-REST/tree/master/DocumentDBRestApi)

## Documentation
You can view all the [Operations on my Wiki](https://github.com/HEDIDIN/DocumentDB-REST/wiki)


### Working ###

The flowing operations are currently working:

* Get an Offer
* List Offers
* Replace an Offer
* Querying Offers
* Create a Database
* Get a Database
* List Databases
* Delete a Database
* Create a User
* Get a User
* List Users
* Delete a User
* Create a Permission
* Get a Permission
* List Permissions
* Replace a Permission
* Delete a Permission
* Create a Document
* Get a Document
* List Documents
* Replace a Document
* Delete a Document
* Create an Attachment
* Get an attachment
* Create a Collection
* Get a Collection
* List Collections
* Delete a Collection
* Register a Stored Procedure
* Execute a stored procedure
* List stored procedures
* Replace a stored procedure
* Delete a stored procedure
* Query a UDF
* Query a Trigger
* Query a Collection Resource
* Query a Document Resource



### Unimplemented ###

* Auto generation of the Authorization Header to populate the header parameter
* Create a trigger
* Replace a trigger
* Delete a trigger
* List triggers
* Create a UDF
* Replace a UDF
* Delete a UDF
* Replace an attachment
* List attachments
* Delete attachments
* Security for accessing the API

### Future Functionality ###

* Enumeration of stored procedures to select from for Execute a stored procedure. 
   * This should be a drop down list on the API Docs

## Configure Swagger ##

You will need to modify `YourDocumentDBAccount.documents.azure.com:443` in the Swagger file
Replace `YourDocumentDBAccount` with your *DocumentDB Account Name*

## Usage ##

The VS 2015 Project was added. The project is an API App.  The code has ben refactored using ReSharper.
You will need to restore the packages. 

The `DocumentDBConnector.cs` is the base class. 

The `DocumentDbAccount` public property is required. This is the same value as `YourDocumentDBAccount`


## Changelog ##

* 1.0.0 - 2015-12-14 - Initial Release
* 1.0.1 - 2016-01-01 - Reviewed Documentation
* 1.0.2 - 2016-02-01 - Added Query a Resource to the Unimplemented list
* 1.0.3 - 2016-03-01 - Added Query Collection Resource and Query Document Resource; Added details to Operation Descriptions including links to external documentation to the Swagger. Source code has not been updated
* 1.0.4 - 2016-03-02 - Added List stored procedures, Replace a stored procedure, Delete a stored procedure


## Contributing to DocumentDB-REST ##

I am willing to accept pull requests that implements any unimplemented functionality listed as "Unimplemented" above.
I would also like to hear any feedback for people using it.


[LICENSE](./LICENSE)
