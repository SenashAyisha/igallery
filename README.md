# Ex.08 Design of Interactive Image Gallery
## Date:12.12.2025
Reference Number:25018487

## AIM:
To design a web application for an inteactive image gallery with minimum five images.

## DESIGN STEPS:

### Step 1:
Clone the github repository and create Django admin interface.

### Step 2:
Change settings.py file to allow request from all hosts.

### Step 3:
Use CSS for positioning and styling.

### Step 4:
Write JavaScript program for implementing interactivity.

### Step 5:
Validate the HTML and CSS code.

### Step 6:
Publish the website in the given URL.

## PROGRAM :
```
gallery.html
<!DOCTYPE html>
<html>
<head>
    <title>Image Gallery</title>
    <link rel="stylesheet" href="image.css">
</head>
<body>

    <div class="gallery">
        <img src="sun.png" width="300" height="300" class="gimg">
        <img src="mountain.png" width="300" height="300" class="gimg">
        <img src="night.png" width="300" height="300" class="gimg">
        <img src="moon.png" width="300" height="300"  class="gimg">
        <img src="earth.png" width="300" height="300" class="gimg">
        
    </div>

    <h1>&copy; Image Gallery | Designed by:</h1>
    <h2>F.SENASH AYISHA (25018487)</h2>

    <script src=""image.js""></script>
</body>
</html>

gallery.cs

* {
    margin: 0;
    padding: 0;
}

body {
    background: linear-gradient(135deg, #03323f, #2a5298, #00c6ff);
    font-family: Georgia, serif;
    text-align: center;
}

.gallery {
    margin-top: 60px;
    display: grid;
    gap: 20px;
    grid-template-columns: repeat(5, 1fr);
    padding: 20px;
}

.gimg {
    width: 100%;
    height: 350px;
    object-fit: cover;
    border: solid 10px rgba(93, 188, 25, 0.83);
    transition: transform 0.3s ease;
    cursor: pointer;
}

h1, h2 {
    margin-top: 40px;
    color: azure;
}

gallery.js
const images = document.querySelectorAll(".gimg");

images.forEach(img => {
    img.addEventListener("mouseover", () => {
        img.style.transform = "scale(1.8)";
    });
    img.addEventListener("mouseout", () => {
        img.style.transform = "scale(1)";
    });
});

```
## OUTPUT:
<img width="1239" height="921" alt="Screenshot 2025-12-12 204606" src="https://github.com/user-attachments/assets/3742b1c4-282b-464a-9b5b-19ea19ce4902" />

## RESULT:
The program for designing an interactive image gallery using HTML, CSS and JavaScript is executed successfully.
