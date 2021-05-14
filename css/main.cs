@font-face {
  font-family: "KPMG";
  src: url("KPMG-Extralight.woff2") format("woff2"), url("KPMG-Extralight.woff") format("woff");
  font-weight: 200;
  font-style: normal;
  font-display: swap;
}
@font-face {
  font-family: "Univers for KPMG";
  src: url("UniversforKPMG-Bold.eot");
  src: url("UniversforKPMG-Bold.eot?#iefix") format("embedded-opentype"), url("UniversforKPMG-Bold.woff2") format("woff2"), url("UniversforKPMG-Bold.woff") format("woff"), url("UniversforKPMG-Bold.ttf") format("truetype");
  font-weight: bold;
  font-style: normal;
  font-display: swap;
}
/* BOOTSTRAP HACKS */
@media (min-width: 1200px) {
  .container, .container-lg, .container-md, .container-sm, .container-xl {
    max-width: 75%;
  }
}
html {
  width: 100%;
  max-width: 1920px;
  margin-left: auto;
  margin-right: auto;
}

.nopad {
  padding-left: 0px;
  padding-right: 0px;
}

.bg__shape {
  height: 100%;
  width: 100%;
}

#showHere {
  visibility: hidden;
}

h1 {
  font-family: "KPMG", sans-serif;
  font-size: 200px;
  color: #fff;
  font-weight: 200;
  font-style: normal;
}

h2 {
  font-family: "Work Sans", sans-serif;
  font-style: normal;
  font-weight: bold;
  font-size: 40px;
  color: #fff;
  letter-spacing: 2px;
}

h3 {
  font-family: "Work Sans", sans-serif;
  font-style: normal;
  font-weight: bold;
  font-size: 30px;
  color: #fff;
  letter-spacing: 2px;
}

h4 {
  font-family: "Work Sans", sans-serif;
  font-style: normal;
  font-weight: bold;
  font-size: 24px;
  color: #fff;
  letter-spacing: 2px;
  text-transform: uppercase;
}

p {
  font-family: "Work Sans", sans-serif;
  font-style: normal;
  font-weight: normal;
  font-size: 18px;
  color: #fff;
  letter-spacing: 2px;
}

span.small {
  text-align: center;
  font-family: "Work Sans", sans-serif;
  font-style: normal;
  font-weight: normal;
  font-size: 16px;
  color: #fff;
  letter-spacing: 2px;
}

.button__blue {
  background-color: #0991da;
  width: 280px;
  height: 43.0717773438px;
  text-align: center;
  font-family: "Work Sans", sans-serif;
  font-style: normal;
  font-weight: bold;
  font-size: 24px;
  color: #fff;
  letter-spacing: 2px;
  display: flex;
  justify-content: center;
  align-items: center;
  border-radius: 15px;
  text-decoration: none;
}
.button__blue:hover {
  background-color: #fff;
  color: #470A68;
  text-decoration: none;
}

.button__purple {
  background-color: #c02b7c;
  width: 280px;
  height: 43.0717773438px;
  text-align: center;
  font-family: "Work Sans", sans-serif;
  font-style: normal;
  font-weight: bold;
  font-size: 24px;
  color: #fff;
  letter-spacing: 2px;
  display: flex;
  justify-content: center;
  align-items: center;
  border-radius: 15px;
  text-decoration: none;
}
.button__purple:hover {
  background-color: #fff;
  color: #470A68;
  text-decoration: none;
}

.button__transparent {
  background-color: transparent;
  border: 2px solid #c02b7c;
  width: 280px;
  height: 43.0717773438px;
  text-align: center;
  font-family: "Work Sans", sans-serif;
  font-style: normal;
  font-weight: bold;
  font-size: 24px;
  color: #fff;
  letter-spacing: 2px;
  display: flex;
  justify-content: center;
  align-items: center;
  border-radius: 15px;
  text-decoration: none;
}
.button__transparent:hover {
  background-color: #fff;
  border: 2px solid #fff;
  color: #470A68;
  text-decoration: none;
}

/*----------------------------------------------------------------------------*\
  Headhesive Specific Styles
/*----------------------------------------------------------------------------*/
/**
 * Headhesive element clone
 * > `clone` class for the cloned element:
 *
 * @example
 * var options = {
 *   classes {
 *     clone: 'banner--clone';
 *   }
 * }
 */
