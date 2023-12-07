# Core_Mvc_CRUD_Using_EntityFramework
<a href="https://www.buymeacoffee.com/anandugnath" target="_blank"><img src="https://www.buymeacoffee.com/assets/img/custom_images/orange_img.png" alt="Buy Me A Coffee" style="height: 41px !important;width: 174px !important;box-shadow: 0px 3px 2px 0px rgba(190, 190, 190, 0.5) !important;-webkit-box-shadow: 0px 3px 2px 0px rgba(190, 190, 190, 0.5) !important;" ></a>

<h2>1.Introduction</h2>
In Project, we will learn CRUD Operations in ASP.NET Core 3.1. We will use Entityframework to interact with sql-server database and for performing CRUD operations.
<br/>
<br/>
<b>Dependencies:</b> It contains all the installed NuGet packages. We can manage the NuGet packages by right clicking on it.
<br/>
<b>Properties:</b> It contains launchSettings.json file which has visual studio profiles, iis and debug setting.
<br/>
<b>wwwroot folder:</b> It is the web root folder of asp.net core application where we can put all the static files such as  javascript , css.
<br/>
<b>Controllers:</b> It contails all the controller class we create in our asp.net core mvc application.
<br/>
<b>Models:</b> We can put all the model or view model classes inside this folder.
<br/>
<b>Views:</b> We can add views for certain actions methods inside view folder. There will be seperate folder for each view we create inside Views folder.
<br/>
<b>appsettings.json:</b> It is the application configuration file which is used to store configuration settings i.e connections strings of the database, global variables etc. 
</br>
<b>Program.cs :</b> Initially asp.net core application starts as a console application. In the Main method it calls the CreateWebHostBuilder() method that configures the asp.net core setting and launch it as asp.net core application.
<br/>
<b>Startup.cs:</b>  It contains the ConfigureServices() and Configure methods. As the name implies ConfigureServices() method configures all the services which are going to used by the application. Configure method take care of all the request processing pipelines.
<br/>
<b>Download Database </b>
<br/>
<kbd>[Download](https://github.com/anandugnath/CoreMVC_CRUD/blob/main/MVC_Core_CRUD/MVC_CORE_CRUD/Database/DB.sql)</kbd>
 
<br/>
<h3> Install All Necessary Packages From NuGet </h3>
</br>
https://www.nuget.org/packages/EntityFramework/6.4.4
<br/>
https://www.nuget.org/packages/Microsoft.Extensions.Configuration.Json/8.0.0?_src=template
<br/>
https://www.nuget.org/packages/System.Configuration.ConfigurationManager/8.0.0?_src=template
<br/>
https://www.nuget.org/packages/Newtonsoft.Json/13.0.3?_src=template
<br/>
<br/>
<br/>
 
