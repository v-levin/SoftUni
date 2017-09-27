function solve(input) {
    let arrLength = Number(input[0]);
    let arr = new Array(arrLength).fill(0);

    for (let i = 1; i < input.length; i++) {
        let inputParams = input[i];
        let separatorIndex = inputParams.indexOf('-');
        let index = Number(inputParams.substring(0, separatorIndex));
        let value = Number(inputParams.substring(separatorIndex + 1));

        arr[index] = value;
    }

    console.log(arr.join('\n'));
}