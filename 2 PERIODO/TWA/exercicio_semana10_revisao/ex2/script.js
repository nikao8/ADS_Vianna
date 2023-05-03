const clique = document.getElementById("click-me");
const result = document.getElementById("counter");
let cont = 0;

clique.addEventListener("click", () => {
    cont++;
    result.innerHTML = cont;
})