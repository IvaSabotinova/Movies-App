<p align="center">
   <img  src="https://github.com/IvaSabotinova/Movies-App/assets/96121572/3e675d4b-dd94-4b68-bea5-9833a567a35f" alt="ReactJS" 
width="80px">
      <img  src="https://github.com/IvaSabotinova/Movies-App/assets/96121572/035b39fc-7890-4b2d-841f-d901d4706cbd" alt="And" 
width="30px">   
   <img  src="https://github.com/IvaSabotinova/Movies-App/assets/96121572/caa8bb8f-656e-4c06-a4d6-af047129e0d2" alt="WebApi" 
width="160px">
</p>

# <p align="center" style="font-size:30px;"><b>:movie_camera: Movies App</b></p>


### Short Description

The app has a **public part** available without authentication. It reveals all movies, their details as well as enables searches by whole or part of movies' titles, searches per genre and sorting by: name A-Z, name Z-A, rating 0-10 and rating 10-0. Pagination by different page size is also implemented.

There are two basic roles - **admin** and **user**.

After successful log-in, a **user** can add new movie. He can also edit / delete the movies added by him. 

The **admin** can edit / delete other users' records. He can also add / edit / delete movies.

A **star rating** functionality for logged-in users is implemented.

Every logged-in user can also make his own **watch list** of movies.

### Built With

Front-End - [ReactJS](https://react.dev/)

Back-End - [.NET Web Api](https://learn.microsoft.com/en-us/aspnet/core/tutorials/first-web-api?view=aspnetcore-8.0&tabs=visual-studio)

### Getting started
1. Download the project
2. Write your own connection string in appsettings.json in Movies-WebApi project
3. Open or download and open MSSQLServer instance
4. In directory "/Movies-WebApi/Movies-WebApi", open command terminal and run:
  ```sh
   dotnet ef migrations add InitialCreate
   ```

     ```sh
   dotnet ef database update
   ```

     ```sh
   dotnet run
   ```

5. In directory "/Movies-ReactApp", open command terminal and run:
   ```sh
   npm install
   ```
 
   ```sh
   npm run dev
   ```

### Users

| Username  | Password  | 
| ------------- | ------------- | 
| admin   | admin123456 | 
| George  | george123456 | 
| Katya  | katya123456 | 


### :camera: Screenshots

**Home Page - Searching / sorting by genres**

<p align="left">
    <img src="https://github.com/IvaSabotinova/Movies-App/assets/96121572/0fa14431-e7b0-4b9d-8000-8380c6d622bb" alt="HomePage-01" width="900px">
</p>

**Home Page – Sorting by name and rating (ascending & descending)**

<p align="left">
    <img src="https://github.com/IvaSabotinova/Movies-App/assets/96121572/b96c48a9-69ff-45c0-a20a-3990301eb309" alt="HomePage-02" width="900px">
</p>

**Home Page - Searching movies' titles**

<p align="left">
    <img src="https://github.com/IvaSabotinova/Movies-App/assets/96121572/76793ebc-f232-4315-9679-18c3f8421697" alt="HomePage-03" width="900px">
</p>

**Home Page – Searching / sorting by all / different criteria**

<p align="left">
    <img src="https://github.com/IvaSabotinova/Movies-App/assets/96121572/758c5c9b-08a1-43fd-a5ea-a958a126e2d8" alt="HomePage-04" width="900px">
</p>

**Home Page - Pagination**

<p align="left">
    <img src="https://github.com/IvaSabotinova/Movies-App/assets/96121572/f771534d-3de1-4d2f-adb9-7a168a42ee2f" alt="HomePage-05" width="900px">
</p>

**Home Page**

<p align="left">
    <img src="https://github.com/IvaSabotinova/Movies-App/assets/96121572/6d4a7bea-d69e-4465-b674-87df5b338665" alt="HomePage-06" width="900px">
</p>


**Add New Movie**

<p align="left">
    <img src="https://github.com/IvaSabotinova/Movies-App/assets/96121572/b5b25c7a-c914-45f8-bc3b-9ad4b464d7b6" alt="Add-New-Movie01" width="900px">
</p>

<p align="left">
    <img src="https://github.com/IvaSabotinova/Movies-App/assets/96121572/06cea231-ba6d-48ef-a9b7-95cbd8dd85ef" alt="Add-New-Movie02" width="900px">
</p>


**Movie Details Page & Star Rating Functionality**

<p align="left">
    <img src="https://github.com/IvaSabotinova/Movies-App/assets/96121572/8e7299cb-0b06-43e3-9167-4623f8197079" alt="MovieDetails" width="900px">
</p>


**Edit Movie**

<p align="left">
    <img src="https://github.com/IvaSabotinova/Movies-App/assets/96121572/2e78444a-d01a-48fb-913d-7f501179009e" alt="Edit-Movie" width="900px">    
</p>

**Star Rating Functionality & React-Toastify**

<p align="left">
    <img src="https://github.com/IvaSabotinova/Movies-App/assets/96121572/7cf199e6-5734-44d5-8e9d-7e7c0647a62d" alt="star-rating-new" width="900px">    
</p>

<p align="left">
    <img src="https://github.com/IvaSabotinova/Movies-App/assets/96121572/7f7a5fd6-694c-44d8-8ecd-6fb3757d468c" alt="star-rating-update" width="900px">    
</p>


**Register new user**

<p align="left">
    <img src="https://github.com/IvaSabotinova/Movies-App/assets/96121572/e7cf9622-f232-42a0-8db8-10a85cb536b5" alt="Register" width="900px">
</p>

**Log-in page**

<p align="left">
    <img src="https://github.com/IvaSabotinova/Movies-App/assets/96121572/6eb0a112-26f1-4b01-89ce-4a40a9d5eb0a" alt="Login" width="900px">
</p>

**Adding movies to watch list**


<p align="left">
    <img src="https://github.com/IvaSabotinova/Movies-App/assets/96121572/81af05f4-c597-4887-89d2-f978254a390f" alt="Login" width="900px">
</p>

<p align="left">
    <img src="https://github.com/IvaSabotinova/Movies-App/assets/96121572/c4a8e190-85ae-43c2-b528-2ae559620cf8" alt="Login" width="900px">
</p>

**Removing movie from watch list**

<p align="left">
    <img src="https://github.com/IvaSabotinova/Movies-App/assets/96121572/62b4f537-e68d-4f73-8f1c-987dbc7b6ffc" alt="Login" width="900px">
</p>