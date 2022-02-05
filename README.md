# QuikTrippin': A C# Console App for the Best Gas Station in the World

## Get Started:

```javascript
 $ git clone git@github.com:nss-evening-cohort-16/targaryen-quiktrippin.git
 $ cd targaryen-quiktrippin
```

## About the Users
* QuikTrip is one of the best gas stations on the planet and as developers, we've been asked to help the Account Manager and their department. It's becoming a hard task to keep track of the sales from the various regions and they need their district managers to enter their store sales and all employees information and individual sales. 


## Features: 
* Users have a console menu interface with the following options to choose from: Enter District Sales, Generate District Report, Add New Employee, Add a Store, or Add a District. 
* Users can add multiple districts and create and assign new stores and employees to specific districts. 
* Users can view quarterly and yearly gas and retail sales.

## [Loom video walkthrough](https://www.loom.com/share/991cf6810a794cccb9a0faf6feca363d)

## Code Snippet:

```c#
public static void DistrictReport(string name)
        {
            int storeList = 0;
            foreach (Store store in Stores)
            {
                if (store.DistrictName == name)
                {
                    storeList++;
                    Console.WriteLine($@"
{name} Store #{store.StoreNumber}
------------------------------");
                    Store.EmployeeReport(store.StoreNumber);
                    Store.GasReport(store.StoreNumber);
                }
            }
        }
```

## Screenshots:

<img width="454" alt="2022-02-05 (1)" src="https://user-images.githubusercontent.com/86667443/152648682-96de09ca-513f-41e2-b05b-212e000df5ba.png">
<img width="478" alt="2022-02-05 (2)" src="https://user-images.githubusercontent.com/86667443/152648683-e6269554-b428-4979-98a7-4aadf0e393c6.png">

### Contributors: [Mary Beth Hunter](https://github.com/marybethhunter), [Albert Chittaphong](https://github.com/albertchitta), [Gabriel Smith](https://github.com/Gabrielsmith1998), [Dario Perez](https://github.com/darioperez1415)
