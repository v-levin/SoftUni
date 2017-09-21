function solve(input) {
    let students = input.map(parseStudent);

    students.forEach(student => {
       let studentStr = `Name: ${student.name}\nAge: ${student.age}\nGrade: ${student.grade.toFixed(2)}`;
       console.log(studentStr);
    });

    function parseStudent(str) {
        let tokens = str.split(' -> ');
        let [name, age, grade] = tokens.map(x => !isNaN(x) ? Number(x) : x);

        let obj = {name: name, age: age, grade: grade};

        return obj;
    }
}

// solve([ 'Pesho -> 13 -> 6.00', 'Ivan -> 12 -> 5.57', 'Toni -> 13 -> 4.90']);