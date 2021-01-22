let body = document.getElementsByTagName("body");
let header = document.querySelector("header");
let navResponsive = document.querySelector("#ul-nav");
let shadowNav = document.createElement("div");
let asidePost = document.querySelector(".info-post");
document.querySelector(".icon-responsive").addEventListener("click", () => {
  shadowNav.classList.add("shadowNav");
  document.body.appendChild(shadowNav);
  document.querySelector(".shadowNav").addEventListener("click", () => {
    navResponsive.classList.remove("active-nav");
    document.body.removeChild(shadowNav);
  });
});
if (header.children.length == 2) {
  header.classList.add("small-header");
}
if (window.innerWidth <= 960 && asidePost !== null) {
  asidePost.removeAttribute("uk-sticky");
}
console.log(window.innerWidth);
