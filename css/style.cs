* {
  box-sizing: border-box;
  margin: 0;
  padding: 0;
}

ul li {
  list-style-type: none;
}

body {
  font-family: "barlow-regular", sans-serif;
  line-height: 1.4;
  overflow: visible;
  overflow-x: hidden;
}

h2 {
  font-family: barlow-medium;
}

p {
  color: #818181;
}

img {
  width: 100%;
}

i {
  color: #ffffff;
}

button {
  display: block;
  background: #AD1457;
  color: #ffffff;
}

.container {
  max-width: 1100px;
  margin: 0 auto;
}

nav .navbar {
  width: 100%;
  display: flex;
  position: relative;
  z-index: 99999;
}
nav .navbar .first-nav {
  position: fixed;
  display: flex;
  background-color: #121212;
  width: 100%;
  padding: 0.4em 1em;
}
nav .navbar .first-nav .left-nav {
  width: 50%;
}
nav .navbar .first-nav .left-nav i {
  font-size: 17px;
  padding: 0.3em 0.5em 0 0;
}
nav .navbar .first-nav .right-nav {
  display: flex;
  width: 50%;
  justify-content: flex-end;
  text-align: center;
}
nav .navbar .first-nav .right-nav button {
  color: #ffffff;
  font-size: 0.9rem;
  font-weight: 500;
  padding: 0.4em 1.2em;
  border: 1px solid #ffffff;
  border-radius: 4px;
}
nav .second-nav {
  width: 100%;
  background-color: #ffffff;
  margin-top: 2.7em;
}
nav .second-nav .container {
  display: flex;
  justify-content: space-between;
  align-items: center;
  padding: 1em 0;
}
nav .second-nav .right-nav {
  padding: 0 4em 0 0;
}
nav .second-nav .right-nav ul {
  display: flex;
  color: #1f1f1f;
  font-size: 0.9rem;
}
nav .second-nav .right-nav ul :first-child {
  background: #AD1457;
  color: #ffffff;
  padding: 0.6em 0.8em;
  border-radius: 2px;
}
nav .second-nav .right-nav ul li {
  padding: 0.5em 0.6em;
}
nav .second-nav .right-nav ul li :first-child {
  background: #AD1457;
}

