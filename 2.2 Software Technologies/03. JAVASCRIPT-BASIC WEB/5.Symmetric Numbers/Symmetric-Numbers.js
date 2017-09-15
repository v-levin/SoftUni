function solve(n) {
    let isSymetric = false;

    for (let i = 1; i <= n; i++) {
        let numToStr = i.toString();
        let numLength = numToStr.length;
        for (let j = 0; j < numLength / 2; j++) {
            if (numToStr[j] !== numToStr[numToStr.length - 1 - j]) {
                isSymetric = false;
                break;
            }
            isSymetric = true;
        }
        if (isSymetric) {
            let num = Number(numToStr);
            console.log(num);
        }
    }
}

solve(100);
solve(750);