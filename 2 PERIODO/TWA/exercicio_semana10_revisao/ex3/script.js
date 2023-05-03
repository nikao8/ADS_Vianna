const add = document.getElementById('add-task');
const lista = document.getElementById('task-list');
const entrada = document.getElementById('new-task');

add.addEventListener("click", () => {
    lista.innerHTML += entrada.value + `<br>`
})