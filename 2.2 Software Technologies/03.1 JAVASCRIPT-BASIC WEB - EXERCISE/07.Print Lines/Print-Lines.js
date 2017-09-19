function solve(input) {
    for (let text of input) {
        if (text !== 'Stop') {
            console.log(text);
        } else {
            break;
        }
    }
}