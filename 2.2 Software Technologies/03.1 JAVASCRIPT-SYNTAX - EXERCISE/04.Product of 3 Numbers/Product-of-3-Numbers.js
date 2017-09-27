function solve(input) {
    let count = 0;
    for (let num of input) {
        let number = Number(num);
        if (number < 0) {
            count++;
        }
    }

    if (count % 2 === 0) {
        console.log("Positive")
    } else {
        console.log("Negative");
    }
}