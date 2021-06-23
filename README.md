# BankApp
### Abstract
____________________________________________

A page on the web service App will be loaded and will generate a prize when both the Account Number and Name comes together. The prize that the user wins and the account number that they were assigned should be saved into the database which will act as an history page on the front end service. Below is a table which demonstrates the user journey, showing when can a user win a prize and what type of prize do they win, this will be dependant on the first number of the account number. I will be working with 4 services and will connect them with an API. Service one is the front end of the app which will be created using ASP.NET MVC. Service two is the Account numbers service which will generate the account number randomly. Service three is the Names service which will generate the names randomly. Lastly, service four is the merge service which will combine both service two and three together and based upon that, a prize will be generated as shown below.

![userstory](userstory.PNG)



### Aim and Objectives
_____________________________________________
The aims and objectives of this projects are as the following:
<table>
  <body>
    <tr>
      <th>Aims </th>
      <th align="center">Objectives</th> 
    </tr>
    <tr>
      <td><ul><li>Use an agile methodology to manage the project</li></ul></td>
      <td align="left"><ul>
          <li>Will use an agile methodology called Asana board to set deadlines for tasks and carry out tasks</li>
          <li>On the Asana board, will create user stories, use cases and tasks which are needed to complete the project</li>
        </ul></td>
    </tr>
    <tr>
      <td><ul><li>Create a design which describe the architecture of the  BankApp.</li></ul></td>
      <td align="left"><ul><li>Will create a list of requirements using the MoSCoW technique</li>
        <li>Will draw diagrams such as the CI/CD pipeline, Service Architect diagram, ERD diagram, wireframes of how the app will look like and the work flow diagram</li>
        <li>Will carry out risk assessement to demonstrate the potential risks within this project</li>
        </ul></td>
    </tr>
    <tr>
      <td><ul><li>Create a working BankApp which consists  of 4 services</li></ul></td>
      <td align="left">
      <ul><li>Will be using programming languages such as C#, HTML, CSS and web API to connect the 4 services, and for the back end will be using AzureMySQL to save the history of the prizes that were won by different users</li>
      </td>
    </tr>
      <td>
        <ul>
          <li>Testing for the BankApp</li>
        </ul>
      </td>
      <td align="left"><ul>
          <li>Carry out xUnit testing and automated testing to validate the application</li>
           <li>Provide a generated report for testing and show the test coverage</li>
        </ul></td>
    </tr>
     <tr>
      <td>
        <ul>
          <li>Deployment andIntegrate the code for the BankApp</li>
        </ul>
      </td>
      <td align="left"><ul>
         <li>Use terraform to deploy Azure App Services and databses</li>
          <li>Contionous integration of the code into a VCS (Version Control System) using the Feature-Branch model, make use of different branches and merge them, showing a change in one branch and merging it with the master and redeploy to demonstrate that the work flow is working successfully</li>
           <li>Deploy the BankApp to a cloud-based virtual machine through a CI server through GitHub Actions and Azure App Services</li>
        </ul></td>
    </tr>
  </body>
</table>

### Project Tracking tool
_______________________________________________________
For my BankApp project, I used an Asana board to create user stories (which explains the existence of each functonality and what benefit will it bring to us) and tasks which will make it easier for me to follow the project specifications. Below is my Kanban Board that shows the tasks I have to do, the tasks I am doing currently, testing and lastly the tasks I have completed successfully. I have also added a tool section in my Kanban board to show which tools I have used in this project. User stories have also been implemented and have been labelled. To view my trello board, please click on this link https://app.asana.com/share/avanade/bankapp/9006878344988/e7c9f6fc85811394dccd83c613866273

![Asana](as.PNG)




### Functional and Non-functional Requirements 
_______________________________________________________________________
The table below shows the requirements of the project using the MoSCoW technique where I will be prioritising requirements.
<table>
  <body>
    <tr>
      <th align="centre">Must Have </th>
      <th align="centre">Should Have</th> 
      <th align="centre">Could Have</th> 
      <th align="centre">Wont Have</th> 
    </tr>
    <tr>
      <td align= "left">The user must be able to see the account number and name that was generated and what prize the user won</td>
       <td align= "left">The user can view the history of the account numbers and prizes that the users won</td>
      <td align= "left">Input validation - For example, one user can win only one prize</td>
      <td align= "left">The admin can login and manage the users and the account numbers they were assigned to</td>
    </tr>
   
</table>