main .section-1-bg {
  background: url(../uploads/bg-img.jpg);
  background-size: cover;
  background-attachment: fixed;
  overflow: hidden;
  width: 100%;
}
main .section-1-bg .section-1 {
  height: 100%;
  display: flex;
  color: #ffffff;
  padding: 8em 0 8em 5em;
}
main .section-1-bg .section-1 .content {
  width: 55%;
}
main .section-1-bg .section-1 .content h1 {
  font-size: 4em;
  font-family: "barlow-bold";
}
main .section-1-bg .section-1 .content p {
  padding-top: 1em;
}
main .section-1-bg .section-1 .content .btn {
  padding-top: 3em;
  display: flex;
  gap: 2em;
}
main .section-1-bg .section-1 .content .btn button {
  background: #121212;
  padding: 0.7em 2em;
  border-radius: 5px;
  border: 1px solid #ffffff;
  font-size: 1rem;
  text-align: center;
}
main .section-1-bg .section-1 .content .btn button i {
  padding-right: 0.2em;
}
main .section-1-bg .section-1 .picture {
  display: flex;
  width: 45%;
  position: relative;
}
main .section-1-bg .section-1 .picture .iphone-1 {
  width: 120%;
  height: auto;
  position: absolute;
  right: 9%;
  z-index: 2;
}
main .section-1-bg .section-1 .picture .iphone-2 {
  width: 110%;
  height: auto;
  position: absolute;
  right: -13%;
  bottom: -110%;
  z-index: 1;
}
main .section-1-bg .section-1 .picture img {
  max-width: 100%;
  height: auto;
}
main .section-2-bg {
  margin: 0 0 4em 0;
}
main .section-2-bg .section-2 .content-1 {
  text-align: center;
  padding: 6em 0 0 0;
}
main .section-2-bg .section-2 .content-1 h2 {
  font-size: 2rem;
  font-weight: 700;
}
main .section-2-bg .section-2 .content-1 p {
  font-weight: 500;
}
main .section-2-bg .section-2 .content-2 {
  display: flex;
  margin-bottom: 3em;
  padding: 4em 0 0 0;
}
main .section-2-bg .section-2 .content-2 i {
  color: #1f1f1f;
}
main .section-2-bg .section-2 .content-2 .column-left,
main .section-2-bg .section-2 .content-2 .column-right {
  padding-top: 0.5em;
}
main .section-2-bg .section-2 .content-2 .column-left ul li,
main .section-2-bg .section-2 .content-2 .column-right ul li {
  display: flex;
  padding-top: 2.4em;
}
main .section-2-bg .section-2 .content-2 .column-left ul li p,
main .section-2-bg .section-2 .content-2 .column-right ul li p {
  font-size: 0.8rem;
  color: #818181;
  padding-top: 1em;
}
main .section-2-bg .section-2 .content-2 .column-left ul li i,
main .section-2-bg .section-2 .content-2 .column-right ul li i {
  background: #AD1457;
  padding: 1em;
  color: #ffffff;
  font-size: 1.2rem;
  border-radius: 5px;
}
main .section-2-bg .section-2 .content-2 .column-right {
  flex: 1;
}
main .section-2-bg .section-2 .content-2 .column-right ul li {
  justify-content: start;
}
main .section-2-bg .section-2 .content-2 .column-right .content {
  padding-left: 1em;
}
main .section-2-bg .section-2 .content-2 .column-middle {
  flex: 1;
  background: url(../images/phonebg.jpg) center top no-repeat;
  background-size: 65%;
  height: 515px;
  position: relative;
}
main .section-2-bg .section-2 .content-2 .column-middle .pic {
  width: 58%;
  position: absolute;
  right: 21.5%;
  top: 11%;
  height: auto;
}
main .section-2-bg .section-2 .content-2 .column-left {
  flex: 1;
}
main .section-2-bg .section-2 .content-2 .column-left ul li {
  justify-content: end;
}
main .section-2-bg .section-2 .content-2 .column-left .content {
  padding-right: 1em;
  text-align: end;
}
main .section-3-bg {
  margin: 0 0 9em 0;
}
main .section-3-bg .section-3 .work {
  display: flex;
  color: #ffffff;
  height: 260px;
}
main .section-3-bg .section-3 .work .content {
  width: 25%;
  padding: 0 3em 3em 2em;
  line-height: 2em;
}
main .section-3-bg .section-3 .work .content h2 {
  display: block;
  font-size: 9rem;
  color: rgba(255, 255, 255, 0.1);
  font-family: barlow-bold;
  padding: 0 0 0 0.2em;
  margin-bottom: -0.05em;
  line-height: 110px !important;
  position: relative;
  z-index: 1;
}
main .section-3-bg .section-3 .work .content h3 {
  font-size: 2rem;
  position: relative;
  z-index: 2;
}
main .section-3-bg .section-3 .work .content p {
  color: #ffffff;
  font-size: 0.8rem;
}
main .section-3-bg .section-3 .work .colon-2,
main .section-3-bg .section-3 .work .colon-4 {
  background-color: #AD1457;
}
main .section-3-bg .section-3 .work .colon-1,
main .section-3-bg .section-3 .work .colon-3 {
  background-color: #C62828;
}
main .section-3-bg .section-3 .work #height {
  height: 290px;
}
main .section-4 {
  text-align: center;
  margin-bottom: 7em;
}
main .section-4 .content-1 h2 {
  font-size: 2rem;
  font-family: barlow-bold;
}
main .section-4 .content-1 p {
  padding-top: 1em;
}
main .section-4 .content-2 .cards {
  display: flex;
  flex-wrap: wrap;
  justify-content: center;
  gap: 2em;
  padding: 3em 0 0 0;
}
main .section-4 .content-2 .cards img {
  width: 20%;
}
main .section-5-bg {
  background: url(../uploads/ben_img.jpg);
  width: 100%;
  background-attachment: fixed;
  background-size: cover;
  overflow: hidden;
  margin-bottom: 7em;
}
main .section-5-bg .section-5 {
  display: flex;
  align-items: center;
  color: #ffffff;
  padding: 8em 0 8em 0;
}
main .section-5-bg .section-5 p {
  color: #ffffff;
}
main .section-5-bg .section-5 .content-left {
  width: 50%;
  padding: 2em 0 0 0;
}
main .section-5-bg .section-5 .content-left h2 {
  font-size: 2.5rem;
  padding-bottom: 0.6em;
}
main .section-5-bg .section-5 .content-left ul {
  display: flex;
  padding: 3em 0 3em 0;
  gap: 1em;
}
main .section-5-bg .section-5 .content-left ul li {
  font-size: 0.8rem;
  font-weight: lighter;
  text-align: center;
}
main .section-5-bg .section-5 .content-left ul li i {
  font-size: 2rem;
  padding-right: 0.3em;
  vertical-align: middle;
}
main .section-5-bg .section-5 .content-left .btn button {
  background: #121212;
  padding: 0.7em 2em;
  border-radius: 5px;
  border: 1px solid #ffffff;
  font-size: 1rem;
  text-align: center;
}
main .section-5-bg .section-5 .content-right {
  width: 50%;
  right: 5%;
  position: absolute;
  z-index: 2;
}
main .section-5-bg .section-5 .content-right img {
  width: 150%;
}
main .section-6 .content-1 {
  text-align: center;
  margin-bottom: 4em;
}
main .section-6 .content-1 h2 {
  font-size: 2.4rem;
  padding-bottom: 0.6em;
}
main .section-6 .content-2 {
  margin-bottom: 4em;
}
main .section-6 .content-2 .cards {
  display: flex;
  gap: 1.5em;
}
main .section-6 .content-2 .cards .card {
  width: 30%;
  text-align: center;
  border: 2px solid rgba(129, 129, 129, 0.1);
}
main .section-6 .content-2 .cards .card .content .footer-card {
  margin: 1em 0;
  display: flex;
  justify-content: center;
  gap: 0.4em;
}
main .section-6 .content-2 .cards .card .content p {
  font-size: 0.8rem;
}
main .section-6 .content-2 .cards .card .content small {
  color: #818181;
  display: block;
  font-size: 0.7rem;
  font-weight: bold;
  margin-bottom: 1em;
}
main .section-6 .content-2 .cards .card .content i {
  color: #ffffff;
  padding: 0.4em;
  background-color: #e80d45;
  border-radius: 4px;
}
main .section-6 .content-2 .cards .card img {
  width: 80%;
  border-radius: 50%;
  margin: 2em;
}
main .section-7-bg {
  background: url(../uploads/ben_img_2.jpg);
  background-attachment: fixed;
  background-size: cover;
  background-position: center;
  overflow: hidden;
  color: #ffffff !important;
  margin-bottom: 7em;
}
main .section-7-bg .section-7 {
  padding: 6em 0 6em 0;
}
main .section-7-bg .section-7 .content {
  display: flex;
  justify-content: space-between;
}
main .section-7-bg .section-7 .content .square {
  display: flex;
  align-items: center;
  max-width: 25%;
}
main .section-7-bg .section-7 .content .square i {
  font-size: 2rem;
  background-color: #C62828;
  padding: 0.8em;
  border-radius: 4px;
  box-shadow: 0 0 10px rgba(0, 0, 0, 0.2);
}
main .section-7-bg .section-7 .content .square .content {
  display: flex;
  flex-direction: column;
  padding-left: 1em;
}
main .section-7-bg .section-7 .content .square .content p {
  font-size: 2rem;
  font-family: barlow-medium;
}
main .section-7-bg .section-7 .content .square .content h3 {
  font-size: 1rem;
  font-weight: 300;
}
main .section-7-bg .section-7 .content .square span,
main .section-7-bg .section-7 .content .square h3,
main .section-7-bg .section-7 .content .square p {
  display: block;
  color: #ffffff;
}
main .section-8 .content-1 {
  text-align: center;
}
main .section-8 .content-1 h2 {
  font-size: 2.4rem;
  font-weight: bolder;
  padding-bottom: 0.6em;
}
main .section-8 .content-2 {
  padding-top: 3em;
}
main .section-8 .content-2 .cards {
  display: flex;
  gap: 2em;
}
main .section-8 .content-2 .cards .card {
  padding: 1.5em;
  box-shadow: 0 5px 7px rgba(0, 0, 0, 0.1);
}
main .section-8 .content-2 .cards .card p {
  font-size: 0.8em;
  padding-top: 1em;
}
main .section-8 .content-2 .cards .card .title {
  display: flex;
  align-items: flex-start;
}
main .section-8 .content-2 .cards .card .title i {
  color: #AD1457;
  font-size: 2rem;
  padding-right: 0.5em;
}
main .section-8 .content-2 .cards .card .footer-card {
  margin-top: 4em;
}

/*# sourceMappingURL=style.cs.map */
