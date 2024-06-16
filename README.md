Explanation of the project:
I created a Intreface called IVehicle that defines the properties and methods that any vehicle should have, such as brand, model,
value, and methods to get rental cost, initial insurance cost, insurance discount, and specific information about the vehicle.
Also i created the abstract class called Vehicle  which implements the IVehicle interface and provides common properties and methods for all vehicle types.
In the models folder i created a classes that inherits all the properties from the Vehicle.
In the class Car i implemented specific logic for cars, including rental cost per day, initial insurance cost, and insurance discount based on safety rating.
In the class Motorcycle i implemented the specific logic for motorcycles, including rental cost per day, initial insurance cost, and insurance discount based on the rider's age.
In the class  CargoVan i implemented the specific logic for cargo vans, including rental cost per day, initial insurance cost, and insurance discount based on the driver’s experience.
After that i created a interface IInvoice and class Inovice which implements interface IInovice. Class Invoice generates an invoice based on the rental information provided. It calculates the total rental cost, 
initial insurance cost, and any applicable discounts for early return of the vehicle. The invoice includes details such as customer name, vehicle details, rental period, and costs.
At the end in the Program class i put the data from the example output and the invoice for each vehicle type to print.
