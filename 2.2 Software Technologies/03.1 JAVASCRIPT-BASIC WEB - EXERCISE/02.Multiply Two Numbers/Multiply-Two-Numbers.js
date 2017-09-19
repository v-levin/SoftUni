function solve(input) {
    let num1 = Number(input[0]);
    let num2 = Number(input[1]);

    let result = multiply(num1, num2);

    console.log(result);

    function multiply(num1, num2) {
        return num1 * num2;
    }
}