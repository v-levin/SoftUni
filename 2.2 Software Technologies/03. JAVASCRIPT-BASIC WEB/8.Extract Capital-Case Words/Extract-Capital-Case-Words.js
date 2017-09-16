function solve(input) {
    let text = input.join(" ");
    let pattern = /[^a-zA-Z]+/;
    console.log(text
        .split(pattern)
        .filter(e => e === e.toUpperCase())
        .filter(e => e)
        .join(", ")
    );
}

solve([ 'We start by HTML, CSS, JavaScript, JSON and REST.',
    'Later we touch some PHP, MySQL and SQL.',
    'Later we play with C#, EF, SQL Server and ASP.NET MVC.',
    'Finally, we touch some Java, Hibernate and Spring.MVC.' ]);