.banner--clone {
  /* Required styles */
  position: fixed;
  z-index: 1;
  top: 0;
  left: 0;
  /* Additional styles */
  background: #c95a5d;
  /* Translate -100% to move off screen */
  -webkit-transform: translateY(-100%);
  -ms-transform: translateY(-100%);
  transform: translateY(-100%);
  /* Animations */
  -webkit-transition: all 300ms ease-in-out;
  -moz-transition: all 300ms ease-in-out;
  transition: all 300ms ease-in-out;
}

/**
 * Headhesive stick
 * > `stick` class for the cloned element:
 *
 * @example
 * var options = {
 *   classes {
 *     stick: 'banner--stick';
 *   }
 * }
 */
.banner--stick {
  /* Translate back to 0%; */
  -webkit-transform: translateY(0%);
  -ms-transform: translateY(0%);
  transform: translateY(0%);
}

/**
 * Headhesive unstick
 * > `unstick` class for the cloned element:
 *
 * @example
 * var options = {
 *   classes {
 *     unstick: 'banner--unstick';
 *   }
 * }
 */
.banner--unstick {
  /* Not required to use, but could be useful to have */
}

.desktop-nav {
  top: 0px;
}
.desktop-nav .navbar-dark {
  background-color: #461f4b;
}
.desktop-nav .navbar-dark .navbar-nav {
  display: flex;
  width: 100%;
  align-items: center;
  justify-content: flex-end;
}
.desktop-nav .navbar-dark .navbar-nav .nav-item {
  padding-right: 3.5rem;
}
.desktop-nav .navbar-dark .navbar-nav .nav-item .nav-link {
  white-space: nowrap;
  text-align: center;
  font-family: "Work Sans", sans-serif;
  font-style: normal;
  font-weight: bold;
  font-size: 14px;
  color: #fff;
  letter-spacing: 2px;
  text-transform: uppercase;
}
.desktop-nav .navbar-dark .navbar-nav .nav-item .nav-link:hover {
  color: #0991da;
}
.desktop-nav .btn {
  background-color: #0991da;
  border-radius: 7px;
  color: #fff;
  white-space: nowrap;
  text-align: center;
  font-family: "Work Sans", sans-serif;
  font-style: normal;
  font-weight: bold;
  font-size: 14px;
  letter-spacing: 2px;
  border: none;
  border-radius: 7px;
  color: #fff;
  white-space: nowrap;
  text-align: center;
  font-family: "Work Sans", sans-serif;
  font-style: normal;
  font-weight: bold;
  font-size: 14px;
  letter-spacing: 2px;
  border: none;
  padding-left: 2.5em;
  padding-right: 2.5em;
  text-transform: uppercase;
  padding-top: 3px;
  padding-bottom: 3px;
  text-transform: uppercase;
}
.desktop-nav .btn:hover {
  background: white;
  color: #470A68;
}

.banner {
  left: 0;
  right: 0;
  max-width: 1920px;
  margin: auto;
  z-index: 10000000000000002000;
}

/* Add some content at the bottom of the video/page */
.hero {
  overflow: hidden;
  position: relative;
  margin-bottom: -0.4em;
}
.hero #bgVideo {
  position: relative;
  right: 0;
  top: 0;
  height: 100vh;
  width: 100%;
  object-fit: cover;
}
.hero .wrapper {
  position: absolute;
  top: 0;
  left: 0;
  right: 0;
}
.hero .wrapper .content {
  display: flex;
  justify-content: center;
  align-items: flex-start;
  height: 100vh;
  flex-direction: column;
  position: relative;
  margin-top: -10rem;
}
.hero .wrapper .content .sub-title {
  margin-top: -0.5em;
  margin-bottom: 1em;
}
.hero .wrapper .content .button {
  width: 286px;
  height: 63px;
  background-color: #fff;
  font-family: "Work Sans", sans-serif;
  font-style: normal;
  font-weight: bold;
  font-size: 22px;
  color: #470A68;
  letter-spacing: 2px;
  text-align: center;
  display: flex;
  justify-content: center;
  align-items: center;
  border-radius: 20px;
  text-decoration: none;
  text-transform: uppercase;
}
.hero .wrapper .content .button:hover {
  background-color: #0991da;
  color: #fff;
}