### Service Architect diagram 
_________________________________________________________________


![architect](architect.png)
  

### CI/CD Pipeline
____________________________________________________________________
  
![pipeline](pipeline.png)
  
 ### WorkFlow Diagram
____________________________________________________________________
  
![workflow](workFlow.PNG)

### Entity diagram 
________________________________________________________________________

  

![ERD](ERD.png)

### Front End of the App
____________________________________________________________________



![green](greenImplen.PNG)



![red](implen2.PNG)



### Testing Report
_________________________________________________________________________

xUnit tests were used to run the tests for the BankApp. xUnit test is a unit testing tool which is mainly designed for the .NET framework. The BankApp I have created runs on .NET framework and is a console MVC app. The reason why I used xUnit testing is to compile the code and to detect problems during the early phase of developing the app before actually deploying the app. For the BankApp, I have tested all of my controllers and actions as shown on the screenshot below. However, some of the actions returned null which resulted in some of my tests failing. I used a structure to write my code for testing which was to start off with arranging the test then performing the action and lastly asserting it. I also created Moqs, interfaces and repositories to help me test the controllers of the BankApp.

![testing](ReportGen.PNG)

### Risk Assessement 
____________________________________________________________________________




### Revisits - Updated Version of diagrams after the implementation 
_______________________________________________________________________________________________

In this project. I was able to implement the must requirements which was stated in the project requirements section on this documentation previously. I was also able to implement other requirements too. 

The following requirements that have been implemented in this project are:
* The user must be able to view recipes 
* The user must be able to add recipes 
* The user must be able to edit recipes
* The user must be able to delete recipes
* The user must be able to add reviews 
* The user must be able to view reviews

I was unable to implement the database to the BankApp, therefore I do not have an updated version of the ERD. However, I was able to implement the WorkFlow diagram inside my project successfully.

Below is an updated version of my Service Architecture Diagram. 
![updatearchitect](updateArchitect.png)
  
Below is an updated version of my CI/CD Pipeline. 
![updatepipeline](updatePipeline.png)
  
Below is an updated version of my Kanban board. I have completed all of the required tasks successfully. However, was unable to create a prototype for the CookBookApp as I ran out of time. 

![Asana](asana.PNG)




### Evaluation 
_________________________________________________________________

The strengths of this project were that:
* I was able to use a Trello Kanban Board successfully.
* I was able to complete the CRUD functionality successfully and was able to link the two tables on the database successfully. For example, I was able to retrieve the RecipeID in my Reviews table in the database and was able to add reviews and views for a certain recipe. 
* I was able to use ASP.NET, HTML and CSS as my front end and back end. 
* I was able to connect the workBench with AzureMySql and ASP.NET
* I was able to test both of my recipes and reviews controller and generated a report for them to show the overall test coverage 
* I was able to deploy my app through the Azure App Service and publishing the app on visual studio, allowing me to perform continous integration as shown below on the screenshot:

![deploy](deploy.PNG)


* I was able to re-create all of my diagrams and revisit them to compare what I had before the implementation and after the implementation, allowing me to suggest future work that may be required for the app by using the MoSCoW technique. 
* I was able to carry out the risk assessements and I also revisited the risks to see how I mitigated the risk 
* I was able to push my CookBookApp code to the github successfully.
* I was able to use all of the tools that I learnt during the training and apply them to my project.

The weaknesses of this project were that:
* I was not able to deploy the app through the Azure pipelines as the build failed, therefore had to use an alternative way to deploy the CookBookApp. However, I was able to build the code and create a YAML file but was unable to deploy the app unsuccessfully as shown below:

![dev](devop.PNG)

* I was not able to do alot of work on the front end of the side to make the app look prettier and more user friendly. 

Further improvements:
* Test the whole code and increase the code coverage report percentage 
* Create a prototype for the CookBookApp
* Work on making the app look more user friendly. For example, when the user adds recipe to the app, the description textarea should be bigger allowing them to add a detailed description without any hassle.
* Deploy the app through Azure pipelines
* Implement the should have, could have and wont have requirements of this project in the future 
* Include validations. For example, if the user enters a text rather than a number in the number of serving part, then it should prompt a user with a message stating them to enter a valid number. Also, create validations for empty forms. For example, if the form is left empty and user clicks save, it wont submit or add to the database as all fields should be mandatory to be filled in. 
* Use Angular for the front end to integrate it with ASP.NET.

### Authors
_________________________________

Samia Iqbal
