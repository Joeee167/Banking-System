# Banking-System
- A banking system that provides functionalities for admins , employees and clients including modifying client info , adding and deleting clients . It also allows the client to perform transactions using his debit card or saving account.

# UML , CLasses and Interfaces

                                                 UML Diagram
 ![UML](https://github.com/Joeee167/Banking-System/blob/main/Screenshot%202024-06-18%20174936.png)


    Base Class Person
    {
        Attributes : Username + Password

        Methods for all derived classes : Login + Update Client
        
    }

    Class Employee : Person
    {
        Additional Methods : 
        1. Add Client
        2. Delete Client
        3. Find Client
        
    }

      Class Admin : Employee
    {
        Additional Methods : 
        1. Show Clients List
    }

     Class Client : Person
    {
        Attributes : 
        - Account Number
        - PIN Code
        - Client Name
        - Phone Number

        Additional Methods :
        - Perform Transactions through composition of debit card and saving account
    }

    Class DebitCard : Ioperations
    {
        Attributes : 
        - Account Balance
          
        Methods :
        - Withdraw
        - Deposit
    }

     Class SavingAccount : Ioperations
    {
        Attributes : 
        - Account Balance
        - Interest Rate
          
        Methods :
        - Withdraw
        - Deposit
        - Calculate Monthly Interest
    }

    Interface Ioperations
    {
        Methods :
        - Withdraw
        - Deposit
    }

  # Screens And Functions

                      Login Screen
  ![LoginScreen](https://github.com/Joeee167/Banking-System/blob/main/Screenshot%202024-06-20%20151744.png)
  - The user enters username and password , according to the file the user is found in ( Admin / Employee / Client ) , the user will be directed to Main Menu and allowed to perform some functions .



                    Main Menu Screen
![Main Menu](https://github.com/Joeee167/Banking-System/blob/main/Screenshot%202024-06-20%20160449.png)
- According to the user type ( Admin / Employee / Client ) , some of the six functions are allowed to use and the others are disabled


                  Show Clients Screen
![Show Clients](https://github.com/Joeee167/Banking-System/blob/main/Screenshot%202024-06-20%20172220.png)
- Show Clients Screen that is only available to the admin that allow him to view all the clients' info.


                    Add Clients Screen
![Add Clients](https://github.com/Joeee167/Banking-System/blob/main/Screenshot%202024-06-22%20142257.png)
- Screen to add new client >>> available to Admin and Employee only.
- It is not allowed to add client with existing account number.
- If you try to add a user with existing account number , a message appears to show that.
    

                    Find Clients Screen
![Find Client](https://github.com/Joeee167/Banking-System/blob/main/Screenshot%202024-06-23%20141252.png)

![Find Client](https://github.com/Joeee167/Banking-System/blob/main/Screenshot%202024-06-23%20141314.png)

![Find Client](https://github.com/Joeee167/Banking-System/blob/main/Screenshot%202024-06-23%20141341.png)

- Find Client by account number >>> available to admin and employees only.
- If the client is found , the client info ( AccountNumber - PIN - Name - Phone Number - Debit Card Balance - Saving Account Balance ) is shown.
- If the client is not found , a warning message " Client Not Found! " is shown.

                    Delete Clients Screen
![Delete Client](https://github.com/Joeee167/Banking-System/blob/main/Screenshot%202024-06-24%20134030.png)

- Delete Client By Account Number >>> available to admin and employee only
- If a client is found with the entered account number , a message appears to confirm deletion then the client is removed from the file
- If the client is not found , a warning message " Client Not Found! " is shown.

