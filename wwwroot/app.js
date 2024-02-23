let button = document.getElementById("button");
let input = document.getElementById("input");
let text = document.getElementById("text");
let date;

button.addEventListener("click", function () {
    let input_text = document.getElementById("input").value;

    date = input_text.value;
   fetchTime();
}
)

const fetchTime = function () {
    fetch("https://localhost:7180/api/Controll", {
        method: "POST",
        headers: {
            "Content-Type": "application/json",
        },
        body: date,
    })
        .then((response) => {
            return response.StringData;
        })
        .then((StringData) => {
            let zeit = StringData;
            text.innerHTML = zeit;
        })
        .catch((error) => {
            console.log(error);
        })
};
