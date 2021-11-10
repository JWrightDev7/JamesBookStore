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