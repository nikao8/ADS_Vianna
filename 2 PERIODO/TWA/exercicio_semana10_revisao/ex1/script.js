let getTd = document.querySelectorAll(`td`)
let count = 0;

let restart = document.getElementById(`reset`)

getTd.forEach(td => {
  td.addEventListener(`click`,() => {
    if(count % 2 === 0) {
      td.innerHTML = `x`
    } else {
      td.innerHTML = `o`
    }

    count++;
  }
  )
})

restart.addEventListener(`click`, () => {
    getTd.forEach(td => {
        td.innerHTML = "";
    })
})