.about {
  position: relative;
  width: 100%;
  overflow: visible;
  z-index: 10;
}
.about .content {
  position: absolute;
  top: 0px;
  display: flex;
  flex-direction: column;
  height: 100%;
  justify-content: space-between;
  left: 0;
  right: 0;
  padding-top: 3rem;
}
.about .content .title {
  padding-bottom: 2.5rem;
}
.about .content .text {
  display: flex;
  flex-direction: column;
  width: 95%;
}
.about .content .row.buttons {
  width: 45%;
  justify-content: space-between;
  margin: 0px;
}
.about .content .row.buttons .item {
  width: 100%;
  max-width: 280px;
}
.about .content .row.buttons .item .button__one, .about .content .row.buttons .item .button__two {
  width: 280px;
  height: 73.0717773438px;
  text-transform: uppercase;
}
.about .content .row.buttons .item .small {
  justify-content: center;
  display: flex;
  margin-top: 10px;
}

@font-face {
  font-family: "KPMG";
  src: url("KPMG-Extralight.woff2") format("woff2"), url("KPMG-Extralight.woff") format("woff");
  font-weight: 200;
  font-style: normal;
  font-display: swap;
}
@font-face {
  font-family: "Univers for KPMG";
  src: url("UniversforKPMG-Bold.eot");
  src: url("UniversforKPMG-Bold.eot?#iefix") format("embedded-opentype"), url("UniversforKPMG-Bold.woff2") format("woff2"), url("UniversforKPMG-Bold.woff") format("woff"), url("UniversforKPMG-Bold.ttf") format("truetype");
  font-weight: bold;
  font-style: normal;
  font-display: swap;
}
/* BOOTSTRAP HACKS */
@media (min-width: 1200px) {
  .container, .container-lg, .container-md, .container-sm, .container-xl {
    max-width: 75%;
  }
}
html {
  width: 100%;
  max-width: 1920px;
  margin-left: auto;
  margin-right: auto;
}

.nopad {
  padding-left: 0px;
  padding-right: 0px;
}

.bg__shape {
  height: 100%;
  width: 100%;
}

#showHere {
  visibility: hidden;
}

h1 {
  font-family: "KPMG", sans-serif;
  font-size: 200px;
  color: #fff;
  font-weight: 200;
  font-style: normal;
}

h2 {
  font-family: "Work Sans", sans-serif;
  font-style: normal;
  font-weight: bold;
  font-size: 40px;
  color: #fff;
  letter-spacing: 2px;
}

h3 {
  font-family: "Work Sans", sans-serif;
  font-style: normal;
  font-weight: bold;
  font-size: 30px;
  color: #fff;
  letter-spacing: 2px;
}

h4 {
  font-family: "Work Sans", sans-serif;
  font-style: normal;
  font-weight: bold;
  font-size: 24px;
  color: #fff;
  letter-spacing: 2px;
  text-transform: uppercase;
}

p {
  font-family: "Work Sans", sans-serif;
  font-style: normal;
  font-weight: normal;
  font-size: 18px;
  color: #fff;
  letter-spacing: 2px;
}

span.small {
  text-align: center;
  font-family: "Work Sans", sans-serif;
  font-style: normal;
  font-weight: normal;
  font-size: 16px;
  color: #fff;
  letter-spacing: 2px;
}

.button__blue {
  background-color: #0991da;
  width: 280px;
  height: 43.0717773438px;
  text-align: center;
  font-family: "Work Sans", sans-serif;
  font-style: normal;
  font-weight: bold;
  font-size: 24px;
  color: #fff;
  letter-spacing: 2px;
  display: flex;
  justify-content: center;
  align-items: center;
  border-radius: 15px;
  text-decoration: none;
}
.button__blue:hover {
  background-color: #fff;
  color: #470A68;
  text-decoration: none;
}

.button__purple {
  background-color: #c02b7c;
  width: 280px;
  height: 43.0717773438px;
  text-align: center;
  font-family: "Work Sans", sans-serif;
  font-style: normal;
  font-weight: bold;
  font-size: 24px;
  color: #fff;
  letter-spacing: 2px;
  display: flex;
  justify-content: center;
  align-items: center;
  border-radius: 15px;
  text-decoration: none;
}
.button__purple:hover {
  background-color: #fff;
  color: #470A68;
  text-decoration: none;
}

