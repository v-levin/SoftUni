function solve(input) {
    let arr = {};
    for (let i = 0; i < input.length - 1; i++) {
            let inputParams = input[i].split(' ');
            let key = inputParams[0];
            let value = inputParams[1];

            arr[key] = value;
    }

    let key = input[input.length - 1];
    if (key in arr) {
        console.log(arr[key]);
    } else {
        console.log('None');
    }
}