<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <title>First Steps Into PHP</title>

</head>
<body>
<form>
    N: <input type="text" name="num" />
    <input type="submit" />
</form>
<?php

if (isset($_GET["num"])) {
    $num = intval($_GET["num"]);

    $prevNum = 1;
    $currNum = 1;

    echo $prevNum . " " . $currNum . " ";

    for ($i = 0; $i < $num - 2; $i++) {
        $nextNum = $prevNum + $currNum;

        echo $nextNum . " ";

        $prevNum = $currNum;
        $currNum = $nextNum;
    }
}

?>
</body>
</html>