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

  - Login Screen
   ![LoginScreen](https://github.com/Joeee167/Banking-System/blob/main/Screenshot%202024-06-20%20151744.png)
  - The user enters username and password , according to the file the user is found in ( Admin / Employee / Client ) , the user will be directed to Main Menu and allowed to perform some functions .

    