.button__transparent {
  background-color: transparent;
  border: 2px solid #c02b7c;
  width: 280px;
  height: 43.0717773438px;
  text-align: center;
  font-family: "Work Sans", sans-serif;
  font-style: normal;
  font-weight: bold;
  font-size: 24px;
  color: #fff;
  letter-spacing: 2px;
  display: flex;
  justify-content: center;
  align-items: center;
  border-radius: 15px;
  text-decoration: none;
}
.button__transparent:hover {
  background-color: #fff;
  border: 2px solid #fff;
  color: #470A68;
  text-decoration: none;
}

.timeline {
  display: block;
  background-color: #6d2077;
}
.timeline .content {
  display: flex;
  z-index: 1;
  padding-top: 6rem;
}
.timeline .content .tab-content {
  padding-top: 1em;
}
.timeline .content .nav-tabs .nav-item.show .nav-link, .timeline .content .nav-tabs .nav-link.active {
  color: unset;
  background-color: unset;
  border-color: unset;
}
.timeline .content .nav-tabs .nav-link {
  border: unset;
  border-top-left-radius: unset;
  border-top-right-radius: unset;
}
.timeline .content .nav-tabs {
  border-bottom: none;
  width: 500px;
  justify-content: space-between;
}
.timeline .content .nav-tabs .nav-link {
  width: 242px;
  height: 70.0717773438px;
  text-align: center;
  font-family: "Work Sans", sans-serif;
  font-style: normal;
  font-weight: bold;
  font-size: 24px;
  letter-spacing: 2px;
  display: flex;
  justify-content: center;
  align-items: center;
  border-radius: 15px;
  text-decoration: none;
  border: 3px solid #c02b7c;
  background-color: transparent;
  color: #fff;
}
.timeline .content .nav-tabs .nav-link.active {
  background-color: #0991da;
  color: #fff;
  border: 3px solid #0991da;
}
.timeline .content .nav-tabs .nav-link:hover {
  background-color: #fff;
  color: #470A68;
  border: 3px solid #fff;
}
.timeline .content .title {
  margin-top: 2rem;
  margin-bottom: 5rem;
  background: #c02b7c;
  border-radius: 15px;
  padding-top: 1.5rem;
  padding-bottom: 1.5rem;
  padding-left: 2em;
  padding-right: 2em;
}
.timeline .content .left {
  display: flex;
  flex-direction: row;
  justify-content: space-between;
  align-items: center;
}
.timeline .content .left .frame img {
  position: relative;
  object-fit: contain;
}
.timeline .content .left .frame .time {
  position: absolute;
  top: 1.5rem;
  padding-left: 3rem;
  margin: auto;
}
.timeline .content .left .frame .time span {
  font-family: "Work Sans", sans-serif;
  font-style: normal;
  font-weight: bold;
  font-size: 1.8em;
  color: #fff;
}
.timeline .content .left .pin {
  display: flex;
  flex-direction: column;
  align-items: center;
  position: absolute;
  right: 3rem;
  top: 2.5em;
}
.timeline .content .left .pin .head {
  border-radius: 100%;
  background: #0991da;
  width: 35px;
  height: 35px;
}
.timeline .content .left .pin .body {
  height: 10rem;
  width: 1px;
  background-color: white;
}
.timeline .content .right {
  padding-left: 2rem;
  padding-bottom: 3rem;
}
.timeline .content .right h4 {
  font-weight: bold;
  font-size: 30px;
}
.timeline .content .right p {
  font-size: 16px;
}

.speakers {
  background-color: #461f4b;
}
.speakers .wrapper {
  padding-bottom: 5rem;
}
.speakers .tab-content {
  width: 100%;
}
.speakers .nav-tabs .nav-item.show .nav-link, .speakers .nav-tabs .nav-link.active {
  color: unset;
  background-color: unset;
  border-color: unset;
}
.speakers .nav-tabs .nav-link {
  border: unset;
  border-top-left-radius: unset;
  border-top-right-radius: unset;
}
.speakers .nav-tabs {
  border-bottom: none;
  width: 500px;
  justify-content: space-between;
  padding-bottom: 3rem;
  padding-top: 2rem;
}
.speakers .nav-tabs .nav-link {
  width: 242px;
  height: 70.0717773438px;
  text-align: center;
  font-family: "Work Sans", sans-serif;
  font-style: normal;
  font-weight: bold;
  font-size: 24px;
  letter-spacing: 2px;
  display: flex;
  justify-content: center;
  align-items: center;
  border-radius: 15px;
  text-decoration: none;
  border: 3px solid #c02b7c;
  background-color: transparent;
  color: #fff;
}
.speakers .nav-tabs .nav-link.active {
  background-color: #0991da;
  color: #fff;
  border: 3px solid #0991da;
}
.speakers .nav-tabs .nav-link:hover {
  background-color: #fff;
  color: #470A68;
  border: 3px solid #fff;
}

