function solve(input) {
    let searchKey = input.slice(-1).pop();
    let keyValuePairs = input.slice(0, -1).map(parseKeyValuePair);

    let dict = {};

    keyValuePairs.forEach(element => {
        if (!dict[element.key]) {
            dict[element.key] = [];
        }

        dict[element.key].push(element.value);
    });

    console.log(dict[searchKey] ? dict[searchKey].join('\n') : 'None');

    function parseKeyValuePair(str) {
        let tokens = str.split(' ');
        let result = {key: tokens[0], value: tokens[1]};

        return result;
    }
}

// solve(['key value', 'key eulav', 'test tset', 'key']);
// solve(['3 test', '4 test2', '4 test3', '4 test5', '4']);
// solve(['3 bla', '3 alb', '2']);