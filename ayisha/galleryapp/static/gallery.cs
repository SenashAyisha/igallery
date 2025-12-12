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