/* team12 */
.speaker {
  border: none;
}

.speaker .hoverbox {
  text-align: center;
  overflow: hidden;
  position: relative;
  width: 413px;
  height: 426px;
  border: 4px solid #6d2077;
}

.speaker .hoverbox .bg {
  width: 100%;
  height: auto;
  position: relative;
  left: 0;
  transition: all 0.3s ease 0s;
  min-height: 300px;
  object-fit: cover;
  height: 100%;
  width: 100%;
  object-position: center center;
}

.speaker .hoverbox:hover .bg {
  /* left: 100%; */
  /* transform: scale(0.7) rotateZ(180deg); */
}

.speaker .hoverbox .hoverbox-content {
  width: 100%;
  height: 100%;
  background: #6d2077;
  position: absolute;
  top: 0;
  left: -100%;
  transform: scale(0.7) rotateZ(180deg);
  transition: all 0.3s ease 0s;
  display: flex;
  justify-content: center;
  align-items: center;
}

.speaker .hoverbox:hover .hoverbox-content {
  left: 0;
  transform: scale(1) rotateZ(0deg);
  z-index: 10;
}

.speaker .hoverbox .title {
  font-size: 21px;
  font-weight: 700;
  color: #fff;
  text-transform: uppercase;
  border-bottom: 1px solid #fff;
  padding-bottom: 20px;
  margin-top: 40px;
}

.speaker .hoverbox .description {
  text-align: center;
  font-family: "Work Sans", sans-serif;
  font-style: normal;
  font-weight: normal;
  font-size: 20px;
  color: #fff;
  padding: 2rem;
}

.speaker .hoverbox .read-more {
  display: block;
  width: 100px;
  padding: 7px 0;
  background: #fff;
  border-radius: 10px 0 10px 0;
  font-size: 14px;
  color: #484141;
  text-transform: capitalize;
  margin: 0 auto;
  transition: all 0.3s ease 0s;
  background-repeat: no-repeat;
}

.speaker .hoverbox .read-more:hover {
  border-radius: 0 10px 0 10px;
  text-decoration: none;
}

@media only screen and (max-width: 990px) {
  .speaker .hoverbox {
    margin-bottom: 30px;
  }
}
@media only screen and (max-width: 360px) {
  .speaker .hoverbox .title {
    margin-top: 10px;
    padding-bottom: 8px;
  }
}
.speaker .hoverbox .speaker-box {
  position: relative;
}

.speaker .hoverbox .content {
  position: absolute;
  bottom: 0px;
}

.speaker .hoverbox .text {
  position: absolute;
  bottom: 0px;
  height: 100%;
  display: flex;
  justify-content: flex-end;
  z-index: 3;
  flex-direction: column;
  width: 100%;
  text-align: center;
  margin: auto;
  padding-bottom: 1em;
}

.speaker .hoverbox .text .name {
  text-align: center;
  font-family: "Work Sans", sans-serif;
  font-style: normal;
  font-weight: bold;
  font-size: 24px;
  color: #fff;
  letter-spacing: 0.5px;
  text-transform: uppercase;
}

.speaker .hoverbox .text .job {
  text-align: center;
  font-family: "Work Sans", sans-serif;
  font-style: normal;
  font-weight: normal;
  font-size: 18px;
  color: #fff;
  letter-spacing: 0.5px;
}

.speaker .item {
  margin-bottom: 3rem;
}

.shape {
  position: relative;
  width: 100%;
}
.shape .content {
  position: absolute;
  display: flex;
  z-index: 1;
  left: 0;
  right: 0;
  bottom: 1rem;
}
.shape .content h3 {
  text-transform: uppercase;
}

.footer.desktop-nav .navbar-dark {
  background-color: #6d2077;
}
.footer.desktop-nav .navbar-dark .navbar-nav .nav-item:not(:last-child) {
  padding-right: 3rem;
}
.footer.desktop-nav .navbar-dark .navbar-nav .nav-item .nav-link {
  font-weight: normal;
  font-size: 10px;
}
.footer.desktop-nav .navbar-dark .navbar-nav .nav-item .nav-link:hover {
  color: #0991da;
}

/*# sourceMappingURL=main.cs.map */
