@import url("https://fonts.googleapis.com/css2?family=Barlow:ital,wght@0,100;0,200;0,300;0,400;0,500;0,600;0,700;0,800;0,900;1,100;1,200;1,300;1,400;1,500;1,600;1,700;1,800;1,900&family=Cinzel:wght@400;500;600;700;800;900&family=Frank+Ruhl+Libre:wght@300;400;500;600;700;800;900&family=Fraunces:wght@700;800;900&family=League+Spartan&family=Open+Sans:ital,wght@0,300;0,400;0,500;0,600;0,700;0,800;1,800&family=Poppins&family=Raleway:ital,wght@0,100;0,200;0,300;0,400;0,500;0,600;0,700;0,800;0,900;1,100;1,200;1,300;1,400;1,500;1,600;1,700;1,800;1,900&family=VT323&display=swap");
@import url("https://fonts.googleapis.com/css2?family=Barlow:ital,wght@0,100;0,200;0,300;0,400;0,500;0,600;0,700;0,800;0,900;1,100;1,200;1,300;1,400;1,500;1,600;1,700;1,800;1,900&family=Cinzel:wght@400;500;600;700;800;900&family=Frank+Ruhl+Libre:wght@300;400;500;600;700;800;900&family=Fraunces:wght@700;800;900&family=League+Spartan&family=Open+Sans:ital,wght@0,300;0,400;0,500;0,600;0,700;0,800;1,800&family=Poppins&family=Raleway:ital,wght@0,100;0,200;0,300;0,400;0,500;0,600;0,700;0,800;0,900;1,100;1,200;1,300;1,400;1,500;1,600;1,700;1,800;1,900&family=VT323&display=swap");
@font-face {
  font-family: fa-brand-400;
  src: url(/assets/font/fa-brands-400.woff2);
}
@font-face {
  font-family: fa-light-300;
  src: url(/assets/font/fa-light-300.woff2);
}
@font-face {
  font-family: fa-regular-400;
  src: url(/assets/font/fa-regular-400.woff2);
}
@font-face {
  font-family: fa-solid-900;
  src: url(/assets/font/fa-solid-900.woff2);
}
@font-face {
  font-family: fa-brand-400;
  src: url(/assets/font/fa-brands-400.woff2);
}
@font-face {
  font-family: fa-light-300;
  src: url(/assets/font/fa-light-300.woff2);
}
@font-face {
  font-family: fa-regular-400;
  src: url(/assets/font/fa-regular-400.woff2);
}
@font-face {
  font-family: fa-solid-900;
  src: url(/assets/font/fa-solid-900.woff2);
}
nav {
  display: flex;
  justify-content: space-around;
  padding-top: 2vw;
}
nav ul {
  display: flex;
  flex-direction: row;
  font-size: 1.5rem;
  list-style: none;
}
nav ul li a {
  display: flex;
  text-decoration: none;
  color: rgb(255, 255, 255);
  font-style: normal;
  font-size: 1.5rem;
  padding-right: 2vw;
}
nav ul li a:hover {
  color: rgb(190, 161, 95);
  cursor: pointer;
}
nav ul li a:active {
  color: rgb(190, 161, 95);
}
nav address a {
  display: flex;
  flex-direction: row;
  text-decoration: none;
  color: rgb(255, 255, 255);
  font-style: normal;
  font-size: 1.5rem;
  padding-right: 2vw;
}
nav address a:hover {
  color: rgb(190, 161, 95);
  cursor: pointer;
}
nav address a img {
  width: 2vw;
}
nav address a p {
  padding-right: 2vw;
}
nav address button {
  color: rgb(255, 255, 255);
  background-color: rgb(190, 161, 95);
  text-transform: uppercase;
  font-weight: 600;
  border-radius: 5px;
  border: none;
  padding: 1rem 2rem;
}

:root {
  font-size: 10px;
  font-family: "fa-brand-400";
}

body {
  margin: 0rem;
}

header {
  width: 100vw;
  height: 50vw;
  background: linear-gradient(to bottom right, rgb(0, 0, 0), transparent), url("/assets/img/slider/img_bg_slider_home01.jpg");
  background-repeat: no-repeat;
  background-size: cover;
  background-position: center center;
}
header h1 {
  color: white;
  width: 33.3333333333vw;
  font-size: 10rem;
  font-family: "Cinzel", serif;
  font-weight: 100;
  text-transform: uppercase;
  padding: 6.25vw 0 0 12.5vw;
  margin-top: 0%;
}
header .bestQualityFoods {
  float: right;
}

@font-face {
  font-family: fa-brand-400;
  src: url(/assets/font/fa-brands-400.woff2);
}
@font-face {
  font-family: fa-light-300;
  src: url(/assets/font/fa-light-300.woff2);
}
@font-face {
  font-family: fa-regular-400;
  src: url(/assets/font/fa-regular-400.woff2);
}
@font-face {
  font-family: fa-solid-900;
  src: url(/assets/font/fa-solid-900.woff2);
}
footer {
  font-size: larger;
  color: white;
  background-image: url("/assets/img/footer/img-ng-footer.jpg");
  padding-top: 2rem;
}
footer img {
  display: flex;
  justify-content: center;
  align-items: center;
}
footer .top_img {
  margin: auto;
}
footer section .logo_cuilleur_foot {
  height: 5vw;
}
footer input {
  height: 3vw;
  width: 20vw;
}
footer span i {
  background-color: rgb(190, 161, 95);
  height: 5vw;
  width: 4vw;
}
footer ul {
  display: flex;
  flex-direction: column;
  list-style: none;
}
footer .foot_info {
  display: flex;
  justify-content: space-around;
  padding-bottom: 2rem;
}
footer .foot_copy_social {
  display: flex;
  justify-content: space-around;
}
footer .social_foot {
  display: flex;
  flex-direction: row;
  margin: 0vw 2vw 2vw 2vw;
}
footer hr {
  width: 85vw;
}

/*# sourceMappingURL=style.cs.map */
