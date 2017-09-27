function solve(input) {
    let arr = [];

    for (let i = 0; i < input.length; i++) {
        let inputParams = input[i].split(' ');
        let command = inputParams[0];
        let num = Number(inputParams[1]);

        switch (command) {
            case 'add':
                arr.push(num);
                break;
            case 'remove':
                let index = num;
                if (index !== -1) {
                    arr.splice(index, 1);
                }
                break;
        }
    }
    console.log(arr.join('\n'));
}