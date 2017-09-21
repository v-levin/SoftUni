function solve(input) {
    let persons = input.map(JSON.parse);

    persons.forEach(person => {
        let personStr = `Name: ${person.name}\nAge: ${person.age}\nDate: ${person.date}`;
        console.log(personStr);
    });
}

// solve([ '{"name":"Gosho","age":10,"date":"19/06/2005"}',
//     '{"name":"Tosho","age":11,"date":"04/04/2005"}',
//     '{"name":"Maria","age":24,"date":"31/12/1996"}' ]);