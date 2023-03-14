# Steps for creating an MVC project using .Net core

Choose the folliwng template in visual studio:

<img width="924" alt="image" src="https://user-images.githubusercontent.com/126539919/224893781-6bb112f9-fbc4-46b9-b8d8-122aa0bc1dd1.png">

Then, make sure to check off "Do not use top-level statements":

<img width="939" alt="image" src="https://user-images.githubusercontent.com/126539919/224893865-ac9da355-0bf6-4cdc-b633-20fb3815c415.png">

Once the project is created, right click on the project file, and click "Edit Project File":

<img width="748" alt="image" src="https://user-images.githubusercontent.com/126539919/224893969-1c90cbe3-e7be-4716-a4f7-8be635b02af6.png">

In there, remove the following line:

```
<Nullable>enable</Nullable>
```

and then click save and close that file.

Then, in the HomeController, remove everything except for the following:


```
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
```

Then, go into your `Views` folder, and delete the `Privacy.cshtml` file.

Then, go into the `Views/Shared` folder and open the `_Layout.cshtml` file. In there, remove this line from the navbar:

```
      <li class="nav-item">
          <a class="nav-link text-dark" asp-area="" asp-controller="Home" asp-action="Privacy">Privacy</a>
      </li>
```

If you want to add your own nav link on top, add something like the following:

```
      <li class="nav-item">
          <a class="nav-link text-dark" asp-controller="PutYourControllerNameHere" asp-action="PutYourActionNameHere">LinkTextToDisplay</a>
      </li>
```

Then, at the bottom of the layout, remove the footer:

```
    <footer class="border-top footer text-muted">
        <div class="container">
            &copy; 2023 - WebApplication17 - <a asp-area="" asp-controller="Home" asp-action="Privacy">Privacy</a>
        </div>
    </footer>
```    

