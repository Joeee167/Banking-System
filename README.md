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
        Methods : 
        1. Add Client
        2. Delete Client
        
    }
    
