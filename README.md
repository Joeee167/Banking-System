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

    Class DebitCard
    {
        Attributes : 
        - Account Balance
          
        Methods :
        - Withdraw
        - Deposit
    }

     Class SavingAccount
    {
        Attributes : 
        - Account Balance
        - Interest Rate
          
        Methods :
        - Withdraw
        - Deposit
        - Calculate Monthly Interest
    }
    
    
