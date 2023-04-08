# PAW Test Subject

__Duration__: 60 min, Mandatory: the project should compile and run without any errors.

(1p) By default


(1p) Create a Windows Forms project with the following name "StudyYear_Group_LastName_FirstName". For managing flights at an airport, you are asked to define two classes: a primary class Flight (with 3 different types of properties) and a secondary class Runway (includes a collection or array of flights). At least one of the classes will include a constructor with parameters.


(2p) The user should be able to add new instances for the primary class using a secondary from (-75% if you are using the main form). The instances will be stored in the array / collection included in the secondary class. Hint: you only need one instance of the secondary class.


(1p) The instances of the primary class will be displayed using a DatagridView control.


(1p) Perform validations on the data imputed by the user in the secondary form. The errors will be displayed using ErrorProviders.


(2p) Add the option to edit the items in the DatagridView by double clicking on them (use a secondary form).


(1p) Implement the IComparable or IComparable <T> interface to compare instances of the primary class based on a criterion at your choice. Keep the items displayed in the DatagridView sorted all the time in ascending order based on the chosen criterion.


(2p) Add a tool bar at the top of the application, allowing the user to serialize and deserialize the instance of the secondary class using the XML format.