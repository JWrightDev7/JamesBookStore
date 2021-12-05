Monday Nov 1st
	-Started initial creation of project.
	-Created Git Repo to backup code
	-Looked through the default files to look at how it is layed out
	-Adjusted the look of the site with a different custom boostrap css file
	-changed attributes in the layout file to remove dark-text
	-Added additional stylesheets and script files to the layout file to allow the use of jquery, toastr, sweetalert, font awesome and datatables
	-Added a new dropdown menu to the nav bar
	-Created 3 different class libraries. DataAccess, Utility, Models
	-Installed EntityFrameworkCore
	-Added Project references between each of the class libraries and the main project to allow use of the data in each

Tuesday Nov 2nd
	-created area for customers and moved the home view to the customer area
	-Created the admin area that allows admins to have a view as well
	-removed the controllers and models folders from each of the new areas
	-worked on fixing the dropdown menu
	-commented out ssl port in the launch settings

Wednesday Nov 3rd
	-Fixed Dropdown menu issue of not expanding
	-finished up readme for part 1



Part 2
Wednesday Nov 10th
	- 9:15am Created the initial migration for the database in JamesBooks.DataAccess
	- 9:16am Update the database with the update-database command in nuget package manager console 
	- 9:25am Created Category Class in Models project.
	- 9:32am Created a new migration and updated the database to include the category table
	- 9:40am Created IRepository Interface
	- 9:50am Added CRUD to the Interface
	- 10:03am Created Repository class to implement the interface to allow the CRUD functions to work
	- 10:12am Created ICategoryRepository Interface and CategoryRepository class to implement the functions of the interface
	- 10:15am Implemented the interface into the CategoryRepository Class.
	- 10:30am Created ISP_Call interface and SP_Call Class to work with the database

Sunday Nov 14th
	- 9:35am Finished creating the SP_Call Class
	- 9:45am Created both the IUnitOfWork Interface and the UnitOfWork Class to implement the interface.
	- 10:00am Registered the IUnitOfWork interface and the implementation of it in the UnitOfWork Class in the configure services of the startup.cs so it can be used by any controller
	- 10:10am Created the CategoryController controller and the index.cshtml view for the controller
	- 10:30am Added the link to the admin categories index page into the dropdown menu on the navigation, Implemented the icons from font awesome and added the category javascript file
	- 10:45am Finished updating the readme and completed part 2 of the assignment

Tuesday Nov 23rd
	- 4:00pm Fixed DB Name
	- 4:05pm Started to create the CoverType.cs Class file in the models project
	- 4:20pm Finished creating CoverType Repo as well as the CoverType Interface and adding it to the database
	- 4:30pm Created CoverType Controller and View
	- 4:45pm Finished Creating CoverType Controller and View and moved onto adding the product class
	- 5:14pm Finished making the product class and added it to the DB with the migration: 20211123221320_addProductToDb
	- 5:30pm Had issue when creating productRepository class, fixed and re updated the DB
	- 5:45pm Created IProductRepository and linked it to the main Repository.
	- 5:55pm Started Part 3 Section 2, Created the ProductVM View and the ProductController
	- 6:10pm Created the CRUD Operations for Products
	- 6:20pm Created the ProductVM to allow for a select list on the products page
	- 6:30pm Finished creating the Product Controller and adjusting the product.js and index for products
	- 6:40pm When running got an exception at the getAll method in the Product Controller.
	- 6:50pm Finished Section 2 of part 3

Wednesday Nov 24th
	- 9:30am Fixed upsert method for category
	- 10:00am Fixed Category, CoverType CRUD Operations, they were not working correctly before
	- 10:45am Finished fixing the CRUD operations for Category and CoverType, was missing the Upsert and delete methods in the controller

Total Hours Worked for Part 3: 3 Hours 50 Minutes

Monday Nov 29th
	- 11:20am Started section 3 for part 3
	- 11:35am Added functionality to the product upsert and also added the text box from TINY
	- 11:45am Tested the application and getting error of System.NullReferenceException: 'Object reference not set to an instance of an object.' when creating a new product

Wednesday December 1st
	- 3:00pm Working on fixing the NullReferenceError
	- 4:00pm Continued on with the Part 3 Stage 3 in the assignment and will come back to try and fix the NullReferenceError

Sunday December 5th
	- 12:15pm Unable to find the fix for the System.NullReferenceException: 'Object reference not set to an instance of an object.' error when creating a new product
	- 1:00pm Completed Updates the ProductController to check for the image file and allow deletion or creation of it
	- 1:30pm Completed Updates for the HttpDelete in the product controller to allow for deletion of the image file if it exists
	- 2:00pm Fixed error for System.NullReferenceException: 'Object reference not set to an instance of an object.', Forgot to add: Product = new ProductRepository(_db); to UnitOfWork.cs
	- 3:00pm Getting new error when adding an image under create product. System.IO.DirectoryNotFoundException: 'Could not find a part of the path.
	- 3:30pm Fixed error for the Could not find part of the path
	- 4:30pm Getting new error after creating a product where the price is not shown and getting an AJAX error
	- 5:00pm Updated Customer Home view to see the product displayed on the home page.
	- 5:15pm Trying to fix error where price does not display on the product page


Total Hours worked for Part 4: 8 Hours 