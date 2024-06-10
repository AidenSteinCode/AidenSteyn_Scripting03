@import url('https://fonts.googleapis.com/css2?family=Roboto:wght@400;700&display=swap');

body {
    background: linear-gradient(to bottom, grey, white);
    font-family: 'Roboto', sans-serif;
    margin: 0;
    padding: 0;
    overflow-x: hidden;
}

h1 {
    color: #007bff;
    margin-top: 20px;
    font-family: 'Roboto', sans-serif;
}

.jumbotron {
    background-color: #007bff;
    color: white;
    padding: 40px 20px;
    font-family: 'Roboto', sans-serif;
}

.navbar {
    margin-bottom: 20px;
}

.paragraph-container {
    border: 2px solid #007bff;
    border-radius: 10px;
    padding: 20px;
    margin: 20px 0;
    background-color: white;
    opacity: 0;
    transform: translateY(20px);
    animation: fadeInUp 1s ease-in-out forwards;
}

.paragraph-container p {
    margin: 10px 0;
    font-family: 'Roboto', sans-serif;
}

@keyframes fadeInUp {
    to {
        opacity: 1;
        transform: translateY(0);
    }
}

#animated-s {
    position: absolute;
    top: -100px;
    left: 50%;
    transform: translateX(-50%);
    font-size: 50px;
    font-weight: bold;
    color: #007bff;
    animation: dropS 2s ease forwards;
}

@keyframes dropS {
    0% {
        top: -100px;
    }
    100% {
        top: 10px;
    }
}

.hero-section {
    position: relative;
    height: 100vh;
    display: flex;
    align-items: center;
    justify-content: center;
    overflow: hidden;
}

.hero-section img {
    width: 100%;
    height: 100%;
    object-fit: cover;
    position: absolute;
    top: 0;
    left: 0;
    z-index: 0;
}

.hero-section .overlay {
    position: absolute;
    top: 0;
    left: 0;
    width: 100%;
    height: 100%;
    background: rgba(0, 0, 0, 0.5); 
    z-index: 1;
}

.hero-section .hero-content {
    color: white;
    z-index: 2;
    text-align: center;
}

.hero-section h1 {
    font-size: 4em;
    margin: 0;
}

.hero-section p {
    font-size: 1.5em;
    margin: 10px 0 0;
}

.image-grid {
    display: flex;
    flex-wrap: wrap;
    gap: 20px;
    justify-content: center;
    margin-bottom: 40px;
}

.image-grid-item {
    width: 30%;
    text-align: center;
}

.image-grid img {
    border: 5px solid #007bff;
    border-radius: 10px;
    width: 100%;
    transition: transform 0.3s;
}

.image-grid img:hover {
    transform: scale(1.05);
}

.image-description {
    margin-top: 10px;
}
